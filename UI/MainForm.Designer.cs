
namespace UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelBookingSubMenu = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureMenuBar = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelHorrorMovieText = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelBookingSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuBar)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelSideMenu.Controls.Add(this.panelBookingSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonBooking);
            this.panelSideMenu.Controls.Add(this.buttonMovies);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 800);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelBookingSubMenu
            // 
            this.panelBookingSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panelBookingSubMenu.Controls.Add(this.buttonCancel);
            this.panelBookingSubMenu.Controls.Add(this.buttonChange);
            this.panelBookingSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookingSubMenu.Location = new System.Drawing.Point(0, 255);
            this.panelBookingSubMenu.Name = "panelBookingSubMenu";
            this.panelBookingSubMenu.Size = new System.Drawing.Size(250, 137);
            this.panelBookingSubMenu.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(0, 65);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCancel.Size = new System.Drawing.Size(250, 65);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.buttonChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChange.Location = new System.Drawing.Point(0, 0);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonChange.Size = new System.Drawing.Size(250, 65);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Change";
            this.buttonChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBooking.FlatAppearance.BorderSize = 0;
            this.buttonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBooking.Location = new System.Drawing.Point(0, 190);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonBooking.Size = new System.Drawing.Size(250, 65);
            this.buttonBooking.TabIndex = 2;
            this.buttonBooking.Text = "Change Booking";
            this.buttonBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMovies.FlatAppearance.BorderSize = 0;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMovies.Location = new System.Drawing.Point(0, 125);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMovies.Size = new System.Drawing.Size(250, 65);
            this.buttonMovies.TabIndex = 1;
            this.buttonMovies.Text = "Movies";
            this.buttonMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMovies.UseVisualStyleBackColor = true;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureMenuBar);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 125);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureMenuBar
            // 
            this.pictureMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pictureMenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureMenuBar.Image = global::UI.Properties.Resources.gifs_8;
            this.pictureMenuBar.InitialImage = null;
            this.pictureMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pictureMenuBar.Name = "pictureMenuBar";
            this.pictureMenuBar.Size = new System.Drawing.Size(250, 125);
            this.pictureMenuBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMenuBar.TabIndex = 0;
            this.pictureMenuBar.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.buttonExit);
            this.panelHeader.Controls.Add(this.labelHorrorMovieText);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(950, 125);
            this.panelHeader.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(881, 31);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(48, 44);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelHorrorMovieText
            // 
            this.labelHorrorMovieText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHorrorMovieText.AutoSize = true;
            this.labelHorrorMovieText.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHorrorMovieText.ForeColor = System.Drawing.Color.Red;
            this.labelHorrorMovieText.Location = new System.Drawing.Point(77, 22);
            this.labelHorrorMovieText.Name = "labelHorrorMovieText";
            this.labelHorrorMovieText.Size = new System.Drawing.Size(756, 74);
            this.labelHorrorMovieText.TabIndex = 0;
            this.labelHorrorMovieText.Text = "Horror Movie Festival";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 125);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(950, 675);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::UI.Properties.Resources._6f7afd24bfde63efb1b3fa6bfb84f2121;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horror Movie Festival";
            this.panelSideMenu.ResumeLayout(false);
            this.panelBookingSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuBar)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelBookingSubMenu;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureMenuBar;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label labelHorrorMovieText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
    }
}

