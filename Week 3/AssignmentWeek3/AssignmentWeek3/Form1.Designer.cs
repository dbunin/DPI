namespace AssignmentWeek3
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
            this.lb = new System.Windows.Forms.ListBox();
            this.btnCreateDealer = new System.Windows.Forms.Button();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.btnGetCarsFromDealer = new System.Windows.Forms.Button();
            this.btnGetAllCars = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.btnCreateDealerBMW = new System.Windows.Forms.Button();
            this.btnCreateSportCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 20;
            this.lb.Location = new System.Drawing.Point(39, 32);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(710, 404);
            this.lb.TabIndex = 0;
            // 
            // btnCreateDealer
            // 
            this.btnCreateDealer.Location = new System.Drawing.Point(12, 519);
            this.btnCreateDealer.Name = "btnCreateDealer";
            this.btnCreateDealer.Size = new System.Drawing.Size(143, 83);
            this.btnCreateDealer.TabIndex = 1;
            this.btnCreateDealer.Text = "Create dealer of Audi";
            this.btnCreateDealer.UseVisualStyleBackColor = true;
            this.btnCreateDealer.Click += new System.EventHandler(this.btnCreateDealer_Click);
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(274, 519);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(143, 83);
            this.btnCreateCar.TabIndex = 2;
            this.btnCreateCar.Text = "Create car Econom";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // btnGetCarsFromDealer
            // 
            this.btnGetCarsFromDealer.Location = new System.Drawing.Point(536, 519);
            this.btnGetCarsFromDealer.Name = "btnGetCarsFromDealer";
            this.btnGetCarsFromDealer.Size = new System.Drawing.Size(143, 83);
            this.btnGetCarsFromDealer.TabIndex = 3;
            this.btnGetCarsFromDealer.Text = "Get cars created by one dealer";
            this.btnGetCarsFromDealer.UseVisualStyleBackColor = true;
            this.btnGetCarsFromDealer.Click += new System.EventHandler(this.btnGetCarsFromDealer_Click);
            // 
            // btnGetAllCars
            // 
            this.btnGetAllCars.Location = new System.Drawing.Point(667, 519);
            this.btnGetAllCars.Name = "btnGetAllCars";
            this.btnGetAllCars.Size = new System.Drawing.Size(143, 83);
            this.btnGetAllCars.TabIndex = 4;
            this.btnGetAllCars.Text = "Get all cars";
            this.btnGetAllCars.UseVisualStyleBackColor = true;
            this.btnGetAllCars.Click += new System.EventHandler(this.btnGetAllCars_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(38, 464);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(711, 26);
            this.tb.TabIndex = 5;
            // 
            // btnCreateDealerBMW
            // 
            this.btnCreateDealerBMW.Location = new System.Drawing.Point(143, 519);
            this.btnCreateDealerBMW.Name = "btnCreateDealerBMW";
            this.btnCreateDealerBMW.Size = new System.Drawing.Size(143, 83);
            this.btnCreateDealerBMW.TabIndex = 6;
            this.btnCreateDealerBMW.Text = "Create dealer of BMW";
            this.btnCreateDealerBMW.UseVisualStyleBackColor = true;
            this.btnCreateDealerBMW.Click += new System.EventHandler(this.btnCreateDealerBMW_Click);
            // 
            // btnCreateSportCar
            // 
            this.btnCreateSportCar.Location = new System.Drawing.Point(405, 519);
            this.btnCreateSportCar.Name = "btnCreateSportCar";
            this.btnCreateSportCar.Size = new System.Drawing.Size(143, 83);
            this.btnCreateSportCar.TabIndex = 7;
            this.btnCreateSportCar.Text = "Create car Sport";
            this.btnCreateSportCar.UseVisualStyleBackColor = true;
            this.btnCreateSportCar.Click += new System.EventHandler(this.btnCreateSportCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 760);
            this.Controls.Add(this.btnCreateSportCar);
            this.Controls.Add(this.btnCreateDealerBMW);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btnGetAllCars);
            this.Controls.Add(this.btnGetCarsFromDealer);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.btnCreateDealer);
            this.Controls.Add(this.lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btnCreateDealer;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Button btnGetCarsFromDealer;
        private System.Windows.Forms.Button btnGetAllCars;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btnCreateDealerBMW;
        private System.Windows.Forms.Button btnCreateSportCar;
    }
}

