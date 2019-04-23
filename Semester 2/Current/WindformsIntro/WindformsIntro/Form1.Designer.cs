namespace WindformsIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SomethingUsefull = new System.Windows.Forms.Button();
            this.Checkbox_Failsafe = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_Pickel = new System.Windows.Forms.DateTimePicker();
            this.label_Boi = new System.Windows.Forms.Label();
            this.picturebox_ye = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_ye)).BeginInit();
            this.SuspendLayout();
            // 
            // SomethingUsefull
            // 
            this.SomethingUsefull.AccessibleName = "SomethingUsefull";
            this.SomethingUsefull.BackColor = System.Drawing.Color.Lavender;
            this.SomethingUsefull.ForeColor = System.Drawing.Color.Black;
            this.SomethingUsefull.Location = new System.Drawing.Point(211, 213);
            this.SomethingUsefull.Name = "SomethingUsefull";
            this.SomethingUsefull.Size = new System.Drawing.Size(314, 131);
            this.SomethingUsefull.TabIndex = 0;
            this.SomethingUsefull.Text = "Something Usefull";
            this.SomethingUsefull.UseVisualStyleBackColor = false;
            this.SomethingUsefull.Click += new System.EventHandler(this.button1_Click);
            // 
            // Checkbox_Failsafe
            // 
            this.Checkbox_Failsafe.AutoSize = true;
            this.Checkbox_Failsafe.Location = new System.Drawing.Point(531, 261);
            this.Checkbox_Failsafe.Name = "Checkbox_Failsafe";
            this.Checkbox_Failsafe.Size = new System.Drawing.Size(154, 36);
            this.Checkbox_Failsafe.TabIndex = 1;
            this.Checkbox_Failsafe.Text = "Failsafe";
            this.Checkbox_Failsafe.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Pickel
            // 
            this.dateTimePicker_Pickel.Location = new System.Drawing.Point(577, 54);
            this.dateTimePicker_Pickel.Name = "dateTimePicker_Pickel";
            this.dateTimePicker_Pickel.Size = new System.Drawing.Size(521, 38);
            this.dateTimePicker_Pickel.TabIndex = 2;
            // 
            // label_Boi
            // 
            this.label_Boi.AutoSize = true;
            this.label_Boi.Location = new System.Drawing.Point(1019, 261);
            this.label_Boi.Name = "label_Boi";
            this.label_Boi.Size = new System.Drawing.Size(191, 32);
            this.label_Boi.TabIndex = 3;
            this.label_Boi.Text = "The Label Boi";
            // 
            // picturebox_ye
            // 
            this.picturebox_ye.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picturebox_ye.ErrorImage")));
            this.picturebox_ye.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_ye.Image")));
            this.picturebox_ye.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturebox_ye.InitialImage")));
            this.picturebox_ye.Location = new System.Drawing.Point(243, 367);
            this.picturebox_ye.Margin = new System.Windows.Forms.Padding(0);
            this.picturebox_ye.Name = "picturebox_ye";
            this.picturebox_ye.Size = new System.Drawing.Size(1075, 798);
            this.picturebox_ye.TabIndex = 4;
            this.picturebox_ye.TabStop = false;
            this.picturebox_ye.Click += new System.EventHandler(this.picturebox_ye_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1219, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1877, 1174);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picturebox_ye);
            this.Controls.Add(this.label_Boi);
            this.Controls.Add(this.dateTimePicker_Pickel);
            this.Controls.Add(this.Checkbox_Failsafe);
            this.Controls.Add(this.SomethingUsefull);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_ye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SomethingUsefull;
        private System.Windows.Forms.CheckBox Checkbox_Failsafe;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Pickel;
        private System.Windows.Forms.Label label_Boi;
        private System.Windows.Forms.PictureBox picturebox_ye;
        private System.Windows.Forms.TextBox textBox1;
    }
}

