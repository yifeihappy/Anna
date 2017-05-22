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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VitalSignsForm));
            this.aGauge1 = new RFIDIntegratedApplication.AGauge();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNeedleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aGauge2 = new RFIDIntegratedApplication.AGauge();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.breathLabel = new System.Windows.Forms.Label();
            this.heartbeatLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.aGauge1.Location = new System.Drawing.Point(67, 198);
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
            this.aGauge1.Size = new System.Drawing.Size(225, 113);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 17F;
            this.aGauge1.ValueInRangeChanged += new RFIDIntegratedApplication.AGauge.ValueInRangeChangedDelegate(this.aGauge1_ValueInRangeChanged);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNeedleTypeToolStripMenuItem});
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
            this.settingToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(680, 25);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
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
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(150, 180);
            this.aGauge2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge2.Location = new System.Drawing.Point(337, 183);
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
            this.aGauge2.Size = new System.Drawing.Size(297, 112);
            this.aGauge2.TabIndex = 8;
            this.aGauge2.Text = "aGauge4";
            this.aGauge2.Value = 70F;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "心率";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(137, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "呼吸速率";
            // 
            // breathLabel
            // 
            this.breathLabel.BackColor = System.Drawing.Color.LightGreen;
            this.breathLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breathLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.breathLabel.Location = new System.Drawing.Point(143, 174);
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
            this.heartbeatLabel.Location = new System.Drawing.Point(457, 174);
            this.heartbeatLabel.Name = "heartbeatLabel";
            this.heartbeatLabel.Size = new System.Drawing.Size(50, 22);
            this.heartbeatLabel.TabIndex = 23;
            this.heartbeatLabel.Text = "70";
            this.heartbeatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 81);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // VitalSignsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.heartbeatLabel);
            this.Controls.Add(this.breathLabel);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "VitalSignsForm";
            this.Text = "Display";
        
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGauge aGauge1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNeedleTypeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private AGauge aGauge2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label breathLabel;
        private System.Windows.Forms.Label heartbeatLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}