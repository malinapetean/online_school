
namespace view
{
    partial class FrmMkSignIn
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label_id_course = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label_course_name = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.label_create_course = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(256, 151);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(284, 25);
            this.txt_id.TabIndex = 32;
            // 
            // label_id_course
            // 
            this.label_id_course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id_course.AutoSize = true;
            this.label_id_course.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id_course.Location = new System.Drawing.Point(256, 126);
            this.label_id_course.Name = "label_id_course";
            this.label_id_course.Size = new System.Drawing.Size(127, 22);
            this.label_id_course.TabIndex = 31;
            this.label_id_course.Text = "Email Address";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(256, 207);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(284, 25);
            this.txt_name.TabIndex = 30;
            // 
            // label_course_name
            // 
            this.label_course_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_course_name.Location = new System.Drawing.Point(256, 179);
            this.label_course_name.Name = "label_course_name";
            this.label_course_name.Size = new System.Drawing.Size(130, 25);
            this.label_course_name.TabIndex = 29;
            this.label_course_name.Text = "Password";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.Purple;
            this.btn_cancel.Location = new System.Drawing.Point(407, 249);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 38);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Purple;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_create.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_create.Location = new System.Drawing.Point(307, 249);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(94, 38);
            this.btn_create.TabIndex = 33;
            this.btn_create.Text = "Sign In";
            this.btn_create.UseVisualStyleBackColor = false;
            // 
            // label_create_course
            // 
            this.label_create_course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_create_course.AutoSize = true;
            this.label_create_course.BackColor = System.Drawing.Color.Transparent;
            this.label_create_course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_create_course.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_create_course.ForeColor = System.Drawing.Color.Purple;
            this.label_create_course.Location = new System.Drawing.Point(256, 76);
            this.label_create_course.Name = "label_create_course";
            this.label_create_course.Size = new System.Drawing.Size(107, 35);
            this.label_create_course.TabIndex = 28;
            this.label_create_course.Text = "Sign In";
            this.label_create_course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMkSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label_id_course);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label_course_name);
            this.Controls.Add(this.label_create_course);
            this.Name = "FrmMkSignIn";
            this.Text = "FrmMkSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label_id_course;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label_course_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label_create_course;
    }
}