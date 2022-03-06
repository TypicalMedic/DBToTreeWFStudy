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
    public partial class Expo : Form
    {
        Form1 parent;
        public Expo(Form1 p)
        {
            parent = p;
            InitializeComponent();
            testDataSetBindingSource.DataSource = parent.testDataSetBindingSource.DataSource;
            //картинаBindingSource.DataSource = parent.картинаBindingSource.DataSource;
            //testDataSet = parent.testDataSet;
            картинаTableAdapter.Fill(testDataSet.Картина);
            реставрацияTableAdapter.Fill(testDataSet.Реставрация);
            экспозицияTableAdapter.Fill(testDataSet.Экспозиция);
            экспозицияBindingSource.AddNew();
        }

        public Expo(int id, Form1 pp)
        {
            parent = pp;
            InitializeComponent();
            testDataSetBindingSource.DataSource = parent.testDataSetBindingSource.DataSource;
            //картинаBindingSource.DataSource = parent.картинаBindingSource.DataSource;
            //testDataSet = parent.testDataSet;
            картинаTableAdapter.Fill(testDataSet.Картина);
            реставрацияTableAdapter.Fill(testDataSet.Реставрация);
            экспозицияTableAdapter.Fill(testDataSet.Экспозиция);
            int newid = testDataSet.Экспозиция.AsParallel().ToList().FindIndex(p => p.Код == id);
            экспозицияBindingSource.Position = newid;
        }

        private void год_созданияLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveCh_Click(object sender, EventArgs e)
        {
            Validate();
            экспозицияBindingSource.EndEdit();
            экспозицияTableAdapter.Update(testDataSet.Экспозиция);
            parent.экспозицияBindingSource.DataSource = экспозицияBindingSource.DataSource;
            parent.testDataSet = testDataSet;
            if (saveCh.Tag.ToString() == "add")
            {
                MessageBox.Show("Реставрация успешно добавлена!");
                экспозицияBindingSource.AddNew();
            }
            else
            {
                MessageBox.Show("Реставрация успешно изменена!");
            }
            parent.LoadDB();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Expo_Load(object sender, EventArgs e)
        {

        }
    }
}
