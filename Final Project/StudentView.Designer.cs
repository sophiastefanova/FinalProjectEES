namespace MajorProjectEES
{
    partial class StudentView
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
            this.refresh_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.Enroll = new System.Windows.Forms.Label();
            this.enroll_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnsComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(187, 227);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(2);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(71, 25);
            this.refresh_button.TabIndex = 13;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(222, 105);
            this.dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "My Classes:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(181, 20);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(134, 31);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // classesComboBox
            // 
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(478, 118);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(121, 21);
            this.classesComboBox.TabIndex = 14;
            // 
            // Enroll
            // 
            this.Enroll.AutoSize = true;
            this.Enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enroll.Location = new System.Drawing.Point(475, 93);
            this.Enroll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(80, 17);
            this.Enroll.TabIndex = 15;
            this.Enroll.Text = "All Classes:";
            // 
            // enroll_button
            // 
            this.enroll_button.Location = new System.Drawing.Point(528, 160);
            this.enroll_button.Margin = new System.Windows.Forms.Padding(2);
            this.enroll_button.Name = "enroll_button";
            this.enroll_button.Size = new System.Drawing.Size(71, 25);
            this.enroll_button.TabIndex = 16;
            this.enroll_button.Text = "Enroll";
            this.enroll_button.UseVisualStyleBackColor = true;
            this.enroll_button.Click += new System.EventHandler(this.enroll_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(338, 227);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(71, 25);
            this.logout_button.TabIndex = 17;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filters:";
            // 
            // columnsComboBox
            // 
            this.columnsComboBox.FormattingEnabled = true;
            this.columnsComboBox.Items.AddRange(new object[] {
            "SubjectName",
            "TeacherName",
            "ClassTime",
            "RoomNumber"});
            this.columnsComboBox.Location = new System.Drawing.Point(32, 118);
            this.columnsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.columnsComboBox.Name = "columnsComboBox";
            this.columnsComboBox.Size = new System.Drawing.Size(82, 21);
            this.columnsComboBox.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 175);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(32, 251);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 24);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(32, 214);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(57, 24);
            this.filterButton.TabIndex = 25;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "What are you looking for?";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(634, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.columnsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.enroll_button);
            this.Controls.Add(this.Enroll);
            this.Controls.Add(this.classesComboBox);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.Load += new System.EventHandler(this.StudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.Label Enroll;
        private System.Windows.Forms.Button enroll_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox columnsComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label2;
    }
}