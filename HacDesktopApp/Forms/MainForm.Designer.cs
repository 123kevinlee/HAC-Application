﻿namespace HacDesktopApp
{
    partial class MainForm
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.Flag = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Tools_button = new System.Windows.Forms.Button();
            this.class_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.TopRightCorner = new System.Windows.Forms.Panel();
            this.CornerName = new System.Windows.Forms.Label();
            this.classPage = new HacDesktopApp.Pages.classes();
            this.homePage = new HacDesktopApp.home();
            this.SideBar.SuspendLayout();
            this.TopRightCorner.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.SideBar.Controls.Add(this.exit_button);
            this.SideBar.Controls.Add(this.Flag);
            this.SideBar.Controls.Add(this.calendar);
            this.SideBar.Controls.Add(this.button4);
            this.SideBar.Controls.Add(this.Tools_button);
            this.SideBar.Controls.Add(this.class_button);
            this.SideBar.Controls.Add(this.home_button);
            this.SideBar.Controls.Add(this.TopRightCorner);
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(273, 548);
            this.SideBar.TabIndex = 0;
            this.SideBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.SideBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.SideBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(0, 493);
            this.exit_button.Margin = new System.Windows.Forms.Padding(0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(273, 34);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Flag
            // 
            this.Flag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.Flag.Location = new System.Drawing.Point(0, 90);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(10, 80);
            this.Flag.TabIndex = 7;
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calendar.FlatAppearance.BorderSize = 0;
            this.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.ForeColor = System.Drawing.Color.White;
            this.calendar.Location = new System.Drawing.Point(0, 413);
            this.calendar.Margin = new System.Windows.Forms.Padding(0);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(273, 80);
            this.calendar.TabIndex = 6;
            this.calendar.Text = "Calendar";
            this.calendar.UseVisualStyleBackColor = false;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            this.calendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.calendar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.calendar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 333);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 80);
            this.button4.TabIndex = 5;
            this.button4.Text = "Menu 2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // Tools_button
            // 
            this.Tools_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.Tools_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tools_button.FlatAppearance.BorderSize = 0;
            this.Tools_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tools_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_button.ForeColor = System.Drawing.Color.White;
            this.Tools_button.Location = new System.Drawing.Point(0, 253);
            this.Tools_button.Margin = new System.Windows.Forms.Padding(0);
            this.Tools_button.Name = "Tools_button";
            this.Tools_button.Size = new System.Drawing.Size(273, 80);
            this.Tools_button.TabIndex = 4;
            this.Tools_button.Text = "Tools";
            this.Tools_button.UseVisualStyleBackColor = false;
            this.Tools_button.Click += new System.EventHandler(this.Tools_button_Click);
            this.Tools_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Tools_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Tools_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // class_button
            // 
            this.class_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.class_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.class_button.FlatAppearance.BorderSize = 0;
            this.class_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_button.ForeColor = System.Drawing.Color.White;
            this.class_button.Location = new System.Drawing.Point(0, 173);
            this.class_button.Margin = new System.Windows.Forms.Padding(0);
            this.class_button.Name = "class_button";
            this.class_button.Size = new System.Drawing.Size(273, 80);
            this.class_button.TabIndex = 3;
            this.class_button.Text = "Classes";
            this.class_button.UseVisualStyleBackColor = false;
            this.class_button.Click += new System.EventHandler(this.class_button_Click);
            this.class_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.class_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.class_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.White;
            this.home_button.Location = new System.Drawing.Point(0, 93);
            this.home_button.Margin = new System.Windows.Forms.Padding(0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(273, 80);
            this.home_button.TabIndex = 2;
            this.home_button.Text = "Home Page";
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            this.home_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.home_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.home_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // TopRightCorner
            // 
            this.TopRightCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(93)))));
            this.TopRightCorner.Controls.Add(this.CornerName);
            this.TopRightCorner.Location = new System.Drawing.Point(0, -2);
            this.TopRightCorner.Name = "TopRightCorner";
            this.TopRightCorner.Size = new System.Drawing.Size(274, 100);
            this.TopRightCorner.TabIndex = 1;
            this.TopRightCorner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.TopRightCorner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.TopRightCorner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // CornerName
            // 
            this.CornerName.AutoSize = true;
            this.CornerName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CornerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.CornerName.Location = new System.Drawing.Point(34, 30);
            this.CornerName.Name = "CornerName";
            this.CornerName.Size = new System.Drawing.Size(203, 38);
            this.CornerName.TabIndex = 1;
            this.CornerName.Text = "HAC Viewer";
            this.CornerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.CornerName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.CornerName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // classPage
            // 
            this.classPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.classPage.Location = new System.Drawing.Point(266, -1);
            this.classPage.Name = "classPage";
            this.classPage.Size = new System.Drawing.Size(690, 530);
            this.classPage.TabIndex = 2;
            this.classPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.classPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.classPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homePage.Location = new System.Drawing.Point(266, -3);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(690, 530);
            this.homePage.TabIndex = 1;
            this.homePage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.homePage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.homePage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(956, 525);
            this.ControlBox = false;
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.classPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            this.SideBar.ResumeLayout(false);
            this.TopRightCorner.ResumeLayout(false);
            this.TopRightCorner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel TopRightCorner;
        private System.Windows.Forms.Label CornerName;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button calendar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Tools_button;
        private System.Windows.Forms.Button class_button;
        private System.Windows.Forms.Panel Flag;
        private System.Windows.Forms.Button exit_button;
        private home homePage;
        private Pages.classes classPage;
    }
}

