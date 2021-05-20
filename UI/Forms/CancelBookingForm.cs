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
using UI.Forms;

namespace UI
{
    public partial class CancelBookingForm : Form
    {
        FestivalHandler festivalHandler = new FestivalHandler();
        public static Customer customer;

        public CancelBookingForm()
        {
            InitializeComponent();
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        private void textBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            textBoxPhoneNumber.BackColor = Color.Gray;
        }
        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            textBoxPhoneNumber.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchHittingEnterOrButtonClick();
            }
        }
        private void SearchHittingEnterOrButtonClick()
        {
            if (festivalHandler.CheckIfCustomerExists(textBoxPhoneNumber.Text))
            {

                customer = festivalHandler.GetExistingCustomer(textBoxPhoneNumber.Text);

                OpenChildForm(new CancelBookingChildForm());
            }
            else
            {
                textBoxPhoneNumber.Text = "";
                labelCustomerDoesNotExist.Visible = true;
                labelCustomerDoesNotExist.Text = "No booking for that phone number avaliable!\nPlease try again...";
            }
        }
        private void textBoxPhoneNumber_TextChanged_1(object sender, EventArgs e)
        {
            labelCustomerDoesNotExist.Visible = false;
            bool valid = festivalHandler.PhoneNumberValid(textBoxPhoneNumber.Text);
            if (valid == true)
            {
                pictureBoxPhoneNumber.Image = Image.FromFile("CheckmarkIcon.png");
                pictureBoxPhoneNumber.Visible = true;
                buttonEnter.Visible = true;
            }
            else if (valid == false)
            {
                pictureBoxPhoneNumber.Image = Image.FromFile("CrossmarkIcon.png");
                pictureBoxPhoneNumber.Visible = true;
                buttonEnter.Visible = false;
            }
            if (textBoxPhoneNumber.Text == "")
            {
                pictureBoxPhoneNumber.Visible = false;
                buttonEnter.Visible = false;
            }
        }
        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            SearchHittingEnterOrButtonClick();
        }
    }
}
