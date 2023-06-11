namespace TempHumi
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange3 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange1 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange2 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange3 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_show_info = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lb_temp = new System.Windows.Forms.Label();
            this.lb_humi = new System.Windows.Forms.Label();
            this.bt_connect = new System.Windows.Forms.Button();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge10 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.Gause_temp = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.linearGauge9 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.Gause_humi = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.max_temp = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.max_rh = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gause_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gause_humi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_temp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_rh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(338, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhiệt độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1114, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Độ ẩm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.bt_show_info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1543, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Checked = true;
            this.càiĐặtToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.càiĐặtToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.càiĐặtToolStripMenuItem.Text = "Save";
            this.càiĐặtToolStripMenuItem.Click += new System.EventHandler(this.càiĐặtToolStripMenuItem_Click);
            // 
            // bt_show_info
            // 
            this.bt_show_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show_info.Name = "bt_show_info";
            this.bt_show_info.Size = new System.Drawing.Size(93, 26);
            this.bt_show_info.Text = "Trợ giúp";
            this.bt_show_info.Click += new System.EventHandler(this.bt_show_info_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temp.Location = new System.Drawing.Point(412, 120);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(0, 53);
            this.lb_temp.TabIndex = 4;
            // 
            // lb_humi
            // 
            this.lb_humi.AutoSize = true;
            this.lb_humi.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_humi.Location = new System.Drawing.Point(1159, 120);
            this.lb_humi.Name = "lb_humi";
            this.lb_humi.Size = new System.Drawing.Size(0, 53);
            this.lb_humi.TabIndex = 5;
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(687, 12);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(344, 138);
            this.bt_connect.TabIndex = 7;
            this.bt_connect.Text = "Kết nối";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.BackColor = System.Drawing.SystemColors.Control;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge10});
            this.gaugeControl1.Location = new System.Drawing.Point(195, 169);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(592, 516);
            this.gaugeControl1.TabIndex = 8;
            // 
            // circularGauge10
            // 
            this.circularGauge10.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge10.Bounds = new System.Drawing.Rectangle(4, 4, 498, 453);
            this.circularGauge10.Name = "circularGauge10";
            this.circularGauge10.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.Gause_temp});
            this.circularGauge10.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            this.circularGauge10.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.AcceptOrder = -1000;
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg1";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.56F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style25;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(250F, 224F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AcceptOrder = 0;
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F);
            this.arcScaleComponent1.EndAngle = 45F;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -6F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_1;
            this.arcScaleComponent1.MajorTickmark.TextOffset = -22F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_2;
            this.arcScaleComponent1.Name = "scale1";
            this.arcScaleComponent1.RadiusX = 95F;
            this.arcScaleComponent1.RadiusY = 95.5F;
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968");
            arcScaleRange1.EndThickness = 2F;
            arcScaleRange1.EndValue = 33F;
            arcScaleRange1.Name = "Range0";
            arcScaleRange1.ShapeOffset = 11.5F;
            arcScaleRange1.StartThickness = 2F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFDA80");
            arcScaleRange2.EndThickness = 2F;
            arcScaleRange2.EndValue = 66F;
            arcScaleRange2.Name = "Range1";
            arcScaleRange2.ShapeOffset = 11.5F;
            arcScaleRange2.StartThickness = 2F;
            arcScaleRange2.StartValue = 33F;
            arcScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E99D9D");
            arcScaleRange3.EndThickness = 2F;
            arcScaleRange3.EndValue = 100F;
            arcScaleRange3.Name = "Range2";
            arcScaleRange3.ShapeOffset = 11.5F;
            arcScaleRange3.StartThickness = 2F;
            arcScaleRange3.StartValue = 66F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2,
            arcScaleRange3});
            this.arcScaleComponent1.StartAngle = -225F;
            this.arcScaleComponent1.Value = 50F;
            // 
            // Gause_temp
            // 
            this.Gause_temp.AcceptOrder = 50;
            this.Gause_temp.ArcScale = this.arcScaleComponent1;
            this.Gause_temp.EndOffset = 13F;
            this.Gause_temp.Name = "needle1";
            this.Gause_temp.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style25;
            this.Gause_temp.StartOffset = -16.5F;
            this.Gause_temp.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.AcceptOrder = 100;
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleSpindleCapComponent1.Name = "cap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style25;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(15F, 15F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.AutoLayout = false;
            this.gaugeControl2.BackColor = System.Drawing.SystemColors.Control;
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.linearGauge9});
            this.gaugeControl2.Location = new System.Drawing.Point(958, 169);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(636, 529);
            this.gaugeControl2.TabIndex = 9;
            // 
            // linearGauge9
            // 
            this.linearGauge9.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent1});
            this.linearGauge9.Bounds = new System.Drawing.Rectangle(39, 10, 402, 465);
            this.linearGauge9.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.Gause_humi});
            this.linearGauge9.Name = "linearGauge9";
            this.linearGauge9.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.linearGauge9.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent1});
            // 
            // linearScaleBackgroundLayerComponent1
            // 
            this.linearScaleBackgroundLayerComponent1.AcceptOrder = -1000;
            this.linearScaleBackgroundLayerComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleBackgroundLayerComponent1.Name = "bg1";
            this.linearScaleBackgroundLayerComponent1.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // linearScaleComponent1
            // 
            this.linearScaleComponent1.AcceptOrder = 0;
            this.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent1.MajorTickCount = 6;
            this.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent1.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent1.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent1.MaxValue = 100F;
            this.linearScaleComponent1.MinorTickCount = 4;
            this.linearScaleComponent1.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent1.Name = "scale1";
            linearScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7AC463");
            linearScaleRange1.EndThickness = 3F;
            linearScaleRange1.EndValue = 33F;
            linearScaleRange1.Name = "Range0";
            linearScaleRange1.ShapeOffset = -12F;
            linearScaleRange1.StartThickness = 3F;
            linearScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1D183");
            linearScaleRange2.EndThickness = 3F;
            linearScaleRange2.EndValue = 66F;
            linearScaleRange2.Name = "Range1";
            linearScaleRange2.ShapeOffset = -12F;
            linearScaleRange2.StartThickness = 3F;
            linearScaleRange2.StartValue = 33F;
            linearScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1877E");
            linearScaleRange3.EndThickness = 3F;
            linearScaleRange3.EndValue = 100F;
            linearScaleRange3.Name = "Range2";
            linearScaleRange3.ShapeOffset = -12F;
            linearScaleRange3.StartThickness = 3F;
            linearScaleRange3.StartValue = 66F;
            this.linearScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange1,
            linearScaleRange2,
            linearScaleRange3});
            this.linearScaleComponent1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent1.Value = 50F;
            // 
            // Gause_humi
            // 
            this.Gause_humi.AcceptOrder = 50;
            this.Gause_humi.LinearScale = this.linearScaleComponent1;
            this.Gause_humi.Name = "level1";
            this.Gause_humi.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.Gause_humi.ZOrder = -50;
            // 
            // max_temp
            // 
            this.max_temp.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_temp.Location = new System.Drawing.Point(196, 52);
            this.max_temp.Name = "max_temp";
            this.max_temp.Size = new System.Drawing.Size(110, 62);
            this.max_temp.TabIndex = 10;
            this.max_temp.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.max_temp);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(295, 704);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 120);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngưỡng nhiệt độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 53);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.max_rh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1046, 704);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 132);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngưỡng độ ẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(39, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 53);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max";
            // 
            // max_rh
            // 
            this.max_rh.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_rh.Location = new System.Drawing.Point(201, 51);
            this.max_rh.Name = "max_rh";
            this.max_rh.Size = new System.Drawing.Size(86, 62);
            this.max_rh.TabIndex = 10;
            this.max_rh.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(629, 968);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 22);
            this.textBox1.TabIndex = 16;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 971);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gaugeControl2);
            this.Controls.Add(this.gaugeControl1);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.lb_humi);
            this.Controls.Add(this.lb_temp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ĐỒ ÁN: Đo nhiệt độ và độ ẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gause_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gause_humi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_temp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_rh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bt_show_info;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label lb_humi;
        private System.Windows.Forms.Button bt_connect;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge10;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent Gause_temp;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge9;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent Gause_humi;
        private System.Windows.Forms.NumericUpDown max_temp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown max_rh;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}

