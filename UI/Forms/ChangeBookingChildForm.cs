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

namespace UI
{
    public partial class ChangeBookingChildForm : Form
    {
        private Customer customer;
        private Movie movie;
        private Theater theater;
        FestivalHandler festivalHandler = new FestivalHandler();

        public ChangeBookingChildForm()
        {
            InitializeComponent();
        }
        private void ChangeBookingChildForm_Load(object sender, EventArgs e)
        {
            customer = ChangeBookingForm.customer;
            movie = festivalHandler.GetTickets(customer);
            theater = festivalHandler.GetSpecificTheater(customer);

            pictureBoxSelectedMovie.Image = Image.FromFile(movie.PicturePath);

            label1.Text = $"Name: {customer.FirstName} {customer.LastName}";
            label2.Text = $"You have: {customer.Tickets.Count} tickets";
            label3.Text = $"Phone Number: {customer.PhoneNumber}";
            label4.Text = $"Movie: {movie.Name}";
            label5.Text = $"Tickets left: {theater.SeatsLeft}\nPlus your : {customer.Tickets.Count} tickets";
            label6.Text = $"How many tickets, in total, do you want?";
        }
        private void comboBoxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int amountOfTickets = int.Parse(comboBoxTickets.Text);

            button1.Visible = false;

            if (amountOfTickets > theater.SeatsLeft + customer.Tickets.Count)
            {
                pictureBoxTickets.Image = Image.FromFile("CrossmarkIcon.png");
                pictureBoxTickets.Visible = true;
            }
            else if (amountOfTickets == customer.Tickets.Count)
            {
                pictureBoxTickets.Image = Image.FromFile("CrossmarkIcon.png");
                pictureBoxTickets.Visible = true;
            }
            else
            {
                button1.Visible = true;
                pictureBoxTickets.Visible = true;
                pictureBoxTickets.Image = Image.FromFile("CheckmarkIcon.png");
                comboBoxTickets.BackColor = Color.Gray;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ticketAmount = int.Parse(comboBoxTickets.Text);
            festivalHandler.ChangeCustomerTickets(theater, customer, ticketAmount);

            button1.Visible = false;
            pictureBoxTickets.Visible = false;
            comboBoxTickets.Visible = false;

            label4.Visible = false;
            label6.Visible = false;
            label5.Visible = false;

            label1.Text = "Succesful!";
            label2.Text = $"New ticket amount: {comboBoxTickets.Text}";
            pictureBox1.Visible = true;
        }
    }
}
