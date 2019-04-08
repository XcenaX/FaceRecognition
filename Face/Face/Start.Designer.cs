namespace Face
{
    partial class Start
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.BackColor = System.Drawing.Color.DimGray;
            this.cameraBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cameraBox.Location = new System.Drawing.Point(247, 30);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(300, 280);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            this.cameraBox.UseWaitCursor = true;
            this.cameraBox.Visible = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Gray;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.Location = new System.Drawing.Point(279, 396);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(90, 30);
            this.Login.TabIndex = 3;
            this.Login.Text = "Войти";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Gray;
            this.Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Register.Location = new System.Drawing.Point(412, 396);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(85, 30);
            this.Register.TabIndex = 4;
            this.Register.Text = "Регистрация";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.LightYellow;
            this.textName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textName.Location = new System.Drawing.Point(308, 354);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(165, 20);
            this.textName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(308, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя для входа или регисрации";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.cameraBox);
            this.MaximumSize = new System.Drawing.Size(816, 488);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "Start";
            this.Text = "Пост Охраны";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
    }
}

