using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class pic : Form
    {
        Form1 parent;
        public pic(Form1 p)
        {
            parent = p;
            InitializeComponent();
            testDataSetBindingSource.DataSource = parent.testDataSetBindingSource.DataSource;
            //картинаBindingSource.DataSource = parent.картинаBindingSource.DataSource;
            //testDataSet = parent.testDataSet;
            картинаTableAdapter.Fill(testDataSet.Картина);
            экспозицияTableAdapter.Fill(testDataSet.Экспозиция);
            реставрацияTableAdapter.Fill(testDataSet.Реставрация);
            картинаBindingSource.AddNew();
        }

        public pic(int id, Form1 pp)
        {
            parent = pp;
            InitializeComponent();
            // картинаBindingSource.DataSource = parent.картинаBindingSource;
            testDataSetBindingSource.DataSource = parent.testDataSetBindingSource.DataSource;
            // testDataSet = parent.testDataSet;
            картинаTableAdapter.Fill(testDataSet.Картина);
            экспозицияTableAdapter.Fill(testDataSet.Экспозиция);
            реставрацияTableAdapter.Fill(testDataSet.Реставрация);
            int newid = testDataSet.Картина.AsParallel().ToList().FindIndex(p => p.Код_К == id);
            картинаBindingSource.Position = newid;
        }

        private void картинаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.картинаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet);

        }

        private void картинаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.картинаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet);

        }

        private void pic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Реставрация' table. You can move, or remove it, as needed.
            // this.реставрацияTableAdapter.Fill(this.testDataSet.Реставрация);
            //// TODO: This line of code loads data into the 'testDataSet.Экспозиция' table. You can move, or remove it, as needed.
            //// TODO: This line of code loads data into the 'testDataSet.Картина' table. You can move, or remove it, as needed.
            //this.картинаTableAdapter.Fill(this.testDataSet.Картина);

        }

        private void названиеLabel_Click(object sender, EventArgs e)
        {

        }

        private void экспозицияComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void год_созданияTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveCh_Click(object sender, EventArgs e)
        {
            this.Validate();
            //экспозицияBindingSource.EndEdit();
            //экспозицияTableAdapter.Update(testDataSet.Экспозиция);
            //testDataSetBindingSource.EndEdit();
            картинаBindingSource.EndEdit();
            картинаTableAdapter.Update(testDataSet.Картина);
            parent.картинаBindingSource.DataSource = картинаBindingSource.DataSource;
            //parent.экспозицияBindingSource.DataSource = экспозицияBindingSource.DataSource;
            //parent.testDataSetBindingSource.DataSource = testDataSetBindingSource.DataSource;
            parent.testDataSet = testDataSet;
            if (saveCh.Tag.ToString() == "add")
            {
                MessageBox.Show("Картина успешно добавлена!");
                картинаBindingSource.AddNew();
            }
            else
            {
                MessageBox.Show("Картина успешно изменена!");
            }
            parent.LoadDB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
