namespace GUI
{
    partial class Haslo
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
            this.button_haslo = new System.Windows.Forms.Button();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_haslo
            // 
            this.button_haslo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_haslo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_haslo.Location = new System.Drawing.Point(117, 128);
            this.button_haslo.Name = "button_haslo";
            this.button_haslo.Size = new System.Drawing.Size(173, 48);
            this.button_haslo.TabIndex = 0;
            this.button_haslo.Text = "LOG IN";
            this.button_haslo.UseVisualStyleBackColor = false;
            this.button_haslo.Click += new System.EventHandler(this.button_haslo_Click);
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_haslo.Location = new System.Drawing.Point(117, 90);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.PasswordChar = '*';
            this.textBox_haslo.Size = new System.Drawing.Size(173, 26);
            this.textBox_haslo.TabIndex = 1;
            this.textBox_haslo.Text = "haslo";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mail.Location = new System.Drawing.Point(117, 48);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(173, 26);
            this.textBox_mail.TabIndex = 2;
            this.textBox_mail.Text = "Email";
            // 
            // Haslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(413, 307);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.button_haslo);
            this.Name = "Haslo";
            this.Text = "Haslo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_haslo;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.TextBox textBox_mail;
    }
}