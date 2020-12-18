
namespace PraktikumWeek14
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
            this.lblinput = new System.Windows.Forms.Label();
            this.txtboxinput = new System.Windows.Forms.TextBox();
            this.btnreverse = new System.Windows.Forms.Button();
            this.btnurutkan = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblinput.Location = new System.Drawing.Point(40, 63);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(39, 17);
            this.lblinput.TabIndex = 0;
            this.lblinput.Text = "Input";
            // 
            // txtboxinput
            // 
            this.txtboxinput.Location = new System.Drawing.Point(43, 83);
            this.txtboxinput.Name = "txtboxinput";
            this.txtboxinput.Size = new System.Drawing.Size(187, 20);
            this.txtboxinput.TabIndex = 1;
            // 
            // btnreverse
            // 
            this.btnreverse.Location = new System.Drawing.Point(43, 143);
            this.btnreverse.Name = "btnreverse";
            this.btnreverse.Size = new System.Drawing.Size(88, 23);
            this.btnreverse.TabIndex = 2;
            this.btnreverse.Text = "REVERSE";
            this.btnreverse.UseVisualStyleBackColor = true;
            this.btnreverse.Click += new System.EventHandler(this.btnreverse_Click);
            // 
            // btnurutkan
            // 
            this.btnurutkan.Location = new System.Drawing.Point(144, 143);
            this.btnurutkan.Name = "btnurutkan";
            this.btnurutkan.Size = new System.Drawing.Size(86, 23);
            this.btnurutkan.TabIndex = 3;
            this.btnurutkan.Text = "URUTKAN";
            this.btnurutkan.UseVisualStyleBackColor = true;
            this.btnurutkan.Click += new System.EventHandler(this.btnurutkan_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbloutput.Location = new System.Drawing.Point(40, 235);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(51, 17);
            this.lbloutput.TabIndex = 4;
            this.lbloutput.Text = "Output";
            this.lbloutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 366);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnurutkan);
            this.Controls.Add(this.btnreverse);
            this.Controls.Add(this.txtboxinput);
            this.Controls.Add(this.lblinput);
            this.Name = "Form1";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.TextBox txtboxinput;
        private System.Windows.Forms.Button btnreverse;
        private System.Windows.Forms.Button btnurutkan;
        private System.Windows.Forms.Label lbloutput;
    }
}

