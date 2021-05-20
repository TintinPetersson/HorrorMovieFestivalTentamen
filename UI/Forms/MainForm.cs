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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        #region Side Menu Visibility
        private void CustomizeDesign()
        {
            panelBookingSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelBookingSubMenu.Visible == true) { panelBookingSubMenu.Visible = false; }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion
        #region Menu Buttons
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MoviePickForm());
            panelLeft.Visible = true;
            panelLeft.Height = buttonMovies.Height;
            panelLeft.Top = buttonMovies.Top;
            HideSubMenu();
        }
        private void buttonBooking_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelBookingSubMenu);
            panelLeft.Visible = true;
            panelLeft.Height = buttonBooking.Height;
            panelLeft.Top = buttonBooking.Top;
        }
        #endregion
        #region Sub Menu
        private void buttonChange_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangeBookingForm());
            HideSubMenu();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CancelBookingForm());
            HideSubMenu();
        }
        #endregion
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
            panelLeft.Visible = false;
            HideSubMenu();
        }
    }
}
