namespace assigment2_gethub
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
            this.lblmessagename = new System.Windows.Forms.Label();
            this.lblmessagepass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmessagename
            // 
            this.lblmessagename.AutoSize = true;
            this.lblmessagename.Location = new System.Drawing.Point(63, 39);
            this.lblmessagename.Name = "lblmessagename";
            this.lblmessagename.Size = new System.Drawing.Size(50, 20);
            this.lblmessagename.TabIndex = 0;
            this.lblmessagename.Text = "label1";
            // 
            // lblmessagepass
            // 
            this.lblmessagepass.AutoSize = true;
            this.lblmessagepass.Location = new System.Drawing.Point(63, 69);
            this.lblmessagepass.Name = "lblmessagepass";
            this.lblmessagepass.Size = new System.Drawing.Size(0, 20);
            this.lblmessagepass.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 161);
            this.Controls.Add(this.lblmessagepass);
            this.Controls.Add(this.lblmessagename);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblmessagename;
        private Label lblmessagepass;
    }
}