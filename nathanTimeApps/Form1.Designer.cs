namespace nathanTimeApps
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
            this.label6 = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSecond = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.radioButtonAddTimeWithSeconds = new System.Windows.Forms.RadioButton();
            this.numericUpDownSecond = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.radioButtonSetCurrentTime = new System.Windows.Forms.RadioButton();
            this.labelTotalSecond = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = ":";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.Location = new System.Drawing.Point(322, 19);
            this.labelMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(55, 29);
            this.labelMinute.TabIndex = 33;
            this.labelMinute.Text = "MM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = ":";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(242, 19);
            this.labelHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(49, 29);
            this.labelHour.TabIndex = 31;
            this.labelHour.Text = "HH";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(373, 405);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 28);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.Location = new System.Drawing.Point(411, 19);
            this.labelSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(47, 29);
            this.labelSecond.TabIndex = 35;
            this.labelSecond.Text = "SS";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(257, 405);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(100, 28);
            this.buttonClearAll.TabIndex = 29;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSecond);
            this.groupBox1.Controls.Add(this.buttonGo);
            this.groupBox1.Controls.Add(this.radioButtonAddTimeWithSeconds);
            this.groupBox1.Controls.Add(this.numericUpDownSecond);
            this.groupBox1.Controls.Add(this.numericUpDownMinute);
            this.groupBox1.Controls.Add(this.numericUpDownHour);
            this.groupBox1.Controls.Add(this.radioButtonSetCurrentTime);
            this.groupBox1.Location = new System.Drawing.Point(27, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(445, 252);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Operation";
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(72, 151);
            this.textBoxSecond.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(88, 22);
            this.textBoxSecond.TabIndex = 7;
            this.textBoxSecond.Text = "0";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(316, 211);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(100, 28);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // radioButtonAddTimeWithSeconds
            // 
            this.radioButtonAddTimeWithSeconds.AutoSize = true;
            this.radioButtonAddTimeWithSeconds.Location = new System.Drawing.Point(44, 123);
            this.radioButtonAddTimeWithSeconds.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAddTimeWithSeconds.Name = "radioButtonAddTimeWithSeconds";
            this.radioButtonAddTimeWithSeconds.Size = new System.Drawing.Size(235, 20);
            this.radioButtonAddTimeWithSeconds.TabIndex = 4;
            this.radioButtonAddTimeWithSeconds.TabStop = true;
            this.radioButtonAddTimeWithSeconds.Text = "Add the Current Time with Seconds";
            this.radioButtonAddTimeWithSeconds.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSecond
            // 
            this.numericUpDownSecond.Location = new System.Drawing.Point(252, 70);
            this.numericUpDownSecond.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSecond.Name = "numericUpDownSecond";
            this.numericUpDownSecond.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownSecond.TabIndex = 3;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(160, 70);
            this.numericUpDownMinute.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownMinute.TabIndex = 2;
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(69, 70);
            this.numericUpDownHour.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownHour.TabIndex = 1;
            // 
            // radioButtonSetCurrentTime
            // 
            this.radioButtonSetCurrentTime.AutoSize = true;
            this.radioButtonSetCurrentTime.Location = new System.Drawing.Point(43, 42);
            this.radioButtonSetCurrentTime.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSetCurrentTime.Name = "radioButtonSetCurrentTime";
            this.radioButtonSetCurrentTime.Size = new System.Drawing.Size(148, 20);
            this.radioButtonSetCurrentTime.TabIndex = 0;
            this.radioButtonSetCurrentTime.TabStop = true;
            this.radioButtonSetCurrentTime.Text = "Set the Current Time";
            this.radioButtonSetCurrentTime.UseVisualStyleBackColor = true;
            // 
            // labelTotalSecond
            // 
            this.labelTotalSecond.AutoSize = true;
            this.labelTotalSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSecond.Location = new System.Drawing.Point(242, 80);
            this.labelTotalSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalSecond.Name = "labelTotalSecond";
            this.labelTotalSecond.Size = new System.Drawing.Size(81, 29);
            this.labelTotalSecond.TabIndex = 27;
            this.labelTotalSecond.Text = "SSSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "In Seconds :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Current Time :";
            // 
            // MyTimer
            // 
            this.MyTimer.Enabled = true;
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTotalSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Playing with Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RadioButton radioButtonAddTimeWithSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.RadioButton radioButtonSetCurrentTime;
        private System.Windows.Forms.Label labelTotalSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MyTimer;
    }
}

