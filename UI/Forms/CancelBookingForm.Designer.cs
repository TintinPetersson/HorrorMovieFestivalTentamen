﻿
namespace UI
{
    partial class CancelBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCustomerDoesNotExist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPhoneNumber = new System.Windows.Forms.PictureBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.labelCustomerDoesNotExist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxPhoneNumber);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Controls.Add(this.textBoxPhoneNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 628);
            this.panel1.TabIndex = 19;
            // 
            // labelCustomerDoesNotExist
            // 
            this.labelCustomerDoesNotExist.AutoSize = true;
            this.labelCustomerDoesNotExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerDoesNotExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelCustomerDoesNotExist.Location = new System.Drawing.Point(246, 371);
            this.labelCustomerDoesNotExist.Name = "labelCustomerDoesNotExist";
            this.labelCustomerDoesNotExist.Size = new System.Drawing.Size(85, 29);
            this.labelCustomerDoesNotExist.TabIndex = 8;
            this.labelCustomerDoesNotExist.Text = "label3";
            this.labelCustomerDoesNotExist.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(393, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "At least 10 digits";
            // 
            // pictureBoxPhoneNumber
            // 
            this.pictureBoxPhoneNumber.Image = global::UI.Properties.Resources.CheckmarkIcon;
            this.pictureBoxPhoneNumber.Location = new System.Drawing.Point(642, 219);
            this.pictureBoxPhoneNumber.Name = "pictureBoxPhoneNumber";
            this.pictureBoxPhoneNumber.Size = new System.Drawing.Size(29, 39);
            this.pictureBoxPhoneNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoneNumber.TabIndex = 6;
            this.pictureBoxPhoneNumber.TabStop = false;
            this.pictureBoxPhoneNumber.Visible = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEnter.Location = new System.Drawing.Point(379, 279);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(129, 36);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Visible = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click_1);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(259, 219);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(376, 37);
            this.textBoxPhoneNumber.TabIndex = 1;
            this.textBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged_1);
            this.textBoxPhoneNumber.Enter += new System.EventHandler(this.textBoxPhoneNumber_Enter);
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            this.textBoxPhoneNumber.Leave += new System.EventHandler(this.textBoxPhoneNumber_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(343, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Phone Number:";
            // 
            // CancelBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(932, 628);
            this.Controls.Add(this.panel1);
            this.Name = "CancelBookingForm";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCustomerDoesNotExist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxPhoneNumber;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label1;
    }
}