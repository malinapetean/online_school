using Online_school_library.Controllers;
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
        private Button btnAdd;
       

        public Form1()
        {
            InitializeComponent();

            this.courses = new ControllerCourse();
            
            this.btnAdd = new Button();
            this.btnAdd.Click += new EventHandler(add_Click);

            
            this.Controls.Add(new PnlHeader());
            this.Controls.Add(new PnlMain(courses.getAll(),this));
            this.Controls.Add(new PnlAsside(btnAdd,this));

        }
        private void add_Click(object sender, EventArgs e)
        {
            
            erasePanel("PnlMain");
            
            this.Controls.Add(new PnlAddCourse(this));
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
