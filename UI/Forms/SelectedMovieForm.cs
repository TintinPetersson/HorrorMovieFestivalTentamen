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
        public static Movie movie;
        public static Theater theater;
        public static Customer customer;

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
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "20:00 - 22:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "22:00 - 00:00" && checkBoxNo.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "22:00 - 00:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "00:00 - 02:00" && checkBoxNo.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "00:00 - 02:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "02:00 - 04:00" && checkBoxNo.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
            else if (comboBoxSelectTime.Text == "02:00 - 04:00" && checkBoxYes.Checked == true)
            {
                #region Starting Changes
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;

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
                    buttonBook.Visible = false;
                }
                #endregion
            }
        }
        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYes.Checked == true)
            {
                checkBoxYes.ForeColor = Color.FromArgb(192, 192, 0);
                checkBoxNo.ForeColor = Color.White;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxNo.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                buttonBook.Visible = false;
                labelErrorMessage.Visible = false;

            }
            else if (checkBoxNo.Checked == true)
            {
                checkBoxNo.ForeColor = Color.FromArgb(192, 192, 0);
                checkBoxYes.ForeColor = Color.White;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxYes.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                buttonBook.Visible = false;
                labelErrorMessage.Visible = false;
            }
        }
        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked == true)
            {
                checkBoxNo.ForeColor = Color.FromArgb(192, 192, 0);
                checkBoxYes.ForeColor = Color.White;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxYes.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                buttonBook.Visible = false;
                labelErrorMessage.Visible = false;
            }
            else if (checkBoxYes.Checked == true)
            {
                checkBoxYes.ForeColor = Color.FromArgb(192, 192, 0);
                checkBoxNo.ForeColor = Color.White;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxNo.Checked = false;
                labelSelectTime.Visible = true;
                comboBoxSelectTime.Visible = true;
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                buttonBook.Visible = false;
                labelErrorMessage.Visible = false;
            }
        }
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            buttonBook.Visible = false;
            labelTickets.Visible = false;
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
                        buttonBook.Visible = true;

                        //List<int> tickets = new List<int>();
                        //var amountOfTicketsInTheater = theater.SeatsLeft;
                        //int counter = 1;
                        //for (int i = 0; i < amountOfTicketsInTheater; i++)
                        //{
                        //    tickets[i] = counter;
                        //    counter++;
                        //}

                        //foreach (var item in tickets)
                        //{
                        //    comboBoxTickets.SelectedItem = item.ToString();
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
            buttonBook.Visible = false;
            labelTickets.Visible = false;
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
                        buttonBook.Visible = true;
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
            buttonBook.Visible = false;
            labelTickets.Visible = false;
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
                        buttonBook.Visible = true;
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
            comboBoxSelectTime.BackColor = Color.FromArgb(41, 44, 51);
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
                comboBoxTickets.BackColor = Color.FromArgb(41, 44, 51);
                buttonBook.Enabled = true;
            }
        }
        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            textBoxFirstName.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            textBoxLastName.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void textBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            textBoxPhoneNumber.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            textBoxFirstName.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            textBoxLastName.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            textBoxPhoneNumber.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void buttonBook_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            int ticketAmount = int.Parse(comboBoxTickets.Text);

            if (festivalHandler.CheckIfCustomerExists(phoneNumber) == false)
            {
                customer = festivalHandler.GetNewCustomer(firstName, lastName, phoneNumber, ticketAmount, theater);
                buttonBook.Enabled = false;
                OpenChildForm(new SuccesfulBookingForm());
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNumber.Text = "";
                checkBoxNo.Checked = false;
                labelSelectTime.Visible = false;
                comboBoxSelectTime.Visible = false;
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                pictureBoxPhoneNumber.Visible = false;
                pictureBoxTickets.Visible = false;
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
                buttonBook.Visible = false;
                labelWheelChair.Visible = false;
                checkBoxYes.Visible = false;
                checkBoxNo.Visible = false;
                labelEnterInfo.Visible = false;

                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "You have previously booked tickets!\nCancel the tickets\nor try again...";
                buttonTryAgain.Visible = true;
            }
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
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        private void comboBoxSelectTime_Enter(object sender, EventArgs e)
        {
            comboBoxSelectTime.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            labelWheelChair.Visible = true;
            checkBoxYes.Visible = true;
            checkBoxNo.Visible = true;
            labelEnterInfo.Visible = true;

            labelErrorMessage.Visible = false;
            buttonTryAgain.Visible = false;
        }
    }
}
