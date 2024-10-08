﻿namespace PaintShop
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ditherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceduralGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.convolutionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.convolutionLabel = new System.Windows.Forms.Label();
            this.convolutionBtn = new System.Windows.Forms.Button();
            this.convolutionSave = new System.Windows.Forms.Button();
            this.convolutionMatrixPanel = new System.Windows.Forms.TableLayoutPanel();
            this.convolution0x0 = new System.Windows.Forms.NumericUpDown();
            this.convolution0x1 = new System.Windows.Forms.NumericUpDown();
            this.convolution0x2 = new System.Windows.Forms.NumericUpDown();
            this.convolution1x2 = new System.Windows.Forms.NumericUpDown();
            this.convolution1x1 = new System.Windows.Forms.NumericUpDown();
            this.convolution1x0 = new System.Windows.Forms.NumericUpDown();
            this.convolution2x0 = new System.Windows.Forms.NumericUpDown();
            this.convolution2x1 = new System.Windows.Forms.NumericUpDown();
            this.convolution2x2 = new System.Windows.Forms.NumericUpDown();
            this.convolutionNormalize = new System.Windows.Forms.NumericUpDown();
            this.convolutionLabel2 = new System.Windows.Forms.Label();
            this.convolutionLabel3 = new System.Windows.Forms.Label();
            this.ditherPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ditherBtn = new System.Windows.Forms.Button();
            this.ditherSave = new System.Windows.Forms.Button();
            this.ditherBtn2x2 = new System.Windows.Forms.Button();
            this.ditherBtn4x4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dither4x4Panel = new System.Windows.Forms.TableLayoutPanel();
            this.dither4x4_0x0 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_0x1 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_1x0 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_2x0 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_1x1 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_3x0 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_2x1 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_3x1 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_2x2 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_1x2 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_0x2 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_0x3 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_1x3 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_2x3 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_3x3 = new System.Windows.Forms.NumericUpDown();
            this.dither4x4_3x2 = new System.Windows.Forms.NumericUpDown();
            this.dither2x2Panel = new System.Windows.Forms.TableLayoutPanel();
            this.dither2x2_0x0 = new System.Windows.Forms.NumericUpDown();
            this.dither2x2_0x1 = new System.Windows.Forms.NumericUpDown();
            this.dither2x2_1x0 = new System.Windows.Forms.NumericUpDown();
            this.dither2x2_1x1 = new System.Windows.Forms.NumericUpDown();
            this.ditherLabel = new System.Windows.Forms.Label();
            this.quantizePanel = new System.Windows.Forms.TableLayoutPanel();
            this.quantizeLabel = new System.Windows.Forms.Label();
            this.quantizeTrackBar = new System.Windows.Forms.TrackBar();
            this.quantizeSave = new System.Windows.Forms.Button();
            this.quantizeTrackBarLabel = new System.Windows.Forms.Label();
            this.greyscalePanel = new System.Windows.Forms.TableLayoutPanel();
            this.greyscaleLabel = new System.Windows.Forms.Label();
            this.greyscaleBtn = new System.Windows.Forms.Button();
            this.greyscaleSave = new System.Windows.Forms.Button();
            this.brightnessPanel = new System.Windows.Forms.TableLayoutPanel();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessSave = new System.Windows.Forms.Button();
            this.brightnessTrackBarLabel = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.contrastPanel = new System.Windows.Forms.TableLayoutPanel();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastTrackbar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBarLabel = new System.Windows.Forms.Label();
            this.contrastSave = new System.Windows.Forms.Button();
            this.invertPanel = new System.Windows.Forms.TableLayoutPanel();
            this.invertLabel = new System.Windows.Forms.Label();
            this.invertBtn = new System.Windows.Forms.Button();
            this.invertTrackBar = new System.Windows.Forms.TrackBar();
            this.invertTrackBarLabel = new System.Windows.Forms.Label();
            this.noisePanel = new System.Windows.Forms.TableLayoutPanel();
            this.noiseLabel = new System.Windows.Forms.Label();
            this.noiseTrackBar = new System.Windows.Forms.TrackBar();
            this.noiseTrackbarLabel = new System.Windows.Forms.Label();
            this.noiseSave = new System.Windows.Forms.Button();
            this.procgenPanel = new System.Windows.Forms.TableLayoutPanel();
            this.procgenLabel = new System.Windows.Forms.Label();
            this.procgenLandBtn = new System.Windows.Forms.Button();
            this.procgenSky = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bottomInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.coordsLabel = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.topToolbarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colorBtn = new System.Windows.Forms.Button();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.lineBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.bucketBtn = new System.Windows.Forms.Button();
            this.colourLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.convolutionPanel.SuspendLayout();
            this.convolutionMatrixPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convolution0x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution0x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution0x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution1x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution1x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution1x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution2x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution2x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution2x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolutionNormalize)).BeginInit();
            this.ditherPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dither4x4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x2)).BeginInit();
            this.dither2x2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_0x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_0x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_1x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_1x1)).BeginInit();
            this.quantizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantizeTrackBar)).BeginInit();
            this.greyscalePanel.SuspendLayout();
            this.brightnessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.contrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackbar)).BeginInit();
            this.invertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invertTrackBar)).BeginInit();
            this.noisePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTrackBar)).BeginInit();
            this.procgenPanel.SuspendLayout();
            this.bottomInfoPanel.SuspendLayout();
            this.topToolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.noiseToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.quantizeToolStripMenuItem,
            this.ditherToolStripMenuItem,
            this.convolutionToolStripMenuItem,
            this.proceduralGenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // noiseToolStripMenuItem
            // 
            this.noiseToolStripMenuItem.Name = "noiseToolStripMenuItem";
            this.noiseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.noiseToolStripMenuItem.Text = "Noise";
            this.noiseToolStripMenuItem.Click += new System.EventHandler(this.noiseToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // quantizeToolStripMenuItem
            // 
            this.quantizeToolStripMenuItem.Name = "quantizeToolStripMenuItem";
            this.quantizeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quantizeToolStripMenuItem.Text = "Quantize";
            this.quantizeToolStripMenuItem.Click += new System.EventHandler(this.quantizeToolStripMenuItem_Click);
            // 
            // ditherToolStripMenuItem
            // 
            this.ditherToolStripMenuItem.Name = "ditherToolStripMenuItem";
            this.ditherToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ditherToolStripMenuItem.Text = "Dither";
            this.ditherToolStripMenuItem.Click += new System.EventHandler(this.ditherToolStripMenuItem_Click);
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            this.convolutionToolStripMenuItem.Click += new System.EventHandler(this.convolutionToolStripMenuItem_Click);
            // 
            // proceduralGenToolStripMenuItem
            // 
            this.proceduralGenToolStripMenuItem.Name = "proceduralGenToolStripMenuItem";
            this.proceduralGenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.proceduralGenToolStripMenuItem.Text = "Procedural gen";
            this.proceduralGenToolStripMenuItem.Click += new System.EventHandler(this.proceduralGenToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.brightnessPanel);
            this.splitContainer1.Panel2.Controls.Add(this.contrastPanel);
            this.splitContainer1.Panel2.Controls.Add(this.invertPanel);
            this.splitContainer1.Panel2.Controls.Add(this.noisePanel);
            this.splitContainer1.Panel2.Controls.Add(this.procgenPanel);
            this.splitContainer1.Panel2.Controls.Add(this.convolutionPanel);
            this.splitContainer1.Panel2.Controls.Add(this.ditherPanel);
            this.splitContainer1.Panel2.Controls.Add(this.quantizePanel);
            this.splitContainer1.Panel2.Controls.Add(this.greyscalePanel);
            this.splitContainer1.Size = new System.Drawing.Size(912, 605);
            this.splitContainer1.SplitterDistance = 644;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.AutoScroll = true;
            this.pictureBoxPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPanel.Controls.Add(this.pictureBox);
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPanel.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBoxPanel.Size = new System.Drawing.Size(644, 605);
            this.pictureBoxPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImage = global::PaintShop.Properties.Resources.png;
            this.pictureBox.Location = new System.Drawing.Point(-145, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(738, 403);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // convolutionPanel
            // 
            this.convolutionPanel.ColumnCount = 1;
            this.convolutionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.convolutionPanel.Controls.Add(this.convolutionLabel, 0, 0);
            this.convolutionPanel.Controls.Add(this.convolutionBtn, 0, 1);
            this.convolutionPanel.Controls.Add(this.convolutionSave, 0, 2);
            this.convolutionPanel.Controls.Add(this.convolutionMatrixPanel, 0, 3);
            this.convolutionPanel.Controls.Add(this.convolutionNormalize, 0, 4);
            this.convolutionPanel.Controls.Add(this.convolutionLabel2, 0, 3);
            this.convolutionPanel.Controls.Add(this.convolutionLabel3, 0, 4);
            this.convolutionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionPanel.Location = new System.Drawing.Point(0, 0);
            this.convolutionPanel.Name = "convolutionPanel";
            this.convolutionPanel.RowCount = 7;
            this.convolutionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.76744F));
            this.convolutionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.23256F));
            this.convolutionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.convolutionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.convolutionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.convolutionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.convolutionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.convolutionPanel.Size = new System.Drawing.Size(264, 605);
            this.convolutionPanel.TabIndex = 7;
            // 
            // convolutionLabel
            // 
            this.convolutionLabel.AutoSize = true;
            this.convolutionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolutionLabel.Location = new System.Drawing.Point(3, 0);
            this.convolutionLabel.Name = "convolutionLabel";
            this.convolutionLabel.Size = new System.Drawing.Size(258, 95);
            this.convolutionLabel.TabIndex = 0;
            this.convolutionLabel.Text = "Convolution";
            this.convolutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convolutionBtn
            // 
            this.convolutionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolutionBtn.Location = new System.Drawing.Point(3, 98);
            this.convolutionBtn.Name = "convolutionBtn";
            this.convolutionBtn.Size = new System.Drawing.Size(258, 111);
            this.convolutionBtn.TabIndex = 1;
            this.convolutionBtn.Text = "Apply Convolution";
            this.convolutionBtn.UseVisualStyleBackColor = true;
            this.convolutionBtn.Click += new System.EventHandler(this.convolutionBtn_Click);
            // 
            // convolutionSave
            // 
            this.convolutionSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolutionSave.Location = new System.Drawing.Point(3, 215);
            this.convolutionSave.Name = "convolutionSave";
            this.convolutionSave.Size = new System.Drawing.Size(258, 83);
            this.convolutionSave.TabIndex = 2;
            this.convolutionSave.Text = "Set Filter";
            this.convolutionSave.UseVisualStyleBackColor = true;
            this.convolutionSave.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // convolutionMatrixPanel
            // 
            this.convolutionMatrixPanel.ColumnCount = 3;
            this.convolutionMatrixPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.convolutionMatrixPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.convolutionMatrixPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.convolutionMatrixPanel.Controls.Add(this.convolution0x0, 0, 0);
            this.convolutionMatrixPanel.Controls.Add(this.convolution0x1, 1, 0);
            this.convolutionMatrixPanel.Controls.Add(this.convolution0x2, 2, 0);
            this.convolutionMatrixPanel.Controls.Add(this.convolution1x2, 2, 1);
            this.convolutionMatrixPanel.Controls.Add(this.convolution1x1, 1, 1);
            this.convolutionMatrixPanel.Controls.Add(this.convolution1x0, 0, 1);
            this.convolutionMatrixPanel.Controls.Add(this.convolution2x0, 0, 2);
            this.convolutionMatrixPanel.Controls.Add(this.convolution2x1, 1, 2);
            this.convolutionMatrixPanel.Controls.Add(this.convolution2x2, 2, 2);
            this.convolutionMatrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionMatrixPanel.Location = new System.Drawing.Point(3, 337);
            this.convolutionMatrixPanel.Name = "convolutionMatrixPanel";
            this.convolutionMatrixPanel.RowCount = 3;
            this.convolutionMatrixPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.convolutionMatrixPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.convolutionMatrixPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.convolutionMatrixPanel.Size = new System.Drawing.Size(258, 132);
            this.convolutionMatrixPanel.TabIndex = 3;
            // 
            // convolution0x0
            // 
            this.convolution0x0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution0x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution0x0.Location = new System.Drawing.Point(3, 3);
            this.convolution0x0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution0x0.Name = "convolution0x0";
            this.convolution0x0.Size = new System.Drawing.Size(80, 26);
            this.convolution0x0.TabIndex = 0;
            this.convolution0x0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // convolution0x1
            // 
            this.convolution0x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution0x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution0x1.Location = new System.Drawing.Point(89, 3);
            this.convolution0x1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution0x1.Name = "convolution0x1";
            this.convolution0x1.Size = new System.Drawing.Size(80, 26);
            this.convolution0x1.TabIndex = 1;
            this.convolution0x1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // convolution0x2
            // 
            this.convolution0x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution0x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution0x2.Location = new System.Drawing.Point(175, 3);
            this.convolution0x2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution0x2.Name = "convolution0x2";
            this.convolution0x2.Size = new System.Drawing.Size(80, 26);
            this.convolution0x2.TabIndex = 2;
            this.convolution0x2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // convolution1x2
            // 
            this.convolution1x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution1x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution1x2.Location = new System.Drawing.Point(175, 47);
            this.convolution1x2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution1x2.Name = "convolution1x2";
            this.convolution1x2.Size = new System.Drawing.Size(80, 26);
            this.convolution1x2.TabIndex = 3;
            this.convolution1x2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // convolution1x1
            // 
            this.convolution1x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution1x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution1x1.Location = new System.Drawing.Point(89, 47);
            this.convolution1x1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution1x1.Name = "convolution1x1";
            this.convolution1x1.Size = new System.Drawing.Size(80, 26);
            this.convolution1x1.TabIndex = 4;
            this.convolution1x1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // convolution1x0
            // 
            this.convolution1x0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution1x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution1x0.Location = new System.Drawing.Point(3, 47);
            this.convolution1x0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution1x0.Name = "convolution1x0";
            this.convolution1x0.Size = new System.Drawing.Size(80, 26);
            this.convolution1x0.TabIndex = 5;
            this.convolution1x0.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // convolution2x0
            // 
            this.convolution2x0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution2x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution2x0.Location = new System.Drawing.Point(3, 91);
            this.convolution2x0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution2x0.Name = "convolution2x0";
            this.convolution2x0.Size = new System.Drawing.Size(80, 26);
            this.convolution2x0.TabIndex = 6;
            this.convolution2x0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // convolution2x1
            // 
            this.convolution2x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution2x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution2x1.Location = new System.Drawing.Point(89, 91);
            this.convolution2x1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution2x1.Name = "convolution2x1";
            this.convolution2x1.Size = new System.Drawing.Size(80, 26);
            this.convolution2x1.TabIndex = 7;
            this.convolution2x1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // convolution2x2
            // 
            this.convolution2x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolution2x2.Location = new System.Drawing.Point(175, 91);
            this.convolution2x2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convolution2x2.Name = "convolution2x2";
            this.convolution2x2.Size = new System.Drawing.Size(80, 26);
            this.convolution2x2.TabIndex = 8;
            this.convolution2x2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // convolutionNormalize
            // 
            this.convolutionNormalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolutionNormalize.Location = new System.Drawing.Point(3, 512);
            this.convolutionNormalize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.convolutionNormalize.Name = "convolutionNormalize";
            this.convolutionNormalize.Size = new System.Drawing.Size(258, 26);
            this.convolutionNormalize.TabIndex = 4;
            this.convolutionNormalize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // convolutionLabel2
            // 
            this.convolutionLabel2.AutoSize = true;
            this.convolutionLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolutionLabel2.Location = new System.Drawing.Point(3, 301);
            this.convolutionLabel2.Name = "convolutionLabel2";
            this.convolutionLabel2.Size = new System.Drawing.Size(258, 33);
            this.convolutionLabel2.TabIndex = 5;
            this.convolutionLabel2.Text = "Convolution Mask";
            this.convolutionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convolutionLabel3
            // 
            this.convolutionLabel3.AutoSize = true;
            this.convolutionLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolutionLabel3.Location = new System.Drawing.Point(3, 472);
            this.convolutionLabel3.Name = "convolutionLabel3";
            this.convolutionLabel3.Size = new System.Drawing.Size(258, 37);
            this.convolutionLabel3.TabIndex = 6;
            this.convolutionLabel3.Text = "Normalisation Value";
            this.convolutionLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ditherPanel
            // 
            this.ditherPanel.ColumnCount = 1;
            this.ditherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ditherPanel.Controls.Add(this.ditherBtn, 0, 1);
            this.ditherPanel.Controls.Add(this.ditherSave, 0, 2);
            this.ditherPanel.Controls.Add(this.ditherBtn2x2, 0, 3);
            this.ditherPanel.Controls.Add(this.ditherBtn4x4, 0, 4);
            this.ditherPanel.Controls.Add(this.panel2, 0, 6);
            this.ditherPanel.Controls.Add(this.ditherLabel, 0, 0);
            this.ditherPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ditherPanel.Location = new System.Drawing.Point(0, 0);
            this.ditherPanel.Name = "ditherPanel";
            this.ditherPanel.RowCount = 8;
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.ditherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.ditherPanel.Size = new System.Drawing.Size(264, 605);
            this.ditherPanel.TabIndex = 6;
            // 
            // ditherBtn
            // 
            this.ditherBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ditherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ditherBtn.Location = new System.Drawing.Point(3, 116);
            this.ditherBtn.Name = "ditherBtn";
            this.ditherBtn.Size = new System.Drawing.Size(258, 101);
            this.ditherBtn.TabIndex = 1;
            this.ditherBtn.Text = "Apply Dither";
            this.ditherBtn.UseVisualStyleBackColor = true;
            this.ditherBtn.Click += new System.EventHandler(this.ditherBtn_Click);
            // 
            // ditherSave
            // 
            this.ditherSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ditherSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ditherSave.Location = new System.Drawing.Point(3, 223);
            this.ditherSave.Name = "ditherSave";
            this.ditherSave.Size = new System.Drawing.Size(258, 38);
            this.ditherSave.TabIndex = 2;
            this.ditherSave.Text = "Set Filter";
            this.ditherSave.UseVisualStyleBackColor = true;
            this.ditherSave.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // ditherBtn2x2
            // 
            this.ditherBtn2x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ditherBtn2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ditherBtn2x2.Location = new System.Drawing.Point(3, 267);
            this.ditherBtn2x2.Name = "ditherBtn2x2";
            this.ditherBtn2x2.Size = new System.Drawing.Size(258, 41);
            this.ditherBtn2x2.TabIndex = 3;
            this.ditherBtn2x2.Text = "2x2";
            this.ditherBtn2x2.UseVisualStyleBackColor = true;
            this.ditherBtn2x2.Click += new System.EventHandler(this.ditherBtn2x2_Click);
            // 
            // ditherBtn4x4
            // 
            this.ditherBtn4x4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ditherBtn4x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ditherBtn4x4.Location = new System.Drawing.Point(3, 314);
            this.ditherBtn4x4.Name = "ditherBtn4x4";
            this.ditherBtn4x4.Size = new System.Drawing.Size(258, 42);
            this.ditherBtn4x4.TabIndex = 4;
            this.ditherBtn4x4.Text = "4x4";
            this.ditherBtn4x4.UseVisualStyleBackColor = true;
            this.ditherBtn4x4.Click += new System.EventHandler(this.ditherBtn4x4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dither4x4Panel);
            this.panel2.Controls.Add(this.dither2x2Panel);
            this.panel2.Location = new System.Drawing.Point(3, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 173);
            this.panel2.TabIndex = 6;
            // 
            // dither4x4Panel
            // 
            this.dither4x4Panel.ColumnCount = 4;
            this.dither4x4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dither4x4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dither4x4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dither4x4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dither4x4Panel.Controls.Add(this.dither4x4_0x0, 0, 0);
            this.dither4x4Panel.Controls.Add(this.dither4x4_0x1, 1, 0);
            this.dither4x4Panel.Controls.Add(this.dither4x4_1x0, 0, 1);
            this.dither4x4Panel.Controls.Add(this.dither4x4_2x0, 0, 2);
            this.dither4x4Panel.Controls.Add(this.dither4x4_1x1, 1, 1);
            this.dither4x4Panel.Controls.Add(this.dither4x4_3x0, 0, 3);
            this.dither4x4Panel.Controls.Add(this.dither4x4_2x1, 1, 2);
            this.dither4x4Panel.Controls.Add(this.dither4x4_3x1, 1, 3);
            this.dither4x4Panel.Controls.Add(this.dither4x4_2x2, 2, 2);
            this.dither4x4Panel.Controls.Add(this.dither4x4_1x2, 2, 1);
            this.dither4x4Panel.Controls.Add(this.dither4x4_0x2, 2, 0);
            this.dither4x4Panel.Controls.Add(this.dither4x4_0x3, 3, 0);
            this.dither4x4Panel.Controls.Add(this.dither4x4_1x3, 3, 1);
            this.dither4x4Panel.Controls.Add(this.dither4x4_2x3, 3, 2);
            this.dither4x4Panel.Controls.Add(this.dither4x4_3x3, 3, 3);
            this.dither4x4Panel.Controls.Add(this.dither4x4_3x2, 2, 3);
            this.dither4x4Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dither4x4Panel.Location = new System.Drawing.Point(0, 0);
            this.dither4x4Panel.Name = "dither4x4Panel";
            this.dither4x4Panel.RowCount = 4;
            this.dither4x4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.dither4x4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.dither4x4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.dither4x4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.dither4x4Panel.Size = new System.Drawing.Size(258, 173);
            this.dither4x4Panel.TabIndex = 6;
            this.dither4x4Panel.Visible = false;
            // 
            // dither4x4_0x0
            // 
            this.dither4x4_0x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_0x0.Location = new System.Drawing.Point(3, 3);
            this.dither4x4_0x0.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_0x0.Name = "dither4x4_0x0";
            this.dither4x4_0x0.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_0x0.TabIndex = 0;
            // 
            // dither4x4_0x1
            // 
            this.dither4x4_0x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_0x1.Location = new System.Drawing.Point(67, 3);
            this.dither4x4_0x1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_0x1.Name = "dither4x4_0x1";
            this.dither4x4_0x1.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_0x1.TabIndex = 1;
            this.dither4x4_0x1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // dither4x4_1x0
            // 
            this.dither4x4_1x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_1x0.Location = new System.Drawing.Point(3, 46);
            this.dither4x4_1x0.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_1x0.Name = "dither4x4_1x0";
            this.dither4x4_1x0.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_1x0.TabIndex = 2;
            this.dither4x4_1x0.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // dither4x4_2x0
            // 
            this.dither4x4_2x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_2x0.Location = new System.Drawing.Point(3, 89);
            this.dither4x4_2x0.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_2x0.Name = "dither4x4_2x0";
            this.dither4x4_2x0.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_2x0.TabIndex = 3;
            this.dither4x4_2x0.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dither4x4_1x1
            // 
            this.dither4x4_1x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_1x1.Location = new System.Drawing.Point(67, 46);
            this.dither4x4_1x1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_1x1.Name = "dither4x4_1x1";
            this.dither4x4_1x1.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_1x1.TabIndex = 4;
            this.dither4x4_1x1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // dither4x4_3x0
            // 
            this.dither4x4_3x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_3x0.Location = new System.Drawing.Point(3, 132);
            this.dither4x4_3x0.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_3x0.Name = "dither4x4_3x0";
            this.dither4x4_3x0.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_3x0.TabIndex = 5;
            this.dither4x4_3x0.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dither4x4_2x1
            // 
            this.dither4x4_2x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_2x1.Location = new System.Drawing.Point(67, 89);
            this.dither4x4_2x1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_2x1.Name = "dither4x4_2x1";
            this.dither4x4_2x1.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_2x1.TabIndex = 6;
            this.dither4x4_2x1.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // dither4x4_3x1
            // 
            this.dither4x4_3x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_3x1.Location = new System.Drawing.Point(67, 132);
            this.dither4x4_3x1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_3x1.Name = "dither4x4_3x1";
            this.dither4x4_3x1.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_3x1.TabIndex = 7;
            this.dither4x4_3x1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // dither4x4_2x2
            // 
            this.dither4x4_2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_2x2.Location = new System.Drawing.Point(131, 89);
            this.dither4x4_2x2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_2x2.Name = "dither4x4_2x2";
            this.dither4x4_2x2.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_2x2.TabIndex = 8;
            this.dither4x4_2x2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dither4x4_1x2
            // 
            this.dither4x4_1x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_1x2.Location = new System.Drawing.Point(131, 46);
            this.dither4x4_1x2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_1x2.Name = "dither4x4_1x2";
            this.dither4x4_1x2.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_1x2.TabIndex = 9;
            this.dither4x4_1x2.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // dither4x4_0x2
            // 
            this.dither4x4_0x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_0x2.Location = new System.Drawing.Point(131, 3);
            this.dither4x4_0x2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_0x2.Name = "dither4x4_0x2";
            this.dither4x4_0x2.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_0x2.TabIndex = 10;
            this.dither4x4_0x2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // dither4x4_0x3
            // 
            this.dither4x4_0x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_0x3.Location = new System.Drawing.Point(195, 3);
            this.dither4x4_0x3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_0x3.Name = "dither4x4_0x3";
            this.dither4x4_0x3.Size = new System.Drawing.Size(60, 26);
            this.dither4x4_0x3.TabIndex = 11;
            this.dither4x4_0x3.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // dither4x4_1x3
            // 
            this.dither4x4_1x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_1x3.Location = new System.Drawing.Point(195, 46);
            this.dither4x4_1x3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_1x3.Name = "dither4x4_1x3";
            this.dither4x4_1x3.Size = new System.Drawing.Size(60, 26);
            this.dither4x4_1x3.TabIndex = 12;
            this.dither4x4_1x3.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // dither4x4_2x3
            // 
            this.dither4x4_2x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_2x3.Location = new System.Drawing.Point(195, 89);
            this.dither4x4_2x3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_2x3.Name = "dither4x4_2x3";
            this.dither4x4_2x3.Size = new System.Drawing.Size(60, 26);
            this.dither4x4_2x3.TabIndex = 13;
            this.dither4x4_2x3.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // dither4x4_3x3
            // 
            this.dither4x4_3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_3x3.Location = new System.Drawing.Point(195, 132);
            this.dither4x4_3x3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_3x3.Name = "dither4x4_3x3";
            this.dither4x4_3x3.Size = new System.Drawing.Size(60, 26);
            this.dither4x4_3x3.TabIndex = 14;
            this.dither4x4_3x3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dither4x4_3x2
            // 
            this.dither4x4_3x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither4x4_3x2.Location = new System.Drawing.Point(131, 132);
            this.dither4x4_3x2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dither4x4_3x2.Name = "dither4x4_3x2";
            this.dither4x4_3x2.Size = new System.Drawing.Size(58, 26);
            this.dither4x4_3x2.TabIndex = 15;
            this.dither4x4_3x2.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // dither2x2Panel
            // 
            this.dither2x2Panel.ColumnCount = 2;
            this.dither2x2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dither2x2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dither2x2Panel.Controls.Add(this.dither2x2_0x0, 0, 0);
            this.dither2x2Panel.Controls.Add(this.dither2x2_0x1, 1, 0);
            this.dither2x2Panel.Controls.Add(this.dither2x2_1x0, 0, 1);
            this.dither2x2Panel.Controls.Add(this.dither2x2_1x1, 1, 1);
            this.dither2x2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dither2x2Panel.Location = new System.Drawing.Point(0, 0);
            this.dither2x2Panel.Name = "dither2x2Panel";
            this.dither2x2Panel.RowCount = 2;
            this.dither2x2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dither2x2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dither2x2Panel.Size = new System.Drawing.Size(258, 173);
            this.dither2x2Panel.TabIndex = 5;
            // 
            // dither2x2_0x0
            // 
            this.dither2x2_0x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither2x2_0x0.Location = new System.Drawing.Point(3, 3);
            this.dither2x2_0x0.Name = "dither2x2_0x0";
            this.dither2x2_0x0.Size = new System.Drawing.Size(120, 26);
            this.dither2x2_0x0.TabIndex = 0;
            // 
            // dither2x2_0x1
            // 
            this.dither2x2_0x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither2x2_0x1.Location = new System.Drawing.Point(132, 3);
            this.dither2x2_0x1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.dither2x2_0x1.Name = "dither2x2_0x1";
            this.dither2x2_0x1.Size = new System.Drawing.Size(120, 26);
            this.dither2x2_0x1.TabIndex = 1;
            this.dither2x2_0x1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // dither2x2_1x0
            // 
            this.dither2x2_1x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither2x2_1x0.Location = new System.Drawing.Point(3, 89);
            this.dither2x2_1x0.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.dither2x2_1x0.Name = "dither2x2_1x0";
            this.dither2x2_1x0.Size = new System.Drawing.Size(120, 26);
            this.dither2x2_1x0.TabIndex = 2;
            this.dither2x2_1x0.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dither2x2_1x1
            // 
            this.dither2x2_1x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dither2x2_1x1.Location = new System.Drawing.Point(132, 89);
            this.dither2x2_1x1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.dither2x2_1x1.Name = "dither2x2_1x1";
            this.dither2x2_1x1.Size = new System.Drawing.Size(120, 26);
            this.dither2x2_1x1.TabIndex = 3;
            this.dither2x2_1x1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ditherLabel
            // 
            this.ditherLabel.AutoSize = true;
            this.ditherLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ditherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ditherLabel.Location = new System.Drawing.Point(3, 0);
            this.ditherLabel.Name = "ditherLabel";
            this.ditherLabel.Size = new System.Drawing.Size(258, 113);
            this.ditherLabel.TabIndex = 0;
            this.ditherLabel.Text = "Dither";
            this.ditherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantizePanel
            // 
            this.quantizePanel.ColumnCount = 1;
            this.quantizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.quantizePanel.Controls.Add(this.quantizeLabel, 0, 0);
            this.quantizePanel.Controls.Add(this.quantizeTrackBar, 0, 1);
            this.quantizePanel.Controls.Add(this.quantizeSave, 0, 3);
            this.quantizePanel.Controls.Add(this.quantizeTrackBarLabel, 0, 2);
            this.quantizePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantizePanel.Location = new System.Drawing.Point(0, 0);
            this.quantizePanel.Name = "quantizePanel";
            this.quantizePanel.RowCount = 5;
            this.quantizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.50237F));
            this.quantizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.49763F));
            this.quantizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.quantizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.quantizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.quantizePanel.Size = new System.Drawing.Size(264, 605);
            this.quantizePanel.TabIndex = 5;
            // 
            // quantizeLabel
            // 
            this.quantizeLabel.AutoSize = true;
            this.quantizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantizeLabel.Location = new System.Drawing.Point(3, 0);
            this.quantizeLabel.Name = "quantizeLabel";
            this.quantizeLabel.Size = new System.Drawing.Size(258, 131);
            this.quantizeLabel.TabIndex = 0;
            this.quantizeLabel.Text = "Quantize";
            this.quantizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantizeTrackBar
            // 
            this.quantizeTrackBar.Location = new System.Drawing.Point(3, 134);
            this.quantizeTrackBar.Maximum = 20;
            this.quantizeTrackBar.Minimum = 2;
            this.quantizeTrackBar.Name = "quantizeTrackBar";
            this.quantizeTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantizeTrackBar.Size = new System.Drawing.Size(258, 45);
            this.quantizeTrackBar.TabIndex = 1;
            this.quantizeTrackBar.Value = 2;
            this.quantizeTrackBar.Scroll += new System.EventHandler(this.quantizeTrackBar_Scroll);
            // 
            // quantizeSave
            // 
            this.quantizeSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantizeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantizeSave.Location = new System.Drawing.Point(3, 316);
            this.quantizeSave.Name = "quantizeSave";
            this.quantizeSave.Size = new System.Drawing.Size(258, 93);
            this.quantizeSave.TabIndex = 3;
            this.quantizeSave.Text = "Set Filter";
            this.quantizeSave.UseVisualStyleBackColor = true;
            this.quantizeSave.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // quantizeTrackBarLabel
            // 
            this.quantizeTrackBarLabel.AutoSize = true;
            this.quantizeTrackBarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantizeTrackBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantizeTrackBarLabel.Location = new System.Drawing.Point(3, 240);
            this.quantizeTrackBarLabel.Name = "quantizeTrackBarLabel";
            this.quantizeTrackBarLabel.Size = new System.Drawing.Size(258, 73);
            this.quantizeTrackBarLabel.TabIndex = 2;
            this.quantizeTrackBarLabel.Text = "2";
            this.quantizeTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greyscalePanel
            // 
            this.greyscalePanel.ColumnCount = 1;
            this.greyscalePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.greyscalePanel.Controls.Add(this.greyscaleLabel, 0, 0);
            this.greyscalePanel.Controls.Add(this.greyscaleBtn, 0, 1);
            this.greyscalePanel.Controls.Add(this.greyscaleSave, 0, 2);
            this.greyscalePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greyscalePanel.Location = new System.Drawing.Point(0, 0);
            this.greyscalePanel.Name = "greyscalePanel";
            this.greyscalePanel.RowCount = 4;
            this.greyscalePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.39367F));
            this.greyscalePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.60633F));
            this.greyscalePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.greyscalePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.greyscalePanel.Size = new System.Drawing.Size(264, 605);
            this.greyscalePanel.TabIndex = 4;
            // 
            // greyscaleLabel
            // 
            this.greyscaleLabel.AutoSize = true;
            this.greyscaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greyscaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greyscaleLabel.Location = new System.Drawing.Point(3, 0);
            this.greyscaleLabel.Name = "greyscaleLabel";
            this.greyscaleLabel.Size = new System.Drawing.Size(258, 136);
            this.greyscaleLabel.TabIndex = 0;
            this.greyscaleLabel.Text = "Greyscale";
            this.greyscaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greyscaleBtn
            // 
            this.greyscaleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greyscaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greyscaleBtn.Location = new System.Drawing.Point(3, 139);
            this.greyscaleBtn.Name = "greyscaleBtn";
            this.greyscaleBtn.Size = new System.Drawing.Size(258, 112);
            this.greyscaleBtn.TabIndex = 1;
            this.greyscaleBtn.Text = "Apply Greyscale";
            this.greyscaleBtn.UseVisualStyleBackColor = true;
            this.greyscaleBtn.Click += new System.EventHandler(this.greyscaleBtn_Click);
            // 
            // greyscaleSave
            // 
            this.greyscaleSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greyscaleSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greyscaleSave.Location = new System.Drawing.Point(3, 257);
            this.greyscaleSave.Name = "greyscaleSave";
            this.greyscaleSave.Size = new System.Drawing.Size(258, 71);
            this.greyscaleSave.TabIndex = 2;
            this.greyscaleSave.Text = "Set Filter";
            this.greyscaleSave.UseVisualStyleBackColor = true;
            this.greyscaleSave.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // brightnessPanel
            // 
            this.brightnessPanel.ColumnCount = 1;
            this.brightnessPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.brightnessPanel.Controls.Add(this.brightnessTrackBar, 0, 1);
            this.brightnessPanel.Controls.Add(this.brightnessSave, 0, 3);
            this.brightnessPanel.Controls.Add(this.brightnessTrackBarLabel, 0, 2);
            this.brightnessPanel.Controls.Add(this.brightnessLabel, 0, 0);
            this.brightnessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessPanel.Location = new System.Drawing.Point(0, 0);
            this.brightnessPanel.Name = "brightnessPanel";
            this.brightnessPanel.RowCount = 7;
            this.brightnessPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.brightnessPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.brightnessPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.brightnessPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.brightnessPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.brightnessPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.brightnessPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.brightnessPanel.Size = new System.Drawing.Size(264, 605);
            this.brightnessPanel.TabIndex = 0;
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.brightnessTrackBar.Location = new System.Drawing.Point(3, 89);
            this.brightnessTrackBar.Maximum = 255;
            this.brightnessTrackBar.Minimum = -255;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(258, 45);
            this.brightnessTrackBar.TabIndex = 0;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // brightnessSave
            // 
            this.brightnessSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessSave.Location = new System.Drawing.Point(3, 261);
            this.brightnessSave.Name = "brightnessSave";
            this.brightnessSave.Size = new System.Drawing.Size(258, 75);
            this.brightnessSave.TabIndex = 0;
            this.brightnessSave.Text = "Set Filter";
            this.brightnessSave.UseVisualStyleBackColor = true;
            this.brightnessSave.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // brightnessTrackBarLabel
            // 
            this.brightnessTrackBarLabel.AutoSize = true;
            this.brightnessTrackBarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessTrackBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessTrackBarLabel.Location = new System.Drawing.Point(3, 172);
            this.brightnessTrackBarLabel.Name = "brightnessTrackBarLabel";
            this.brightnessTrackBarLabel.Size = new System.Drawing.Size(258, 86);
            this.brightnessTrackBarLabel.TabIndex = 1;
            this.brightnessTrackBarLabel.Text = "0";
            this.brightnessTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessLabel.Location = new System.Drawing.Point(3, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(258, 86);
            this.brightnessLabel.TabIndex = 2;
            this.brightnessLabel.Text = "Brightness";
            this.brightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrastPanel
            // 
            this.contrastPanel.ColumnCount = 1;
            this.contrastPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contrastPanel.Controls.Add(this.contrastLabel, 0, 0);
            this.contrastPanel.Controls.Add(this.contrastTrackbar, 0, 1);
            this.contrastPanel.Controls.Add(this.contrastTrackBarLabel, 0, 2);
            this.contrastPanel.Controls.Add(this.contrastSave, 0, 3);
            this.contrastPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastPanel.Location = new System.Drawing.Point(0, 0);
            this.contrastPanel.Name = "contrastPanel";
            this.contrastPanel.RowCount = 5;
            this.contrastPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.39378F));
            this.contrastPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.60622F));
            this.contrastPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.contrastPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.contrastPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.contrastPanel.Size = new System.Drawing.Size(264, 605);
            this.contrastPanel.TabIndex = 3;
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastLabel.Location = new System.Drawing.Point(3, 0);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(258, 116);
            this.contrastLabel.TabIndex = 0;
            this.contrastLabel.Text = "Contrast";
            this.contrastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrastTrackbar
            // 
            this.contrastTrackbar.Location = new System.Drawing.Point(3, 119);
            this.contrastTrackbar.Maximum = 100;
            this.contrastTrackbar.Minimum = -100;
            this.contrastTrackbar.Name = "contrastTrackbar";
            this.contrastTrackbar.Size = new System.Drawing.Size(258, 45);
            this.contrastTrackbar.TabIndex = 1;
            this.contrastTrackbar.Scroll += new System.EventHandler(this.contrastTrackbar_Scroll);
            // 
            // contrastTrackBarLabel
            // 
            this.contrastTrackBarLabel.AutoSize = true;
            this.contrastTrackBarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastTrackBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastTrackBarLabel.Location = new System.Drawing.Point(3, 169);
            this.contrastTrackBarLabel.Name = "contrastTrackBarLabel";
            this.contrastTrackBarLabel.Size = new System.Drawing.Size(258, 37);
            this.contrastTrackBarLabel.TabIndex = 2;
            this.contrastTrackBarLabel.Text = "0";
            this.contrastTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrastSave
            // 
            this.contrastSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastSave.Location = new System.Drawing.Point(3, 209);
            this.contrastSave.Name = "contrastSave";
            this.contrastSave.Size = new System.Drawing.Size(258, 73);
            this.contrastSave.TabIndex = 3;
            this.contrastSave.Text = "Set Filter";
            this.contrastSave.UseVisualStyleBackColor = true;
            this.contrastSave.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // invertPanel
            // 
            this.invertPanel.ColumnCount = 1;
            this.invertPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.invertPanel.Controls.Add(this.invertLabel, 0, 0);
            this.invertPanel.Controls.Add(this.invertBtn, 0, 3);
            this.invertPanel.Controls.Add(this.invertTrackBar, 0, 1);
            this.invertPanel.Controls.Add(this.invertTrackBarLabel, 0, 2);
            this.invertPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invertPanel.Location = new System.Drawing.Point(0, 0);
            this.invertPanel.Name = "invertPanel";
            this.invertPanel.RowCount = 4;
            this.invertPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.78862F));
            this.invertPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.21138F));
            this.invertPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.invertPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.invertPanel.Size = new System.Drawing.Size(264, 605);
            this.invertPanel.TabIndex = 1;
            this.invertPanel.Visible = false;
            // 
            // invertLabel
            // 
            this.invertLabel.AutoSize = true;
            this.invertLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertLabel.Location = new System.Drawing.Point(3, 0);
            this.invertLabel.Name = "invertLabel";
            this.invertLabel.Size = new System.Drawing.Size(258, 128);
            this.invertLabel.TabIndex = 2;
            this.invertLabel.Text = "Invert";
            this.invertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invertBtn
            // 
            this.invertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertBtn.Location = new System.Drawing.Point(3, 256);
            this.invertBtn.Name = "invertBtn";
            this.invertBtn.Size = new System.Drawing.Size(258, 78);
            this.invertBtn.TabIndex = 0;
            this.invertBtn.Text = "Set Filter";
            this.invertBtn.UseVisualStyleBackColor = true;
            this.invertBtn.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // invertTrackBar
            // 
            this.invertTrackBar.Location = new System.Drawing.Point(3, 131);
            this.invertTrackBar.Maximum = 255;
            this.invertTrackBar.Name = "invertTrackBar";
            this.invertTrackBar.Size = new System.Drawing.Size(258, 45);
            this.invertTrackBar.TabIndex = 1;
            this.invertTrackBar.Value = 1;
            this.invertTrackBar.Scroll += new System.EventHandler(this.invertTrackBar_Scroll);
            // 
            // invertTrackBarLabel
            // 
            this.invertTrackBarLabel.AutoSize = true;
            this.invertTrackBarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invertTrackBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertTrackBarLabel.Location = new System.Drawing.Point(3, 207);
            this.invertTrackBarLabel.Name = "invertTrackBarLabel";
            this.invertTrackBarLabel.Size = new System.Drawing.Size(258, 46);
            this.invertTrackBarLabel.TabIndex = 3;
            this.invertTrackBarLabel.Text = "0";
            this.invertTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noisePanel
            // 
            this.noisePanel.ColumnCount = 1;
            this.noisePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.noisePanel.Controls.Add(this.noiseLabel, 0, 0);
            this.noisePanel.Controls.Add(this.noiseTrackBar, 0, 1);
            this.noisePanel.Controls.Add(this.noiseTrackbarLabel, 0, 2);
            this.noisePanel.Controls.Add(this.noiseSave, 0, 3);
            this.noisePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noisePanel.Location = new System.Drawing.Point(0, 0);
            this.noisePanel.Name = "noisePanel";
            this.noisePanel.RowCount = 5;
            this.noisePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.noisePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.noisePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.noisePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.noisePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.noisePanel.Size = new System.Drawing.Size(264, 605);
            this.noisePanel.TabIndex = 2;
            // 
            // noiseLabel
            // 
            this.noiseLabel.AutoSize = true;
            this.noiseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiseLabel.Location = new System.Drawing.Point(3, 0);
            this.noiseLabel.Name = "noiseLabel";
            this.noiseLabel.Size = new System.Drawing.Size(258, 85);
            this.noiseLabel.TabIndex = 0;
            this.noiseLabel.Text = "Noise";
            this.noiseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noiseTrackBar
            // 
            this.noiseTrackBar.Location = new System.Drawing.Point(3, 88);
            this.noiseTrackBar.Maximum = 255;
            this.noiseTrackBar.Minimum = 1;
            this.noiseTrackBar.Name = "noiseTrackBar";
            this.noiseTrackBar.Size = new System.Drawing.Size(258, 45);
            this.noiseTrackBar.TabIndex = 1;
            this.noiseTrackBar.Value = 1;
            this.noiseTrackBar.Scroll += new System.EventHandler(this.noiseTrackBar_Scroll);
            // 
            // noiseTrackbarLabel
            // 
            this.noiseTrackbarLabel.AutoSize = true;
            this.noiseTrackbarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noiseTrackbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiseTrackbarLabel.Location = new System.Drawing.Point(3, 174);
            this.noiseTrackbarLabel.Name = "noiseTrackbarLabel";
            this.noiseTrackbarLabel.Size = new System.Drawing.Size(258, 73);
            this.noiseTrackbarLabel.TabIndex = 2;
            this.noiseTrackbarLabel.Text = "0";
            this.noiseTrackbarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noiseSave
            // 
            this.noiseSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noiseSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiseSave.Location = new System.Drawing.Point(3, 250);
            this.noiseSave.Name = "noiseSave";
            this.noiseSave.Size = new System.Drawing.Size(258, 82);
            this.noiseSave.TabIndex = 3;
            this.noiseSave.Text = "Set Filter";
            this.noiseSave.UseVisualStyleBackColor = true;
            this.noiseSave.Click += new System.EventHandler(this.SaveImageToTemp_Click);
            // 
            // procgenPanel
            // 
            this.procgenPanel.ColumnCount = 1;
            this.procgenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.procgenPanel.Controls.Add(this.procgenLabel, 0, 0);
            this.procgenPanel.Controls.Add(this.procgenLandBtn, 0, 1);
            this.procgenPanel.Controls.Add(this.procgenSky, 0, 2);
            this.procgenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procgenPanel.Location = new System.Drawing.Point(0, 0);
            this.procgenPanel.Name = "procgenPanel";
            this.procgenPanel.RowCount = 4;
            this.procgenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.24324F));
            this.procgenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.75676F));
            this.procgenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.procgenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.procgenPanel.Size = new System.Drawing.Size(264, 605);
            this.procgenPanel.TabIndex = 8;
            // 
            // procgenLabel
            // 
            this.procgenLabel.AutoSize = true;
            this.procgenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procgenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procgenLabel.Location = new System.Drawing.Point(3, 0);
            this.procgenLabel.Name = "procgenLabel";
            this.procgenLabel.Size = new System.Drawing.Size(258, 110);
            this.procgenLabel.TabIndex = 0;
            this.procgenLabel.Text = "Procedural Generation";
            this.procgenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // procgenLandBtn
            // 
            this.procgenLandBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procgenLandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procgenLandBtn.Location = new System.Drawing.Point(3, 113);
            this.procgenLandBtn.Name = "procgenLandBtn";
            this.procgenLandBtn.Size = new System.Drawing.Size(258, 139);
            this.procgenLandBtn.TabIndex = 1;
            this.procgenLandBtn.Text = "Generate Land";
            this.procgenLandBtn.UseVisualStyleBackColor = true;
            this.procgenLandBtn.Click += new System.EventHandler(this.procgenLandBtn_Click);
            // 
            // procgenSky
            // 
            this.procgenSky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procgenSky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procgenSky.Location = new System.Drawing.Point(3, 258);
            this.procgenSky.Name = "procgenSky";
            this.procgenSky.Size = new System.Drawing.Size(258, 93);
            this.procgenSky.TabIndex = 2;
            this.procgenSky.Text = "Generate Sky";
            this.procgenSky.UseVisualStyleBackColor = true;
            this.procgenSky.Click += new System.EventHandler(this.procgenSky_Click);
            // 
            // bottomInfoPanel
            // 
            this.bottomInfoPanel.ColumnCount = 4;
            this.bottomInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.bottomInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.bottomInfoPanel.Controls.Add(this.coordsLabel, 0, 0);
            this.bottomInfoPanel.Controls.Add(this.zoomLabel, 1, 0);
            this.bottomInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomInfoPanel.Location = new System.Drawing.Point(3, 659);
            this.bottomInfoPanel.Name = "bottomInfoPanel";
            this.bottomInfoPanel.RowCount = 1;
            this.bottomInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomInfoPanel.Size = new System.Drawing.Size(912, 25);
            this.bottomInfoPanel.TabIndex = 3;
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordsLabel.Location = new System.Drawing.Point(3, 0);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(118, 25);
            this.coordsLabel.TabIndex = 0;
            this.coordsLabel.Text = "X: , Y:";
            this.coordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomLabel.Location = new System.Drawing.Point(127, 0);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(118, 25);
            this.zoomLabel.TabIndex = 1;
            this.zoomLabel.Text = "Zoom: 1";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topToolbarPanel
            // 
            this.topToolbarPanel.ColumnCount = 10;
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topToolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.topToolbarPanel.Controls.Add(this.colorBtn, 0, 0);
            this.topToolbarPanel.Controls.Add(this.thicknessTrackBar, 1, 0);
            this.topToolbarPanel.Controls.Add(this.lineBtn, 3, 0);
            this.topToolbarPanel.Controls.Add(this.penBtn, 2, 0);
            this.topToolbarPanel.Controls.Add(this.ellipseBtn, 5, 0);
            this.topToolbarPanel.Controls.Add(this.rectangleBtn, 4, 0);
            this.topToolbarPanel.Controls.Add(this.bucketBtn, 6, 0);
            this.topToolbarPanel.Controls.Add(this.colourLabel, 0, 0);
            this.topToolbarPanel.Controls.Add(this.label1, 1, 0);
            this.topToolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topToolbarPanel.Location = new System.Drawing.Point(3, 3);
            this.topToolbarPanel.Name = "topToolbarPanel";
            this.topToolbarPanel.RowCount = 1;
            this.topToolbarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topToolbarPanel.Size = new System.Drawing.Size(912, 39);
            this.topToolbarPanel.TabIndex = 2;
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.Black;
            this.colorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBtn.Location = new System.Drawing.Point(63, 3);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(94, 33);
            this.colorBtn.TabIndex = 0;
            this.colorBtn.UseVisualStyleBackColor = false;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thicknessTrackBar.Location = new System.Drawing.Point(263, 3);
            this.thicknessTrackBar.Maximum = 30;
            this.thicknessTrackBar.Minimum = 1;
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(144, 33);
            this.thicknessTrackBar.TabIndex = 1;
            this.thicknessTrackBar.Value = 1;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lineBtn
            // 
            this.lineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBtn.Location = new System.Drawing.Point(513, 3);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(94, 33);
            this.lineBtn.TabIndex = 4;
            this.lineBtn.Text = "Line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // penBtn
            // 
            this.penBtn.BackColor = System.Drawing.Color.White;
            this.penBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penBtn.Location = new System.Drawing.Point(413, 3);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(94, 33);
            this.penBtn.TabIndex = 5;
            this.penBtn.Text = "Pen";
            this.penBtn.UseVisualStyleBackColor = false;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ellipseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipseBtn.Location = new System.Drawing.Point(713, 3);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(94, 33);
            this.ellipseBtn.TabIndex = 3;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangleBtn.Location = new System.Drawing.Point(613, 3);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(94, 33);
            this.rectangleBtn.TabIndex = 2;
            this.rectangleBtn.Text = "Rectangle";
            this.rectangleBtn.UseVisualStyleBackColor = true;
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // bucketBtn
            // 
            this.bucketBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bucketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucketBtn.Location = new System.Drawing.Point(813, 3);
            this.bucketBtn.Name = "bucketBtn";
            this.bucketBtn.Size = new System.Drawing.Size(94, 33);
            this.bucketBtn.TabIndex = 8;
            this.bucketBtn.Text = "Bucket";
            this.bucketBtn.UseVisualStyleBackColor = true;
            this.bucketBtn.Click += new System.EventHandler(this.bucketBtn_Click);
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourLabel.Location = new System.Drawing.Point(3, 0);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(54, 39);
            this.colourLabel.TabIndex = 9;
            this.colourLabel.Text = "Color:";
            this.colourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thickness:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.topToolbarPanel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.bottomInfoPanel, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.859756F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.14024F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(918, 687);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(918, 711);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PaintShop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.convolutionPanel.ResumeLayout(false);
            this.convolutionPanel.PerformLayout();
            this.convolutionMatrixPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.convolution0x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution0x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution0x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution1x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution1x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution1x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution2x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution2x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolution2x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolutionNormalize)).EndInit();
            this.ditherPanel.ResumeLayout(false);
            this.ditherPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.dither4x4Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_0x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_1x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_2x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither4x4_3x2)).EndInit();
            this.dither2x2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_0x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_0x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_1x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dither2x2_1x1)).EndInit();
            this.quantizePanel.ResumeLayout(false);
            this.quantizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantizeTrackBar)).EndInit();
            this.greyscalePanel.ResumeLayout(false);
            this.greyscalePanel.PerformLayout();
            this.brightnessPanel.ResumeLayout(false);
            this.brightnessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.contrastPanel.ResumeLayout(false);
            this.contrastPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackbar)).EndInit();
            this.invertPanel.ResumeLayout(false);
            this.invertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invertTrackBar)).EndInit();
            this.noisePanel.ResumeLayout(false);
            this.noisePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTrackBar)).EndInit();
            this.procgenPanel.ResumeLayout(false);
            this.procgenPanel.PerformLayout();
            this.bottomInfoPanel.ResumeLayout(false);
            this.bottomInfoPanel.PerformLayout();
            this.topToolbarPanel.ResumeLayout(false);
            this.topToolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel brightnessPanel;
        private System.Windows.Forms.Button brightnessSave;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label brightnessTrackBarLabel;
        private System.Windows.Forms.TableLayoutPanel bottomInfoPanel;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.TableLayoutPanel topToolbarPanel;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Button bucketBtn;
        private System.Windows.Forms.TableLayoutPanel invertPanel;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiseToolStripMenuItem;
        private System.Windows.Forms.Button invertBtn;
        private System.Windows.Forms.TrackBar invertTrackBar;
        private System.Windows.Forms.Label invertLabel;
        private System.Windows.Forms.Label invertTrackBarLabel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.TableLayoutPanel noisePanel;
        private System.Windows.Forms.Label noiseLabel;
        private System.Windows.Forms.TrackBar noiseTrackBar;
        private System.Windows.Forms.TableLayoutPanel contrastPanel;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.TrackBar contrastTrackbar;
        private System.Windows.Forms.Label contrastTrackBarLabel;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.Button contrastSave;
        private System.Windows.Forms.Label noiseTrackbarLabel;
        private System.Windows.Forms.Button noiseSave;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel greyscalePanel;
        private System.Windows.Forms.Label greyscaleLabel;
        private System.Windows.Forms.Button greyscaleBtn;
        private System.Windows.Forms.Button greyscaleSave;
        private System.Windows.Forms.ToolStripMenuItem quantizeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel quantizePanel;
        private System.Windows.Forms.Label quantizeLabel;
        private System.Windows.Forms.TrackBar quantizeTrackBar;
        private System.Windows.Forms.Label quantizeTrackBarLabel;
        private System.Windows.Forms.Button quantizeSave;
        private System.Windows.Forms.ToolStripMenuItem ditherToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel ditherPanel;
        private System.Windows.Forms.Label ditherLabel;
        private System.Windows.Forms.Button ditherBtn;
        private System.Windows.Forms.Button ditherSave;
        private System.Windows.Forms.Button ditherBtn2x2;
        private System.Windows.Forms.Button ditherBtn4x4;
        private System.Windows.Forms.TableLayoutPanel dither2x2Panel;
        private System.Windows.Forms.NumericUpDown dither2x2_0x0;
        private System.Windows.Forms.NumericUpDown dither2x2_0x1;
        private System.Windows.Forms.NumericUpDown dither2x2_1x0;
        private System.Windows.Forms.NumericUpDown dither2x2_1x1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel dither4x4Panel;
        private System.Windows.Forms.NumericUpDown dither4x4_0x0;
        private System.Windows.Forms.NumericUpDown dither4x4_0x1;
        private System.Windows.Forms.NumericUpDown dither4x4_1x0;
        private System.Windows.Forms.NumericUpDown dither4x4_2x0;
        private System.Windows.Forms.NumericUpDown dither4x4_1x1;
        private System.Windows.Forms.NumericUpDown dither4x4_3x0;
        private System.Windows.Forms.NumericUpDown dither4x4_2x1;
        private System.Windows.Forms.NumericUpDown dither4x4_3x1;
        private System.Windows.Forms.NumericUpDown dither4x4_2x2;
        private System.Windows.Forms.NumericUpDown dither4x4_1x2;
        private System.Windows.Forms.NumericUpDown dither4x4_0x2;
        private System.Windows.Forms.NumericUpDown dither4x4_0x3;
        private System.Windows.Forms.NumericUpDown dither4x4_1x3;
        private System.Windows.Forms.NumericUpDown dither4x4_2x3;
        private System.Windows.Forms.NumericUpDown dither4x4_3x3;
        private System.Windows.Forms.NumericUpDown dither4x4_3x2;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proceduralGenToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel convolutionPanel;
        private System.Windows.Forms.Label convolutionLabel;
        private System.Windows.Forms.Button convolutionBtn;
        private System.Windows.Forms.Button convolutionSave;
        private System.Windows.Forms.TableLayoutPanel convolutionMatrixPanel;
        private System.Windows.Forms.NumericUpDown convolution0x0;
        private System.Windows.Forms.NumericUpDown convolution0x1;
        private System.Windows.Forms.NumericUpDown convolution0x2;
        private System.Windows.Forms.NumericUpDown convolution1x2;
        private System.Windows.Forms.NumericUpDown convolution1x1;
        private System.Windows.Forms.NumericUpDown convolution1x0;
        private System.Windows.Forms.NumericUpDown convolution2x0;
        private System.Windows.Forms.NumericUpDown convolution2x1;
        private System.Windows.Forms.NumericUpDown convolution2x2;
        private System.Windows.Forms.NumericUpDown convolutionNormalize;
        private System.Windows.Forms.TableLayoutPanel procgenPanel;
        private System.Windows.Forms.Label procgenLabel;
        private System.Windows.Forms.Button procgenLandBtn;
        private System.Windows.Forms.Button procgenSky;
        private System.Windows.Forms.Label convolutionLabel2;
        private System.Windows.Forms.Label convolutionLabel3;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Label label1;
    }
}

