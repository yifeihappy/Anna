using System;
using RFIDIntegratedApplication.Utility;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms.DataVisualization.Charting;

using RFIDIntegratedApplication.service;
using RFIDIntegratedApplication.Forms;

using vitalsigns;
using MathWorks.MATLAB.NET.Arrays;
using RFIDIntegratedApplication.ServiceReference4;
using System.Threading;

namespace RFIDIntegratedApplication
{
    public partial class VitalSignsForm : DockContent
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool _realtime = true;
        public bool regularSave = true;
        private VitalSignsConfigForm vitalSignsConfigForm;
        public const string BREATH_RATE = "呼吸频率";
        public const string HEART_RATE = "心跳频率";
        Random ran = new Random();
        public bool started = true;
        double breath;
        double heartbeat;
        int fail;
        static MainForm _mainform;
        private long startTime;
        public void enableRealTime()
        {
            realTimeMonitorToolStripMenuItem.Enabled = true;
        }

        public void disableRealTime()
        {
            _realtime = false;
            timer.Stop();
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = false;
            realTimeMonitorToolStripMenuItem.Checked = false;
            realTimeMonitorToolStripMenuItem.Enabled = false;
        }

        public VitalSignsForm(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            _realtime = false;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = false;
            realTimeMonitorToolStripMenuItem.Checked = false;
            //realTimeMonitorToolStripMenuItem.Enabled = false;
            regularSaveToolStripMenuItem.Checked = true;
            regularSaveToolStripMenuItem.Enabled = false;
            importToolStripMenuItem.Enabled = true;
            //Create a new curve
            Title titlePhase = new Title("生命体征变化曲线图", Docking.Top);
            titlePhase.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            titlePhase.Font = new System.Drawing.Font("Microsoft Yahei", 15, System.Drawing.FontStyle.Bold);
            chart1.Titles.Add(titlePhase);
            addGraphItem(BREATH_RATE);
            addGraphItem(HEART_RATE);
            // seriesPhase.Points.AddXY(tagInfo.TimeStamp / 1000, tagInfo.AcutalPhaseInRadian);
           /* for(int i=0;i<100;++i)
             {
                 chart1.Series[BREATH_RATE].Points.AddXY(i, i);
             }*/




        }
        public bool isRealtime
        {
            get
            {
                return _realtime;
            }
            set
            {
                _realtime = value;
            }
        }
        //private double count = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            //模拟的做一些耗时的操作
            //System.Threading.Thread.Sleep(10);
            //int breath = 17 + ran.Next(-2, 1);
            //int heartbeat = 70 + ran.Next(-8, 10);
            //chart1.Series[BREATH_RATE].Points.AddXY(count, breath);
            //chart1.Series[HEART_RATE].Points.AddXY(count, heartbeat);
            long time = (CurrentMillis.MicroSeconds - startTime)/1000;
            chart1.Series[BREATH_RATE].Points.AddXY(time, breath);
            chart1.Series[HEART_RATE].Points.AddXY(time, heartbeat);
            //aGauge1.Value = breath;
            //aGauge2.Value = heartbeat;
            //breathLabel.Text = breath.ToString();
            //heartbeatLabel.Text = heartbeat.ToString();
            updateGauge();
            updateWarningLabel();
            //count = count+0.02;
        }

        private void addGraphItem(String name)
        {
            Series seriesPhase = new Series(name);
            //Set chart type
            //seriesPhase.ChartType = SeriesChartType.FastPoint;
            seriesPhase.ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), "FastLine");
            //Set curve width
            seriesPhase.BorderWidth = 2;
            //seriesPhase.MarkerSize = 5;
            chart1.Series.Add(seriesPhase);
            //Create a new legend
            Legend legendPhase = new Legend(name);
            //Set legend propertities
            legendPhase.Title = "项目";
            legendPhase.Font = new System.Drawing.Font("Microsoft Yahei", 10, System.Drawing.FontStyle.Bold);
            legendPhase.TitleFont = new System.Drawing.Font("Microsoft Yahei", 12, System.Drawing.FontStyle.Bold);

            legendPhase.LegendStyle = LegendStyle.Table;
            legendPhase.Alignment = System.Drawing.StringAlignment.Center;
            legendPhase.IsDockedInsideChartArea = false;
            legendPhase.Docking = Docking.Bottom;

            legendPhase.BorderDashStyle = ChartDashStyle.Dash;
            legendPhase.BorderColor = System.Drawing.Color.LightBlue;
            legendPhase.BorderWidth = 3;
            chart1.Legends.Add(legendPhase);
            chart1.Legends[name].DockedToChartArea = "ChartArea1";
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
            switch (e.valueInRange)
            {
                case 0:
                    breathLabel.BackColor = Color.Orange;
                    break;
                case 1:
                    breathLabel.BackColor = Color.LightGreen;
                    break;
                case 2:
                    breathLabel.BackColor = Color.Orange;
                    break;
            }


        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void updateWarningLabel()
        {
            switch (fail)
            {
                case 3:
                    warningPicBox.Image = Properties.Resources.warning2;
                    warningLabel.Text = "呼吸暂停";
                    break;
                case 2:
                    warningPicBox.Image = Properties.Resources.warning2;
                    warningLabel.Text = "信号太弱";
                    break;
                case 1:
                    warningPicBox.Image = Properties.Resources.warning2;
                    warningLabel.Text = "请保持静止";
                    break;
                default:
                    warningPicBox.Image = Properties.Resources.warning1;
                    warningLabel.Text = "正常";
                    break;
            }
        }


        private void shake()
        {
            Random ran = new Random((int)DateTime.Now.Ticks);

            Point point = this.Location;

            for (int i = 0; i < 30; i++)
            {
                this.Location = new Point(point.X + ran.Next(10) - 8, point.Y + ran.Next(10) - 8);

                System.Threading.Thread.Sleep(15);

                this.Location = point;

                System.Threading.Thread.Sleep(15);
            }
        }
        public void updateGauge()
        {
            breathLabel.Text = this.breath.ToString();
            heartbeatLabel.Text = this.heartbeat.ToString();

            //int breath,heartbeat;
            aGauge1.Value = (int)this.breath;// = Convert.ToInt32(breathStr, CultureInfo.InvariantCulture.NumberFormat);
            aGauge2.Value = (int)this.heartbeat;// = Convert.ToInt32(heartbeatStr, CultureInfo.InvariantCulture.NumberFormat);

        }

        public void updateBreathHeartbeatFail(double breath, double heartbeat,int fail)
        {
            updateBreathAndHeartbeat(breath, heartbeat);
            this.fail = fail;
          
         
        }

        private void updateBreathAndHeartbeat(double breath, double heartbeat)
        {
            this.breath = breath;
            this.heartbeat = heartbeat;
            
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        public void updatePhase(string key, int data)
        {

        }

        private void VitalSignsForm_Load(object sender, EventArgs e)
        {
            importToolStripMenuItem.Enabled = !_realtime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shake();
        }

        private void realTimeMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _realtime = !_realtime;
            realTimeMonitorToolStripMenuItem.Checked = !realTimeMonitorToolStripMenuItem.Checked;
            importToolStripMenuItem.Enabled = !_realtime;
            toolStripButton2.Enabled = !toolStripButton2.Enabled;
            regularSaveToolStripMenuItem.Enabled = !regularSaveToolStripMenuItem.Enabled;
            toolStripButton1.Enabled = !toolStripButton1.Enabled;
            if (!_realtime)
            {
                timer.Stop();

            }
        }

        private void clearChart()
        {
           // chart1.Series.Clear();
            chart1.Series[BREATH_RATE].Points.Clear();
            chart1.Series[HEART_RATE].Points.Clear();
           // chart1.Legends.Clear();
           //   addGraphItem(BREATH_RATE);
           //  addGraphItem(HEART_RATE);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "E:\\交大\\Script\\Data";
            openFileDialog.Filter = "CSV File(*.csv)|*.csv";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                clearChart();

                MessageBox.Show("已选择："+openFileDialog.FileName);
                
                /*VitalSignsExtract vitalSignsExtract = new VitalSignsExtract();
                MWCharArray filename = openFileDialog.FileName;
                MWArray[] argsIn = new MWArray[] { filename };
                MWArray[] result = new MWArray[3];
                vitalSignsExtract.offlineVitalSignsExtract(3,ref result,argsIn);
                double[,] temp = (double[,])result[0].ToArray();
                int num = temp.GetLength(1);
                int[] breath = new int[num];
                int[] heartbeat = new int[num];
                double[] t = new double[num];
                for (int i = 0; i < num; i++)
                {
                    breath[i] = (int)temp[1, i];
                    heartbeat[i] = (int)temp[2, i];
                    t[i] = temp[0, i];
                }
                for (int i = 0; i < heartbeat.Length; i++)
                {
                    chart1.Series[BREATH_RATE].Points.AddXY(t[i], breath[i]);
                    chart1.Series[HEART_RATE].Points.AddXY(t[i], heartbeat[i]);
                }
                updateBreathAndHeartbeat((int)(MWNumericArray)result[1], (int)(MWNumericArray)result[2]);
                */
                filename = openFileDialog.FileName;
                Thread thread = new Thread(offlineAnlyzeProcess);
                thread.Start();


            }
        }

        private volatile string filename;
        private void offlineAnlyzeProcess()
        {
            try
            {
                //double[,] result = 
                IVitalSignsService vitalSignsService = ServiceManager.getOneVitalSignsService();
                FrequencyInfo frequency = vitalSignsService.offlineAnalyze(filename);
                ServiceManager.closeService(vitalSignsService);
                double[] heartbeat = frequency.heartbeat;
                double[] breath = frequency.breath;
                double[] t = frequency.t;
                double meanBreath = frequency.meanBreath;
                double meanHeartbeat = frequency.meanHeartbeat;
                this.BeginInvoke(method: new Action(() =>
                {
                    for (int i = 0; i < heartbeat.Length; i++)
                    {
                        chart1.Series[BREATH_RATE].Points.AddXY(t[i], breath[i]);
                        chart1.Series[HEART_RATE].Points.AddXY(t[i], heartbeat[i]);
                    }
                    updateBreathAndHeartbeat(meanBreath, meanHeartbeat);
                    updateGauge();
                }));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("服务调用失败" + ex.ToString());
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitalSignsConfigForm = new VitalSignsConfigForm();
            vitalSignsConfigForm.Show();
        }

        private void changeNeedleType_Click(object sender, EventArgs e)
        {
            aGauge1.NeedleType = aGauge1.NeedleType == 0 ? 1 : 0;
            aGauge2.NeedleType = aGauge2.NeedleType == 0 ? 1 : 0;
        }

        //start
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = false;
            startTime = CurrentMillis.MicroSeconds;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            _mainform.startVitalSignsMonitoring();
            if (regularSave)
            {
                _mainform.startRegularSaving();
            }
            clearChart();
            updateBreathAndHeartbeat(0, 0);
            regularSaveToolStripMenuItem.Enabled = false;
            realTimeMonitorToolStripMenuItem.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton1.Enabled = false;
            regularSaveToolStripMenuItem.Enabled = true;
            realTimeMonitorToolStripMenuItem.Enabled = true;
            timer.Stop();
            _mainform.stopVitalSignsMonitoring();
            if (regularSave)
            {
                _mainform.stopRegularSaving();
            }
        }

        private void aGauge2_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void warningPicBox_Click(object sender, EventArgs e)
        {

        }

        private void regularSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regularSave = !regularSave;
            regularSaveToolStripMenuItem.Checked = !regularSaveToolStripMenuItem.Checked;
            /*
            if (regularSave)
            {
                _mainform.startRegularSaving();
            }
            else
            {
                _mainform.stopRegularSaving();
            }*/
        }


    }
}
