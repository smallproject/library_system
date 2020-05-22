using Library_system.Database;
using Library_system.Database.UnitOfWork;
using System;
using System.Windows.Forms;

namespace Library_system.Manage
{
    public partial class formIndex_card : Form
    {
        private bool _newIndex = false;
        public formIndex_card()
        {
            InitializeComponent();
            onInit();
        }

        private void onInit()
        {
            emptyFields();
            fieldsEnableValue(false);
            buttonSwitch(false);
        }

        private void emptyFields()
        {
            //Labels
            lblIndex.Text = @"Index";
            lblcode.Text = @"Code";
            lblDescription.Text = @"Description";
            lblName.Text = @"Name";
            lblRangeFrom.Text = @"Range From";
            lblRangeTo.Text = @"Range To";
            lblCurrentIndex.Text = @"Current Index";

            //Textboxes
            txtb_Code.Text = "";
            txtb_Name.Text = "";
            txtb_Description.Text = "";
            txtb_RangeFrom.Text = "0";
            txtb_RangeTo.Text = "0";
            txtb_CurrentIndex.Text = "0";

            //Buttons
            btn_save.Text = @"Save";
            btn_cancel.Text = @"Cancel";
        }

        private void formIndex_card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Library_system_Database_LibrarySystemContextDataSet.Index' table. You can move, or remove it, as needed.
            this.indexTableAdapter.Fill(this._Library_system_Database_LibrarySystemContextDataSet.Index);

        }


        private void buttonSwitch(bool enableBtn)
        {
            btn_save.Visible = enableBtn;
            btn_save.Enabled = enableBtn;
            btn_cancel.Visible = enableBtn;
            btn_cancel.Enabled = enableBtn;
        }


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //needs to modify async delay
            //var t = Task.Run(async delegate
            //{
            //    await Task.Delay(1000);
            //    this.dataGridView1.Rows.Clear();
            //});

            //t.Wait();
            //this.dataGridView1.Refresh();
            //return;

            //indexBindingSource.ResetBindings(true);

            formIndex_card_Load(this, null);
            dataGridView1.ClearSelection();
        }


        private void delayTask()
        {

        }

        private void fieldsEnableValue(bool value)
        {
            txtb_Code.Enabled = value;
            txtb_Name.Enabled = value;
            txtb_Description.Enabled = value;
            txtb_RangeFrom.Enabled = value;
            txtb_RangeTo.Enabled = value;
            txtb_CurrentIndex.Enabled = value;
        }

        private void fieldsEnableValue(bool value, bool newValue)
        {
            txtb_Code.Enabled = newValue;
            txtb_Name.Enabled = value;
            txtb_Description.Enabled = value;
            txtb_RangeFrom.Enabled = value;
            txtb_RangeTo.Enabled = value;
            txtb_CurrentIndex.Enabled = value;
            btn_save.Enabled = value;
        }

        private Index localIndex;

        private Index fieldsToIndex()
        {
            return new Index()
            {

                Code = txtb_Code.Text,
                Name = txtb_Name.Text,
                Description = txtb_Description.Text,
                RangeFrom = Int32.Parse(txtb_RangeFrom.Text),
                RangeTo = Int32.Parse(txtb_RangeTo.Text),
                CurrentIndex = Int32.Parse(txtb_CurrentIndex.Text)
            };
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count.Equals(0))
            {
                deleteToolStripMenuItem.Enabled = false;
                return;
            }

            txtb_Code.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtb_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtb_Description.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtb_RangeFrom.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtb_RangeTo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtb_CurrentIndex.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


            deleteToolStripMenuItem.Enabled = true;
            //return;

            //StringBuilder text = new StringBuilder();
            //text.AppendLine(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //text.AppendLine(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            //text.AppendLine(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            //text.AppendLine(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            //text.AppendLine(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            //text.AppendLine(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            //MessageBox.Show(text.ToString());

            //txtb_Code.Text = dataGridView1.SelectedRows[0].ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            fieldsEnableValue(false);
            buttonSwitch(false);
            _newIndex = false;

            dataGridView1.ClearSelection();
            //dataGridView1.MultiSelect = false;
            //dataGridView1.MultiSelect = true;
            dataGridView1.Rows[0].Selected = true;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView1_SelectionChanged(this, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fieldsEnableValue(true, false);
            buttonSwitch(true);

            dataGridView1_SelectionChanged(this, null);
        }

        //new index
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emptyFields();
            fieldsEnableValue(true, true);
            buttonSwitch(true);
            _newIndex = true;
        }

        //save or update index
        private void btn_save_Click(object sender, EventArgs e)
        {
            IIndexUow uow = new IndexUow();
            uow.Index = _declareValues();

            if (_newIndex)
            {
                uow.Create();
            }
            else
            {
                uow.Update();
            }

            emptyFields();
            buttonSwitch(false);
            fieldsEnableValue(false);

            //this.indexTableAdapter.ClearBeforeFill = true;
            //this.indexTableAdapter.Update(this._Library_system_Database_LibrarySystemContextDataSet.Index);
            formIndex_card_Load(this, null);
        }

        //delete index
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIndexUow uow = new IndexUow();
            uow.Index = _declareValues();
            uow.Delete();

            emptyFields();
            buttonSwitch(false);
            fieldsEnableValue(false);
            formIndex_card_Load(this, null);
        }

        private Index _declareValues()
        {
            return new Index()
            {
                Code = txtb_Code.Text,
                Name = txtb_Name.Text,
                Description = txtb_Description.Text,
                RangeFrom = Int32.Parse(txtb_RangeFrom.Text),
                RangeTo = Int32.Parse(txtb_RangeTo.Text),
                CurrentIndex = Int32.Parse(txtb_CurrentIndex.Text)
            };
        }
    }
}
