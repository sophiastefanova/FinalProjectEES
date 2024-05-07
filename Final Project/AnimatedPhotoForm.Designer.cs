namespace MajorProjectEES
{
    partial class AnimatedPhotoForm
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
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.PaleTurquoise;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(325, 358);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(151, 50);
            this.start.TabIndex = 0;
            this.start.Text = "Let\'s get started!";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // AnimatedPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Name = "AnimatedPhotoForm";
            this.Text = "AnimatedPhotoForm";
            this.Load += new System.EventHandler(this.AnimatedPhotoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
    }
}

