namespace FinalProject
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
            this.GDPLEData = new System.Windows.Forms.DataGridView();
            this.regionPull = new System.Windows.Forms.ComboBox();
            this.variablePull = new System.Windows.Forms.ComboBox();
            this.yearSlider = new System.Windows.Forms.TrackBar();
            this.graph = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.RadioButton();
            this.radius = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.showNames = new System.Windows.Forms.CheckBox();
            this.showMissing = new System.Windows.Forms.CheckBox();
            this.finalProjectDataSet = new FinalProject.FinalProjectDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.GDPLEData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GDPLEData
            // 
            this.GDPLEData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDPLEData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.GDPLEData.Location = new System.Drawing.Point(81, 554);
            this.GDPLEData.Name = "GDPLEData";
            this.GDPLEData.Size = new System.Drawing.Size(247, 156);
            this.GDPLEData.TabIndex = 1;
            // 
            // regionPull
            // 
            this.regionPull.FormattingEnabled = true;
            this.regionPull.Location = new System.Drawing.Point(840, 564);
            this.regionPull.Name = "regionPull";
            this.regionPull.Size = new System.Drawing.Size(160, 21);
            this.regionPull.TabIndex = 2;
            this.regionPull.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // variablePull
            // 
            this.variablePull.FormattingEnabled = true;
            this.variablePull.Location = new System.Drawing.Point(840, 599);
            this.variablePull.Name = "variablePull";
            this.variablePull.Size = new System.Drawing.Size(160, 21);
            this.variablePull.TabIndex = 3;
            this.variablePull.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // yearSlider
            // 
            this.yearSlider.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yearSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearSlider.LargeChange = 1;
            this.yearSlider.Location = new System.Drawing.Point(116, 503);
            this.yearSlider.Maximum = 2011;
            this.yearSlider.Minimum = 1980;
            this.yearSlider.Name = "yearSlider";
            this.yearSlider.Size = new System.Drawing.Size(884, 45);
            this.yearSlider.TabIndex = 4;
            this.yearSlider.Value = 1980;
            this.yearSlider.ValueChanged += new System.EventHandler(this.yearSlider_ValueChanged);
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.SystemColors.Window;
            this.graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph.Cursor = System.Windows.Forms.Cursors.Default;
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(1000, 500);
            this.graph.TabIndex = 0;
            this.graph.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(71, 501);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(39, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "1980";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(71, 525);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(39, 23);
            this.stop.TabIndex = 12;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(0, 527);
            this.delay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(46, 20);
            this.delay.TabIndex = 14;
            this.delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delay.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Delay";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(665, 662);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(47, 17);
            this.area.TabIndex = 16;
            this.area.Text = "Area";
            this.area.UseVisualStyleBackColor = true;
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Checked = true;
            this.radius.Location = new System.Drawing.Point(601, 662);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(58, 17);
            this.radius.TabIndex = 17;
            this.radius.TabStop = true;
            this.radius.Text = "Radius";
            this.radius.UseVisualStyleBackColor = true;
            this.radius.CheckedChanged += new System.EventHandler(this.radius_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Scale by:";
            // 
            // showNames
            // 
            this.showNames.AutoSize = true;
            this.showNames.Location = new System.Drawing.Point(401, 599);
            this.showNames.Name = "showNames";
            this.showNames.Size = new System.Drawing.Size(128, 17);
            this.showNames.TabIndex = 19;
            this.showNames.Text = "Show Country Names";
            this.showNames.UseVisualStyleBackColor = true;
            this.showNames.CheckedChanged += new System.EventHandler(this.showNames_CheckedChanged);
            // 
            // showMissing
            // 
            this.showMissing.AutoSize = true;
            this.showMissing.Checked = true;
            this.showMissing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMissing.Location = new System.Drawing.Point(594, 599);
            this.showMissing.Name = "showMissing";
            this.showMissing.Size = new System.Drawing.Size(138, 17);
            this.showMissing.TabIndex = 20;
            this.showMissing.Text = "Show Missing Countries";
            this.showMissing.UseVisualStyleBackColor = true;
            this.showMissing.CheckedChanged += new System.EventHandler(this.showMissing_CheckedChanged);
            // 
            // finalProjectDataSet
            // 
            this.finalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.finalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 722);
            this.Controls.Add(this.showMissing);
            this.Controls.Add(this.showNames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.yearSlider);
            this.Controls.Add(this.variablePull);
            this.Controls.Add(this.regionPull);
            this.Controls.Add(this.GDPLEData);
            this.Controls.Add(this.graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GDPLEData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GDPLEData;
        private System.Windows.Forms.ComboBox regionPull;
        private System.Windows.Forms.ComboBox variablePull;
        private FinalProjectDataSet finalProjectDataSet;
        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.TrackBar yearSlider;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.NumericUpDown delay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton area;
        private System.Windows.Forms.RadioButton radius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showNames;
        private System.Windows.Forms.CheckBox showMissing;
    }
}

