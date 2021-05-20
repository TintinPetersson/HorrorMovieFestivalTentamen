using Logic;
using Logic.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class CancelBookingChildForm : Form
    {
        FestivalHandler festivalHandler = new FestivalHandler();
        private Customer customer;
        private Movie movie;
        private Theater theater;
        public CancelBookingChildForm()
        {
            InitializeComponent();
        }
        private void CancelBookingChildForm_Load(object sender, EventArgs e)
        {
            customer = CancelBookingForm.customer;
            movie = festivalHandler.GetTickets(customer);
            theater = festivalHandler.GetSpecificTheater(customer);

            pictureBoxSelectedMovie.Image = Image.FromFile(movie.PicturePath);

            label1.Text = $"Name: {customer.FirstName} {customer.LastName}";
            label2.Text = $"You have: {customer.Tickets.Count} tickets";
            label3.Text = $"Phone Number: {customer.PhoneNumber}";
            label4.Text = $"Movie: {movie.Name}";
            label5.Text = $"Movie start time:\n{theater.StartTime}";
            label6.Text = $"Press delete if you want to cancel your tickets.";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonDelete.Visible = false;

            label4.Visible = false;
            label6.Visible = false;

            label1.Text = "Succesful!";
            label2.Text = $"Your tickets were removed";
            pictureBox1.Visible = true;

            festivalHandler.RemoveCustomer(CancelBookingForm.customer);
        }
    }
}
