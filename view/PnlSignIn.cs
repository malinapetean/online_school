using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlSignIn:Panel
    {
        private Label signin;
        private Label email;
        private Label password;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Button btnCancel;
        private ControllerCourse courses;
        private Form1 form;
        public PnlSignIn(Form1 form)
        {
            this.form = form;
            this.courses = new ControllerCourse();
            this.Size = new Size(680, 430);
            this.Location = new Point(0, 70);
            this.Name = "PnlSignIn";
            this.BackColor = Color.Transparent;
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;


            signin = new Label();
            signin.Location = new System.Drawing.Point(225, 40);
            signin.Width = 187;
            signin.Height = 35;
            signin.Text = "Sign In";
            Font font = new Font("Times New Roman", 18, FontStyle.Bold);
            signin.ForeColor = Color.Plum;
            signin.Font = font;
            this.Controls.Add(signin);

            email = new Label();
            email.Location = new System.Drawing.Point(200, 95);
            email.Size= new Size(130,25);
            email.Text = "Email Adress";
            Font labels = new Font("Times New Roman", 12);
            email.Font = labels;
            this.Controls.Add(email);

            txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(200, 120);
            txtEmail.Size= new Size(285,25);
            this.Controls.Add(txtEmail);

            password = new Label();
            password.Location = new System.Drawing.Point(200, 150);
            password.Size = new Size(130,25);
            password.Text = "Password";
            password.Font = labels;
            this.Controls.Add(password);

            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(200, 175);
            txtPassword.Size = new Size(285, 25);
            this.Controls.Add(txtPassword);

            btnSignIn = new Button();
            btnSignIn.Location = new System.Drawing.Point(240, 240);
            btnSignIn.Width = 95;
            btnSignIn.Height = 38;
            btnSignIn.Text = "Sign In";
            btnSignIn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            btnSignIn.BackColor = Color.Plum;
            btnSignIn.ForeColor = Color.Transparent;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(btnSignIn);
            this.btnSignIn.Click += new EventHandler(btnSignIn_Click);

            btnCancel = new Button();
            btnCancel.Location = new Point(355, 240);
            btnCancel.Width = 95;
            btnCancel.Height = 38;
            btnCancel.Text = "Cancel";
            btnCancel.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            btnCancel.BackColor = Color.Transparent;
            btnCancel.ForeColor = Color.Plum;
            btnCancel.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(btnCancel);
            this.btnCancel.Click += new EventHandler(cancel_Click);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.form.erasePanel("PnlSignIn");
            this.form.Controls.Add(new PnlMain(courses.getAll(), form));
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!(txtEmail.Text.Equals("") || txtPassword.Text.Equals("")))
            {
                ///
                ///
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
