namespace Library_system.Manage
{
    partial class formIndex_card
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtb_CurrentIndex = new System.Windows.Forms.TextBox();
            this.lblCurrentIndex = new System.Windows.Forms.Label();
            this.txtb_RangeTo = new System.Windows.Forms.TextBox();
            this.lblRangeTo = new System.Windows.Forms.Label();
            this.txtb_RangeFrom = new System.Windows.Forms.TextBox();
            this.lblRangeFrom = new System.Windows.Forms.Label();
            this.txtb_Description = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtb_Name = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtb_Code = new System.Windows.Forms.TextBox();
            this.lblcode = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Library_system_Database_LibrarySystemContextDataSet = new Library_system._Library_system_Database_LibrarySystemContextDataSet();
            this.indexTableAdapter = new Library_system._Library_system_Database_LibrarySystemContextDataSetTableAdapters.IndexTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Library_system_Database_LibrarySystemContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel);
            this.splitContainer1.Panel1.Controls.Add(this.btn_save);
            this.splitContainer1.Panel1.Controls.Add(this.lblIndex);
            this.splitContainer1.Panel1.Controls.Add(this.txtb_CurrentIndex);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentIndex);
            this.splitContainer1.Panel1.Controls.Add(this.txtb_RangeTo);
            this.splitContainer1.Panel1.Controls.Add(this.lblRangeTo);
            this.splitContainer1.Panel1.Controls.Add(this.txtb_RangeFrom);
            this.splitContainer1.Panel1.Controls.Add(this.lblRangeFrom);
            this.splitContainer1.Panel1.Controls.Add(this.txtb_Description);
            this.splitContainer1.Panel1.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel1.Controls.Add(this.txtb_Name);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.txtb_Code);
            this.splitContainer1.Panel1.Controls.Add(this.lblcode);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(680, 513);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(546, 300);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 33);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(436, 300);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 33);
            this.btn_save.TabIndex = 14;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "btn_save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblIndex.Location = new System.Drawing.Point(12, 37);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(72, 17);
            this.lblIndex.TabIndex = 12;
            this.lblIndex.Text = "lblIndex";
            // 
            // txtb_CurrentIndex
            // 
            this.txtb_CurrentIndex.Location = new System.Drawing.Point(151, 268);
            this.txtb_CurrentIndex.Name = "txtb_CurrentIndex";
            this.txtb_CurrentIndex.Size = new System.Drawing.Size(173, 23);
            this.txtb_CurrentIndex.TabIndex = 6;
            this.txtb_CurrentIndex.Text = "txtb_CurrentIndex";
            // 
            // lblCurrentIndex
            // 
            this.lblCurrentIndex.AutoSize = true;
            this.lblCurrentIndex.Location = new System.Drawing.Point(12, 271);
            this.lblCurrentIndex.Name = "lblCurrentIndex";
            this.lblCurrentIndex.Size = new System.Drawing.Size(128, 17);
            this.lblCurrentIndex.TabIndex = 10;
            this.lblCurrentIndex.Text = "lblCurrentIndex";
            // 
            // txtb_RangeTo
            // 
            this.txtb_RangeTo.Location = new System.Drawing.Point(477, 226);
            this.txtb_RangeTo.Name = "txtb_RangeTo";
            this.txtb_RangeTo.Size = new System.Drawing.Size(173, 23);
            this.txtb_RangeTo.TabIndex = 5;
            this.txtb_RangeTo.Text = "txtb_RangeTo";
            // 
            // lblRangeTo
            // 
            this.lblRangeTo.AutoSize = true;
            this.lblRangeTo.Location = new System.Drawing.Point(374, 232);
            this.lblRangeTo.Name = "lblRangeTo";
            this.lblRangeTo.Size = new System.Drawing.Size(88, 17);
            this.lblRangeTo.TabIndex = 8;
            this.lblRangeTo.Text = "lblRangeTo";
            // 
            // txtb_RangeFrom
            // 
            this.txtb_RangeFrom.Location = new System.Drawing.Point(151, 226);
            this.txtb_RangeFrom.Name = "txtb_RangeFrom";
            this.txtb_RangeFrom.Size = new System.Drawing.Size(173, 23);
            this.txtb_RangeFrom.TabIndex = 4;
            this.txtb_RangeFrom.Text = "txtb_RangeFrom";
            // 
            // lblRangeFrom
            // 
            this.lblRangeFrom.AutoSize = true;
            this.lblRangeFrom.Location = new System.Drawing.Point(12, 232);
            this.lblRangeFrom.Name = "lblRangeFrom";
            this.lblRangeFrom.Size = new System.Drawing.Size(104, 17);
            this.lblRangeFrom.TabIndex = 6;
            this.lblRangeFrom.Text = "lblRangeFrom";
            // 
            // txtb_Description
            // 
            this.txtb_Description.Location = new System.Drawing.Point(151, 101);
            this.txtb_Description.Multiline = true;
            this.txtb_Description.Name = "txtb_Description";
            this.txtb_Description.Size = new System.Drawing.Size(499, 94);
            this.txtb_Description.TabIndex = 3;
            this.txtb_Description.Text = "txtb_Description";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 107);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "lblDescription";
            // 
            // txtb_Name
            // 
            this.txtb_Name.Location = new System.Drawing.Point(477, 72);
            this.txtb_Name.Name = "txtb_Name";
            this.txtb_Name.Size = new System.Drawing.Size(173, 23);
            this.txtb_Name.TabIndex = 2;
            this.txtb_Name.Text = "txtb_Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(374, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            // 
            // txtb_Code
            // 
            this.txtb_Code.Location = new System.Drawing.Point(151, 72);
            this.txtb_Code.Name = "txtb_Code";
            this.txtb_Code.Size = new System.Drawing.Size(173, 23);
            this.txtb_Code.TabIndex = 1;
            this.txtb_Code.Text = "txtb_Code";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Location = new System.Drawing.Point(12, 78);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(64, 17);
            this.lblcode.TabIndex = 0;
            this.lblcode.Text = "lblcode";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rangeFromDataGridViewTextBoxColumn,
            this.rangeToDataGridViewTextBoxColumn,
            this.currentIndexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.indexBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rangeFromDataGridViewTextBoxColumn
            // 
            this.rangeFromDataGridViewTextBoxColumn.DataPropertyName = "RangeFrom";
            this.rangeFromDataGridViewTextBoxColumn.HeaderText = "RangeFrom";
            this.rangeFromDataGridViewTextBoxColumn.Name = "rangeFromDataGridViewTextBoxColumn";
            this.rangeFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rangeToDataGridViewTextBoxColumn
            // 
            this.rangeToDataGridViewTextBoxColumn.DataPropertyName = "RangeTo";
            this.rangeToDataGridViewTextBoxColumn.HeaderText = "RangeTo";
            this.rangeToDataGridViewTextBoxColumn.Name = "rangeToDataGridViewTextBoxColumn";
            this.rangeToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentIndexDataGridViewTextBoxColumn
            // 
            this.currentIndexDataGridViewTextBoxColumn.DataPropertyName = "CurrentIndex";
            this.currentIndexDataGridViewTextBoxColumn.HeaderText = "CurrentIndex";
            this.currentIndexDataGridViewTextBoxColumn.Name = "currentIndexDataGridViewTextBoxColumn";
            this.currentIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indexBindingSource
            // 
            this.indexBindingSource.DataMember = "Index";
            this.indexBindingSource.DataSource = this._Library_system_Database_LibrarySystemContextDataSet;
            // 
            // _Library_system_Database_LibrarySystemContextDataSet
            // 
            this._Library_system_Database_LibrarySystemContextDataSet.DataSetName = "_Library_system_Database_LibrarySystemContextDataSet";
            this._Library_system_Database_LibrarySystemContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // indexTableAdapter
            // 
            this.indexTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // formIndex_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 513);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formIndex_card";
            this.Text = "formIndex_card";
            this.Load += new System.EventHandler(this.formIndex_card_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Library_system_Database_LibrarySystemContextDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.TextBox txtb_Code;
        private System.Windows.Forms.TextBox txtb_Name;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtb_CurrentIndex;
        private System.Windows.Forms.Label lblCurrentIndex;
        private System.Windows.Forms.TextBox txtb_RangeTo;
        private System.Windows.Forms.Label lblRangeTo;
        private System.Windows.Forms.TextBox txtb_RangeFrom;
        private System.Windows.Forms.Label lblRangeFrom;
        private System.Windows.Forms.TextBox txtb_Description;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblIndex;
        private _Library_system_Database_LibrarySystemContextDataSet _Library_system_Database_LibrarySystemContextDataSet;
        private System.Windows.Forms.BindingSource indexBindingSource;
        private _Library_system_Database_LibrarySystemContextDataSetTableAdapters.IndexTableAdapter indexTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
    }
}