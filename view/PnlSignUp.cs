using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlSignUp:Panel
    {
        private Label signUp;
        private Label email;
        private Label password;
        private Label firstName;
        private Label lastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSignUp;
        private Button btnCancel;
        private ControllerCourse courses;
        private Form1 form;

        public PnlSignUp(Form1 form)
        {
            this.form = form;
            this.courses = new ControllerCourse();
            this.Size = new Size(680, 430);
            this.Location = new Point(0, 70);
            this.Name = "PnlSignUp";
            this.BackColor = Color.Transparent;
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;


            signUp = new Label();
            signUp.Location = new System.Drawing.Point(225, 40);
            signUp.Width = 187;
            signUp.Height = 35;
            signUp.Text = "Sign Up";
            Font font = new Font("Times New Roman", 18, FontStyle.Bold);
            signUp.ForeColor = Color.MediumOrchid;
           
            signUp.Font = font;
            this.Controls.Add(signUp);

            firstName = new Label();
            firstName.Location = new System.Drawing.Point(200, 95);
            firstName.Size = new Size(130, 25);
            firstName.Text = "First Name";
            Font labels = new Font("Times New Roman", 12);
            firstName.Font = labels;
            this.Controls.Add(firstName);

            txtFirstName = new TextBox();
            txtFirstName.Location = new System.Drawing.Point(200, 120);
            txtFirstName.Size = new Size(285, 25);
            this.Controls.Add(txtFirstName);

            lastName = new Label();
            lastName.Location = new System.Drawing.Point(200, 150);
            lastName.Size = new Size(130, 25);
            lastName.Text = "Last Name";
            lastName.Font = labels;
            this.Controls.Add(lastName);

            txtLastName = new TextBox();
            txtLastName.Location = new System.Drawing.Point(200, 175);
            txtLastName.Size = new Size(285, 25);
            this.Controls.Add(txtLastName);

            email = new Label();
            email.Location = new System.Drawing.Point(200, 205);
            email.Size = new Size(130, 25);
            email.Text = "Email Adress";
            email.Font = labels;
            this.Controls.Add(email);

            txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(200, 230);
            txtEmail.Size = new Size(285, 25);
            this.Controls.Add(txtEmail);

            password = new Label();
            password.Location = new System.Drawing.Point(200, 260);
            password.Size = new Size(130, 25);
            password.Text = "Password";
            password.Font = labels;
            this.Controls.Add(password);

            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(200, 285);
            txtPassword.Size = new Size(285, 25);
            this.Controls.Add(txtPassword);

            btnSignUp = new Button();
            btnSignUp.Location = new System.Drawing.Point(240, 320);
            btnSignUp.Width = 95;
            btnSignUp.Height = 38;
            btnSignUp.Text = "Sign Up";
            btnSignUp.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.ForeColor = Color.MediumOrchid;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(btnSignUp);
            this.btnSignUp.Click += new EventHandler(btnSignUp_Click);

            btnCancel = new Button();
            btnCancel.Location = new Point(355, 320);
            btnCancel.Width = 95;
            btnCancel.Height = 38;
            btnCancel.Text = "Cancel";
            btnCancel.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            btnCancel.BackColor = Color.MediumOrchid;
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(btnCancel);
            this.btnCancel.Click += new EventHandler(cancel_Click);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.form.erasePanel("PnlSignUp");
            this.form.Controls.Add(new PnlMain(courses.getAll(), form));
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!(txtEmail.Text.Equals("") || txtPassword.Text.Equals("") || txtFirstName.Text.Equals("") || txtLastName.Text.Equals("")))
            {
                ///
                this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
                this.form.Controls.Remove(this);


            }
            else
            {
                MessageBox.Show("Complete all text boxes!");
            }
        }
    }
}
