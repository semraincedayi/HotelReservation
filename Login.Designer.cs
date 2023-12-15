namespace veritabanidemo1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_go_register = new MaterialSkin.Controls.MaterialButton();
            this.btn_forgot = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.pb_password = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_email = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_go_register
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(36, 325);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Email:";
            // 
            // btn_forgot
            // 
            this.btn_forgot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_forgot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_forgot.Depth = 0;
            this.btn_forgot.HighEmphasis = true;
            this.btn_forgot.Icon = null;
            this.btn_forgot.Location = new System.Drawing.Point(206, 614);
            this.btn_forgot.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_forgot.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_forgot.Name = "btn_forgot";
            this.btn_forgot.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_forgot.Size = new System.Drawing.Size(186, 36);
            this.btn_forgot.TabIndex = 20;
            this.btn_forgot.Text = "FORGOT MY PASSWORD";
            this.btn_forgot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btn_forgot.UseAccentColor = false;
            this.btn_forgot.UseVisualStyleBackColor = true;
            this.btn_forgot.Click += new System.EventHandler(this.btn_forgot_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(106, 241);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(256, 41);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Login to Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(80, 429);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 24);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Password";
            // 
            // tb_email
            // 
            this.tb_email.AllowPromptAsInput = true;
            this.tb_email.AnimateReadOnly = false;
            this.tb_email.AsciiOnly = false;
            this.tb_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_email.BeepOnError = false;
            this.tb_email.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_email.Depth = 0;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_email.HidePromptOnLeave = false;
            this.tb_email.HideSelection = true;
            this.tb_email.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tb_email.LeadingIcon = null;
            this.tb_email.Location = new System.Drawing.Point(80, 340);
            this.tb_email.Mask = "";
            this.tb_email.MaxLength = 32767;
            this.tb_email.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.PrefixSuffixText = null;
            this.tb_email.PromptChar = '_';
            this.tb_email.ReadOnly = false;
            this.tb_email.RejectInputOnFirstFailure = false;
            this.tb_email.ResetOnPrompt = true;
            this.tb_email.ResetOnSpace = true;
            this.tb_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_email.SelectedText = "";
            this.tb_email.SelectionLength = 0;
            this.tb_email.SelectionStart = 0;
            this.tb_email.ShortcutsEnabled = true;
            this.tb_email.Size = new System.Drawing.Size(312, 48);
            this.tb_email.SkipLiterals = true;
            this.tb_email.TabIndex = 14;
            this.tb_email.TabStop = false;
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_email.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_email.TrailingIcon = null;
            this.tb_email.UseSystemPasswordChar = false;
            this.tb_email.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(80, 302);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 671);
            this.Controls.Add(this.btn_go_register);
            this.Controls.Add(this.btn_forgot);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_go_register;
        private MaterialSkin.Controls.MaterialButton btn_forgot;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_login;
        private MaterialSkin.Controls.MaterialMaskedTextBox pb_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox tb_email;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}