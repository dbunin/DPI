namespace WindowsFormsApplication1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCreateSimpleCar = new System.Windows.Forms.Button();
            this.btnCreateCarWithWTires = new System.Windows.Forms.Button();
            this.btnCreateCarWithConditioner = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(61, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 284);
            this.listBox1.TabIndex = 0;
            // 
            // btnCreateSimpleCar
            // 
            this.btnCreateSimpleCar.Location = new System.Drawing.Point(61, 384);
            this.btnCreateSimpleCar.Name = "btnCreateSimpleCar";
            this.btnCreateSimpleCar.Size = new System.Drawing.Size(96, 100);
            this.btnCreateSimpleCar.TabIndex = 1;
            this.btnCreateSimpleCar.Text = "Create Simple car";
            this.btnCreateSimpleCar.UseVisualStyleBackColor = true;
            this.btnCreateSimpleCar.Click += new System.EventHandler(this.btnCreateSimpleCar_Click);
            // 
            // btnCreateCarWithWTires
            // 
            this.btnCreateCarWithWTires.Location = new System.Drawing.Point(163, 384);
            this.btnCreateCarWithWTires.Name = "btnCreateCarWithWTires";
            this.btnCreateCarWithWTires.Size = new System.Drawing.Size(96, 100);
            this.btnCreateCarWithWTires.TabIndex = 2;
            this.btnCreateCarWithWTires.Text = "Create car with winter tires";
            this.btnCreateCarWithWTires.UseVisualStyleBackColor = true;
            this.btnCreateCarWithWTires.Click += new System.EventHandler(this.btnCreateCarWithWTires_Click);
            // 
            // btnCreateCarWithConditioner
            // 
            this.btnCreateCarWithConditioner.Location = new System.Drawing.Point(265, 384);
            this.btnCreateCarWithConditioner.Name = "btnCreateCarWithConditioner";
            this.btnCreateCarWithConditioner.Size = new System.Drawing.Size(96, 100);
            this.btnCreateCarWithConditioner.TabIndex = 3;
            this.btnCreateCarWithConditioner.Text = "CreateCarWithConditionaer";
            this.btnCreateCarWithConditioner.UseVisualStyleBackColor = true;
            this.btnCreateCarWithConditioner.Click += new System.EventHandler(this.btnCreateCarWithConditioner_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 26);
            this.textBox1.TabIndex = 4;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(532, 384);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 100);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 567);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCreateCarWithConditioner);
            this.Controls.Add(this.btnCreateCarWithWTires);
            this.Controls.Add(this.btnCreateSimpleCar);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCreateSimpleCar;
        private System.Windows.Forms.Button btnCreateCarWithWTires;
        private System.Windows.Forms.Button btnCreateCarWithConditioner;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowAll;
    }
}

