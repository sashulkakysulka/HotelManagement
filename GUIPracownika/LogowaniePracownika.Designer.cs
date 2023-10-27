namespace GUIPracownika
{
    partial class LogowaniePracownika
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
            this.button_dopracy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heja!! Zaloguj sie by zacząć pracować";
            // 
            // button_dopracy
            // 
            this.button_dopracy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_dopracy.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dopracy.Location = new System.Drawing.Point(295, 186);
            this.button_dopracy.Name = "button_dopracy";
            this.button_dopracy.Size = new System.Drawing.Size(175, 45);
            this.button_dopracy.TabIndex = 1;
            this.button_dopracy.Text = "Do pracy!!";
            this.button_dopracy.UseVisualStyleBackColor = false;
            this.button_dopracy.Click += new System.EventHandler(this.button_dopracy_Click);
            // 
            // LogowaniePracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_dopracy);
            this.Controls.Add(this.label1);
            this.Name = "LogowaniePracownika";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dopracy;
    }
}

