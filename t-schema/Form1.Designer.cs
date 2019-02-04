namespace t_schema
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
            this.btnGet = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUndgrp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(86, 249);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(206, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Hämta från DB";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(21, 53);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(13, 17);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "-";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUndgrp);
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblUndgrp
            // 
            this.lblUndgrp.AutoSize = true;
            this.lblUndgrp.Location = new System.Drawing.Point(21, 18);
            this.lblUndgrp.Name = "lblUndgrp";
            this.lblUndgrp.Size = new System.Drawing.Size(13, 17);
            this.lblUndgrp.TabIndex = 2;
            this.lblUndgrp.Text = "-";
            this.lblUndgrp.Click += new System.EventHandler(this.lblUndgrp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUndgrp;
    }
}

