namespace GUI
{
    partial class Sprawdz
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_wyszukaj = new System.Windows.Forms.Button();
            this.button_sprawdzrezerwacje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_przyjazd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_wyjazd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WYSZUKAJ WOLNE POKOJE";
            // 
            // button_wyszukaj
            // 
            this.button_wyszukaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_wyszukaj.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_wyszukaj.Location = new System.Drawing.Point(29, 326);
            this.button_wyszukaj.Name = "button_wyszukaj";
            this.button_wyszukaj.Size = new System.Drawing.Size(304, 61);
            this.button_wyszukaj.TabIndex = 4;
            this.button_wyszukaj.Text = "WYSZUKAJ";
            this.button_wyszukaj.UseVisualStyleBackColor = false;
            this.button_wyszukaj.Click += new System.EventHandler(this.button_wyszukaj_Click);
            // 
            // button_sprawdzrezerwacje
            // 
            this.button_sprawdzrezerwacje.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_sprawdzrezerwacje.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sprawdzrezerwacje.Location = new System.Drawing.Point(29, 51);
            this.button_sprawdzrezerwacje.Name = "button_sprawdzrezerwacje";
            this.button_sprawdzrezerwacje.Size = new System.Drawing.Size(304, 61);
            this.button_sprawdzrezerwacje.TabIndex = 5;
            this.button_sprawdzrezerwacje.Text = "SPRAWDZ SWOJĄ REZERWACJĘ";
            this.button_sprawdzrezerwacje.UseVisualStyleBackColor = false;
            this.button_sprawdzrezerwacje.Click += new System.EventHandler(this.button_sprawdzrezerwacje_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check - out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check - in";
            // 
            // dateTimePicker_przyjazd
            // 
            this.dateTimePicker_przyjazd.Location = new System.Drawing.Point(133, 225);
            this.dateTimePicker_przyjazd.Name = "dateTimePicker_przyjazd";
            this.dateTimePicker_przyjazd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_przyjazd.TabIndex = 8;
            // 
            // dateTimePicker_wyjazd
            // 
            this.dateTimePicker_wyjazd.Location = new System.Drawing.Point(133, 275);
            this.dateTimePicker_wyjazd.Name = "dateTimePicker_wyjazd";
            this.dateTimePicker_wyjazd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_wyjazd.TabIndex = 9;
            // 
            // Sprawdz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(392, 507);
            this.Controls.Add(this.dateTimePicker_wyjazd);
            this.Controls.Add(this.dateTimePicker_przyjazd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_sprawdzrezerwacje);
            this.Controls.Add(this.button_wyszukaj);
            this.Controls.Add(this.label1);
            this.Name = "Sprawdz";
            this.Text = "Wyszukiwanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_wyszukaj;
        private System.Windows.Forms.Button button_sprawdzrezerwacje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_przyjazd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_wyjazd;
    }
}