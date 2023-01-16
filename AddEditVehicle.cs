using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditVehicle()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            isEditMode = false;
            _db = new CarRentalEntities();
    }
        public AddEditVehicle(TypeOfCar carToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            isEditMode = true;
            _db = new CarRentalEntities();
            PopulateFields(carToEdit);
        }

        private void PopulateFields(TypeOfCar car)
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicensePN.Text = car.LicensePlateNumber;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                //edit core here
                var id = int.Parse(lblId.Text);
                var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);
                car.Model = tbModel.Text;
                car.Make = tbMake.Text;
                car.VIN = tbVIN.Text;
                car.Year = int.Parse(tbYear.Text);
                car.LicensePlateNumber = tbLicensePN.Text;

                _db.SaveChanges();
                
            }
            else
            {
                //add code here
                var newCar = new TypeOfCar
                {
                    LicensePlateNumber = tbLicensePN.Text,
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    VIN = tbVIN.Text,
                    Year = int.Parse(tbYear.Text)
                };

                _db.TypeOfCars.Add(newCar);
                _db.SaveChanges();
                MessageBox.Show("Vehicle Added");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
