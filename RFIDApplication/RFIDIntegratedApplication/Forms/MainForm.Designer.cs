﻿namespace RFIDIntegratedApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tssbtnSave = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbtnAddWindow = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiUpdateEpc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReaderSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTagTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRSSIGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhaseGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHolographics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDemoSortingBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDemoTrackingObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.vitalSignsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslRunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 27);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.Size = new System.Drawing.Size(1010, 802);
            this.dockPanelMain.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbtnSave,
            this.toolStripSeparator5,
            this.tsbtnStart,
            this.tsbtnStop,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.tssbtnAddWindow});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1010, 27);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "Tool Strip";
            // 
            // tssbtnSave
            // 
            this.tssbtnSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiSaveAs});
            this.tssbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tssbtnSave.Image")));
            this.tssbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtnSave.Name = "tssbtnSave";
            this.tssbtnSave.Size = new System.Drawing.Size(67, 24);
            this.tssbtnSave.Text = "Save";
            this.tssbtnSave.ButtonClick += new System.EventHandler(this.tssbtnSave_ButtonClick);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(112, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveAs.Image")));
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(112, 22);
            this.tsmiSaveAs.Text = "Save as";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.Enabled = false;
            this.tsbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStart.Image")));
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(55, 24);
            this.tsbtnStart.Text = "Start";
            this.tsbtnStart.Click += new System.EventHandler(this.tsbtnStart_Click);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStop.Image")));
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(55, 24);
            this.tsbtnStop.Text = "Stop";
            this.tsbtnStop.Click += new System.EventHandler(this.tsbtnStop_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = global::RFIDIntegratedApplication.Properties.Resources.restart;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 24);
            this.toolStripButton1.Text = "Restart";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // tssbtnAddWindow
            // 
            this.tssbtnAddWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdateEpc,
            this.tsmiReaderSettings,
            this.tsmiTagTable,
            this.tsmiRSSIGraph,
            this.tsmiPhaseGraph,
            this.tsmiHolographics,
            this.vitalSignsToolStripMenuItem});
            this.tssbtnAddWindow.Image = ((System.Drawing.Image)(resources.GetObject("tssbtnAddWindow.Image")));
            this.tssbtnAddWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtnAddWindow.Name = "tssbtnAddWindow";
            this.tssbtnAddWindow.Size = new System.Drawing.Size(87, 24);
            this.tssbtnAddWindow.Text = "Window";
            this.tssbtnAddWindow.ButtonClick += new System.EventHandler(this.tssbtnAddWindow_ButtonClick);
            // 
            // tsmiUpdateEpc
            // 
            this.tsmiUpdateEpc.Image = global::RFIDIntegratedApplication.Properties.Resources.epc;
            this.tsmiUpdateEpc.Name = "tsmiUpdateEpc";
            this.tsmiUpdateEpc.Size = new System.Drawing.Size(155, 22);
            this.tsmiUpdateEpc.Text = "update epc";
            this.tsmiUpdateEpc.Click += new System.EventHandler(this.tsmiUpdateEpc_Click);
            // 
            // tsmiReaderSettings
            // 
            this.tsmiReaderSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReaderSettings.Image")));
            this.tsmiReaderSettings.Name = "tsmiReaderSettings";
            this.tsmiReaderSettings.Size = new System.Drawing.Size(155, 22);
            this.tsmiReaderSettings.Text = "Reader Settings";
            this.tsmiReaderSettings.Click += new System.EventHandler(this.tsmiReaderSettings_Click);
            // 
            // tsmiTagTable
            // 
            this.tsmiTagTable.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTagTable.Image")));
            this.tsmiTagTable.Name = "tsmiTagTable";
            this.tsmiTagTable.Size = new System.Drawing.Size(155, 22);
            this.tsmiTagTable.Text = "Tag Table";
            this.tsmiTagTable.Click += new System.EventHandler(this.tsmiTagTable_Click);
            // 
            // tsmiRSSIGraph
            // 
            this.tsmiRSSIGraph.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRSSIGraph.Image")));
            this.tsmiRSSIGraph.Name = "tsmiRSSIGraph";
            this.tsmiRSSIGraph.Size = new System.Drawing.Size(155, 22);
            this.tsmiRSSIGraph.Text = "RSSI Graph";
            this.tsmiRSSIGraph.Click += new System.EventHandler(this.tsmiRSSIGraph_Click);
            // 
            // tsmiPhaseGraph
            // 
            this.tsmiPhaseGraph.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPhaseGraph.Image")));
            this.tsmiPhaseGraph.Name = "tsmiPhaseGraph";
            this.tsmiPhaseGraph.Size = new System.Drawing.Size(155, 22);
            this.tsmiPhaseGraph.Text = "Phase Graph";
            this.tsmiPhaseGraph.Click += new System.EventHandler(this.tsmiPhaseGraph_Click);
            // 
            // tsmiHolographics
            // 
            this.tsmiHolographics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDemoSortingBooks,
            this.tsmiDemoTrackingObjects});
            this.tsmiHolographics.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHolographics.Image")));
            this.tsmiHolographics.Name = "tsmiHolographics";
            this.tsmiHolographics.Size = new System.Drawing.Size(155, 22);
            this.tsmiHolographics.Text = "Holographics";
            // 
            // tsmiDemoSortingBooks
            // 
            this.tsmiDemoSortingBooks.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDemoSortingBooks.Image")));
            this.tsmiDemoSortingBooks.Name = "tsmiDemoSortingBooks";
            this.tsmiDemoSortingBooks.Size = new System.Drawing.Size(204, 22);
            this.tsmiDemoSortingBooks.Text = "Demo - Sorting books";
            this.tsmiDemoSortingBooks.Click += new System.EventHandler(this.tsmiDemoSortingBooks_Click);
            // 
            // tsmiDemoTrackingObjects
            // 
            this.tsmiDemoTrackingObjects.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDemoTrackingObjects.Image")));
            this.tsmiDemoTrackingObjects.Name = "tsmiDemoTrackingObjects";
            this.tsmiDemoTrackingObjects.Size = new System.Drawing.Size(204, 22);
            this.tsmiDemoTrackingObjects.Text = "Demo - Tracking objects";
            // 
            // vitalSignsToolStripMenuItem
            // 
            this.vitalSignsToolStripMenuItem.Image = global::RFIDIntegratedApplication.Properties.Resources.VitalSign;
            this.vitalSignsToolStripMenuItem.Name = "vitalSignsToolStripMenuItem";
            this.vitalSignsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.vitalSignsToolStripMenuItem.Text = "VitalSigns";
            this.vitalSignsToolStripMenuItem.Click += new System.EventHandler(this.vitalSignsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRunTime,
            this.tsslblCounter,
            this.tsslblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 800);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1010, 29);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "status";
            // 
            // tsslRunTime
            // 
            this.tsslRunTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslRunTime.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tsslRunTime.Image = ((System.Drawing.Image)(resources.GetObject("tsslRunTime.Image")));
            this.tsslRunTime.Name = "tsslRunTime";
            this.tsslRunTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslRunTime.Size = new System.Drawing.Size(82, 24);
            this.tsslRunTime.Text = "Run Time";
            this.tsslRunTime.Click += new System.EventHandler(this.tsslRunTime_Click);
            // 
            // tsslblCounter
            // 
            this.tsslblCounter.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslblCounter.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tsslblCounter.Image = ((System.Drawing.Image)(resources.GetObject("tsslblCounter.Image")));
            this.tsslblCounter.Name = "tsslblCounter";
            this.tsslblCounter.Size = new System.Drawing.Size(74, 24);
            this.tsslblCounter.Text = "Counter";
            this.tsslblCounter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Image = ((System.Drawing.Image)(resources.GetObject("tsslblStatus.Image")));
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(59, 24);
            this.tsslblStatus.Text = "Ready";
            this.tsslblStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsslblStatus.Click += new System.EventHandler(this.tsslblStatus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 829);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dockPanelMain);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RFID Integrated Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton tssbtnSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslRunTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslblCounter;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.ToolStripSplitButton tssbtnAddWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateEpc;
        private System.Windows.Forms.ToolStripMenuItem tsmiReaderSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiRSSIGraph;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhaseGraph;
        private System.Windows.Forms.ToolStripMenuItem tsmiHolographics;
        private System.Windows.Forms.ToolStripMenuItem tsmiDemoSortingBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiDemoTrackingObjects;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem vitalSignsToolStripMenuItem;
    }
}