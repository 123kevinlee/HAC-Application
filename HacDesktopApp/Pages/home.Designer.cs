namespace HacDesktopApp
{
    partial class home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.building_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.grade_label = new System.Windows.Forms.Label();
            this.counselor_label = new System.Windows.Forms.Label();
            this.hr_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.studentNameLabel.Location = new System.Drawing.Point(25, 20);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(123, 19);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "Student Name:";
            this.studentNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.studentNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.studentNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // building_label
            // 
            this.building_label.AutoSize = true;
            this.building_label.BackColor = System.Drawing.Color.Transparent;
            this.building_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.building_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.building_label.Location = new System.Drawing.Point(25, 16);
            this.building_label.Name = "building_label";
            this.building_label.Size = new System.Drawing.Size(76, 19);
            this.building_label.TabIndex = 1;
            this.building_label.Text = "Building:";
            this.building_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.building_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.building_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.BackColor = System.Drawing.Color.Transparent;
            this.birthday_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.birthday_label.Location = new System.Drawing.Point(26, 59);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(85, 19);
            this.birthday_label.TabIndex = 3;
            this.birthday_label.Text = "Birth Date:";
            this.birthday_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.birthday_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.birthday_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.BackColor = System.Drawing.Color.Transparent;
            this.grade_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.grade_label.Location = new System.Drawing.Point(26, 55);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(103, 19);
            this.grade_label.TabIndex = 2;
            this.grade_label.Text = "Grade Level";
            this.grade_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.grade_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.grade_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // counselor_label
            // 
            this.counselor_label.AutoSize = true;
            this.counselor_label.BackColor = System.Drawing.Color.Transparent;
            this.counselor_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counselor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.counselor_label.Location = new System.Drawing.Point(26, 133);
            this.counselor_label.Name = "counselor_label";
            this.counselor_label.Size = new System.Drawing.Size(90, 19);
            this.counselor_label.TabIndex = 7;
            this.counselor_label.Text = "Counselor:";
            this.counselor_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.counselor_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.counselor_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // hr_label
            // 
            this.hr_label.AutoSize = true;
            this.hr_label.BackColor = System.Drawing.Color.Transparent;
            this.hr_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.hr_label.Location = new System.Drawing.Point(26, 94);
            this.hr_label.Name = "hr_label";
            this.hr_label.Size = new System.Drawing.Size(101, 19);
            this.hr_label.TabIndex = 6;
            this.hr_label.Text = "Homeroom:";
            this.hr_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.hr_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.hr_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(66, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student Overview";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.studentNameLabel);
            this.panel1.Controls.Add(this.birthday_label);
            this.panel1.Location = new System.Drawing.Point(30, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 100);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.grade_label);
            this.panel2.Controls.Add(this.counselor_label);
            this.panel2.Controls.Add(this.hr_label);
            this.panel2.Controls.Add(this.building_label);
            this.panel2.Location = new System.Drawing.Point(30, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 170);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "home";
            this.Size = new System.Drawing.Size(690, 530);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label building_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.Label counselor_label;
        private System.Windows.Forms.Label hr_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
