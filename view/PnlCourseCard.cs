using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlCourseCard:Panel
    {
        private Course course;
        private ControllerCourse control;
        private Label name;
        private Label department;

        private Form1 form;

        public PnlCourseCard(Course course, Form1 form)
        {
            control = new ControllerCourse();
            this.course = course;
            this.Name = "PnlCourseCard";
            this.form = form;
            this.Size = new Size(230, 96);
            this.BackColor = Color.Thistle;

            name = new Label();
            name.Location = new Point(13, 53);
            name.Font = new Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            name.Height = 25; 
            name.Width = 200;
            name.Text = course.Name;
            name.ForeColor = Color.Black;
            this.Controls.Add(name);

            department = new Label();
            department.Location = new Point(13, 10);
            department.Font = new Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            department.Height = 30; 
            department.Width = 80;
            department.Text = course.Department;
            department.ForeColor = Color.Black;
            this.Controls.Add(department);

            this.Click += new EventHandler(card_Click);
        }

        private void card_Click(object sender, EventArgs e)
        {
            this.form.erasePanel("PnlMain");
            this.form.Controls.Add(new PnlUpdate(form, control.getCourseByID(course.Id)));
        }
    }
}
