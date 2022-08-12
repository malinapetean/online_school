using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlUpdate:Panel
    {
        private Label updateCourse;
        private Label name;
        private Label id;
        private Label department;
        private Label description;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDepartment;
        private TextBox txtDescription;
        private Button update;
        private Button delete;
        private Button cancel;
        private Course course;
        private ControllerCourse courses;
        private Form1 form;

        private User user = new Teacher("teacher,10,Petean,Anamaria,malinapetean@gmail.com,1234,matematica");

        public PnlUpdate(Form1 form,Course course)
        {
            this.form = form;
            this.course = course;
            courses = new ControllerCourse();
            this.Size = new Size(680, 430);
            this.Location = new Point(0, 70);
            this.BackColor = Color.Transparent;
            this.Name = "PnlUpdate";
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            

            Font font = new Font("Times New Roman", 18,FontStyle.Bold);
            Font labels = new Font("Times New Roman", 12);

            updateCourse = new Label();
            updateCourse.Location = new System.Drawing.Point(220, 10);
            updateCourse.Width = 220; 
            updateCourse.Height = 35;
            updateCourse.Text = "Update Course";
            updateCourse.BackColor = Color.Thistle;
            updateCourse.ForeColor = Color.Purple;
            updateCourse.Font = font;
            //updateCourse.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            this.Controls.Add(updateCourse);

            id = new Label();
            id.Location = new System.Drawing.Point(182, 65);
            id.Size = new Size(91, 22);
            id.Text = "Course ID";
            id.Font = labels;
            //id.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            this.Controls.Add(id);

            txtId = new TextBox();
            txtId.Location = new System.Drawing.Point(182, 90);
            txtId.Size = new Size(285, 95);
            this.Controls.Add(txtId);
            txtId.Text = course.Id.ToString();
            //txtId.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            txtId.Enabled = false;

            name = new Label();
            name.Location = new System.Drawing.Point(182, 118);
            name.Size= new Size(130, 25);
            name.Text = "Course name";
            name.Font = labels;
            //name.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            this.Controls.Add(name);

            txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(182, 146);
            txtName.Size = new Size(285, 95);
            txtName.Text = course.Name;
            //txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left; 
            this.Controls.Add(txtName);
            txtName.TextChanged += new EventHandler(update_TextChanged);

            department = new Label();
            department.Location = new System.Drawing.Point(182, 174);
            department.Size = new Size(170, 22);
            department.Text = "Course Department";
            department.Font = labels;
            //department.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            this.Controls.Add(department);

            txtDepartment = new TextBox();
            txtDepartment.Location = new System.Drawing.Point(182, 199);
            txtDepartment.Size= new Size(285, 95);
            this.Controls.Add(txtDepartment);
            txtDepartment.Text = course.Department;
            //txtDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDepartment.TextChanged += new EventHandler(update_TextChanged);

            description = new Label();
            description.Location = new System.Drawing.Point(182, 227);
            description.Size = new Size(103, 22);
            description.Text = "Description";
            description.Font = labels;
            //description.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            this.Controls.Add(description);

            txtDescription = new TextBox();
            txtDescription.Location = new System.Drawing.Point(182, 252);
            txtDescription.Size = new Size(285, 95);
            this.Controls.Add(txtDescription);
            txtDescription.Text = course.Detalis;
            //txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDescription.TextChanged += new EventHandler(update_TextChanged);

            update = new Button();
            update.Location = new System.Drawing.Point(170, 290);
            update.Size= new Size(94, 38);
            update.Text = "Update";
            update.Font = new Font("Times New Roman",13, FontStyle.Bold);
            update.FlatStyle = new FlatStyle();
            update.BackColor = Color.Purple;
            update.ForeColor = Color.Thistle;
            this.Controls.Add(update);
            this.update.Click += new EventHandler(update_Click);

            cancel = new Button();
            cancel.Location = new Point(270, 290);
            cancel.Width = 94;
            cancel.Height = 38;
            cancel.Text = "Cancel";
            cancel.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            cancel.BackColor = Color.Thistle;
            cancel.ForeColor = Color.Purple;
            this.Controls.Add(cancel);
            this.cancel.Click += new EventHandler(cancel_Click);

            delete = new Button();
            delete.Location = new Point(370, 290);
            delete.Width = 94;
            delete.Height = 38;
            delete.Text = "Delete";
            delete.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            delete.BackColor = Color.Thistle;
            delete.ForeColor = Color.Purple;
            this.Controls.Add(delete);
            delete.Click += new EventHandler(delete_Click);
        }

        private void update_Click(object sender, EventArgs e)
        {
            int ok = 0;
            foreach(Course c in courses.myCourses(user))
            {
                if(c.Name.Equals(course.Name))
                {
                    MessageBox.Show("You can't change the name like this because you already have a course with this name");
                    ok = 1;
                }

            }
            if (!(txtName.Text.Equals("") || txtDepartment.Text.Equals("") || txtDescription.Text.Equals(""))&& ok==0)
            {
                this.courses.updateCourse(this.course);
                this.courses.save();
                this.courses.load();
                this.form.Controls.Add(new PnlDetails(user, form,course));
                this.form.Controls.Remove(this);

            }
            else if(txtName.Text.Equals("") || txtDepartment.Text.Equals("") || txtDescription.Text.Equals(""))
                MessageBox.Show(checkErrors());
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            
            this.form.Controls.Add(new PnlDetails(user, form,course));
            this.courses.load();
            this.form.Controls.Remove(this);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            this.courses.delete(this.course);
            this.courses.save();
            this.courses.load();
            this.form.Controls.Add(new PnlMain(this.courses.getAll(), form));
            this.form.Controls.Remove(this);

        }
        private void update_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.course.Name = txtName.Text;
                this.course.Detalis = txtDescription.Text;
                this.course.Department = txtDepartment.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("valoare invalida");
            }
        }
        private String checkErrors()
        {
            String text = "";
            if (txtDepartment.Text.Equals(""))
                text += "Add department! ";
            if (txtName.Text.Equals(""))
                text += "Add name! ";
            if (txtDescription.Text.Equals(""))
                text += "Add description! ";
            return text;
        }

    }
}
