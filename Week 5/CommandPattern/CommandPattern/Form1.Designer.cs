namespace CommandPattern
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
            this.lbState = new System.Windows.Forms.ListBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnVolumeUo = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.rbRadio = new System.Windows.Forms.RadioButton();
            this.rbTV = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.btnShowStates = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbState
            // 
            this.lbState.FormattingEnabled = true;
            this.lbState.ItemHeight = 20;
            this.lbState.Location = new System.Drawing.Point(30, 37);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(394, 304);
            this.lbState.TabIndex = 0;
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(30, 364);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(94, 66);
            this.btnOn.TabIndex = 1;
            this.btnOn.Text = "Turn On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(130, 364);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(94, 66);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "Turn Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnVolumeUo
            // 
            this.btnVolumeUo.Location = new System.Drawing.Point(230, 364);
            this.btnVolumeUo.Name = "btnVolumeUo";
            this.btnVolumeUo.Size = new System.Drawing.Size(94, 66);
            this.btnVolumeUo.TabIndex = 3;
            this.btnVolumeUo.Text = "Volume Up";
            this.btnVolumeUo.UseVisualStyleBackColor = true;
            this.btnVolumeUo.Click += new System.EventHandler(this.btnVolumeUo_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Location = new System.Drawing.Point(330, 364);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(94, 66);
            this.btnVolumeDown.TabIndex = 4;
            this.btnVolumeDown.Text = "Volume Down";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.ItemHeight = 20;
            this.lbDevices.Location = new System.Drawing.Point(441, 37);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(171, 144);
            this.lbDevices.TabIndex = 5;
            // 
            // rbRadio
            // 
            this.rbRadio.AutoSize = true;
            this.rbRadio.Location = new System.Drawing.Point(447, 226);
            this.rbRadio.Name = "rbRadio";
            this.rbRadio.Size = new System.Drawing.Size(124, 24);
            this.rbRadio.TabIndex = 6;
            this.rbRadio.TabStop = true;
            this.rbRadio.Text = "CreateRadio";
            this.rbRadio.UseVisualStyleBackColor = true;
            // 
            // rbTV
            // 
            this.rbTV.AutoSize = true;
            this.rbTV.Location = new System.Drawing.Point(447, 284);
            this.rbTV.Name = "rbTV";
            this.rbTV.Size = new System.Drawing.Size(102, 24);
            this.rbTV.TabIndex = 7;
            this.rbTV.TabStop = true;
            this.rbTV.Text = "CreateTV";
            this.rbTV.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(530, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 66);
            this.button5.TabIndex = 8;
            this.button5.Text = "Create Device";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnShowStates
            // 
            this.btnShowStates.Location = new System.Drawing.Point(430, 364);
            this.btnShowStates.Name = "btnShowStates";
            this.btnShowStates.Size = new System.Drawing.Size(94, 66);
            this.btnShowStates.TabIndex = 9;
            this.btnShowStates.Text = "Show States";
            this.btnShowStates.UseVisualStyleBackColor = true;
            this.btnShowStates.Click += new System.EventHandler(this.btnShowStates_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(594, 66);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel last command";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 515);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShowStates);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.rbTV);
            this.Controls.Add(this.rbRadio);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnVolumeUo);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.lbState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbState;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnVolumeUo;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.RadioButton rbRadio;
        private System.Windows.Forms.RadioButton rbTV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnShowStates;
        private System.Windows.Forms.Button btnCancel;
    }
}

