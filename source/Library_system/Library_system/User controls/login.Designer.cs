namespace Library_system.User_controls
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtbusername = new System.Windows.Forms.TextBox();
            this.txtbpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(3, 0);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(72, 17);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "lbllogin";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(22, 47);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(96, 17);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "lblusername";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(22, 76);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(96, 17);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "lblpassword";
            // 
            // txtbusername
            // 
            this.txtbusername.Location = new System.Drawing.Point(124, 44);
            this.txtbusername.Name = "txtbusername";
            this.txtbusername.Size = new System.Drawing.Size(156, 23);
            this.txtbusername.TabIndex = 3;
            this.txtbusername.Text = "txtbusername";
            // 
            // txtbpassword
            // 
            this.txtbpassword.Location = new System.Drawing.Point(124, 73);
            this.txtbpassword.Name = "txtbpassword";
            this.txtbpassword.Size = new System.Drawing.Size(156, 23);
            this.txtbpassword.TabIndex = 4;
            this.txtbpassword.Text = "txtbpassword";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(124, 112);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 28);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "btnlogin";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(205, 112);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 28);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "btncancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtbpassword);
            this.Controls.Add(this.txtbusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "login";
            this.Size = new System.Drawing.Size(354, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtbusername;
        private System.Windows.Forms.TextBox txtbpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncancel;
    }
}
