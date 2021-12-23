using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class frmVehicles : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private Vehicle myVehicle;

        public frmVehicles()
        {
            InitializeComponent();
        }

        private void rbtnCar_CheckedChanged(object sender, EventArgs e)
        {
            grbCar.Enabled = rbtnCar.Checked;
            grbBike.Enabled = !rbtnCar.Checked;
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle newVehicle;
                if (rbtnCar.Checked)
                {
                    newVehicle = new Car(txtName.Text,
                        txtBrand.Text,
                        double.Parse(txtPrice.Text),
                        int.Parse(txtWarranty.Text),
                        txtStore.Text,
                        (int)nrudPassenger.Value,
                        cboFuel.Text);
                }
                else
                {
                    newVehicle = new Bicycle(txtName.Text,
                        txtBrand.Text,
                        double.Parse(txtPrice.Text),
                        int.Parse(txtWarranty.Text),
                        txtStore.Text,
                        (int)nrudTireSize.Value,
                        cboTerrain.Text);
                }
                vehicles.Add(newVehicle);

                ClearControls();

                MessageBox.Show($"Total Number of Vehicles: {vehicles.Count}");

                txtName.Focus();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControls();
                myVehicle = null;

                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Name.ToLower() == txtSearch.Text.ToLower())
                        myVehicle = vehicle;
                }

                txtName.Text = myVehicle.Name;
                txtBrand.Text = myVehicle.Brand;
                txtPrice.Text = myVehicle.Price.ToString();
                txtWarranty.Text = myVehicle.Warranty.ToString();
                txtStore.Text = myVehicle.Store;

                if (myVehicle is Car)
                {
                    nrudPassenger.Value = (myVehicle as Car).NumberOfPassengers;
                    cboFuel.Text = (myVehicle as Car).Fuel;

                    rbtnCar.Checked = true;
                    rbtnBicycle.Checked = false;
                }
                else
                if (myVehicle is Bicycle)
                {
                    nrudTireSize.Value = (myVehicle as Bicycle).TireSize;
                    cboTerrain.Text = (myVehicle as Bicycle).Terrain;

                    rbtnCar.Checked = false;
                    rbtnBicycle.Checked = true;
                }

                btnCalculateInterest.Enabled = true;
                btnMakeSale.Enabled = true;
            }
            catch (Exception ex)
            {
                ClearControls();

                MessageBox.Show("Vehicle not found!");
            }
        }

        //reusable method to clear all controls at once
        private void ClearControls()
        {
            txtName.Text = "";
            txtBrand.Text = "";
            txtPrice.Text = "0.00";
            txtWarranty.Text = "1";
            txtStore.Text = "";
            nrudPassenger.Value = 0;
            cboFuel.Text = "";
            nrudTireSize.Value = 0;
            cboTerrain.Text = "";

            btnCalculateInterest.Enabled = false;
            btnMakeSale.Enabled = false;

            rbtnCar.Checked = true;
        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            //for test purposes, populating the list with 2 vehicles so that 
            //I don't have to recreate vehicles every time I run the application
            vehicles.Add(new Car("Corolla",
                "Toyota",
                20000,
                5,
                "Oshawa Toyota",
                5,
                "Gas"
                ));

            vehicles.Add(new Bicycle("BMX",
                "Colony",
                600,
                3,
                "SportCheck",
                20,
                "Unpaved"
                ));
        }

        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            if (myVehicle != null)
                MessageBox.Show(myVehicle.MakeSale());
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            if (myVehicle != null)
                MessageBox.Show(myVehicle.CalculateInterest().ToString("C"));
        }
    }
}
