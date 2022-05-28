namespace assigment2_gethub
{
    partial class Form3
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
            this.lblnamnav = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnmain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblnamnav);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 143);
            this.panel1.TabIndex = 0;
            // 
            // lblnamnav
            // 
            this.lblnamnav.AutoSize = true;
            this.lblnamnav.Location = new System.Drawing.Point(153, 8);
            this.lblnamnav.Name = "lblnamnav";
            this.lblnamnav.Size = new System.Drawing.Size(50, 20);
            this.lblnamnav.TabIndex = 4;
            this.lblnamnav.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::assigment2_gethub.Properties.Resources.Screenshot__7_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(144, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 401);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnhelp);
            this.panel2.Controls.Add(this.btninfo);
            this.panel2.Controls.Add(this.btnmain);
            this.panel2.Location = new System.Drawing.Point(1, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 404);
            this.panel2.TabIndex = 1;
            // 
            // btnhelp
            // 
            this.btnhelp.Location = new System.Drawing.Point(21, 221);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(95, 59);
            this.btnhelp.TabIndex = 2;
            this.btnhelp.Text = "help";
            this.btnhelp.UseVisualStyleBackColor = true;
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(21, 132);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(95, 58);
            this.btninfo.TabIndex = 1;
            this.btninfo.Text = "information";
            this.btninfo.UseVisualStyleBackColor = true;
            // 
            // btnmain
            // 
            this.btnmain.Location = new System.Drawing.Point(21, 33);
            this.btnmain.Name = "btnmain";
            this.btnmain.Size = new System.Drawing.Size(95, 58);
            this.btnmain.TabIndex = 0;
            this.btnmain.Text = "main";
            this.btnmain.UseVisualStyleBackColor = true;
            this.btnmain.Click += new System.EventHandler(this.btnmain_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblnamnav;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Button btnhelp;
        private Button btninfo;
        private Button btnmain;
    }
}