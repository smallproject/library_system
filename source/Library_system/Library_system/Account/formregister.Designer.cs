namespace Library_system.Account
{
    partial class formregister
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
            this.register1 = new Library_system.User_controls.register();
            this.SuspendLayout();
            // 
            // register1
            // 
            this.register1.birthdate = new System.DateTime(((long)(0)));
            this.register1.firstname = null;
            this.register1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register1.lastname = null;
            this.register1.Location = new System.Drawing.Point(13, 13);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(441, 433);
            this.register1.TabIndex = 0;
            // 
            // formregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 471);
            this.Controls.Add(this.register1);
            this.Name = "formregister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.ResumeLayout(false);

        }

        #endregion

        private User_controls.register register1;
    }
}