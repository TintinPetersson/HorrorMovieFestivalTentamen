using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SuccesfulBookingForm : Form
    {
        public SuccesfulBookingForm()
        {
            InitializeComponent();
        }
        private void SuccesfulBookingForm_Load(object sender, EventArgs e)
        {
            var nameOfMovie = SelectedMovieForm.movie.Name;
            var phoneNumber = SelectedMovieForm.customer.PhoneNumber;
            var tickets = SelectedMovieForm.customer.Tickets.Count;
            var handicapable = SelectedMovieForm.theater.GotWheelchairRamp ? "Yes" : "No";

            label1.Text = $"Movie:  {nameOfMovie}";
            label2.Text = $"Number: {phoneNumber}";
            label3.Text = $"Tickets:  {tickets}";
            label4.Text = $"Adapted for wheelchair: {handicapable}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MoviePickForm());
        }
        #region Child Form
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSuccesfulBooking.Controls.Add(childForm);
            panelSuccesfulBooking.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
    }
}
