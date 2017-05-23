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
namespace RFIDIntegratedApplication
{
    public partial class VitalSignsForm : DockContent
    {
        private System.Windows.Forms.Timer timer = new Timer() { };
        private bool _realtime = true;
        public   const  string BREATH_RATE = "呼吸频率";
        public const string HEART_RATE = "心跳频率";
        public VitalSignsForm()
        {
            InitializeComponent();
            //Create a new curve
            Title titlePhase = new Title("生命体征变化曲线图", Docking.Top);
            titlePhase.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            titlePhase.Font = new System.Drawing.Font("Microsoft Yahei", 15, System.Drawing.FontStyle.Bold);
            chart1.Titles.Add(titlePhase);
            addGraphItem(BREATH_RATE);
            addGraphItem(HEART_RATE);
            // seriesPhase.Points.AddXY(tagInfo.TimeStamp / 1000, tagInfo.AcutalPhaseInRadian);
            /*for(int i=0;i<100;++i)
             {
                 chart1.Series[BREATH_RATE].Points.AddXY(i, i);
             }*/
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
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
        private int count=0;
        void timer_Tick(object sender, EventArgs e)
        {
            //模拟的做一些耗时的操作
            System.Threading.Thread.Sleep(1);
            chart1.Series[BREATH_RATE].Points.AddXY(count, count);
            chart1.Series[HEART_RATE].Points.AddXY(count, count+10);
            count++;
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

        private void changeNeedleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aGauge1.NeedleType = aGauge1.NeedleType == 0 ? 1 : 0;
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
        public void updateGauge(string breathStr, string heartbeatStr)
        {
            breathLabel.Text = breathStr;
            heartbeatLabel.Text = heartbeatStr;

            int breath,heartbeat;
            aGauge1.Value = breath = Convert.ToInt32(breathStr, CultureInfo.InvariantCulture.NumberFormat);
            aGauge2.Value = heartbeat = Convert.ToInt32(heartbeatStr, CultureInfo.InvariantCulture.NumberFormat);

        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        public void updatePhase(string key,int data)
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
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
