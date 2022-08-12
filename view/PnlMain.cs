using Online_school_library.Controllers;
using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlMain:Panel
    {
        private List<Course> courses;
        private List<PnlCourseCard> cards;
        private ControllerCourse control;
        private Form1 form;
        //private User user= new Teacher("teacher,10,Petean,Anamaria,malinapetean@gmail.com,1234,matematica");
        public PnlMain(List<Course> courses, Form1 form)
        {
            this.cards = new List<PnlCourseCard>();
            this.control = new ControllerCourse();
            this.form = form;
            base.Parent = form;
            
            this.courses = courses;
            this.Size= new Size(650,385);
            this.Location = new Point(0,70);
            this.BackColor = Color.MediumOrchid;
            this.Size = new Size(650, 385);
            this.Name = "PnlMain";
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;
            
            createCards(this.Parent.Width / 400);
            this.Resize += new EventHandler(main_Resize);

        }
        
        private void main_Resize(object sender, EventArgs e)
        {
            
            if (this.Width < 460+150)
            {
                ///Debug.WriteLine("mobil");
                createCards(1);
            }else if (this.Width < 740+150)
            {
                ///Debug.WriteLine("tableta");
                createCards(2);
            }
            else if (this.Width < 1020+150)
            {
                ///Debug.WriteLine("tableta");
                createCards(3);
            }
            else if (this.Width < 1300+150)
            {
                ///Debug.WriteLine("tableta");
                createCards(4);
            }
            else if (this.Width < 1580 + 150)
            {
                ///Debug.WriteLine("tableta");
                createCards(5);
            }
            else
            {
                ///Debug.WriteLine("pc");
                createCards(6);
            }
        }
        public void createCards(int nrcollums)
        {
            this.Controls.Clear();
           
            int x = 60, y = 100, ct = 0;
     

            foreach (Course c in courses)
            {
                ct++;
                PnlCourseCard pnlcourse = new PnlCourseCard(c, form);
                pnlcourse.Location = new Point(x, y);
                this.Controls.Add(pnlcourse);
                this.cards.Add(pnlcourse);

                x += 280;
                if (ct % nrcollums == 0)
                {
                    x = 60;
                    y += 140;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }

        }
        

    }
}
