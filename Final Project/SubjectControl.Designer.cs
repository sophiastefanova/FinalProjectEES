namespace MajorProjectEES
{
    partial class SubjectControl
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
            this.roomnumber = new System.Windows.Forms.TextBox();
            this.classtime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.subjectscombo = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomnumber
            // 
            this.roomnumber.Location = new System.Drawing.Point(246, 159);
            this.roomnumber.Margin = new System.Windows.Forms.Padding(2);
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Size = new System.Drawing.Size(89, 20);
            this.roomnumber.TabIndex = 24;
            // 
            // classtime
            // 
            this.classtime.Location = new System.Drawing.Point(246, 132);
            this.classtime.Margin = new System.Windows.Forms.Padding(2);
            this.classtime.Name = "classtime";
            this.classtime.Size = new System.Drawing.Size(89, 20);
            this.classtime.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(104, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Room Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(126, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Class Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(154, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add Class";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.GreenYellow;
            this.submit_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submit_button.Location = new System.Drawing.Point(257, 220);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(61, 23);
            this.submit_button.TabIndex = 26;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // subjectscombo
            // 
            this.subjectscombo.FormattingEnabled = true;
            this.subjectscombo.Location = new System.Drawing.Point(246, 106);
            this.subjectscombo.Name = "subjectscombo";
            this.subjectscombo.Size = new System.Drawing.Size(89, 21);
            this.subjectscombo.TabIndex = 29;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.back_button.Location = new System.Drawing.Point(150, 220);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(61, 23);
            this.back_button.TabIndex = 30;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // SubjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(448, 278);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.subjectscombo);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomnumber);
            this.Controls.Add(this.classtime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SubjectControl";
            this.Text = "SubjectControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomnumber;
        private System.Windows.Forms.TextBox classtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.ComboBox subjectscombo;
        private System.Windows.Forms.Button back_button;
    }
}