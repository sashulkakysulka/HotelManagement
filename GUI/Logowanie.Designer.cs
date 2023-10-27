namespace GUI
{
    partial class Logowanie
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
            this.button_gosc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_gosc
            // 
            this.button_gosc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_gosc.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gosc.Location = new System.Drawing.Point(269, 169);
            this.button_gosc.Name = "button_gosc";
            this.button_gosc.Size = new System.Drawing.Size(224, 51);
            this.button_gosc.TabIndex = 1;
            this.button_gosc.Text = "Przejdz do rezerwacji";
            this.button_gosc.UseVisualStyleBackColor = false;
            this.button_gosc.Click += new System.EventHandler(this.button_gosc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Witamy w hotelu \"Palacowa przyjemnosc\"";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_gosc);
            this.Name = "Logowanie";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_gosc;
        private System.Windows.Forms.Label label1;
    }
}

