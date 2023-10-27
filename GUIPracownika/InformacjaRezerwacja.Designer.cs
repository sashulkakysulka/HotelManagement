namespace GUI
{
    partial class InformacjaRezerwacja
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
            this.button_odszukaj = new System.Windows.Forms.Button();
            this.label_goscinf = new System.Windows.Forms.Label();
            this.listBox_rezerwacja = new System.Windows.Forms.ListBox();
            this.textBox_dokument = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_usun = new System.Windows.Forms.Button();
            this.button_feed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_odszukaj
            // 
            this.button_odszukaj.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_odszukaj.Location = new System.Drawing.Point(205, 83);
            this.button_odszukaj.Name = "button_odszukaj";
            this.button_odszukaj.Size = new System.Drawing.Size(179, 30);
            this.button_odszukaj.TabIndex = 0;
            this.button_odszukaj.Text = "SZUKAJ";
            this.button_odszukaj.UseVisualStyleBackColor = true;
            this.button_odszukaj.Click += new System.EventHandler(this.button_odszukaj_Click);
            // 
            // label_goscinf
            // 
            this.label_goscinf.Location = new System.Drawing.Point(12, 139);
            this.label_goscinf.Name = "label_goscinf";
            this.label_goscinf.Size = new System.Drawing.Size(163, 148);
            this.label_goscinf.TabIndex = 1;
            // 
            // listBox_rezerwacja
            // 
            this.listBox_rezerwacja.FormattingEnabled = true;
            this.listBox_rezerwacja.ItemHeight = 16;
            this.listBox_rezerwacja.Location = new System.Drawing.Point(192, 139);
            this.listBox_rezerwacja.Name = "listBox_rezerwacja";
            this.listBox_rezerwacja.Size = new System.Drawing.Size(391, 148);
            this.listBox_rezerwacja.TabIndex = 2;
            // 
            // textBox_dokument
            // 
            this.textBox_dokument.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dokument.Location = new System.Drawing.Point(205, 51);
            this.textBox_dokument.Name = "textBox_dokument";
            this.textBox_dokument.Size = new System.Drawing.Size(179, 26);
            this.textBox_dokument.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "ODSZUKAJ GOŚCIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "numer dokumentu gościa";
            // 
            // button_usun
            // 
            this.button_usun.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_usun.Location = new System.Drawing.Point(192, 293);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(391, 38);
            this.button_usun.TabIndex = 7;
            this.button_usun.Text = "usun rezerwacje";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // button_feed
            // 
            this.button_feed.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_feed.Location = new System.Drawing.Point(16, 357);
            this.button_feed.Name = "button_feed";
            this.button_feed.Size = new System.Drawing.Size(159, 45);
            this.button_feed.TabIndex = 8;
            this.button_feed.Text = "raport feedback";
            this.button_feed.UseVisualStyleBackColor = true;
            this.button_feed.Click += new System.EventHandler(this.button_feed_Click);
            // 
            // InformacjaRezerwacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_feed);
            this.Controls.Add(this.button_usun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_dokument);
            this.Controls.Add(this.listBox_rezerwacja);
            this.Controls.Add(this.label_goscinf);
            this.Controls.Add(this.button_odszukaj);
            this.Name = "InformacjaRezerwacja";
            this.Text = "InformacjaRezerwacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_odszukaj;
        private System.Windows.Forms.Label label_goscinf;
        private System.Windows.Forms.ListBox listBox_rezerwacja;
        private System.Windows.Forms.TextBox textBox_dokument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Button button_feed;
    }
}