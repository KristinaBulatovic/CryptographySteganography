namespace CryptographySteganography
{
    partial class CrypSteg
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
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.lab_text = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.lab_pass = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.cb_algorithm = new System.Windows.Forms.ComboBox();
            this.lab_loadPic = new System.Windows.Forms.Label();
            this.lab_algorithm = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_image.Location = new System.Drawing.Point(12, 41);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(348, 423);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 20;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            // 
            // lab_text
            // 
            this.lab_text.AutoSize = true;
            this.lab_text.BackColor = System.Drawing.Color.Transparent;
            this.lab_text.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_text.ForeColor = System.Drawing.Color.White;
            this.lab_text.Location = new System.Drawing.Point(372, 136);
            this.lab_text.Name = "lab_text";
            this.lab_text.Size = new System.Drawing.Size(51, 26);
            this.lab_text.TabIndex = 32;
            this.lab_text.Text = "Text";
            // 
            // tb_text
            // 
            this.tb_text.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_text.Location = new System.Drawing.Point(377, 165);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_text.Size = new System.Drawing.Size(328, 185);
            this.tb_text.TabIndex = 3;
            this.tb_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_text_KeyDown);
            // 
            // lab_pass
            // 
            this.lab_pass.AutoSize = true;
            this.lab_pass.BackColor = System.Drawing.Color.Transparent;
            this.lab_pass.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_pass.ForeColor = System.Drawing.Color.White;
            this.lab_pass.Location = new System.Drawing.Point(372, 91);
            this.lab_pass.Name = "lab_pass";
            this.lab_pass.Size = new System.Drawing.Size(96, 26);
            this.lab_pass.TabIndex = 30;
            this.lab_pass.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.Enabled = false;
            this.tb_password.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_password.Location = new System.Drawing.Point(489, 89);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(216, 33);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decrypt.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_decrypt.Location = new System.Drawing.Point(563, 415);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(142, 49);
            this.btn_decrypt.TabIndex = 6;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            this.btn_decrypt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_decrypt_KeyDown);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encrypt.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_encrypt.Location = new System.Drawing.Point(377, 415);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(142, 49);
            this.btn_encrypt.TabIndex = 5;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = false;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            this.btn_encrypt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_encrypt_KeyDown);
            // 
            // cb_algorithm
            // 
            this.cb_algorithm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_algorithm.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_algorithm.FormattingEnabled = true;
            this.cb_algorithm.Items.AddRange(new object[] {
            "",
            "Tripl DES",
            "DES",
            "AES"});
            this.cb_algorithm.Location = new System.Drawing.Point(489, 41);
            this.cb_algorithm.Name = "cb_algorithm";
            this.cb_algorithm.Size = new System.Drawing.Size(216, 34);
            this.cb_algorithm.TabIndex = 1;
            this.cb_algorithm.SelectedIndexChanged += new System.EventHandler(this.cb_algorithm_SelectedIndexChanged);
            this.cb_algorithm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_algorithm_KeyDown);
            // 
            // lab_loadPic
            // 
            this.lab_loadPic.AutoSize = true;
            this.lab_loadPic.BackColor = System.Drawing.Color.Transparent;
            this.lab_loadPic.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_loadPic.ForeColor = System.Drawing.Color.White;
            this.lab_loadPic.Location = new System.Drawing.Point(7, 12);
            this.lab_loadPic.Name = "lab_loadPic";
            this.lab_loadPic.Size = new System.Drawing.Size(159, 26);
            this.lab_loadPic.TabIndex = 33;
            this.lab_loadPic.Text = "Load the picture";
            // 
            // lab_algorithm
            // 
            this.lab_algorithm.AutoSize = true;
            this.lab_algorithm.BackColor = System.Drawing.Color.Transparent;
            this.lab_algorithm.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_algorithm.ForeColor = System.Drawing.Color.White;
            this.lab_algorithm.Location = new System.Drawing.Point(372, 43);
            this.lab_algorithm.Name = "lab_algorithm";
            this.lab_algorithm.Size = new System.Drawing.Size(106, 26);
            this.lab_algorithm.TabIndex = 34;
            this.lab_algorithm.Text = "Algorithm";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(635, 356);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 31);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_clear_KeyDown);
            // 
            // CrypSteg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 476);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lab_algorithm);
            this.Controls.Add(this.lab_loadPic);
            this.Controls.Add(this.lab_text);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.lab_pass);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.cb_algorithm);
            this.Controls.Add(this.pb_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrypSteg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrypSteg";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CrypSteg_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label lab_text;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Label lab_pass;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.ComboBox cb_algorithm;
        private System.Windows.Forms.Label lab_loadPic;
        private System.Windows.Forms.Label lab_algorithm;
        private System.Windows.Forms.Button btn_clear;
    }
}