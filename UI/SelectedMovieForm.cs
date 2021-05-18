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
    public partial class SelectedMovieForm : Form
    {

        public FestivalHandler festivalHandler = new FestivalHandler();
        private Movie movie;
        private Theater theater;

        public SelectedMovieForm(int movieNumber)
        {
            InitializeComponent();
            movie = festivalHandler.GetMovie(movieNumber);
            pictureBoxSelectedMovie.Image = Image.FromFile(movie.PicturePath);
            textBoxMovieTitle.Text = movie.Info;
        }
        private void comboBoxSelectTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectTime.Text == "20:00 - 22:00" && checkBoxNo.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 20:00 No WheelChair
                theater = festivalHandler.GetTheaters(new DateTime(2021, 06, 22, 20, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "20:00 - 22:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 20:00 Yes WheelChair
                theater = festivalHandler.GetTheatersWheelChair(new DateTime(2021, 06, 22, 20, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "22:00 - 00:00" && checkBoxNo.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 22:00 No WheelChair
                theater = festivalHandler.GetTheaters(new DateTime(2021, 06, 22, 22, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "22:00 - 00:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 22:00 Yes WheelChair
                theater = festivalHandler.GetTheatersWheelChair(new DateTime(2021, 06, 22, 22, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "00:00 - 02:00" && checkBoxNo.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 00:00 No WheelChair
                theater = festivalHandler.GetTheaters(new DateTime(2021, 06, 23, 00, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "00:00 - 02:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 00:00 Yes WheelChair
                theater = festivalHandler.GetTheatersWheelChair(new DateTime(2021, 06, 23, 00, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "02:00 - 04:00" && checkBoxNo.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 02:00 No WheelChair
                theater = festivalHandler.GetTheaters(new DateTime(2021, 06, 23, 02, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "02:00 - 04:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                #endregion
                #region 02:00 Yes WheelChair
                theater = festivalHandler.GetTheatersWheelChair(new DateTime(2021, 06, 23, 02, 00, 00), movie);
                if (theater != null && theater.SeatsLeft > 0)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = true;
                    textBoxFirstName.Visible = true;
                    labelLastName.Visible = true;
                    textBoxLastName.Visible = true;
                    labelPhoneNumber.Visible = true;
                    textBoxPhoneNumber.Visible = true;

                    labelAmount.Text = theater.SeatsLeft.ToString();
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else if (theater != null)
                {
                    labelTicketsLeft.Visible = true;
                    labelAmount.Visible = true;
                    labelTheaterNumber.Visible = true;
                    labelTheaterTitle.Visible = true;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;

                    labelAmount.Text = "Sold Out";
                    labelTheaterNumber.Text = theater.RoomNumber.ToString();
                }
                else
                {
                    labelTicketsLeft.Visible = false;
                    labelAmount.Visible = false;
                    labelTheaterNumber.Visible = false;
                    labelTheaterTitle.Visible = false;
                    labelFirstName.Visible = false;
                    textBoxFirstName.Visible = false;
                    labelLastName.Visible = false;
                    textBoxLastName.Visible = false;
                    labelPhoneNumber.Visible = false;
                    textBoxPhoneNumber.Visible = false;
                }
                #endregion
            }
        }
        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYes.Checked == true)
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxNo.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
            }
            else if (checkBoxNo.Checked == true)
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxYes.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
            }
        }
        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked == true)
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxYes.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
            }
            else if (checkBoxYes.Checked == true)
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxNo.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
            }
        }
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            bool valid = festivalHandler.FirstNameValid(textBoxFirstName.Text);
            if (valid == true)
            {
                pictureBoxFirstName.Image = Image.FromFile("CheckmarkIcon.png");
                pictureBoxFirstName.Visible = true;
                if (festivalHandler.LastNameValid(textBoxLastName.Text) == true)
                {
                    if (festivalHandler.PhoneNumberValid(textBoxPhoneNumber.Text) == true)
                    {
                        labelTickets.Visible = true;
                        comboBoxTickets.Visible = true;

                        //List<int> hej = new List<int>();
                        //foreach (var item in hej)
                        //{
                        //}

                    }
                }
            }
            else if (valid == false)
            {
                pictureBoxFirstName.Image = Image.FromFile("CrossmarkIcon.png");
                pictureBoxFirstName.Visible = true;
                comboBoxTickets.Visible = false;
            }
            if (textBoxFirstName.Text == "")
            {
                pictureBoxFirstName.Visible = false;
                comboBoxTickets.Visible = false;
            }
        }
        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            bool valid = festivalHandler.LastNameValid(textBoxLastName.Text);
            if (valid == true)
            {
                pictureBoxLastName.Image = Image.FromFile("CheckmarkIcon.png");
                pictureBoxLastName.Visible = true;
                if (festivalHandler.FirstNameValid(textBoxFirstName.Text) == true)
                {
                    if (festivalHandler.PhoneNumberValid(textBoxPhoneNumber.Text) == true)
                    {
                        labelTickets.Visible = true;
                        comboBoxTickets.Visible = true;
                    }
                }
            }
            else if (valid == false)
            {
                pictureBoxLastName.Image = Image.FromFile("CrossmarkIcon.png");
                pictureBoxLastName.Visible = true;
                comboBoxTickets.Visible = false;
            }
            if (textBoxLastName.Text == "")
            {
                pictureBoxLastName.Visible = false;
                comboBoxTickets.Visible = false;
            }
        }
        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            bool valid = festivalHandler.PhoneNumberValid(textBoxPhoneNumber.Text);
            if (valid == true)
            {
                pictureBoxPhoneNumber.Image = Image.FromFile("CheckmarkIcon.png");
                pictureBoxPhoneNumber.Visible = true;
                if (festivalHandler.FirstNameValid(textBoxFirstName.Text) == true)
                {
                    if (festivalHandler.LastNameValid(textBoxLastName.Text) == true)
                    {
                        labelTickets.Visible = true;
                        comboBoxTickets.Visible = true;
                    }
                }
            }
            else if (valid == false)
            {
                pictureBoxPhoneNumber.Image = Image.FromFile("CrossmarkIcon.png");
                pictureBoxPhoneNumber.Visible = true;
                comboBoxTickets.Visible = false;
            }
            if (textBoxPhoneNumber.Text == "")
            {
                pictureBoxPhoneNumber.Visible = false;
                comboBoxTickets.Visible = false;
            }
        }
        private void comboBoxSelectTime_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxSelectTime.BackColor = Color.Gray;
        }
        private void comboBoxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int amountOfTickets = int.Parse(comboBoxTickets.Text);
            if (amountOfTickets > theater.SeatsLeft)
            {
                pictureBoxTickets.Image = Image.FromFile("CrossmarkIcon.png");
                pictureBoxTickets.Visible = true;
                buttonBook.Enabled = false;
            }
            else
            {
                pictureBoxTickets.Image = Image.FromFile("CheckmarkIcon.png");
                pictureBoxTickets.Visible = true;
                comboBoxTickets.BackColor = Color.Gray;
                buttonBook.Enabled = true;
            }
        }
        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            textBoxFirstName.BackColor = Color.Gray;
        }
        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            textBoxLastName.BackColor = Color.Gray;
        }
        private void textBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            textBoxPhoneNumber.BackColor = Color.Gray;
        }
        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            textBoxFirstName.BackColor = Color.White;
        }
        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            textBoxLastName.BackColor = Color.White;
        }
        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            textBoxPhoneNumber.BackColor = Color.White;
        }
    }
}
