namespace WURS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Username = new Bunifu.Framework.UI.BunifuTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Silver;
            this.Username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Username.BackgroundImage")));
            this.Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Username.ForeColor = System.Drawing.Color.SeaGreen;
            this.Username.Icon = ((System.Drawing.Image)(resources.GetObject("Username.Icon")));
            this.Username.Location = new System.Drawing.Point(277, 152);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(250, 42);
            this.Username.TabIndex = 2;
            this.Username.text = "Username";
            this.Username.OnTextChange += new System.EventHandler(this.Username_OnTextChange);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Silver;
            this.Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password.BackgroundImage")));
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Password.ForeColor = System.Drawing.Color.SeaGreen;
            this.Password.Icon = ((System.Drawing.Image)(resources.GetObject("Password.Icon")));
            this.Password.Location = new System.Drawing.Point(277, 209);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(250, 42);
            this.Password.TabIndex = 3;
            this.Password.text = "Password";
            this.Password.OnTextChange += new System.EventHandler(this.Password_OnTextChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuTextbox Username;
        private Bunifu.Framework.UI.BunifuTextbox Password;
    }
}

