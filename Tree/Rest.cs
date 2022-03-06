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
    public partial class Rest : Form
    {
        Form1 parent;
        public Rest(Form1 p)
        {
            parent = p;
            InitializeComponent();
            testDataSetBindingSource.DataSource = parent.testDataSetBindingSource.DataSource;
            //картинаBindingSource.DataSource = parent.картинаBindingSource.DataSource;
            //testDataSet = parent.testDataSet;
            картинаTableAdapter.Fill(testDataSet.Картина);
            реставрацияTableAdapter.Fill(testDataSet.Реставрация);
            экспозицияTableAdapter.Fill(testDataSet.Экспозиция);
            реставрацияBindingSource.AddNew();
        }

        public Rest(int id, Form1 pp)
        {
            parent = pp;
            InitializeComponent();
            testDataSetBindingSource.DataSource = parent.testDataSetBindingSource.DataSource;
            //testDataSet = parent.testDataSet;
            картинаTableAdapter.Fill(testDataSet.Картина);
            реставрацияTableAdapter.Fill(testDataSet.Реставрация);
            экспозицияTableAdapter.Fill(testDataSet.Экспозиция);
            int newid = testDataSet.Реставрация.AsParallel().ToList().FindIndex(p => p.Код_р == id);
            реставрацияBindingSource.Position = newid;
        }

        private void названиеLabel_Click(object sender, EventArgs e)
        {

        }

        private void Rest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveCh_Click(object sender, EventArgs e)
        {
            this.Validate();
            реставрацияBindingSource.EndEdit();
            реставрацияTableAdapter.Update(testDataSet.Реставрация);
            parent.реставрацияBindingSource.DataSource = реставрацияBindingSource.DataSource;
            parent.картинаBindingSource.DataSource = картинаBindingSource.DataSource;
            parent.экспозицияBindingSource.DataSource = экспозицияBindingSource.DataSource;
            parent.testDataSet = testDataSet;
            if (saveCh.Tag.ToString() == "add")
            {
                MessageBox.Show("Реставрация успешно добавлена!");
                реставрацияBindingSource.AddNew();
            }
            else
            {
                MessageBox.Show("Реставрация успешно изменена!");
            }
            parent.LoadDB();
        }
    }
}
