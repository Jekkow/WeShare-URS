namespace WURS
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.Login_Button = new System.Windows.Forms.Button();
            this.Username_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_Visable = new Bunifu.Framework.UI.BunifuImageButton();
            this.LoginAttempt = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Exit_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Visable)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.White;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Location = new System.Drawing.Point(55, 314);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(207, 35);
            this.Login_Button.TabIndex = 1;
            this.Login_Button.Text = "Log in";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Username_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username_Textbox.HintForeColor = System.Drawing.Color.Empty;
            this.Username_Textbox.HintText = "";
            this.Username_Textbox.isPassword = false;
            this.Username_Textbox.LineFocusedColor = System.Drawing.Color.DimGray;
            this.Username_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.Username_Textbox.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.Username_Textbox.LineThickness = 3;
            this.Username_Textbox.Location = new System.Drawing.Point(55, 165);
            this.Username_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(210, 45);
            this.Username_Textbox.TabIndex = 5;
            this.Username_Textbox.Text = "Gebruikersnaam";
            this.Username_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username_Textbox.Enter += new System.EventHandler(this.Username_Enter);
            this.Username_Textbox.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_Textbox.HintForeColor = System.Drawing.Color.Empty;
            this.Password_Textbox.HintText = "";
            this.Password_Textbox.isPassword = false;
            this.Password_Textbox.LineFocusedColor = System.Drawing.Color.DimGray;
            this.Password_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.Password_Textbox.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.Password_Textbox.LineThickness = 3;
            this.Password_Textbox.Location = new System.Drawing.Point(55, 235);
            this.Password_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(210, 45);
            this.Password_Textbox.TabIndex = 6;
            this.Password_Textbox.Text = "Wachtwoord";
            this.Password_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_Textbox.Enter += new System.EventHandler(this.Password_Enter);
            this.Password_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.Password_Textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            this.Password_Textbox.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Password_Visable
            // 
            this.Password_Visable.BackColor = System.Drawing.Color.Transparent;
            this.Password_Visable.Image = ((System.Drawing.Image)(resources.GetObject("Password_Visable.Image")));
            this.Password_Visable.ImageActive = null;
            this.Password_Visable.Location = new System.Drawing.Point(275, 245);
            this.Password_Visable.Name = "Password_Visable";
            this.Password_Visable.Size = new System.Drawing.Size(25, 25);
            this.Password_Visable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Password_Visable.TabIndex = 8;
            this.Password_Visable.TabStop = false;
            this.Password_Visable.Zoom = 10;
            this.Password_Visable.Click += new System.EventHandler(this.Password_Visable_Click);
            // 
            // LoginAttempt
            // 
            this.LoginAttempt.BackColor = System.Drawing.Color.Transparent;
            this.LoginAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAttempt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginAttempt.Location = new System.Drawing.Point(1, 420);
            this.LoginAttempt.Name = "LoginAttempt";
            this.LoginAttempt.Size = new System.Drawing.Size(322, 23);
            this.LoginAttempt.TabIndex = 9;
            this.LoginAttempt.Text = "label1";
            this.LoginAttempt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginAttempt.Click += new System.EventHandler(this.LoginAttempt_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
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
            this.Exit_Button.Location = new System.Drawing.Point(290, 0);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Normalcolor = System.Drawing.Color.Red;
            this.Exit_Button.OnHovercolor = System.Drawing.Color.DarkRed;
            this.Exit_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit_Button.selected = false;
            this.Exit_Button.Size = new System.Drawing.Size(35, 35);
            this.Exit_Button.TabIndex = 10;
            this.Exit_Button.Text = "X";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Button.Textcolor = System.Drawing.Color.White;
            this.Exit_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(324, 481);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.LoginAttempt);
            this.Controls.Add(this.Password_Visable);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Controls.Add(this.Login_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Password_Visable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Login_Button;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username_Textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_Textbox;
        private Bunifu.Framework.UI.BunifuImageButton Password_Visable;
        private System.Windows.Forms.Label LoginAttempt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_Button;
    }
}

