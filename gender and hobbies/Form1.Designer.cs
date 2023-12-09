namespace gender_and_hobbies
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
            this.lblgender = new System.Windows.Forms.Label();
            this.lblhobbies = new System.Windows.Forms.Label();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.chx1 = new System.Windows.Forms.CheckBox();
            this.chx2 = new System.Windows.Forms.CheckBox();
            this.chx3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(65, 45);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(71, 22);
            this.lblgender.TabIndex = 0;
            this.lblgender.Text = "Gender";
            // 
            // lblhobbies
            // 
            this.lblhobbies.AutoSize = true;
            this.lblhobbies.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhobbies.Location = new System.Drawing.Point(65, 92);
            this.lblhobbies.Name = "lblhobbies";
            this.lblhobbies.Size = new System.Drawing.Size(76, 22);
            this.lblhobbies.TabIndex = 1;
            this.lblhobbies.Text = "Hobbies";
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.Location = new System.Drawing.Point(181, 49);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(55, 19);
            this.rdbmale.TabIndex = 2;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male ";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(288, 49);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(68, 19);
            this.rdbfemale.TabIndex = 3;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "FeMale ";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // chx1
            // 
            this.chx1.AutoSize = true;
            this.chx1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx1.Location = new System.Drawing.Point(181, 118);
            this.chx1.Name = "chx1";
            this.chx1.Size = new System.Drawing.Size(82, 19);
            this.chx1.TabIndex = 4;
            this.chx1.Text = "swimming";
            this.chx1.UseVisualStyleBackColor = true;
            // 
            // chx2
            // 
            this.chx2.AutoSize = true;
            this.chx2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx2.Location = new System.Drawing.Point(181, 151);
            this.chx2.Name = "chx2";
            this.chx2.Size = new System.Drawing.Size(66, 19);
            this.chx2.TabIndex = 5;
            this.chx2.Text = "playing";
            this.chx2.UseVisualStyleBackColor = true;
            // 
            // chx3
            // 
            this.chx3.AutoSize = true;
            this.chx3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx3.Location = new System.Drawing.Point(181, 184);
            this.chx3.Name = "chx3";
            this.chx3.Size = new System.Drawing.Size(67, 19);
            this.chx3.TabIndex = 6;
            this.chx3.Text = "gaming";
            this.chx3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(140, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "register employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(453, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chx3);
            this.Controls.Add(this.chx2);
            this.Controls.Add(this.chx1);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.lblhobbies);
            this.Controls.Add(this.lblgender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblhobbies;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.CheckBox chx1;
        private System.Windows.Forms.CheckBox chx2;
        private System.Windows.Forms.CheckBox chx3;
        private System.Windows.Forms.Button button1;
    }
}

