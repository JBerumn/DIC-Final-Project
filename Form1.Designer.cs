namespace Weather_App_GUI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data8 = new System.Windows.Forms.Label();
            this.data7 = new System.Windows.Forms.Label();
            this.data6 = new System.Windows.Forms.Label();
            this.data5 = new System.Windows.Forms.Label();
            this.data4 = new System.Windows.Forms.Label();
            this.data3 = new System.Windows.Forms.Label();
            this.data2 = new System.Windows.Forms.Label();
            this.data1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.locationTextBox);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 44);
            this.panel1.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Black;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.searchButton.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(659, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 34);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.Color.Black;
            this.locationTextBox.Font = new System.Drawing.Font("Koverwatch", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.ForeColor = System.Drawing.Color.White;
            this.locationTextBox.Location = new System.Drawing.Point(20, 8);
            this.locationTextBox.Multiline = true;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(623, 29);
            this.locationTextBox.TabIndex = 0;
            this.locationTextBox.Text = "Location (City, State/Province, Country)";
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.data8);
            this.panel2.Controls.Add(this.data7);
            this.panel2.Controls.Add(this.data6);
            this.panel2.Controls.Add(this.data5);
            this.panel2.Controls.Add(this.data4);
            this.panel2.Controls.Add(this.data3);
            this.panel2.Controls.Add(this.data2);
            this.panel2.Controls.Add(this.data1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 280);
            this.panel2.TabIndex = 2;
            // 
            // data8
            // 
            this.data8.AutoSize = true;
            this.data8.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data8.ForeColor = System.Drawing.Color.White;
            this.data8.Location = new System.Drawing.Point(41, 197);
            this.data8.Name = "data8";
            this.data8.Size = new System.Drawing.Size(33, 20);
            this.data8.TabIndex = 16;
            this.data8.Text = "Data";
            // 
            // data7
            // 
            this.data7.AutoSize = true;
            this.data7.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data7.ForeColor = System.Drawing.Color.White;
            this.data7.Location = new System.Drawing.Point(41, 176);
            this.data7.Name = "data7";
            this.data7.Size = new System.Drawing.Size(33, 20);
            this.data7.TabIndex = 15;
            this.data7.Text = "Data";
            // 
            // data6
            // 
            this.data6.AutoSize = true;
            this.data6.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data6.ForeColor = System.Drawing.Color.White;
            this.data6.Location = new System.Drawing.Point(41, 156);
            this.data6.Name = "data6";
            this.data6.Size = new System.Drawing.Size(33, 20);
            this.data6.TabIndex = 14;
            this.data6.Text = "Data";
            // 
            // data5
            // 
            this.data5.AutoSize = true;
            this.data5.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data5.ForeColor = System.Drawing.Color.White;
            this.data5.Location = new System.Drawing.Point(41, 133);
            this.data5.Name = "data5";
            this.data5.Size = new System.Drawing.Size(33, 20);
            this.data5.TabIndex = 13;
            this.data5.Text = "Data";
            // 
            // data4
            // 
            this.data4.AutoSize = true;
            this.data4.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data4.ForeColor = System.Drawing.Color.White;
            this.data4.Location = new System.Drawing.Point(41, 113);
            this.data4.Name = "data4";
            this.data4.Size = new System.Drawing.Size(33, 20);
            this.data4.TabIndex = 4;
            this.data4.Text = "Data";
            // 
            // data3
            // 
            this.data3.AutoSize = true;
            this.data3.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data3.ForeColor = System.Drawing.Color.White;
            this.data3.Location = new System.Drawing.Point(41, 92);
            this.data3.Name = "data3";
            this.data3.Size = new System.Drawing.Size(33, 20);
            this.data3.TabIndex = 3;
            this.data3.Text = "Data";
            // 
            // data2
            // 
            this.data2.AutoSize = true;
            this.data2.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data2.ForeColor = System.Drawing.Color.White;
            this.data2.Location = new System.Drawing.Point(41, 72);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(33, 20);
            this.data2.TabIndex = 2;
            this.data2.Text = "Data";
            // 
            // data1
            // 
            this.data1.AutoSize = true;
            this.data1.Font = new System.Drawing.Font("Koverwatch", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data1.ForeColor = System.Drawing.Color.White;
            this.data1.Location = new System.Drawing.Point(41, 49);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(33, 20);
            this.data1.TabIndex = 1;
            this.data1.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Koverwatch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Weather";
            // 
            // loadingBar
            // 
            this.loadingBar.Location = new System.Drawing.Point(27, 62);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(623, 23);
            this.loadingBar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label data4;
        private System.Windows.Forms.Label data3;
        private System.Windows.Forms.Label data2;
        private System.Windows.Forms.Label data1;
        private System.Windows.Forms.Label data8;
        private System.Windows.Forms.Label data7;
        private System.Windows.Forms.Label data6;
        private System.Windows.Forms.Label data5;
        private System.Windows.Forms.ProgressBar loadingBar;
    }
}

