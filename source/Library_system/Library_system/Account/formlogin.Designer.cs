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
            this.login1 = new Library_system.User_controls.login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.Location = new System.Drawing.Point(13, 13);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(354, 231);
            this.login1.TabIndex = 0;
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 193);
            this.Controls.Add(this.login1);
            this.Name = "formlogin";
            this.Text = "Log-in";
            this.ResumeLayout(false);

        }

        #endregion

        private User_controls.login login1;
    }
}