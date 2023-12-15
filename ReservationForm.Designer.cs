namespace veritabanidemo1
{
    partial class ReservationForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_goPay = new MaterialSkin.Controls.MaterialButton();
            this.tb_firstName = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_lastName = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_IDnumber = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(87, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "First Name:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(87, 209);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(103, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Last Name:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(87, 307);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(150, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Identıty Number:";
            // 
            // btn_goPay
            // 
            this.btn_goPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_goPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_goPay.Depth = 0;
            this.btn_goPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_goPay.HighEmphasis = true;
            this.btn_goPay.Icon = null;
            this.btn_goPay.Location = new System.Drawing.Point(3, 392);
            this.btn_goPay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_goPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_goPay.Name = "btn_goPay";
            this.btn_goPay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_goPay.Size = new System.Drawing.Size(640, 36);
            this.btn_goPay.TabIndex = 3;
            this.btn_goPay.Text = "P A Y M E N T";
            this.btn_goPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_goPay.UseAccentColor = false;
            this.btn_goPay.UseVisualStyleBackColor = true;
            // 
            // tb_firstName
            // 
            this.tb_firstName.AnimateReadOnly = false;
            this.tb_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_firstName.Depth = 0;
            this.tb_firstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_firstName.LeadingIcon = null;
            this.tb_firstName.Location = new System.Drawing.Point(325, 102);
            this.tb_firstName.MaxLength = 50;
            this.tb_firstName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_firstName.Multiline = false;
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(228, 50);
            this.tb_firstName.TabIndex = 4;
            this.tb_firstName.Text = "";
            this.tb_firstName.TrailingIcon = null;
            // 
            // tb_lastName
            // 
            this.tb_lastName.AnimateReadOnly = false;
            this.tb_lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lastName.Depth = 0;
            this.tb_lastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_lastName.LeadingIcon = null;
            this.tb_lastName.Location = new System.Drawing.Point(325, 183);
            this.tb_lastName.MaxLength = 50;
            this.tb_lastName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_lastName.Multiline = false;
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(228, 50);
            this.tb_lastName.TabIndex = 5;
            this.tb_lastName.Text = "";
            this.tb_lastName.TrailingIcon = null;
            // 
            // tb_IDnumber
            // 
            this.tb_IDnumber.AnimateReadOnly = false;
            this.tb_IDnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_IDnumber.Depth = 0;
            this.tb_IDnumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_IDnumber.LeadingIcon = null;
            this.tb_IDnumber.Location = new System.Drawing.Point(325, 281);
            this.tb_IDnumber.MaxLength = 50;
            this.tb_IDnumber.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_IDnumber.Multiline = false;
            this.tb_IDnumber.Name = "tb_IDnumber";
            this.tb_IDnumber.Size = new System.Drawing.Size(228, 50);
            this.tb_IDnumber.TabIndex = 6;
            this.tb_IDnumber.Text = "";
            this.tb_IDnumber.TrailingIcon = null;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 431);
            this.Controls.Add(this.tb_IDnumber);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.btn_goPay);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btn_goPay;
        private MaterialSkin.Controls.MaterialTextBox tb_firstName;
        private MaterialSkin.Controls.MaterialTextBox tb_lastName;
        private MaterialSkin.Controls.MaterialTextBox tb_IDnumber;
    }
}