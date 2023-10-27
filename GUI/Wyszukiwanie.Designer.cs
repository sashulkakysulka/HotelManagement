namespace GUI
{
    partial class Wyszukiwanie
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
            this.button_odfiltruj = new System.Windows.Forms.Button();
            this.checkedListBox_filtruj = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_koszyk = new System.Windows.Forms.Button();
            this.button_cofnij = new System.Windows.Forms.Button();
            this.button_cofniee = new System.Windows.Forms.Button();
            this.listBox_pokoj = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_odfiltruj
            // 
            this.button_odfiltruj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_odfiltruj.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_odfiltruj.Location = new System.Drawing.Point(271, 204);
            this.button_odfiltruj.Name = "button_odfiltruj";
            this.button_odfiltruj.Size = new System.Drawing.Size(143, 33);
            this.button_odfiltruj.TabIndex = 2;
            this.button_odfiltruj.Text = "ODFILTRUJ";
            this.button_odfiltruj.UseVisualStyleBackColor = false;
            this.button_odfiltruj.Click += new System.EventHandler(this.button_odfiltruj_Click);
            // 
            // checkedListBox_filtruj
            // 
            this.checkedListBox_filtruj.FormattingEnabled = true;
            this.checkedListBox_filtruj.Location = new System.Drawing.Point(271, 49);
            this.checkedListBox_filtruj.Name = "checkedListBox_filtruj";
            this.checkedListBox_filtruj.Size = new System.Drawing.Size(299, 140);
            this.checkedListBox_filtruj.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "DOSTEPNE POKOJE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "ZAREZERWUJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_koszyk
            // 
            this.button_koszyk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_koszyk.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_koszyk.Location = new System.Drawing.Point(271, 243);
            this.button_koszyk.Name = "button_koszyk";
            this.button_koszyk.Size = new System.Drawing.Size(299, 33);
            this.button_koszyk.TabIndex = 6;
            this.button_koszyk.Text = "DO KOSZYKA";
            this.button_koszyk.UseVisualStyleBackColor = false;
            this.button_koszyk.Click += new System.EventHandler(this.button_koszyk_Click);
            // 
            // button_cofnij
            // 
            this.button_cofnij.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_cofnij.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cofnij.Location = new System.Drawing.Point(427, 204);
            this.button_cofnij.Name = "button_cofnij";
            this.button_cofnij.Size = new System.Drawing.Size(143, 33);
            this.button_cofnij.TabIndex = 7;
            this.button_cofnij.Text = "COFNIJ";
            this.button_cofnij.UseVisualStyleBackColor = false;
            this.button_cofnij.Click += new System.EventHandler(this.button_cofnij_Click);
            // 
            // button_cofniee
            // 
            this.button_cofniee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_cofniee.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cofniee.Location = new System.Drawing.Point(427, 298);
            this.button_cofniee.Name = "button_cofniee";
            this.button_cofniee.Size = new System.Drawing.Size(157, 61);
            this.button_cofniee.TabIndex = 8;
            this.button_cofniee.Text = "COFNIJ";
            this.button_cofniee.UseVisualStyleBackColor = false;
            this.button_cofniee.Click += new System.EventHandler(this.button_cofniee_Click);
            // 
            // listBox_pokoj
            // 
            this.listBox_pokoj.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_pokoj.FormattingEnabled = true;
            this.listBox_pokoj.ItemHeight = 20;
            this.listBox_pokoj.Location = new System.Drawing.Point(34, 49);
            this.listBox_pokoj.Name = "listBox_pokoj";
            this.listBox_pokoj.Size = new System.Drawing.Size(200, 304);
            this.listBox_pokoj.TabIndex = 9;
            // 
            // Wyszukiwanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(630, 385);
            this.Controls.Add(this.listBox_pokoj);
            this.Controls.Add(this.button_cofniee);
            this.Controls.Add(this.button_cofnij);
            this.Controls.Add(this.button_koszyk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox_filtruj);
            this.Controls.Add(this.button_odfiltruj);
            this.Name = "Wyszukiwanie";
            this.Text = "Wyszukiwanie";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_odfiltruj;
        private System.Windows.Forms.CheckedListBox checkedListBox_filtruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_koszyk;
        private System.Windows.Forms.Button button_cofnij;
        private System.Windows.Forms.Button button_cofniee;
        private System.Windows.Forms.ListBox listBox_pokoj;
    }
}