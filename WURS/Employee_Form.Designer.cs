namespace WURS
{
    partial class Employee_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogOut_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChangePass_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Acti_Box_Ma = new System.Windows.Forms.ComboBox();
            this.Hour_Box_Ma = new System.Windows.Forms.TextBox();
            this.Home_Check_Ma = new System.Windows.Forms.CheckBox();
            this.Sick_Check_Ma = new System.Windows.Forms.CheckBox();
            this.Comment_Box_Ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Comment_Box_Di = new System.Windows.Forms.TextBox();
            this.Sick_Check_Di = new System.Windows.Forms.CheckBox();
            this.Home_Check_Di = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Di = new System.Windows.Forms.TextBox();
            this.Acti_Box_Di = new System.Windows.Forms.ComboBox();
            this.Comment_Box_Wo = new System.Windows.Forms.TextBox();
            this.Sick_Check_Wo = new System.Windows.Forms.CheckBox();
            this.Home_Check_Wo = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Wo = new System.Windows.Forms.TextBox();
            this.Acti_Box_Wo = new System.Windows.Forms.ComboBox();
            this.Comment_Box_Do = new System.Windows.Forms.TextBox();
            this.Sick_Check_Do = new System.Windows.Forms.CheckBox();
            this.Home_Check_Do = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Do = new System.Windows.Forms.TextBox();
            this.Acti_Box_Do = new System.Windows.Forms.ComboBox();
            this.Comment_Box_Vr = new System.Windows.Forms.TextBox();
            this.Sick_Check_Vr = new System.Windows.Forms.CheckBox();
            this.Home_Check_Vr = new System.Windows.Forms.CheckBox();
            this.Hour_Box_Vr = new System.Windows.Forms.TextBox();
            this.Acti_Box_Vr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Send_Hour_Button = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Week_ComboBox = new System.Windows.Forms.ComboBox();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.Load_Hours = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HoursWorkedThisWeek = new System.Windows.Forms.Label();
            this.MoneyEarnedThisWeek = new System.Windows.Forms.Label();
            this.HoursWorkedWeek = new System.Windows.Forms.Label();
            this.HoursWorkedWeekBG = new System.Windows.Forms.Panel();
            this.MoneyEarnedWeekBG = new System.Windows.Forms.Panel();
            this.MoneyEarnedWeek = new System.Windows.Forms.Label();
            this.RapportenText = new System.Windows.Forms.Label();
            this.Rapporten_ComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HoursWorkedWeekBG.SuspendLayout();
            this.MoneyEarnedWeekBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.MoneyEarnedThisWeek);
            this.panel1.Controls.Add(this.HoursWorkedThisWeek);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Controls.Add(this.LogOut_Button);
            this.panel1.Controls.Add(this.ChangePass_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 410);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.ChangePass_Button.TabIndex = 1;
            this.ChangePass_Button.Text = "Wachtwoord veranderen";
            this.ChangePass_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangePass_Button.Textcolor = System.Drawing.Color.White;
            this.ChangePass_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass_Button.Click += new System.EventHandler(this.ChangePass_Button_Click);
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
            // Acti_Box_Ma
            // 
            this.Acti_Box_Ma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Ma.FormattingEnabled = true;
            this.Acti_Box_Ma.Location = new System.Drawing.Point(383, 162);
            this.Acti_Box_Ma.Name = "Acti_Box_Ma";
            this.Acti_Box_Ma.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Ma.TabIndex = 1;
            // 
            // Hour_Box_Ma
            // 
            this.Hour_Box_Ma.Location = new System.Drawing.Point(323, 162);
            this.Hour_Box_Ma.Name = "Hour_Box_Ma";
            this.Hour_Box_Ma.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Ma.TabIndex = 2;
            this.Hour_Box_Ma.TextChanged += new System.EventHandler(this.Hour_Box_Ma_TextChanged);
            // 
            // Home_Check_Ma
            // 
            this.Home_Check_Ma.AutoSize = true;
            this.Home_Check_Ma.Location = new System.Drawing.Point(543, 165);
            this.Home_Check_Ma.Name = "Home_Check_Ma";
            this.Home_Check_Ma.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Ma.TabIndex = 3;
            this.Home_Check_Ma.UseVisualStyleBackColor = true;
            // 
            // Sick_Check_Ma
            // 
            this.Sick_Check_Ma.AutoSize = true;
            this.Sick_Check_Ma.Location = new System.Drawing.Point(812, 165);
            this.Sick_Check_Ma.Name = "Sick_Check_Ma";
            this.Sick_Check_Ma.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Ma.TabIndex = 4;
            this.Sick_Check_Ma.UseVisualStyleBackColor = true;
            // 
            // Comment_Box_Ma
            // 
            this.Comment_Box_Ma.Location = new System.Drawing.Point(572, 162);
            this.Comment_Box_Ma.Name = "Comment_Box_Ma";
            this.Comment_Box_Ma.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Ma.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Activiteit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thuis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ziek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Commentaar";
            // 
            // Comment_Box_Di
            // 
            this.Comment_Box_Di.Location = new System.Drawing.Point(572, 188);
            this.Comment_Box_Di.Name = "Comment_Box_Di";
            this.Comment_Box_Di.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Di.TabIndex = 15;
            // 
            // Sick_Check_Di
            // 
            this.Sick_Check_Di.AutoSize = true;
            this.Sick_Check_Di.Location = new System.Drawing.Point(812, 191);
            this.Sick_Check_Di.Name = "Sick_Check_Di";
            this.Sick_Check_Di.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Di.TabIndex = 14;
            this.Sick_Check_Di.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Di
            // 
            this.Home_Check_Di.AutoSize = true;
            this.Home_Check_Di.Location = new System.Drawing.Point(543, 191);
            this.Home_Check_Di.Name = "Home_Check_Di";
            this.Home_Check_Di.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Di.TabIndex = 13;
            this.Home_Check_Di.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Di
            // 
            this.Hour_Box_Di.Location = new System.Drawing.Point(323, 188);
            this.Hour_Box_Di.Name = "Hour_Box_Di";
            this.Hour_Box_Di.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Di.TabIndex = 12;
            // 
            // Acti_Box_Di
            // 
            this.Acti_Box_Di.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Di.FormattingEnabled = true;
            this.Acti_Box_Di.Location = new System.Drawing.Point(383, 188);
            this.Acti_Box_Di.Name = "Acti_Box_Di";
            this.Acti_Box_Di.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Di.TabIndex = 11;
            // 
            // Comment_Box_Wo
            // 
            this.Comment_Box_Wo.Location = new System.Drawing.Point(572, 214);
            this.Comment_Box_Wo.Name = "Comment_Box_Wo";
            this.Comment_Box_Wo.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Wo.TabIndex = 20;
            // 
            // Sick_Check_Wo
            // 
            this.Sick_Check_Wo.AutoSize = true;
            this.Sick_Check_Wo.Location = new System.Drawing.Point(812, 217);
            this.Sick_Check_Wo.Name = "Sick_Check_Wo";
            this.Sick_Check_Wo.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Wo.TabIndex = 19;
            this.Sick_Check_Wo.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Wo
            // 
            this.Home_Check_Wo.AutoSize = true;
            this.Home_Check_Wo.Location = new System.Drawing.Point(543, 217);
            this.Home_Check_Wo.Name = "Home_Check_Wo";
            this.Home_Check_Wo.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Wo.TabIndex = 18;
            this.Home_Check_Wo.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Wo
            // 
            this.Hour_Box_Wo.Location = new System.Drawing.Point(323, 214);
            this.Hour_Box_Wo.Name = "Hour_Box_Wo";
            this.Hour_Box_Wo.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Wo.TabIndex = 17;
            // 
            // Acti_Box_Wo
            // 
            this.Acti_Box_Wo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Wo.FormattingEnabled = true;
            this.Acti_Box_Wo.Location = new System.Drawing.Point(383, 214);
            this.Acti_Box_Wo.Name = "Acti_Box_Wo";
            this.Acti_Box_Wo.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Wo.TabIndex = 16;
            // 
            // Comment_Box_Do
            // 
            this.Comment_Box_Do.Location = new System.Drawing.Point(572, 240);
            this.Comment_Box_Do.Name = "Comment_Box_Do";
            this.Comment_Box_Do.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Do.TabIndex = 25;
            // 
            // Sick_Check_Do
            // 
            this.Sick_Check_Do.AutoSize = true;
            this.Sick_Check_Do.Location = new System.Drawing.Point(812, 243);
            this.Sick_Check_Do.Name = "Sick_Check_Do";
            this.Sick_Check_Do.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Do.TabIndex = 24;
            this.Sick_Check_Do.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Do
            // 
            this.Home_Check_Do.AutoSize = true;
            this.Home_Check_Do.Location = new System.Drawing.Point(543, 243);
            this.Home_Check_Do.Name = "Home_Check_Do";
            this.Home_Check_Do.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Do.TabIndex = 23;
            this.Home_Check_Do.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Do
            // 
            this.Hour_Box_Do.Location = new System.Drawing.Point(323, 240);
            this.Hour_Box_Do.Name = "Hour_Box_Do";
            this.Hour_Box_Do.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Do.TabIndex = 22;
            // 
            // Acti_Box_Do
            // 
            this.Acti_Box_Do.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Do.FormattingEnabled = true;
            this.Acti_Box_Do.Location = new System.Drawing.Point(383, 240);
            this.Acti_Box_Do.Name = "Acti_Box_Do";
            this.Acti_Box_Do.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Do.TabIndex = 21;
            // 
            // Comment_Box_Vr
            // 
            this.Comment_Box_Vr.Location = new System.Drawing.Point(572, 266);
            this.Comment_Box_Vr.Name = "Comment_Box_Vr";
            this.Comment_Box_Vr.Size = new System.Drawing.Size(226, 20);
            this.Comment_Box_Vr.TabIndex = 30;
            // 
            // Sick_Check_Vr
            // 
            this.Sick_Check_Vr.AutoSize = true;
            this.Sick_Check_Vr.Location = new System.Drawing.Point(812, 269);
            this.Sick_Check_Vr.Name = "Sick_Check_Vr";
            this.Sick_Check_Vr.Size = new System.Drawing.Size(15, 14);
            this.Sick_Check_Vr.TabIndex = 29;
            this.Sick_Check_Vr.UseVisualStyleBackColor = true;
            // 
            // Home_Check_Vr
            // 
            this.Home_Check_Vr.AutoSize = true;
            this.Home_Check_Vr.Location = new System.Drawing.Point(543, 269);
            this.Home_Check_Vr.Name = "Home_Check_Vr";
            this.Home_Check_Vr.Size = new System.Drawing.Size(15, 14);
            this.Home_Check_Vr.TabIndex = 28;
            this.Home_Check_Vr.UseVisualStyleBackColor = true;
            // 
            // Hour_Box_Vr
            // 
            this.Hour_Box_Vr.Location = new System.Drawing.Point(323, 266);
            this.Hour_Box_Vr.Name = "Hour_Box_Vr";
            this.Hour_Box_Vr.Size = new System.Drawing.Size(50, 20);
            this.Hour_Box_Vr.TabIndex = 27;
            // 
            // Acti_Box_Vr
            // 
            this.Acti_Box_Vr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acti_Box_Vr.FormattingEnabled = true;
            this.Acti_Box_Vr.Location = new System.Drawing.Point(383, 266);
            this.Acti_Box_Vr.Name = "Acti_Box_Vr";
            this.Acti_Box_Vr.Size = new System.Drawing.Size(150, 21);
            this.Acti_Box_Vr.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Maandag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Dinsdag";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Woensdag";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Donderdag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Vrijdag";
            // 
            // Send_Hour_Button
            // 
            this.Send_Hour_Button.FlatAppearance.BorderSize = 0;
            this.Send_Hour_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_Hour_Button.Location = new System.Drawing.Point(752, 292);
            this.Send_Hour_Button.Name = "Send_Hour_Button";
            this.Send_Hour_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Hour_Button.TabIndex = 36;
            this.Send_Hour_Button.Text = "Indienen";
            this.Send_Hour_Button.UseVisualStyleBackColor = true;
            this.Send_Hour_Button.Click += new System.EventHandler(this.Send_Hour_Button_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Week_ComboBox
            // 
            this.Week_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Week_ComboBox.FormattingEnabled = true;
            this.Week_ComboBox.Location = new System.Drawing.Point(323, 82);
            this.Week_ComboBox.Name = "Week_ComboBox";
            this.Week_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Week_ComboBox.TabIndex = 37;
            this.Week_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Week_ComboBox_SelectedIndexChanged);
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(285, 86);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(36, 13);
            this.WeekLabel.TabIndex = 38;
            this.WeekLabel.Text = "Week";
            // 
            // Load_Hours
            // 
            this.Load_Hours.Location = new System.Drawing.Point(345, 82);
            this.Load_Hours.Name = "Load_Hours";
            this.Load_Hours.Size = new System.Drawing.Size(75, 21);
            this.Load_Hours.TabIndex = 39;
            this.Load_Hours.Text = "Laad Uren";
            this.Load_Hours.UseVisualStyleBackColor = true;
            this.Load_Hours.Click += new System.EventHandler(this.Load_Hours_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(255, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 100;
            this.label16.Text = "Nog te keuren";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 99;
            this.label15.Text = "Goedgekeurd";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "Afgekeurd";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Location = new System.Drawing.Point(236, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 12);
            this.panel3.TabIndex = 96;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(236, 339);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 12);
            this.panel4.TabIndex = 97;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(236, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 12);
            this.panel2.TabIndex = 95;
            // 
            // HoursWorkedThisWeek
            // 
            this.HoursWorkedThisWeek.AutoSize = true;
            this.HoursWorkedThisWeek.ForeColor = System.Drawing.Color.White;
            this.HoursWorkedThisWeek.Location = new System.Drawing.Point(86, 114);
            this.HoursWorkedThisWeek.Name = "HoursWorkedThisWeek";
            this.HoursWorkedThisWeek.Size = new System.Drawing.Size(0, 13);
            this.HoursWorkedThisWeek.TabIndex = 101;
            // 
            // MoneyEarnedThisWeek
            // 
            this.MoneyEarnedThisWeek.AutoSize = true;
            this.MoneyEarnedThisWeek.ForeColor = System.Drawing.Color.White;
            this.MoneyEarnedThisWeek.Location = new System.Drawing.Point(86, 137);
            this.MoneyEarnedThisWeek.Name = "MoneyEarnedThisWeek";
            this.MoneyEarnedThisWeek.Size = new System.Drawing.Size(0, 13);
            this.MoneyEarnedThisWeek.TabIndex = 102;
            // 
            // HoursWorkedWeek
            // 
            this.HoursWorkedWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedWeek.Location = new System.Drawing.Point(3, 8);
            this.HoursWorkedWeek.Name = "HoursWorkedWeek";
            this.HoursWorkedWeek.Size = new System.Drawing.Size(188, 23);
            this.HoursWorkedWeek.TabIndex = 101;
            this.HoursWorkedWeek.Text = "Uren";
            this.HoursWorkedWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoursWorkedWeekBG
            // 
            this.HoursWorkedWeekBG.BackColor = System.Drawing.Color.Ivory;
            this.HoursWorkedWeekBG.Controls.Add(this.HoursWorkedWeek);
            this.HoursWorkedWeekBG.Location = new System.Drawing.Point(323, 24);
            this.HoursWorkedWeekBG.Name = "HoursWorkedWeekBG";
            this.HoursWorkedWeekBG.Size = new System.Drawing.Size(194, 39);
            this.HoursWorkedWeekBG.TabIndex = 101;
            // 
            // MoneyEarnedWeekBG
            // 
            this.MoneyEarnedWeekBG.BackColor = System.Drawing.Color.Ivory;
            this.MoneyEarnedWeekBG.Controls.Add(this.MoneyEarnedWeek);
            this.MoneyEarnedWeekBG.Location = new System.Drawing.Point(575, 24);
            this.MoneyEarnedWeekBG.Name = "MoneyEarnedWeekBG";
            this.MoneyEarnedWeekBG.Size = new System.Drawing.Size(194, 39);
            this.MoneyEarnedWeekBG.TabIndex = 102;
            // 
            // MoneyEarnedWeek
            // 
            this.MoneyEarnedWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyEarnedWeek.Location = new System.Drawing.Point(3, 8);
            this.MoneyEarnedWeek.Name = "MoneyEarnedWeek";
            this.MoneyEarnedWeek.Size = new System.Drawing.Size(188, 23);
            this.MoneyEarnedWeek.TabIndex = 104;
            this.MoneyEarnedWeek.Text = "Verdient";
            this.MoneyEarnedWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RapportenText
            // 
            this.RapportenText.AutoSize = true;
            this.RapportenText.Location = new System.Drawing.Point(572, 86);
            this.RapportenText.Name = "RapportenText";
            this.RapportenText.Size = new System.Drawing.Size(45, 13);
            this.RapportenText.TabIndex = 103;
            this.RapportenText.Text = "Rapport";
            // 
            // Rapporten_ComboBox
            // 
            this.Rapporten_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rapporten_ComboBox.FormattingEnabled = true;
            this.Rapporten_ComboBox.Location = new System.Drawing.Point(624, 82);
            this.Rapporten_ComboBox.Name = "Rapporten_ComboBox";
            this.Rapporten_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Rapporten_ComboBox.TabIndex = 104;
            this.Rapporten_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Rapporten_ComboBox_SelectedIndexChanged);
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 410);
            this.Controls.Add(this.Rapporten_ComboBox);
            this.Controls.Add(this.RapportenText);
            this.Controls.Add(this.MoneyEarnedWeekBG);
            this.Controls.Add(this.HoursWorkedWeekBG);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
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
            this.Controls.Add(this.Sick_Check_Ma);
            this.Controls.Add(this.Home_Check_Ma);
            this.Controls.Add(this.Hour_Box_Ma);
            this.Controls.Add(this.Acti_Box_Ma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Load_Hours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_Form";
            this.Text = "Employee_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HoursWorkedWeekBG.ResumeLayout(false);
            this.MoneyEarnedWeekBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton ChangePass_Button;
        private System.Windows.Forms.ComboBox Acti_Box_Ma;
        private System.Windows.Forms.TextBox Hour_Box_Ma;
        private System.Windows.Forms.CheckBox Home_Check_Ma;
        private System.Windows.Forms.CheckBox Sick_Check_Ma;
        private System.Windows.Forms.TextBox Comment_Box_Ma;
        private Bunifu.Framework.UI.BunifuFlatButton LogOut_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Comment_Box_Di;
        private System.Windows.Forms.CheckBox Sick_Check_Di;
        private System.Windows.Forms.CheckBox Home_Check_Di;
        private System.Windows.Forms.TextBox Hour_Box_Di;
        private System.Windows.Forms.ComboBox Acti_Box_Di;
        private System.Windows.Forms.TextBox Comment_Box_Wo;
        private System.Windows.Forms.CheckBox Sick_Check_Wo;
        private System.Windows.Forms.CheckBox Home_Check_Wo;
        private System.Windows.Forms.TextBox Hour_Box_Wo;
        private System.Windows.Forms.ComboBox Acti_Box_Wo;
        private System.Windows.Forms.TextBox Comment_Box_Do;
        private System.Windows.Forms.CheckBox Sick_Check_Do;
        private System.Windows.Forms.CheckBox Home_Check_Do;
        private System.Windows.Forms.TextBox Hour_Box_Do;
        private System.Windows.Forms.ComboBox Acti_Box_Do;
        private System.Windows.Forms.TextBox Comment_Box_Vr;
        private System.Windows.Forms.CheckBox Sick_Check_Vr;
        private System.Windows.Forms.CheckBox Home_Check_Vr;
        private System.Windows.Forms.TextBox Hour_Box_Vr;
        private System.Windows.Forms.ComboBox Acti_Box_Vr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Send_Hour_Button;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_Button;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.ComboBox Week_ComboBox;
        private System.Windows.Forms.Button Load_Hours;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MoneyEarnedThisWeek;
        private System.Windows.Forms.Label HoursWorkedThisWeek;
        private System.Windows.Forms.Label HoursWorkedWeek;
        private System.Windows.Forms.Panel MoneyEarnedWeekBG;
        private System.Windows.Forms.Label MoneyEarnedWeek;
        private System.Windows.Forms.Panel HoursWorkedWeekBG;
        private System.Windows.Forms.Label RapportenText;
        private System.Windows.Forms.ComboBox Rapporten_ComboBox;
    }
}