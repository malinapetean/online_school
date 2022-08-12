
namespace view
{
    partial class FrmMkAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.label_department = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label_id_course = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label_course_name = new System.Windows.Forms.Label();
            this.label_create_course = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.label_description);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.txt_department);
            this.panel1.Controls.Add(this.label_department);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label_id_course);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label_course_name);
            this.panel1.Controls.Add(this.label_create_course);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 490);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_description.Location = new System.Drawing.Point(259, 319);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(283, 25);
            this.txt_description.TabIndex = 21;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_description.Location = new System.Drawing.Point(259, 294);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(103, 22);
            this.label_description.TabIndex = 20;
            this.label_description.Text = "Description";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_cancel.Location = new System.Drawing.Point(417, 411);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 38);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_create.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_create.Location = new System.Drawing.Point(298, 411);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(94, 38);
            this.btn_create.TabIndex = 18;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_department.Location = new System.Drawing.Point(259, 264);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(284, 25);
            this.txt_department.TabIndex = 17;
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_department.Location = new System.Drawing.Point(258, 239);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(158, 22);
            this.label_department.TabIndex = 16;
            this.label_department.Text = "Course department";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(259, 151);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(284, 25);
            this.txt_id.TabIndex = 15;
            // 
            // label_id_course
            // 
            this.label_id_course.AutoSize = true;
            this.label_id_course.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id_course.Location = new System.Drawing.Point(259, 126);
            this.label_id_course.Name = "label_id_course";
            this.label_id_course.Size = new System.Drawing.Size(91, 22);
            this.label_id_course.TabIndex = 14;
            this.label_id_course.Text = "Course ID";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(258, 209);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(284, 25);
            this.txt_name.TabIndex = 13;
            // 
            // label_course_name
            // 
            this.label_course_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_course_name.Location = new System.Drawing.Point(258, 181);
            this.label_course_name.Name = "label_course_name";
            this.label_course_name.Size = new System.Drawing.Size(130, 25);
            this.label_course_name.TabIndex = 12;
            this.label_course_name.Text = "Course name";
            // 
            // label_create_course
            // 
            this.label_create_course.AutoSize = true;
            this.label_create_course.BackColor = System.Drawing.Color.Transparent;
            this.label_create_course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_create_course.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_create_course.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label_create_course.Location = new System.Drawing.Point(298, 64);
            this.label_create_course.Name = "label_create_course";
            this.label_create_course.Size = new System.Drawing.Size(187, 35);
            this.label_create_course.TabIndex = 11;
            this.label_create_course.Text = "Create course";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Creator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 27);
            this.textBox1.TabIndex = 24;
            // 
            // FrmMkAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 558);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMkAdd";
            this.Text = "FrmMkAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label_id_course;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label_course_name;
        private System.Windows.Forms.Label label_create_course;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}