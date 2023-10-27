namespace GUI
{
    partial class IsniejacaRezerwacja
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
            this.button_wyszukaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numer = new System.Windows.Forms.TextBox();
            this.button_feedback = new System.Windows.Forms.Button();
            this.button_cofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_wyszukaj
            // 
            this.button_wyszukaj.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_wyszukaj.Location = new System.Drawing.Point(96, 94);
            this.button_wyszukaj.Name = "button_wyszukaj";
            this.button_wyszukaj.Size = new System.Drawing.Size(182, 45);
            this.button_wyszukaj.TabIndex = 0;
            this.button_wyszukaj.Text = "wyszukaj rezerwacje";
            this.button_wyszukaj.UseVisualStyleBackColor = true;
            this.button_wyszukaj.Click += new System.EventHandler(this.button_wyszukaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "podaj numer dokumentu";
            // 
            // textBox_numer
            // 
            this.textBox_numer.Location = new System.Drawing.Point(96, 66);
            this.textBox_numer.Name = "textBox_numer";
            this.textBox_numer.Size = new System.Drawing.Size(182, 22);
            this.textBox_numer.TabIndex = 2;
            // 
            // button_feedback
            // 
            this.button_feedback.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_feedback.Location = new System.Drawing.Point(96, 145);
            this.button_feedback.Name = "button_feedback";
            this.button_feedback.Size = new System.Drawing.Size(182, 45);
            this.button_feedback.TabIndex = 4;
            this.button_feedback.Text = "Napisz feedback";
            this.button_feedback.UseVisualStyleBackColor = true;
            this.button_feedback.Click += new System.EventHandler(this.button_feedback_Click);
            // 
            // button_cofnij
            // 
            this.button_cofnij.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cofnij.Location = new System.Drawing.Point(303, 147);
            this.button_cofnij.Name = "button_cofnij";
            this.button_cofnij.Size = new System.Drawing.Size(93, 43);
            this.button_cofnij.TabIndex = 5;
            this.button_cofnij.Text = "cofnij";
            this.button_cofnij.UseVisualStyleBackColor = true;
            this.button_cofnij.Click += new System.EventHandler(this.button_cofnij_Click);
            // 
            // IsniejacaRezerwacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 211);
            this.Controls.Add(this.button_cofnij);
            this.Controls.Add(this.button_feedback);
            this.Controls.Add(this.textBox_numer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_wyszukaj);
            this.Name = "IsniejacaRezerwacja";
            this.Text = "IsniejacaRezerwacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_wyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numer;
        private System.Windows.Forms.Button button_feedback;
        private System.Windows.Forms.Button button_cofnij;
    }
}