using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ping_graphic
{
    public partial class PingGraphic : Form
    {
        Thread pingThread;
        Process pingProcess;
        Dictionary<DateTime, int> datePingDict = new Dictionary<DateTime, int>();

        public PingGraphic()
        {
            InitializeComponent();
        }

        private void readStringAndAddPoint(string line)
        {
            Match pingMatch = Regex.Match(line, @"=(?<time>\d+)ms");

            // (chrtPing.Parent != null) check if window is still open
            if (pingMatch.Success && chrtPing.Parent != null)
            {
                int pingValue = int.Parse(pingMatch.Groups["time"].Value);

                DateTime sampleTime = DateTime.Now;

                datePingDict.Add(sampleTime, pingValue);

                chrtPing.Invoke((MethodInvoker)delegate {
                    chrtPing.Series[0].Points.Clear();

                    DateTime minDate = DateTime.Now.Subtract(new TimeSpan(0, dtpViewTime.Value.Minute, dtpViewTime.Value.Second));

                    foreach (KeyValuePair<DateTime, int> pair in datePingDict)
                    {
                        if (minDate < pair.Key)
                        {
                            chrtPing.Series[0].Points.AddXY(pair.Key, pair.Value);
                        }
                    }

                    // generate color using ping value for red and 255 - pingvalue for blue
                    // higer ping = more red and less blue
                    chrtPing.Series[0].Color = Color.FromArgb(Math.Min(pingValue, 255), 0, Math.Max(255 - pingValue, 0));
                });

                UpdateMean();
            }
        }

        private void UpdateMean()
        {
            int min = int.MaxValue, max = int.MinValue, mean = 0;

            DateTime minDate = DateTime.Now.Subtract(new TimeSpan(0, dtpViewTime.Value.Minute, dtpViewTime.Value.Second));

            int pingShown = 0;

            foreach (KeyValuePair<DateTime, int> pair in datePingDict)
            {
                int ping = pair.Value;

                if (minDate < pair.Key)
                {
                    pingShown++;

                    min = Math.Min(min, ping);
                    max = Math.Max(max, ping);
                    mean += ping;
                }
            }

            mean /= pingShown;

            lblMean.Invoke((MethodInvoker)delegate {
                lblMean.Text = "Min:" + min + " Max:" + max + " Mean:" + mean;
            });

        }

        private void throwPing()
        {
            // create process
            Process process = new Process();
            pingProcess = process;
            ProcessStartInfo startInfo = new ProcessStartInfo();

            // create EventHandler to dataReceived to read command output
            DataReceivedEventHandler process_output = new DataReceivedEventHandler((s, e) =>
                readStringAndAddPoint(e.Data)
            );

            startInfo.FileName = "ping.exe";
            startInfo.Arguments += "-t " + txtUrl.Text;

            // parameters to hide window and redirect command standard output and errors
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;

            // add event handler to command output
            process.OutputDataReceived += process_output;
            process.ErrorDataReceived += process_output;

            process.StartInfo = startInfo;

            process.Start();

            // start reading command output
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.WaitForExit();
        }

        private void startThrowThread()
        {
            chrtPing.Series[0].Points.Clear();

            pingThread = new Thread(() => throwPing());
            pingThread.Start();
        }

        private void stopThrowThread()
        {
            if (pingThread != null)
            {
                try
                {
                    pingProcess.CancelErrorRead();
                    pingProcess.CancelOutputRead();
                }
                catch (Exception) { }

                pingProcess.Kill();
                pingProcess = null;
                pingThread = null;
            }
        }


        private void PingGraphic_Load(object sender, EventArgs e)
        {
            chrtPing.ChartAreas[0].AxisY.Interval = 5;
            chrtPing.Series[0].Color = Color.Blue;
            chrtPing.Series[0].ChartType = SeriesChartType.Line;
            chrtPing.Series[0].BorderWidth = 3;

            chrtPing.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chrtPing.Series[0].XValueType = ChartValueType.DateTime;

            if (chbRun.Checked)
            {
                startThrowThread();
            }

            lblMean.Text = "";

            dtpViewTime.Format = DateTimePickerFormat.Custom;
            dtpViewTime.CustomFormat = "mm:ss";
            dtpViewTime.ShowUpDown = true;
        }

        private void chbRun_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRun.Checked && pingThread is null)
            {
                startThrowThread();
            }
            else
            {
                stopThrowThread();
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            chbRun.Checked = false;
        }

        private void PingGraphic_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopThrowThread();
        }
    }
}
