namespace DeveloperHidTheFlag
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btncheckUnPw = new System.Windows.Forms.Button();
            this.RaMBo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(12, 39);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(265, 54);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username :";
            this.lblusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(22, 121);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(255, 54);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 54);
            this.label3.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(301, 39);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(251, 61);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(301, 121);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(251, 61);
            this.txtpassword.TabIndex = 4;
            // 
            // btncheckUnPw
            // 
            this.btncheckUnPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckUnPw.Location = new System.Drawing.Point(67, 230);
            this.btncheckUnPw.Name = "btncheckUnPw";
            this.btncheckUnPw.Size = new System.Drawing.Size(414, 62);
            this.btncheckUnPw.TabIndex = 5;
            this.btncheckUnPw.Text = "Check answer";
            this.btncheckUnPw.UseVisualStyleBackColor = true;
            this.btncheckUnPw.Click += new System.EventHandler(this.btncheckUnPw_Click);
            // 
            // RaMBo
            // 
            this.RaMBo.Location = new System.Drawing.Point(753, 572);
            this.RaMBo.Name = "RaMBo";
            this.RaMBo.Size = new System.Drawing.Size(100, 22);
            this.RaMBo.TabIndex = 6;
            this.RaMBo.Text = "RaMBo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 321);
            this.Controls.Add(this.RaMBo);
            this.Controls.Add(this.btncheckUnPw);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DeveloperHidTheFlag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btncheckUnPw;
        private System.Windows.Forms.TextBox RaMBo;
    }
}

