namespace Library_system.Account
{
    partial class formlogin
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
            this.lblcreate = new System.Windows.Forms.LinkLabel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtbpassword = new System.Windows.Forms.TextBox();
            this.txtbusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcreate
            // 
            this.lblcreate.AutoSize = true;
            this.lblcreate.Location = new System.Drawing.Point(240, 14);
            this.lblcreate.Name = "lblcreate";
            this.lblcreate.Size = new System.Drawing.Size(47, 13);
            this.lblcreate.TabIndex = 1;
            this.lblcreate.TabStop = true;
            this.lblcreate.Text = "lblcreate";
            this.lblcreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblcreate_LinkClicked);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(218, 122);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 28);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "btncancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(137, 122);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 28);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "btnlogin";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtbpassword
            // 
            this.txtbpassword.Location = new System.Drawing.Point(137, 83);
            this.txtbpassword.Name = "txtbpassword";
            this.txtbpassword.Size = new System.Drawing.Size(156, 20);
            this.txtbpassword.TabIndex = 11;
            this.txtbpassword.Text = "txtbpassword";
            // 
            // txtbusername
            // 
            this.txtbusername.Location = new System.Drawing.Point(137, 54);
            this.txtbusername.Name = "txtbusername";
            this.txtbusername.Size = new System.Drawing.Size(156, 20);
            this.txtbusername.TabIndex = 10;
            this.txtbusername.Text = "txtbusername";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(35, 86);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(96, 17);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "lblpassword";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(35, 57);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(96, 17);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "lblusername";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(16, 10);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(72, 17);
            this.lbllogin.TabIndex = 7;
            this.lbllogin.Text = "lbllogin";
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 242);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtbpassword);
            this.Controls.Add(this.txtbusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lblcreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblcreate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtbpassword;
        private System.Windows.Forms.TextBox txtbusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbllogin;
    }
}