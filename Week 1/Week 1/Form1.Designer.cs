namespace Week_1
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
            this.rbFirstInFirstOut = new System.Windows.Forms.RadioButton();
            this.rbShortestSeekTime = new System.Windows.Forms.RadioButton();
            this.rbSCANDisc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFirstInFirstOut
            // 
            this.rbFirstInFirstOut.AutoSize = true;
            this.rbFirstInFirstOut.Location = new System.Drawing.Point(9, 37);
            this.rbFirstInFirstOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFirstInFirstOut.Name = "rbFirstInFirstOut";
            this.rbFirstInFirstOut.Size = new System.Drawing.Size(191, 24);
            this.rbFirstInFirstOut.TabIndex = 0;
            this.rbFirstInFirstOut.TabStop = true;
            this.rbFirstInFirstOut.Text = "First Come First Serve";
            this.rbFirstInFirstOut.UseVisualStyleBackColor = true;
            // 
            // rbShortestSeekTime
            // 
            this.rbShortestSeekTime.AutoSize = true;
            this.rbShortestSeekTime.Location = new System.Drawing.Point(9, 72);
            this.rbShortestSeekTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbShortestSeekTime.Name = "rbShortestSeekTime";
            this.rbShortestSeekTime.Size = new System.Drawing.Size(209, 24);
            this.rbShortestSeekTime.TabIndex = 1;
            this.rbShortestSeekTime.TabStop = true;
            this.rbShortestSeekTime.Text = "Shortest Seek Time First";
            this.rbShortestSeekTime.UseVisualStyleBackColor = true;
            // 
            // rbSCANDisc
            // 
            this.rbSCANDisc.AutoSize = true;
            this.rbSCANDisc.Location = new System.Drawing.Point(9, 106);
            this.rbSCANDisc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSCANDisc.Name = "rbSCANDisc";
            this.rbSCANDisc.Size = new System.Drawing.Size(180, 24);
            this.rbSCANDisc.TabIndex = 2;
            this.rbSCANDisc.TabStop = true;
            this.rbSCANDisc.Text = "SCAN disc (elevator)";
            this.rbSCANDisc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFirstInFirstOut);
            this.groupBox1.Controls.Add(this.rbSCANDisc);
            this.groupBox1.Controls.Add(this.rbShortestSeekTime);
            this.groupBox1.Location = new System.Drawing.Point(267, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(225, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "strategy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 26);
            this.textBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(138, 74);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(108, 284);
            this.listBox1.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 11);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(69, 347);
            this.trackBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 411);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFirstInFirstOut;
        private System.Windows.Forms.RadioButton rbShortestSeekTime;
        private System.Windows.Forms.RadioButton rbSCANDisc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

