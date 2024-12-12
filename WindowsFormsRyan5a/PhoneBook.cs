using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsRyan5a
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonelistDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonelistDataSet1.PersonID' table. You can move, or remove it, as needed.
            this.personIDTableAdapter.Fill(this.phonelistDataSet1.PersonID);
            // TODO: This line of code loads data into the 'phonelistDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.phonelistDataSet.Person);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validate();
           personIDBindingSource.EndEdit();
           tableAdapterManager1.UpdateAll(phonelistDataSet1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            personIDBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            personIDBindingSource.RemoveCurrent();
            tableAdapterManager1.UpdateAll(phonelistDataSet1);
        }
    }
}
