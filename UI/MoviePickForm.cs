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
    public partial class MoviePickForm : Form
    {
        public MoviePickForm()
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
            panelChildFormPickMovie.Controls.Add(childForm);
            panelChildFormPickMovie.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        #region Poster Buttons
        private void buttonPoster1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(1));
            
        }
        private void buttonPoster2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(2));
        }
        private void buttonPoster3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(3));
        }
        private void buttonPoster4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(4));
        }
        private void buttonPoster5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(5));
        }
        private void buttonPoster6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(6));
        }
        private void buttonPoster7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(7));
        }
        private void buttonPoster8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(8));
        }
        private void buttonPoster9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(9));
        }
        private void buttonPoster10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedMovieForm(10));
        }
        #endregion
    }
}
