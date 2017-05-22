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

namespace RFIDIntegratedApplication
{
    public partial class VitalSignsForm : DockContent
    {
        public VitalSignsForm()
        {
            InitializeComponent();
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

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
                this.Location = new Point(point.X + ran.Next(10) - 4, point.Y + ran.Next(10) - 4);

                System.Threading.Thread.Sleep(15);

                this.Location = point;

                System.Threading.Thread.Sleep(15);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shake();
        }


    }
}
