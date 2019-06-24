namespace WURS
{
    partial class Add_Employee_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Employee_Form));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Employee_FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_MiddleName_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_FamilyName_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_Email_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_ContractHour_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_HourWage_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_Distance_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_Intern_CheckBox = new System.Windows.Forms.CheckBox();
            this.Add_Employee_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Employee_Manager_ComboBox = new System.Windows.Forms.ComboBox();
            this.Employee_Function_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tussenvoegsel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Functie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Intern";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reisafstand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Uurloon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Urencontract";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Manager";
            // 
            // Employee_FirstName_TextBox
            // 
            this.Employee_FirstName_TextBox.Location = new System.Drawing.Point(23, 61);
            this.Employee_FirstName_TextBox.Name = "Employee_FirstName_TextBox";
            this.Employee_FirstName_TextBox.Size = new System.Drawing.Size(173, 20);
            this.Employee_FirstName_TextBox.TabIndex = 10;
            // 
            // Employee_MiddleName_TextBox
            // 
            this.Employee_MiddleName_TextBox.Location = new System.Drawing.Point(23, 87);
            this.Employee_MiddleName_TextBox.Name = "Employee_MiddleName_TextBox";
            this.Employee_MiddleName_TextBox.Size = new System.Drawing.Size(173, 20);
            this.Employee_MiddleName_TextBox.TabIndex = 11;
            // 
            // Employee_FamilyName_TextBox
            // 
            this.Employee_FamilyName_TextBox.Location = new System.Drawing.Point(23, 114);
            this.Employee_FamilyName_TextBox.Name = "Employee_FamilyName_TextBox";
            this.Employee_FamilyName_TextBox.Size = new System.Drawing.Size(173, 20);
            this.Employee_FamilyName_TextBox.TabIndex = 12;
            // 
            // Employee_Email_TextBox
            // 
            this.Employee_Email_TextBox.Location = new System.Drawing.Point(23, 142);
            this.Employee_Email_TextBox.Name = "Employee_Email_TextBox";
            this.Employee_Email_TextBox.Size = new System.Drawing.Size(173, 20);
            this.Employee_Email_TextBox.TabIndex = 13;
            // 
            // Employee_ContractHour_TextBox
            // 
            this.Employee_ContractHour_TextBox.Location = new System.Drawing.Point(23, 220);
            this.Employee_ContractHour_TextBox.Name = "Employee_ContractHour_TextBox";
            this.Employee_ContractHour_TextBox.Size = new System.Drawing.Size(173, 20);
            this.Employee_ContractHour_TextBox.TabIndex = 16;
            // 
            // Employee_HourWage_TextBox
            // 
            this.Employee_HourWage_TextBox.Location = new System.Drawing.Point(23, 246);
            this.Employee_HourWage_TextBox.Name = "Employee_HourWage_TextBox";
            this.Employee_HourWage_TextBox.Size = new System.Drawing.Size(173, 20);
            this.Employee_HourWage_TextBox.TabIndex = 17;
            // 
            // Employee_Distance_TextBox
            // 
            this.Employee_Distance_TextBox.Location = new System.Drawing.Point(23, 271);
            this.Employee_Distance_TextBox.Name = "Employee_Distance_TextBox";
            this.Employee_Distance_TextBox.Size = new System.Drawing.Size(173, 20);
            this.Employee_Distance_TextBox.TabIndex = 18;
            // 
            // Employee_Intern_CheckBox
            // 
            this.Employee_Intern_CheckBox.AutoSize = true;
            this.Employee_Intern_CheckBox.Location = new System.Drawing.Point(182, 297);
            this.Employee_Intern_CheckBox.Name = "Employee_Intern_CheckBox";
            this.Employee_Intern_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.Employee_Intern_CheckBox.TabIndex = 19;
            this.Employee_Intern_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Add_Employee_Button
            // 
            this.Add_Employee_Button.Location = new System.Drawing.Point(23, 350);
            this.Add_Employee_Button.Name = "Add_Employee_Button";
            this.Add_Employee_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Employee_Button.TabIndex = 20;
            this.Add_Employee_Button.Text = "Aanmaken";
            this.Add_Employee_Button.UseVisualStyleBackColor = true;
            this.Add_Employee_Button.Click += new System.EventHandler(this.Add_Employee_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Activecolor = System.Drawing.Color.Red;
            this.Exit_Button.BackColor = System.Drawing.Color.Red;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Button.BorderRadius = 0;
            this.Exit_Button.ButtonText = "X";
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit_Button.Iconimage = null;
            this.Exit_Button.Iconimage_right = null;
            this.Exit_Button.Iconimage_right_Selected = null;
            this.Exit_Button.Iconimage_Selected = null;
            this.Exit_Button.IconMarginLeft = 0;
            this.Exit_Button.IconMarginRight = 0;
            this.Exit_Button.IconRightVisible = true;
            this.Exit_Button.IconRightZoom = 0D;
            this.Exit_Button.IconVisible = true;
            this.Exit_Button.IconZoom = 90D;
            this.Exit_Button.IsTab = false;
            this.Exit_Button.Location = new System.Drawing.Point(295, 0);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Normalcolor = System.Drawing.Color.Red;
            this.Exit_Button.OnHovercolor = System.Drawing.Color.DarkRed;
            this.Exit_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit_Button.selected = false;
            this.Exit_Button.Size = new System.Drawing.Size(35, 35);
            this.Exit_Button.TabIndex = 21;
            this.Exit_Button.Text = "X";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Button.Textcolor = System.Drawing.Color.White;
            this.Exit_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Employee_Manager_ComboBox
            // 
            this.Employee_Manager_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_Manager_ComboBox.FormattingEnabled = true;
            this.Employee_Manager_ComboBox.Location = new System.Drawing.Point(23, 194);
            this.Employee_Manager_ComboBox.Name = "Employee_Manager_ComboBox";
            this.Employee_Manager_ComboBox.Size = new System.Drawing.Size(173, 21);
            this.Employee_Manager_ComboBox.TabIndex = 22;
            // 
            // Employee_Function_ComboBox
            // 
            this.Employee_Function_ComboBox.AllowDrop = true;
            this.Employee_Function_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_Function_ComboBox.FormattingEnabled = true;
            this.Employee_Function_ComboBox.Location = new System.Drawing.Point(23, 168);
            this.Employee_Function_ComboBox.Name = "Employee_Function_ComboBox";
            this.Employee_Function_ComboBox.Size = new System.Drawing.Size(173, 21);
            this.Employee_Function_ComboBox.TabIndex = 23;
            this.Employee_Function_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Employee_Function_ComboBox_SelectedIndexChanged);
            // 
            // Add_Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.Employee_Function_ComboBox);
            this.Controls.Add(this.Employee_Manager_ComboBox);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Add_Employee_Button);
            this.Controls.Add(this.Employee_Intern_CheckBox);
            this.Controls.Add(this.Employee_Distance_TextBox);
            this.Controls.Add(this.Employee_HourWage_TextBox);
            this.Controls.Add(this.Employee_ContractHour_TextBox);
            this.Controls.Add(this.Employee_Email_TextBox);
            this.Controls.Add(this.Employee_FamilyName_TextBox);
            this.Controls.Add(this.Employee_MiddleName_TextBox);
            this.Controls.Add(this.Employee_FirstName_TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Employee_Form";
            this.Text = "Add_Employee_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button Add_Employee_Button;
        private System.Windows.Forms.CheckBox Employee_Intern_CheckBox;
        private System.Windows.Forms.TextBox Employee_Distance_TextBox;
        private System.Windows.Forms.TextBox Employee_HourWage_TextBox;
        private System.Windows.Forms.TextBox Employee_ContractHour_TextBox;
        private System.Windows.Forms.TextBox Employee_Email_TextBox;
        private System.Windows.Forms.TextBox Employee_FamilyName_TextBox;
        private System.Windows.Forms.TextBox Employee_MiddleName_TextBox;
        private System.Windows.Forms.TextBox Employee_FirstName_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_Button;
        private System.Windows.Forms.ComboBox Employee_Manager_ComboBox;
        private System.Windows.Forms.ComboBox Employee_Function_ComboBox;
    }
}