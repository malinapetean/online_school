using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlAddCourse:Panel
    {
        private Label createCourse;
        private Label name;
        private Label id;
        private Label department;
        private Label description;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDepartment;
        private TextBox txtDescription;
        private Button btnCreate;
        private Button btnCancel;
        private Course course;
        private ControllerCourse courses;
        private Form1 form;

        public PnlAddCourse(Form1 form)
        {
            this.form = form;
            this.courses = new ControllerCourse();
            this.course = new Course();
            this.course.Id = courses.nextId();
            this.Size= new Size(680, 430);
            this.Location = new Point(0, 70);
            this.Name = "PnlAdd";
            this.BackColor = Color.MediumOrchid;
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

            createCourse = new Label();
            createCourse.Location = new System.Drawing.Point(225, 40);
            createCourse.Width = 187; 
            createCourse.Height = 35;
            createCourse.Text = "Create course";
            Font font = new Font("Times New Roman", 18,FontStyle.Bold);
            createCourse.ForeColor= Color.Thistle;
            createCourse.Font = font;
            this.Controls.Add(createCourse);

            id = new Label();
            id.Location = new System.Drawing.Point(200, 95);
            id.Width = 91;
            id.Height = 22;
            id.Text = "Course Id";
            Font labels = new Font("Times New Roman", 12);
            id.Font = labels;
            this.Controls.Add(id);

            txtId = new TextBox();
            txtId.Location = new System.Drawing.Point(200, 120);
            txtId.Width = 285;
            txtId.Height = 25;
            this.Controls.Add(txtId);
            txtId.Text =courses.nextId().ToString();
            txtId.Enabled = false;

            name = new Label();
            name.Location = new System.Drawing.Point(200, 145);
            name.Width = 120;
            name.Height = 22;
            name.Text = "Course Name";
            name.Font = labels;
            this.Controls.Add(name);

            txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(200, 170);
            txtName.Width = 285;
            txtName.Height = 25;
            this.Controls.Add(txtName);

            department = new Label();
            department.Location = new System.Drawing.Point(200, 200);
            department.Width = 170;
            department.Height = 22;
            department.Text = "Course Department";
            department.Font = labels;
            this.Controls.Add(department);

            txtDepartment = new TextBox();
            txtDepartment.Location = new System.Drawing.Point(200, 230);
            txtDepartment.Width = 285;
            txtDepartment.Height = 25;
            this.Controls.Add(txtDepartment);

            description = new Label();
            description.Location = new System.Drawing.Point(200, 260);
            description.Width = 103;
            description.Height = 22;
            description.Text = "Description";
            description.Font = labels;
            this.Controls.Add(description);

            txtDescription = new TextBox();
            txtDescription.Location = new System.Drawing.Point(200, 285);
            txtDescription.Width = 285;
            txtDescription.Height = 25;
            this.Controls.Add(txtDescription);

            btnCreate = new Button();
            btnCreate.Location = new System.Drawing.Point(240, 330);
            btnCreate.Width = 95;
            btnCreate.Height = 38;
            btnCreate.Text = "Create";
            btnCreate.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            btnCreate.BackColor = Color.Thistle;
            btnCreate.ForeColor = Color.MediumOrchid;
            btnCreate.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(btnCreate);
            this.btnCreate.Click += new EventHandler(btnCreate_Click);

            btnCancel = new Button();
            btnCancel.Location = new Point(355, 330);
            btnCancel.Width = 95;
            btnCancel.Height = 38;
            btnCancel.Text = "Cancel";
            btnCancel.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            btnCancel.BackColor = Color.MediumOrchid;
            btnCancel.ForeColor = Color.Thistle;
            btnCancel.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(btnCancel);
            this.btnCancel.Click += new EventHandler(cancel_Click);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (!(txtName.Text.Equals("") || txtDepartment.Text.Equals("") || txtDescription.Text.Equals("")))
            {

                this.course.Name = txtName.Text;
                this.course.Department = txtDepartment.Text;
                this.course.Detalis = txtDescription.Text;

                this.courses.addCourse(course);
                this.courses.save();
                this.courses.load();
                this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
                this.form.Controls.Remove(this);


            }
            else
            {
                MessageBox.Show("Complete all text boxes!");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

            this.form.erasePanel("PnlAdd");
            this.form.Controls.Add(new PnlMain(courses.getAll(), form));

        }
    }
}
