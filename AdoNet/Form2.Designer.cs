
namespace AdoNet
{
    partial class Form2
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(226, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(178, 26);
            this.txtname.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(226, 94);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(178, 26);
            this.txtemail.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(329, 172);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 28);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnsave;
    }
}