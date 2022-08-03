using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlDetails:Panel
    {
        private Label courseDetails;
        private Label course;
        private Label courseName;
        private Label description;
        private Label deparment;
        private Label departmentName;
        private Label subscribedStudents;
        private TextBox txtDescription;
        private TextBox txtSubscribed;
        private Button btnEnroll;
        private Button btnUnenroll;
        private Button btnReturn;

        private ControllerCourse courses;
        private ControllerEnrolment enrolments;
        private Form1 form;
        private Course c;
        private Student student = new Student("student, 1352, Luca, Alex, alex@yahoo.com, 11234, 34");

        public PnlDetails(Student student,Form1 form, Course c)
        {
            
            courses = new ControllerCourse();
            enrolments = new ControllerEnrolment();
            this.student = student;
            this.c = c;
            this.form = form;
            base.Parent = form;
            //this.Size = new Size(2000, 930);
            this.Location = new Point(0, 70);
            this.BackColor = Color.Plum;
            this.Name = "PnlDetails";
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;

            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
            Font labels = new Font("Times New Roman", 12);

            courseDetails = new Label();
            courseDetails.Font = font;
            courseDetails.Location = new Point(28, 28);
            courseDetails.Size = new Size(162, 26);
            courseDetails.Text = "Course Details";
            courseDetails.ForeColor = Color.Black;
            courseDetails.BackColor = Color.Plum;
            this.Controls.Add(courseDetails);

            course = new Label();
            course.Font = labels;
            course.Location = new Point(28, 92);
            course.Size = new Size(77, 22);
            course.Text = "Course:";
            course.ForeColor = Color.Black;
            course.BackColor = Color.Plum;
            this.Controls.Add(course);

            courseName = new Label();
            FontStyle fontStyle = FontStyle.Italic;
            fontStyle |= FontStyle.Bold;
            courseName.Font = new Font("Times New Roman" ,18, fontStyle);
            courseName.Location = new Point(101, 76);
            courseName.Size = new Size(260,41);
            courseName.Text = c.Name.ToString();
            courseName.ForeColor = Color.Black;
            courseName.BackColor = Color.Plum;
            this.Controls.Add(courseName);

            description = new Label();
            description.Font = labels;
            description.Location= new Point(28, 147);
            description.Size = new Size(109, 22);
            description.Text = "Description:";
            description.ForeColor = Color.Black;
            description.BackColor = Color.Plum;
            this.Controls.Add(description);

            txtDescription = new TextBox();
            txtDescription.Location = new Point(28, 172);
            txtDescription.Size = new Size(300,190);
            txtDescription.Text = c.Detalis.ToString();
            txtDescription.ForeColor = Color.Black;
            txtDescription.BackColor = Color.Thistle;
            txtDescription.Multiline = true;
            this.Controls.Add(txtDescription);

            deparment = new Label();
            deparment.Font = labels;
            deparment.Location = new Point(390, 92);
            deparment.Size = new Size(107, 22);
            deparment.Text = "Department:";
            deparment.ForeColor = Color.Black;
            deparment.BackColor = Color.Plum;
            this.Controls.Add(deparment);

            departmentName = new Label();
            FontStyle fonts = FontStyle.Italic;
            fonts |= FontStyle.Bold;
            departmentName.Font = new Font("Times New Roman", 14, fonts);
            departmentName.Location = new Point(500, 90);
            departmentName.Size = new Size(180,23);
            departmentName.Text = c.Department.ToString();
            departmentName.ForeColor = Color.Black;
            departmentName.BackColor = Color.Plum;
            this.Controls.Add(departmentName);

            subscribedStudents = new Label();
            subscribedStudents.Font = labels;
            subscribedStudents.Location = new Point(390, 147);
            subscribedStudents.Size = new Size(173, 22);
            subscribedStudents.Text = "Subscribed students:";
            subscribedStudents.ForeColor = Color.Black;
            subscribedStudents.BackColor = Color.Plum;
            this.Controls.Add(subscribedStudents);

            txtSubscribed = new TextBox();
            txtSubscribed.Location = new Point(571, 142);
            txtSubscribed.Size = new Size(120, 27);
            txtSubscribed.Text = "Inca nu ";
            txtSubscribed.ForeColor = Color.Black;
            txtSubscribed.BackColor = Color.Thistle;
            this.Controls.Add(txtSubscribed);

            btnReturn = new Button();
            btnReturn.Location = new Point(165, 389);
            btnReturn.Size = new Size(163, 40);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Text = "Return to list";
            btnReturn.Font = new Font("Times New Roman",14);
            btnReturn.ForeColor = Color.Purple;
            btnReturn.BackColor = Color.Thistle;
            this.Controls.Add(btnReturn);
            btnReturn.Click += new EventHandler(return_Click);

            if (enrolments.existence(student, c) == true)
            {
                
                btnUnenroll = new Button();
                btnUnenroll.Location = new Point(28, 388);
                btnUnenroll.Size = new Size(120, 40);
                btnUnenroll.FlatStyle = FlatStyle.Flat;
                btnUnenroll.Text = "Unenroll";
                btnUnenroll.Font = font;
                btnUnenroll.ForeColor = Color.Black;
                btnUnenroll.BackColor = Color.Thistle;
                this.Controls.Add(btnUnenroll);

                btnUnenroll.Click += new EventHandler(Unenroll_Click);
            }
            else
            {
                btnEnroll = new Button();
                btnEnroll.Location = new Point(28, 388);
                btnEnroll.Size = new Size(95, 40);
                btnEnroll.FlatStyle = FlatStyle.Flat;
                btnEnroll.Text = "Enroll";
                btnEnroll.Font = font;
                btnEnroll.ForeColor = Color.Black;
                btnEnroll.BackColor = Color.Thistle;
                this.Controls.Add(btnEnroll);

                btnEnroll.Click += new EventHandler(enroll_Click);
            }
        }

        private void Unenroll_Click(object sender, EventArgs e)
        {
            if(enrolments.existence(student,c)==true)
            {
                this.enrolments.deleteEnroll(student, c);
                this.enrolments.save();
                this.courses.load();
                this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
                this.form.Controls.Remove(this);
            }
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            Enrolment enr = new Enrolment(this.enrolments.nextId(), student.Id, this.c.Id);

            this.enrolments.addEnroll(enr);
            this.enrolments.save();
            this.courses.load();
            this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
            this.form.Controls.Remove(this);
        }

        private void return_Click(object sender, EventArgs e)
        {

            this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
            this.courses.load();
            this.form.Controls.Remove(this);
        }


    }
}
