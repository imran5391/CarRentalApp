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
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities(); //initialize the constructor
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomerName = tbCutomerName.Text;
                var DateOut = dtDateRented.Value;
                var DateIn = dtDateReturned.Value;
                var TypeofCar = cbTypeofCar.Text;
                double cost = Convert.ToDouble(tbCost.Text);
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(TypeofCar))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                }

                if (DateOut > DateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal date selection.\n\r";
                }

                //if(isValid == true)
                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = CustomerName;
                    rentalRecord.DateRented = DateIn;
                    rentalRecord.DateReturned = DateOut;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbTypeofCar.SelectedValue;

                    carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    carRentalEntities.SaveChanges();


                    MessageBox.Show($"Customer Name: {CustomerName}\n\r" +
                    $"Date Rented: {DateOut}\n\r" +
                    $"Date Returned: {DateIn}\n\r" +
                    $"Cost: {cost}\n\r" +
                    $"Type Of Car: {TypeofCar}\n\r" +
                    $"Than you for Contacting");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select * from TypeofCars
            //var cars = carRentalEntities.TypeOfCars.ToList();
            var cars = carRentalEntities.TypeOfCars
                .Select(q => new
                {
                    Id = q.Id,
                    Name = q.Make + " " + q.Model
                }).ToList();
            cbTypeofCar.DisplayMember = "Name";
            cbTypeofCar.ValueMember = "id";
            cbTypeofCar.DataSource = cars;
        }
    }
}
