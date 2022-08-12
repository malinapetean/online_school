using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlHeader : Panel
    {
        private Label labelName;
        private Button signIn;
        private Button signUp;
        private Button btncourses;
        private ControllerCourse courses;
        private Button btnAdd;

        private Form1 form;
        private User user;

        public PnlHeader(Button signIn,Button signUp,Button btnCourses,Button Add,Form1 form,User user)
        {
            labelName = new Label();
            labelName.AutoSize = true;
            labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelName.Font = new System.Drawing.Font("Times New Roman", 18.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelName.Location = new System.Drawing.Point(12, 20);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(147, 32);
            labelName.TabIndex = 0;
            labelName.Text = "COURSES";
            labelName.Click += new EventHandler(label_Click);

            this.Parent = form;
            this.form = form;
            this.user = user;
            this.BackColor = Color.Thistle;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new Point(0, 0);
            this.Name = "PnlHeader";
            this.Size = new Size(this.Parent.Width, 70);
            this.Controls.Add(this.labelName);
            courses = new ControllerCourse();


            this.signIn = signIn;
            signIn.AutoSize = true;
            signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            signIn.Font = new Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            signIn.ForeColor = SystemColors.ActiveCaptionText;
            ///signIn.Location = new Point(this.Width-200, 25);
            signIn.Name = "btnSignIn";
            signIn.Size = new Size(94, 29);
            signIn.TabIndex = 0;
            signIn.Text = "Sign In";
            signIn.BackColor = Color.Plum;
            this.Controls.Add(this.signIn);
            this.Resize += new EventHandler(buttons_Resize);


            this.signUp = signUp;
            signUp.AutoSize = true;
            signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            signUp.Font = new Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            signUp.ForeColor = SystemColors.ActiveCaptionText;
            ///signUp.Location = new Point(this.Width-100, 25);
            signUp.Name = "btnSignup";
            signUp.Size = new Size(94, 29);
            signUp.TabIndex = 0;
            signUp.Text = "Sign Up";
            signUp.BackColor = Color.MediumOrchid;
            this.Controls.Add(this.signUp);

            this.btncourses = btnCourses;
            btnCourses.AutoSize = true;
            btnCourses.Font = new Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.ForeColor = SystemColors.ActiveCaptionText;
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(105, 29);
            btnCourses.TabIndex = 0;
            btnCourses.Text = "My Courses";
            btnCourses.BackColor = Color.MediumOrchid;
            this.Controls.Add(this.btncourses);

            if(user is Teacher)
            {
                this.btnAdd = Add;
                Add.AutoSize = true;
                Add.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
                Add.ForeColor = Color.Thistle;
                Add.Name = "btnAdd";
                Add.Size = new Size(180, 34);
                Add.FlatStyle = FlatStyle.Popup;
                Add.Text = "Add New Course+";
                Add.BackColor = Color.MediumOrchid;
                this.Controls.Add(this.btnAdd);
            }
            
        }

        private void label_Click(object sender, EventArgs e)
        {
            //this.courses.load();

            this.form.erasePanel("PnlMain");
            this.form.erasePanel("PnlUpdate");
            this.form.erasePanel("PnlDetails");
            
            this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
           
        }

        private void buttons_Resize(object sender, EventArgs e)
        {
            signUp.Location = new Point(this.Width - 110, 25);
            signIn.Location = new Point(this.Width - 210, 25);
            btncourses.Location = new Point(this.Width - 333, 25);
            if(user is Teacher)
                btnAdd.Location = new Point(this.Width - 520, 25);

        }
        
    }
}
