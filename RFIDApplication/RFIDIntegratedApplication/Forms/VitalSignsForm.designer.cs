namespace RFIDIntegratedApplication
{
    partial class VitalSignsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNeedleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.breathLabel = new System.Windows.Forms.Label();
            this.heartbeatLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aGauge1 = new RFIDIntegratedApplication.AGauge();
            this.aGauge2 = new RFIDIntegratedApplication.AGauge();
            this.realTimeMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNeedleTypeToolStripMenuItem,
            this.realTimeMonitorToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // changeNeedleTypeToolStripMenuItem
            // 
            this.changeNeedleTypeToolStripMenuItem.Name = "changeNeedleTypeToolStripMenuItem";
            this.changeNeedleTypeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.changeNeedleTypeToolStripMenuItem.Text = "ChangeNeedleType";
            this.changeNeedleTypeToolStripMenuItem.Click += new System.EventHandler(this.changeNeedleTypeToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(821, 25);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(126, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "呼吸速率";
            // 
            // breathLabel
            // 
            this.breathLabel.BackColor = System.Drawing.Color.LightGreen;
            this.breathLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breathLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.breathLabel.Location = new System.Drawing.Point(140, 83);
            this.breathLabel.Name = "breathLabel";
            this.breathLabel.Size = new System.Drawing.Size(50, 22);
            this.breathLabel.TabIndex = 22;
            this.breathLabel.Text = "17";
            this.breathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heartbeatLabel
            // 
            this.heartbeatLabel.BackColor = System.Drawing.Color.LightGreen;
            this.heartbeatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heartbeatLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heartbeatLabel.Location = new System.Drawing.Point(595, 83);
            this.heartbeatLabel.Name = "heartbeatLabel";
            this.heartbeatLabel.Size = new System.Drawing.Size(50, 22);
            this.heartbeatLabel.TabIndex = 23;
            this.heartbeatLabel.Text = "70";
            this.heartbeatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(471, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "心率";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.Interval = 0D;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorTickMark.Interval = 0D;
            chartArea3.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea3.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea3.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "秒";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.Interval = 0D;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorTickMark.Interval = 0D;
            chartArea3.AxisY.Maximum = 200D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "次/分钟";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorX.SelectionColor = System.Drawing.Color.DeepSkyBlue;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.CursorY.SelectionColor = System.Drawing.Color.DeepSkyBlue;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 70F;
            chartArea3.Position.Width = 95F;
            chartArea3.Position.X = 2F;
            chartArea3.Position.Y = 10F;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(64, 317);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(701, 244);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(80, 60);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(80, 60),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "次/分钟",
        "",
        "",
        ""};
            this.aGauge1.CapText = "次/分钟";
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge1.Location = new System.Drawing.Point(64, 143);
            this.aGauge1.MaxValue = 30F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = RFIDIntegratedApplication.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(2));
            this.aGauge1.RangeColor = System.Drawing.Color.Orange;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 30F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Orange,
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        12F,
        20F,
        30F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        12F,
        20F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 20F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 5F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 4;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 93;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(219, 120);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 17F;
            this.aGauge1.ValueInRangeChanged += new RFIDIntegratedApplication.AGauge.ValueInRangeChangedDelegate(this.aGauge1_ValueInRangeChanged);
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 150;
            this.aGauge2.BaseArcStart = 215;
            this.aGauge2.BaseArcSweep = 110;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(130, 80);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(130, 80),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "次/分钟",
        "",
        "",
        ""};
            this.aGauge2.CapText = "次/分钟";
            this.aGauge2.Center = new System.Drawing.Point(150, 180);
            this.aGauge2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge2.Location = new System.Drawing.Point(468, 125);
            this.aGauge2.MaxValue = 160F;
            this.aGauge2.MinValue = 40F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = RFIDIntegratedApplication.AGauge.NeedleColorEnum.Green;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 150;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(1));
            this.aGauge2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge2.RangeEnabled = false;
            this.aGauge2.RangeEndValue = 400F;
            this.aGauge2.RangeInnerRadius = 10;
            this.aGauge2.RangeOuterRadius = 40;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 300F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge2.ScaleLinesInterInnerRadius = 145;
            this.aGauge2.ScaleLinesInterOuterRadius = 150;
            this.aGauge2.ScaleLinesInterWidth = 2;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 140;
            this.aGauge2.ScaleLinesMajorOuterRadius = 150;
            this.aGauge2.ScaleLinesMajorStepValue = 40F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 145;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 150;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 162;
            this.aGauge2.ScaleNumbersRotation = 90;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 2;
            this.aGauge2.Size = new System.Drawing.Size(297, 131);
            this.aGauge2.TabIndex = 8;
            this.aGauge2.Text = "aGauge4";
            this.aGauge2.Value = 70F;
            // 
            // realTimeMonitorToolStripMenuItem
            // 
            this.realTimeMonitorToolStripMenuItem.Checked = true;
            this.realTimeMonitorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realTimeMonitorToolStripMenuItem.Name = "realTimeMonitorToolStripMenuItem";
            this.realTimeMonitorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.realTimeMonitorToolStripMenuItem.Text = "RealTimeMonitor";
            this.realTimeMonitorToolStripMenuItem.Click += new System.EventHandler(this.realTimeMonitorToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // VitalSignsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 573);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.heartbeatLabel);
            this.Controls.Add(this.breathLabel);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "VitalSignsForm";
            this.Text = "Vital Signs";
            this.Load += new System.EventHandler(this.VitalSignsForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGauge aGauge1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNeedleTypeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private AGauge aGauge2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label breathLabel;
        private System.Windows.Forms.Label heartbeatLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem realTimeMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}