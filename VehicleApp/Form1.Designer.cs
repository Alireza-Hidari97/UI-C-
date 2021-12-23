namespace VehicleApp
{
    partial class frmVehicles
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
            this.grpVehicleInformation = new System.Windows.Forms.GroupBox();
            this.grbBike = new System.Windows.Forms.GroupBox();
            this.cboTerrain = new System.Windows.Forms.ComboBox();
            this.nrudTireSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnBicycle = new System.Windows.Forms.RadioButton();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.grbCar = new System.Windows.Forms.GroupBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.nrudPassenger = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.grpVehicleInformation.SuspendLayout();
            this.grbBike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVehicleInformation
            // 
            this.grpVehicleInformation.Controls.Add(this.grbBike);
            this.grpVehicleInformation.Controls.Add(this.groupBox4);
            this.grpVehicleInformation.Controls.Add(this.grbCar);
            this.grpVehicleInformation.Controls.Add(this.txtStore);
            this.grpVehicleInformation.Controls.Add(this.txtWarranty);
            this.grpVehicleInformation.Controls.Add(this.txtPrice);
            this.grpVehicleInformation.Controls.Add(this.txtBrand);
            this.grpVehicleInformation.Controls.Add(this.txtName);
            this.grpVehicleInformation.Controls.Add(this.label5);
            this.grpVehicleInformation.Controls.Add(this.label3);
            this.grpVehicleInformation.Controls.Add(this.label4);
            this.grpVehicleInformation.Controls.Add(this.label2);
            this.grpVehicleInformation.Controls.Add(this.label1);
            this.grpVehicleInformation.Location = new System.Drawing.Point(12, 65);
            this.grpVehicleInformation.Name = "grpVehicleInformation";
            this.grpVehicleInformation.Size = new System.Drawing.Size(776, 375);
            this.grpVehicleInformation.TabIndex = 0;
            this.grpVehicleInformation.TabStop = false;
            this.grpVehicleInformation.Text = "Vehicle Information";
            // 
            // grbBike
            // 
            this.grbBike.Controls.Add(this.cboTerrain);
            this.grbBike.Controls.Add(this.nrudTireSize);
            this.grbBike.Controls.Add(this.label9);
            this.grbBike.Controls.Add(this.label8);
            this.grbBike.Enabled = false;
            this.grbBike.Location = new System.Drawing.Point(306, 197);
            this.grbBike.Name = "grbBike";
            this.grbBike.Size = new System.Drawing.Size(200, 141);
            this.grbBike.TabIndex = 10;
            this.grbBike.TabStop = false;
            this.grbBike.Text = "For Bikes";
            // 
            // cboTerrain
            // 
            this.cboTerrain.FormattingEnabled = true;
            this.cboTerrain.Items.AddRange(new object[] {
            "Paved",
            "Unpaved"});
            this.cboTerrain.Location = new System.Drawing.Point(80, 89);
            this.cboTerrain.Name = "cboTerrain";
            this.cboTerrain.Size = new System.Drawing.Size(107, 24);
            this.cboTerrain.TabIndex = 4;
            // 
            // nrudTireSize
            // 
            this.nrudTireSize.Location = new System.Drawing.Point(101, 38);
            this.nrudTireSize.Name = "nrudTireSize";
            this.nrudTireSize.Size = new System.Drawing.Size(86, 22);
            this.nrudTireSize.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Terrain:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tire Size:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnBicycle);
            this.groupBox4.Controls.Add(this.rbtnCar);
            this.groupBox4.Location = new System.Drawing.Point(561, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 141);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of Vehicle";
            // 
            // rbtnBicycle
            // 
            this.rbtnBicycle.AutoSize = true;
            this.rbtnBicycle.Location = new System.Drawing.Point(48, 93);
            this.rbtnBicycle.Name = "rbtnBicycle";
            this.rbtnBicycle.Size = new System.Drawing.Size(73, 21);
            this.rbtnBicycle.TabIndex = 1;
            this.rbtnBicycle.Text = "Bicycle";
            this.rbtnBicycle.UseVisualStyleBackColor = true;
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Checked = true;
            this.rbtnCar.Location = new System.Drawing.Point(48, 44);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(51, 21);
            this.rbtnCar.TabIndex = 0;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "Car";
            this.rbtnCar.UseVisualStyleBackColor = true;
            this.rbtnCar.CheckedChanged += new System.EventHandler(this.rbtnCar_CheckedChanged);
            // 
            // grbCar
            // 
            this.grbCar.Controls.Add(this.cboFuel);
            this.grbCar.Controls.Add(this.nrudPassenger);
            this.grbCar.Controls.Add(this.label7);
            this.grbCar.Controls.Add(this.label6);
            this.grbCar.Location = new System.Drawing.Point(306, 36);
            this.grbCar.Name = "grbCar";
            this.grbCar.Size = new System.Drawing.Size(200, 141);
            this.grbCar.TabIndex = 11;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "For Cars";
            // 
            // cboFuel
            // 
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Gas",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.cboFuel.Location = new System.Drawing.Point(80, 89);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(106, 24);
            this.cboFuel.TabIndex = 3;
            // 
            // nrudPassenger
            // 
            this.nrudPassenger.Location = new System.Drawing.Point(101, 40);
            this.nrudPassenger.Name = "nrudPassenger";
            this.nrudPassenger.Size = new System.Drawing.Size(86, 22);
            this.nrudPassenger.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fuel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Passengers:";
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(137, 300);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(100, 22);
            this.txtStore.TabIndex = 9;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(137, 230);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(100, 22);
            this.txtWarranty.TabIndex = 8;
            this.txtWarranty.Text = "1";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 162);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0.00";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(137, 102);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Store:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Warranty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(656, 453);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(131, 41);
            this.btnCreateVehicle.TabIndex = 1;
            this.btnCreateVehicle.Text = "Create Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(714, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 36);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(511, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 22);
            this.txtSearch.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search By Vehicle Name:";
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Enabled = false;
            this.btnCalculateInterest.Location = new System.Drawing.Point(176, 453);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(132, 41);
            this.btnCalculateInterest.TabIndex = 21;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Enabled = false;
            this.btnMakeSale.Location = new System.Drawing.Point(13, 453);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(132, 41);
            this.btnMakeSale.TabIndex = 20;
            this.btnMakeSale.Text = "Make Sale";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.grpVehicleInformation);
            this.MaximizeBox = false;
            this.Name = "frmVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.frmVehicles_Load);
            this.grpVehicleInformation.ResumeLayout(false);
            this.grpVehicleInformation.PerformLayout();
            this.grbBike.ResumeLayout(false);
            this.grbBike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbCar.ResumeLayout(false);
            this.grbCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVehicleInformation;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbBike;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grbCar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTerrain;
        private System.Windows.Forms.NumericUpDown nrudTireSize;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.NumericUpDown nrudPassenger;
        private System.Windows.Forms.RadioButton rbtnBicycle;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.Button btnMakeSale;
    }
}

