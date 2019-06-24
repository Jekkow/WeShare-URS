namespace WURS
{
    partial class Manager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Form));
            this.Load_Hours = new System.Windows.Forms.Button();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.Week_ComboBox = new System.Windows.Forms.ComboBox();
            this.Send_Hour_Button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Comment_Box_Vr = new System.Windows.Forms.TextBox();
            this.Sick_Check_Vr = new System.Windows.Forms.CheckBox();
            this.Home_Check_Vr = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Vr = new System.Windows.Forms.TextBox();
            this.Acti_Box_Vr = new System.Windows.Forms.ComboBox();
            this.Comment_Box_Do = new System.Windows.Forms.TextBox();
            this.Sick_Check_Do = new System.Windows.Forms.CheckBox();
            this.Home_Check_Do = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Do = new System.Windows.Forms.TextBox();
            this.Acti_Box_Do = new System.Windows.Forms.ComboBox();
            this.Comment_Box_Wo = new System.Windows.Forms.TextBox();
            this.Sick_Check_Wo = new System.Windows.Forms.CheckBox();
            this.Home_Check_Wo = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Wo = new System.Windows.Forms.TextBox();
            this.Acti_Box_Wo = new System.Windows.Forms.ComboBox();
            this.Comment_Box_Di = new System.Windows.Forms.TextBox();
            this.Sick_Check_Di = new System.Windows.Forms.CheckBox();
            this.Home_Check_Di = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Di = new System.Windows.Forms.TextBox();
            this.Acti_Box_Di = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Comment_Box_Ma = new System.Windows.Forms.TextBox();
            this.Hour_Box_Ma = new System.Windows.Forms.TextBox();
            this.Acti_Box_Ma = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sick_Check_Ma = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.New_Activity = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChangePass_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Add_Employee_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Exit_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogOut_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home_Check_Ma = new System.Windows.Forms.CheckBox();
            this.Employee_Box = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.GoedMon = new System.Windows.Forms.CheckBox();
            this.GoedDi = new System.Windows.Forms.CheckBox();
            this.GoedWo = new System.Windows.Forms.CheckBox();
            this.GoedDo = new System.Windows.Forms.CheckBox();
            this.GoedVr = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.WageThisWeek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_Hours
            // 
            this.Load_Hours.Location = new System.Drawing.Point(763, 25);
            this.Load_Hours.Name = "Load_Hours";
            this.Load_Hours.Size = new System.Drawing.Size(75, 21);
            this.Load_Hours.TabIndex = 79;
            this.Load_Hours.Text = "Laad Uren";
            this.Load_Hours.UseVisualStyleBackColor = true;
            this.Load_Hours.Click += new System.EventHandler(this.Load_Hours_Click);
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(714, 9);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(36, 13);
            this.WeekLabel.TabIndex = 78;
            this.WeekLabel.Text = "Week";
            // 
            // Week_ComboBox
            // 
            this.Week_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Week_ComboBox.FormattingEnabled = true;
            this.Week_ComboBox.Location = new System.Drawing.Point(717, 26);
            this.Week_ComboBox.Name = "Week_ComboBox";
            this.Week_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Week_ComboBox.TabIndex = 77;
            this.Week_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Week_ComboBox_SelectedIndexChanged);
            // 
            // Send_Hour_Button
            // 
            this.Send_Hour_Button.FlatAppearance.BorderSize = 0;
            this.Send_Hour_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_Hour_Button.Location = new System.Drawing.Point(763, 292);
            this.Send_Hour_Button.Name = "Send_Hour_Button";
            this.Send_Hour_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Hour_Button.TabIndex = 76;
            this.Send_Hour_Button.Text = "Indienen";
            this.Send_Hour_Button.UseVisualStyleBackColor = true;
            this.Send_Hour_Button.Click += new System.EventHandler(this.Send_Hour_Button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Vrijdag";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Donderdag";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Woensdag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Dinsdag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Maandag";
            // 
            // Comment_Box_Vr
            // 
            this.Comment_Box_Vr.Location = new System.Drawing.Point(583, 266);
            this.Comment_Box_Vr.Name = "Comment_Box_Vr";
            this.Comment_Box_Vr.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Vr.TabIndex = 70;
            // 
            // Sick_Check_Vr
            // 
            this.Sick_Check_Vr.AutoSize = true;
            this.Sick_Check_Vr.Location = new System.Drawing.Point(823, 269);
            this.Sick_Check_Vr.Name = "Sick_Check_Vr";
            this.Sick_Check_Vr.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Vr.TabIndex = 69;
            this.Sick_Check_Vr.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Vr
            // 
            this.Home_Check_Vr.AutoSize = true;
            this.Home_Check_Vr.Location = new System.Drawing.Point(554, 269);
            this.Home_Check_Vr.Name = "Home_Check_Vr";
            this.Home_Check_Vr.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Vr.TabIndex = 68;
            this.Home_Check_Vr.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Vr
            // 
            this.Hour_Box_Vr.Location = new System.Drawing.Point(334, 266);
            this.Hour_Box_Vr.Name = "Hour_Box_Vr";
            this.Hour_Box_Vr.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Vr.TabIndex = 67;
            // 
            // Acti_Box_Vr
            // 
            this.Acti_Box_Vr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Vr.FormattingEnabled = true;
            this.Acti_Box_Vr.Location = new System.Drawing.Point(394, 266);
            this.Acti_Box_Vr.Name = "Acti_Box_Vr";
            this.Acti_Box_Vr.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Vr.TabIndex = 66;
            // 
            // Comment_Box_Do
            // 
            this.Comment_Box_Do.Location = new System.Drawing.Point(583, 240);
            this.Comment_Box_Do.Name = "Comment_Box_Do";
            this.Comment_Box_Do.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Do.TabIndex = 65;
            // 
            // Sick_Check_Do
            // 
            this.Sick_Check_Do.AutoSize = true;
            this.Sick_Check_Do.Location = new System.Drawing.Point(823, 243);
            this.Sick_Check_Do.Name = "Sick_Check_Do";
            this.Sick_Check_Do.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Do.TabIndex = 64;
            this.Sick_Check_Do.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Do
            // 
            this.Home_Check_Do.AutoSize = true;
            this.Home_Check_Do.Location = new System.Drawing.Point(554, 243);
            this.Home_Check_Do.Name = "Home_Check_Do";
            this.Home_Check_Do.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Do.TabIndex = 63;
            this.Home_Check_Do.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Do
            // 
            this.Hour_Box_Do.Location = new System.Drawing.Point(334, 240);
            this.Hour_Box_Do.Name = "Hour_Box_Do";
            this.Hour_Box_Do.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Do.TabIndex = 62;
            // 
            // Acti_Box_Do
            // 
            this.Acti_Box_Do.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Do.FormattingEnabled = true;
            this.Acti_Box_Do.Location = new System.Drawing.Point(394, 240);
            this.Acti_Box_Do.Name = "Acti_Box_Do";
            this.Acti_Box_Do.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Do.TabIndex = 61;
            // 
            // Comment_Box_Wo
            // 
            this.Comment_Box_Wo.Location = new System.Drawing.Point(583, 214);
            this.Comment_Box_Wo.Name = "Comment_Box_Wo";
            this.Comment_Box_Wo.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Wo.TabIndex = 60;
            // 
            // Sick_Check_Wo
            // 
            this.Sick_Check_Wo.AutoSize = true;
            this.Sick_Check_Wo.Location = new System.Drawing.Point(823, 217);
            this.Sick_Check_Wo.Name = "Sick_Check_Wo";
            this.Sick_Check_Wo.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Wo.TabIndex = 59;
            this.Sick_Check_Wo.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Wo
            // 
            this.Home_Check_Wo.AutoSize = true;
            this.Home_Check_Wo.Location = new System.Drawing.Point(554, 217);
            this.Home_Check_Wo.Name = "Home_Check_Wo";
            this.Home_Check_Wo.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Wo.TabIndex = 58;
            this.Home_Check_Wo.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Wo
            // 
            this.Hour_Box_Wo.Location = new System.Drawing.Point(334, 214);
            this.Hour_Box_Wo.Name = "Hour_Box_Wo";
            this.Hour_Box_Wo.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Wo.TabIndex = 57;
            // 
            // Acti_Box_Wo
            // 
            this.Acti_Box_Wo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Wo.FormattingEnabled = true;
            this.Acti_Box_Wo.Location = new System.Drawing.Point(394, 214);
            this.Acti_Box_Wo.Name = "Acti_Box_Wo";
            this.Acti_Box_Wo.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Wo.TabIndex = 56;
            // 
            // Comment_Box_Di
            // 
            this.Comment_Box_Di.Location = new System.Drawing.Point(583, 188);
            this.Comment_Box_Di.Name = "Comment_Box_Di";
            this.Comment_Box_Di.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Di.TabIndex = 55;
            // 
            // Sick_Check_Di
            // 
            this.Sick_Check_Di.AutoSize = true;
            this.Sick_Check_Di.Location = new System.Drawing.Point(823, 191);
            this.Sick_Check_Di.Name = "Sick_Check_Di";
            this.Sick_Check_Di.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Di.TabIndex = 54;
            this.Sick_Check_Di.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Di
            // 
            this.Home_Check_Di.AutoSize = true;
            this.Home_Check_Di.Location = new System.Drawing.Point(554, 191);
            this.Home_Check_Di.Name = "Home_Check_Di";
            this.Home_Check_Di.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Di.TabIndex = 53;
            this.Home_Check_Di.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Di
            // 
            this.Hour_Box_Di.Location = new System.Drawing.Point(334, 188);
            this.Hour_Box_Di.Name = "Hour_Box_Di";
            this.Hour_Box_Di.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Di.TabIndex = 52;
            // 
            // Acti_Box_Di
            // 
            this.Acti_Box_Di.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Di.FormattingEnabled = true;
            this.Acti_Box_Di.Location = new System.Drawing.Point(394, 188);
            this.Acti_Box_Di.Name = "Acti_Box_Di";
            this.Acti_Box_Di.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Di.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Commentaar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Ziek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Thuis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Activiteit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Uren";
            // 
            // Comment_Box_Ma
            // 
            this.Comment_Box_Ma.Location = new System.Drawing.Point(583, 162);
            this.Comment_Box_Ma.Name = "Comment_Box_Ma";
            this.Comment_Box_Ma.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Ma.TabIndex = 45;
            // 
            // Hour_Box_Ma
            // 
            this.Hour_Box_Ma.Location = new System.Drawing.Point(334, 162);
            this.Hour_Box_Ma.Name = "Hour_Box_Ma";
            this.Hour_Box_Ma.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Ma.TabIndex = 42;
            this.Hour_Box_Ma.TextChanged += new System.EventHandler(this.Hour_Box_Ma_TextChanged);
            // 
            // Acti_Box_Ma
            // 
            this.Acti_Box_Ma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Ma.FormattingEnabled = true;
            this.Acti_Box_Ma.Location = new System.Drawing.Point(394, 162);
            this.Acti_Box_Ma.Name = "Acti_Box_Ma";
            this.Acti_Box_Ma.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Ma.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sick_Check_Ma
            // 
            this.Sick_Check_Ma.AutoSize = true;
            this.Sick_Check_Ma.Location = new System.Drawing.Point(823, 165);
            this.Sick_Check_Ma.Name = "Sick_Check_Ma";
            this.Sick_Check_Ma.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Ma.TabIndex = 44;
            this.Sick_Check_Ma.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.New_Activity);
            this.panel1.Controls.Add(this.ChangePass_Button);
            this.panel1.Controls.Add(this.Add_Employee_Button);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Controls.Add(this.LogOut_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 410);
            this.panel1.TabIndex = 40;
            // 
            // New_Activity
            // 
            this.New_Activity.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.New_Activity.BackColor = System.Drawing.Color.Transparent;
            this.New_Activity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.New_Activity.BorderRadius = 0;
            this.New_Activity.ButtonText = "Activiteit toevoegen";
            this.New_Activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_Activity.DisabledColor = System.Drawing.Color.Gray;
            this.New_Activity.Iconcolor = System.Drawing.Color.Transparent;
            this.New_Activity.Iconimage = null;
            this.New_Activity.Iconimage_right = null;
            this.New_Activity.Iconimage_right_Selected = null;
            this.New_Activity.Iconimage_Selected = null;
            this.New_Activity.IconMarginLeft = 0;
            this.New_Activity.IconMarginRight = 0;
            this.New_Activity.IconRightVisible = true;
            this.New_Activity.IconRightZoom = 0D;
            this.New_Activity.IconVisible = true;
            this.New_Activity.IconZoom = 90D;
            this.New_Activity.IsTab = false;
            this.New_Activity.Location = new System.Drawing.Point(0, 160);
            this.New_Activity.Name = "New_Activity";
            this.New_Activity.Normalcolor = System.Drawing.Color.Transparent;
            this.New_Activity.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.New_Activity.OnHoverTextColor = System.Drawing.Color.White;
            this.New_Activity.selected = false;
            this.New_Activity.Size = new System.Drawing.Size(220, 50);
            this.New_Activity.TabIndex = 84;
            this.New_Activity.Text = "Activiteit toevoegen";
            this.New_Activity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.New_Activity.Textcolor = System.Drawing.Color.White;
            this.New_Activity.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Activity.Click += new System.EventHandler(this.New_Activity_Click);
            // 
            // ChangePass_Button
            // 
            this.ChangePass_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangePass_Button.BackColor = System.Drawing.Color.Transparent;
            this.ChangePass_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangePass_Button.BorderRadius = 0;
            this.ChangePass_Button.ButtonText = "Wachtwoord veranderen";
            this.ChangePass_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePass_Button.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.ChangePass_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.ChangePass_Button.Iconimage = null;
            this.ChangePass_Button.Iconimage_right = null;
            this.ChangePass_Button.Iconimage_right_Selected = null;
            this.ChangePass_Button.Iconimage_Selected = null;
            this.ChangePass_Button.IconMarginLeft = 0;
            this.ChangePass_Button.IconMarginRight = 0;
            this.ChangePass_Button.IconRightVisible = true;
            this.ChangePass_Button.IconRightZoom = 0D;
            this.ChangePass_Button.IconVisible = true;
            this.ChangePass_Button.IconZoom = 90D;
            this.ChangePass_Button.IsTab = false;
            this.ChangePass_Button.Location = new System.Drawing.Point(0, 260);
            this.ChangePass_Button.Name = "ChangePass_Button";
            this.ChangePass_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.ChangePass_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangePass_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.ChangePass_Button.selected = false;
            this.ChangePass_Button.Size = new System.Drawing.Size(220, 50);
            this.ChangePass_Button.TabIndex = 83;
            this.ChangePass_Button.Text = "Wachtwoord veranderen";
            this.ChangePass_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangePass_Button.Textcolor = System.Drawing.Color.White;
            this.ChangePass_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass_Button.Click += new System.EventHandler(this.ChangePass_Button_Click);
            // 
            // Add_Employee_Button
            // 
            this.Add_Employee_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.Add_Employee_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_Employee_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Employee_Button.BorderRadius = 0;
            this.Add_Employee_Button.ButtonText = "Nieuwe medewerker";
            this.Add_Employee_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Employee_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Add_Employee_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Add_Employee_Button.Iconimage = null;
            this.Add_Employee_Button.Iconimage_right = null;
            this.Add_Employee_Button.Iconimage_right_Selected = null;
            this.Add_Employee_Button.Iconimage_Selected = null;
            this.Add_Employee_Button.IconMarginLeft = 0;
            this.Add_Employee_Button.IconMarginRight = 0;
            this.Add_Employee_Button.IconRightVisible = true;
            this.Add_Employee_Button.IconRightZoom = 0D;
            this.Add_Employee_Button.IconVisible = true;
            this.Add_Employee_Button.IconZoom = 90D;
            this.Add_Employee_Button.IsTab = false;
            this.Add_Employee_Button.Location = new System.Drawing.Point(0, 210);
            this.Add_Employee_Button.Name = "Add_Employee_Button";
            this.Add_Employee_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Add_Employee_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.Add_Employee_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Add_Employee_Button.selected = false;
            this.Add_Employee_Button.Size = new System.Drawing.Size(220, 50);
            this.Add_Employee_Button.TabIndex = 82;
            this.Add_Employee_Button.Text = "Nieuwe medewerker";
            this.Add_Employee_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Add_Employee_Button.Textcolor = System.Drawing.Color.White;
            this.Add_Employee_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Employee_Button.Click += new System.EventHandler(this.Add_Employee_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Button.BorderRadius = 0;
            this.Exit_Button.ButtonText = "Afsluiten";
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
            this.Exit_Button.Location = new System.Drawing.Point(0, 360);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Exit_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.Exit_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit_Button.selected = false;
            this.Exit_Button.Size = new System.Drawing.Size(220, 50);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "Afsluiten";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Button.Textcolor = System.Drawing.Color.White;
            this.Exit_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.LogOut_Button.BackColor = System.Drawing.Color.Transparent;
            this.LogOut_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOut_Button.BorderRadius = 0;
            this.LogOut_Button.ButtonText = "Uitloggen";
            this.LogOut_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut_Button.DisabledColor = System.Drawing.Color.Gray;
            this.LogOut_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.LogOut_Button.Iconimage = null;
            this.LogOut_Button.Iconimage_right = null;
            this.LogOut_Button.Iconimage_right_Selected = null;
            this.LogOut_Button.Iconimage_Selected = null;
            this.LogOut_Button.IconMarginLeft = 0;
            this.LogOut_Button.IconMarginRight = 0;
            this.LogOut_Button.IconRightVisible = true;
            this.LogOut_Button.IconRightZoom = 0D;
            this.LogOut_Button.IconVisible = true;
            this.LogOut_Button.IconZoom = 90D;
            this.LogOut_Button.IsTab = false;
            this.LogOut_Button.Location = new System.Drawing.Point(0, 310);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.LogOut_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.LogOut_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.LogOut_Button.selected = false;
            this.LogOut_Button.Size = new System.Drawing.Size(220, 50);
            this.LogOut_Button.TabIndex = 2;
            this.LogOut_Button.Text = "Uitloggen";
            this.LogOut_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOut_Button.Textcolor = System.Drawing.Color.White;
            this.LogOut_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // Home_Check_Ma
            // 
            this.Home_Check_Ma.AutoSize = true;
            this.Home_Check_Ma.Location = new System.Drawing.Point(554, 165);
            this.Home_Check_Ma.Name = "Home_Check_Ma";
            this.Home_Check_Ma.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Ma.TabIndex = 43;
            this.Home_Check_Ma.UseVisualStyleBackColor = true;
            // 
            // Employee_Box
            // 
            this.Employee_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_Box.FormattingEnabled = true;
            this.Employee_Box.Location = new System.Drawing.Point(522, 26);
            this.Employee_Box.Name = "Employee_Box";
            this.Employee_Box.Size = new System.Drawing.Size(172, 21);
            this.Employee_Box.TabIndex = 80;
            this.Employee_Box.SelectedIndexChanged += new System.EventHandler(this.Employee_Box_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(570, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "Medewerker";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Goed";
            // 
            // GoedMon
            // 
            this.GoedMon.AutoSize = true;
            this.GoedMon.Location = new System.Drawing.Point(234, 165);
            this.GoedMon.Name = "GoedMon";
            this.GoedMon.Size = new System.Drawing.Size(15, 14);
            this.GoedMon.TabIndex = 83;
            this.GoedMon.UseVisualStyleBackColor = true;
            // 
            // GoedDi
            // 
            this.GoedDi.AutoSize = true;
            this.GoedDi.Location = new System.Drawing.Point(234, 190);
            this.GoedDi.Name = "GoedDi";
            this.GoedDi.Size = new System.Drawing.Size(15, 14);
            this.GoedDi.TabIndex = 84;
            this.GoedDi.UseVisualStyleBackColor = true;
            // 
            // GoedWo
            // 
            this.GoedWo.AutoSize = true;
            this.GoedWo.Location = new System.Drawing.Point(234, 216);
            this.GoedWo.Name = "GoedWo";
            this.GoedWo.Size = new System.Drawing.Size(15, 14);
            this.GoedWo.TabIndex = 85;
            this.GoedWo.UseVisualStyleBackColor = true;
            // 
            // GoedDo
            // 
            this.GoedDo.AutoSize = true;
            this.GoedDo.Location = new System.Drawing.Point(234, 244);
            this.GoedDo.Name = "GoedDo";
            this.GoedDo.Size = new System.Drawing.Size(15, 14);
            this.GoedDo.TabIndex = 86;
            this.GoedDo.UseVisualStyleBackColor = true;
            // 
            // GoedVr
            // 
            this.GoedVr.AutoSize = true;
            this.GoedVr.Location = new System.Drawing.Point(234, 268);
            this.GoedVr.Name = "GoedVr";
            this.GoedVr.Size = new System.Drawing.Size(15, 14);
            this.GoedVr.TabIndex = 87;
            this.GoedVr.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(234, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 12);
            this.panel2.TabIndex = 88;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Location = new System.Drawing.Point(234, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 12);
            this.panel3.TabIndex = 89;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(234, 337);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 12);
            this.panel4.TabIndex = 90;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Afgekeurd";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 93;
            this.label15.Text = "Goedgekeurd";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(253, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 94;
            this.label16.Text = "Nog te keuren";
            // 
            // WageThisWeek
            // 
            this.WageThisWeek.AutoSize = true;
            this.WageThisWeek.Location = new System.Drawing.Point(226, 29);
            this.WageThisWeek.Name = "WageThisWeek";
            this.WageThisWeek.Size = new System.Drawing.Size(109, 13);
            this.WageThisWeek.TabIndex = 95;
            this.WageThisWeek.Text = "Kies een medewerker";
            this.WageThisWeek.Click += new System.EventHandler(this.WageThisWeek_Click);
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 410);
            this.Controls.Add(this.WageThisWeek);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GoedVr);
            this.Controls.Add(this.GoedDo);
            this.Controls.Add(this.GoedWo);
            this.Controls.Add(this.GoedDi);
            this.Controls.Add(this.GoedMon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Employee_Box);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.Week_ComboBox);
            this.Controls.Add(this.Send_Hour_Button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comment_Box_Vr);
            this.Controls.Add(this.Sick_Check_Vr);
            this.Controls.Add(this.Home_Check_Vr);
            this.Controls.Add(this.Hour_Box_Vr);
            this.Controls.Add(this.Acti_Box_Vr);
            this.Controls.Add(this.Comment_Box_Do);
            this.Controls.Add(this.Sick_Check_Do);
            this.Controls.Add(this.Home_Check_Do);
            this.Controls.Add(this.Hour_Box_Do);
            this.Controls.Add(this.Acti_Box_Do);
            this.Controls.Add(this.Comment_Box_Wo);
            this.Controls.Add(this.Sick_Check_Wo);
            this.Controls.Add(this.Home_Check_Wo);
            this.Controls.Add(this.Hour_Box_Wo);
            this.Controls.Add(this.Acti_Box_Wo);
            this.Controls.Add(this.Comment_Box_Di);
            this.Controls.Add(this.Sick_Check_Di);
            this.Controls.Add(this.Home_Check_Di);
            this.Controls.Add(this.Hour_Box_Di);
            this.Controls.Add(this.Acti_Box_Di);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Comment_Box_Ma);
            this.Controls.Add(this.Hour_Box_Ma);
            this.Controls.Add(this.Acti_Box_Ma);
            this.Controls.Add(this.Sick_Check_Ma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Home_Check_Ma);
            this.Controls.Add(this.Load_Hours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager_Form";
            this.Text = "Manager_Form";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_Hours;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.ComboBox Week_ComboBox;
        private System.Windows.Forms.Button Send_Hour_Button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Comment_Box_Vr;
        private System.Windows.Forms.CheckBox Sick_Check_Vr;
        private System.Windows.Forms.CheckBox Home_Check_Vr;
        private System.Windows.Forms.TextBox Hour_Box_Vr;
        private System.Windows.Forms.ComboBox Acti_Box_Vr;
        private System.Windows.Forms.TextBox Comment_Box_Do;
        private System.Windows.Forms.CheckBox Sick_Check_Do;
        private System.Windows.Forms.CheckBox Home_Check_Do;
        private System.Windows.Forms.TextBox Hour_Box_Do;
        private System.Windows.Forms.ComboBox Acti_Box_Do;
        private System.Windows.Forms.TextBox Comment_Box_Wo;
        private System.Windows.Forms.CheckBox Sick_Check_Wo;
        private System.Windows.Forms.CheckBox Home_Check_Wo;
        private System.Windows.Forms.TextBox Hour_Box_Wo;
        private System.Windows.Forms.ComboBox Acti_Box_Wo;
        private System.Windows.Forms.TextBox Comment_Box_Di;
        private System.Windows.Forms.CheckBox Sick_Check_Di;
        private System.Windows.Forms.CheckBox Home_Check_Di;
        private System.Windows.Forms.TextBox Hour_Box_Di;
        private System.Windows.Forms.ComboBox Acti_Box_Di;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Comment_Box_Ma;
        private System.Windows.Forms.TextBox Hour_Box_Ma;
        private System.Windows.Forms.ComboBox Acti_Box_Ma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Sick_Check_Ma;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_Button;
        private Bunifu.Framework.UI.BunifuFlatButton LogOut_Button;
        private System.Windows.Forms.CheckBox Home_Check_Ma;
        private System.Windows.Forms.ComboBox Employee_Box;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton Add_Employee_Button;
        private System.Windows.Forms.CheckBox GoedVr;
        private System.Windows.Forms.CheckBox GoedDo;
        private System.Windows.Forms.CheckBox GoedWo;
        private System.Windows.Forms.CheckBox GoedDi;
        private System.Windows.Forms.CheckBox GoedMon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuFlatButton ChangePass_Button;
        private Bunifu.Framework.UI.BunifuFlatButton New_Activity;
        private System.Windows.Forms.Label WageThisWeek;
    }
}