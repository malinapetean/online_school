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
        private Label creator;
        private TextBox txtDescription;
        private TextBox txtSubscribed;
        private Button btnMultiTask;
        private Button btnReturn;

        private ControllerCourse courses;
        private ControllerEnrolment enrolments;
        private ControllerUser students;
        private Form1 form;
        private Course c;
        private User user;

        public PnlDetails(User user,Form1 form, Course c)
        {
            
            courses = new ControllerCourse();
            enrolments = new ControllerEnrolment();
            students = new ControllerUser();
            this.user = user;
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

            creator = new Label();
            creator.Font = new Font("Times New Roman", 9);
            creator.Location = new Point(28, 114);
            creator.Size = new Size(131,17);
            creator.Text = "By " + students.getTeacerById(c.TeacherID).Last_Name.ToString();

            creator.ForeColor = Color.Black;
            creator.BackColor = Color.Plum;
            this.Controls.Add(creator);

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

            

            createButtons(user,c);
        }

        private void Unenroll_Click(object sender, EventArgs e)
        {
            
            if (enrolments.existence(user, c) == true)
            {
                 this.enrolments.deleteEnroll(user as Student, c);
                 this.enrolments.save();
                 this.courses.load();
                 this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
                 this.form.Controls.Remove(this);
                
            }
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            Enrolment enr = new Enrolment(this.enrolments.nextId(), user.Id, this.c.Id);

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
        private void edit_Click(object sender, EventArgs e)
        {
            this.form.Controls.Add(new PnlUpdate( form,c));
            this.courses.load();
            this.form.Controls.Remove(this);
        }

        private void deleteButton(String name)
        {
            Control cautat = null;

            foreach (Control aux in this.Controls)
            {
                if (aux.Name.Equals(name))
                {
                    cautat = aux;
                }
            }

            if (cautat != null)
                this.Controls.Remove(cautat);
        
        }
        //create buttons
        //am facut un buton care face enroll, unenroll si edit dupa tipul de user

        public void createButtons(User user, Course c)
        {
            
            btnMultiTask = new Button();
            btnMultiTask.Location = new Point(28, 388);
            btnMultiTask.Size = new Size(120, 40);
            btnMultiTask.FlatStyle = FlatStyle.Flat;
            btnMultiTask.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btnMultiTask.ForeColor = Color.Black;
            btnMultiTask.BackColor = Color.Thistle;
            btnMultiTask.Name = "BtnMultiTask";
            this.Controls.Add(btnMultiTask);
            if(user is Student)
            {
                if(enrolments.existence(user,c)==true)
                {
                    btnMultiTask.Text = "UnEnroll";
                    btnMultiTask.Click += new EventHandler(Unenroll_Click);
                }
                else
                {
                    btnMultiTask.Text = "Enroll";
                    btnMultiTask.Click += new EventHandler(enroll_Click);
                }
            }
            else if(user is Teacher)
            {
                if(user.Id.Equals(c.TeacherID))
                {
                    btnMultiTask.Text = "Edit";
                    btnMultiTask.Click += new EventHandler(edit_Click);
                }
                else
                {
                    deleteButton("BtnMultiTask");
                    btnMultiTask.Enabled = false;
                }
            }
        }



    }
}
