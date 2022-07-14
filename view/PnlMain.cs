using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlMain:Panel
    {
        private List<Course> courses;
        private List<PnlCourseCard> cards;
        private Form1 form;
        public PnlMain(List<Course> courses, Form1 form)
        {
            this.cards = new List<PnlCourseCard>();
            this.form = form;
            this.Parent = form;
            this.courses = courses;
            this.Size= new Size(650,385);
            this.Location = new Point(0,70);
            this.BackColor = Color.Lavender;
            this.Size = new Size(650, 385);
            this.Name = "PnlMain";

            createCards();
        }
        public void createCards()
        {
            int x = 60, y = 30, ct = 0;
            foreach (Course c in courses)
            {
                ct++;
                PnlCourseCard pnlcourse = new PnlCourseCard(c, form);
                pnlcourse.Location = new Point(x, y);
                this.Controls.Add(pnlcourse);
                this.cards.Add(pnlcourse);

                x += 280;
                if (ct % 2 == 0)
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
