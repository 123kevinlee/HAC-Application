namespace HacDesktopApp
{
    partial class LoginForm
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
            this.login_button = new System.Windows.Forms.Button();
            this.Status_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CornerName = new System.Windows.Forms.Label();
            this.Username_text = new System.Windows.Forms.TextBox();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Credit = new System.Windows.Forms.Label();
            this.remember = new System.Windows.Forms.CheckBox();
            this.Reveal_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(226, 314);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 37);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_label.ForeColor = System.Drawing.Color.Red;
            this.Status_label.Location = new System.Drawing.Point(27, 326);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(59, 17);
            this.Status_label.TabIndex = 1;
            this.Status_label.Text = "FillerText";
            this.Status_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Status_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Status_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.CornerName);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 161);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // CornerName
            // 
            this.CornerName.AutoSize = true;
            this.CornerName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CornerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.CornerName.Location = new System.Drawing.Point(18, 53);
            this.CornerName.Name = "CornerName";
            this.CornerName.Size = new System.Drawing.Size(304, 56);
            this.CornerName.TabIndex = 3;
            this.CornerName.Text = "HAC Viewer";
            this.CornerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.CornerName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.CornerName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // Username_text
            // 
            this.Username_text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_text.Location = new System.Drawing.Point(132, 186);
            this.Username_text.Name = "Username_text";
            this.Username_text.Size = new System.Drawing.Size(169, 27);
            this.Username_text.TabIndex = 3;
            // 
            // Password_text
            // 
            this.Password_text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_text.Location = new System.Drawing.Point(132, 219);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(169, 27);
            this.Password_text.TabIndex = 4;
            this.Password_text.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(27, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(27, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(132, 314);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 37);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.BackColor = System.Drawing.Color.Transparent;
            this.Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit.Location = new System.Drawing.Point(238, 378);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(93, 12);
            this.Credit.TabIndex = 8;
            this.Credit.Text = "Created by Kevin Lee";
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.BackColor = System.Drawing.Color.Transparent;
            this.remember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.remember.Location = new System.Drawing.Point(30, 268);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(137, 17);
            this.remember.TabIndex = 9;
            this.remember.Text = "Remember for next time";
            this.remember.UseVisualStyleBackColor = false;
            // 
            // Reveal_button
            // 
            this.Reveal_button.BackColor = System.Drawing.Color.Transparent;
            this.Reveal_button.FlatAppearance.BorderSize = 0;
            this.Reveal_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Reveal_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reveal_button.Location = new System.Drawing.Point(226, 264);
            this.Reveal_button.Name = "Reveal_button";
            this.Reveal_button.Size = new System.Drawing.Size(75, 23);
            this.Reveal_button.TabIndex = 10;
            this.Reveal_button.Text = "Reveal Pass";
            this.Reveal_button.UseVisualStyleBackColor = false;
            this.Reveal_button.Click += new System.EventHandler(this.Reveal_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 390);
            this.Controls.Add(this.Reveal_button);
            this.Controls.Add(this.remember);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Username_text);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CornerName;
        private System.Windows.Forms.TextBox Username_text;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.CheckBox remember;
        private System.Windows.Forms.Button Reveal_button;
    }
}