using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class Form1 : Form
    {
        private ControllerCourse courses;
        private ControllerEnrolment ctrlenr;
        private Button btnAdd;
        private Button signIn;
        private Button signUp;
        private Button btncourses;
        private User user= new Teacher("teacher,10,Petean,Anamaria,malinapetean@gmail.com,1234,matematica");
       

        public Form1()
        {
            InitializeComponent();

            this.courses = new ControllerCourse();
            this.ctrlenr = new ControllerEnrolment();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            //this.btnAdd = new Button();
            //this.btnAdd.Click += new EventHandler(add_Click);
            this.signIn = new Button();
            this.signIn.Click += new EventHandler(signIn_Click);
            this.signUp = new Button();
            this.signUp.Click += new EventHandler(signUp_Click);
            this.btncourses = new Button();
            this.btncourses.Click += new EventHandler(courses_Click);
            if(user is Teacher)
            {
                this.btnAdd = new Button();
                this.btnAdd.Click += new EventHandler(add_Click);
            }
            
            this.Controls.Add(new PnlHeader(signIn,signUp, btncourses,btnAdd,this,user));
            this.Controls.Add(new PnlMain(courses.getAll(),this));
            ///this.Controls.Add(new PnlAsside(btnAdd,this));

        }

        private void courses_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            if (searchPanel("PnlSignIn"))
                erasePanel("PnlSignIn");
            if(user is Student)
            {
                this.Controls.Add(new PnlMain(courses.subscribedCouses(ctrlenr.enrolledCourses(user)),this));
            }
            else if(user is Teacher)
            {
                this.Controls.Add(new PnlMain(courses.myCourses(user), this));
            }
            
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            if (searchPanel("PnlSignIn"))
                erasePanel("PnlSignIn");
            this.Controls.Add(new PnlSignUp(this));
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            if (searchPanel("PnlSignUp"))
                erasePanel("PnlSignUp");
            this.Controls.Add(new PnlSignIn(this));
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            if (searchPanel("PnlSignUp"))
                erasePanel("PnlSignUp");
            if (searchPanel("PnlSignIn"))
                erasePanel("PnlSignIn");
            this.Controls.Add(new PnlAddCourse(this,user));
        }

        public void erasePanel(String name)
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
        public bool searchPanel(String panel)
        {
            Control p = null;
            foreach (Control control in this.Controls)
            {
                if (control.Name.Equals(panel))
                {
                    p = control;
                    return true;
                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
