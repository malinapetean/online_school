using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlAsside:Panel
    {
        private Button btnAdd;
        
        private Form1 form;

        public PnlAsside(Button add,Form1 form)
        {
            this.Location = new Point(650, 70);
            this.Name = "PnlAsside"; 
            this.Parent = form;
            this.Size = new Size(150, 382);
            this.BackColor = System.Drawing.Color.Plum;
            this.Dock = System.Windows.Forms.DockStyle.Right;




            btnAdd = add;
            this.btnAdd.Location = new System.Drawing.Point(27,24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add course";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnAdd);


        }

    }
}
