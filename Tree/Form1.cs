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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.экспозицияTableAdapter.Fill(this.testDataSet.Экспозиция);
            this.картинаTableAdapter.Fill(this.testDataSet.Картина);
            this.реставрацияTableAdapter.Fill(this.testDataSet.Реставрация);
        }

        public void LoadDB()
        {
            treeView1.Nodes.Clear();
            if (testDataSet.Экспозиция.Any())
            {
                добавитьКартинуToolStripMenuItem.Enabled = true;
            }
            else
            {
                добавитьКартинуToolStripMenuItem.Enabled = false;
            }
            if (testDataSet.Картина.Any())
            {
                добавитьРеставрациюToolStripMenuItem.Enabled = true;
            }
            else
            {
                добавитьРеставрациюToolStripMenuItem.Enabled = false;
            }
            try
            {
                foreach (var x in testDataSet.Экспозиция)
                {
                    var node = treeView1.Nodes.Add(x.Название);
                    node.ContextMenuStrip = ExpStrip;
                    node.Name = x.Код.ToString();
                    node.Nodes.Add("(Пусто)").Tag = "Empty";
                    node.Tag = "Expo";
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибка загрузки некоторых элементов БД!\nОстальные элементы загружены.");
            }
        }
        private void ConnectDB_Click(object sender, EventArgs e)
        {
            добавитьToolStripMenuItem.Enabled = true;
            LoadDB();
        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expo xp = new Expo(int.Parse(treeView1.SelectedNode.Name), this);
            xp.saveCh.Text = "Сохранить изменения";
            xp.label1.Text = "Просмотр/ изменение экспозиции";
            xp.saveCh.Tag = "edit";
            xp.ShowDialog();
            testDataSetBindingSource.EndEdit();
            экспозицияTableAdapter.Update(testDataSet.Экспозиция);
        }
        private void LoadRests(TreeNode parent)
        {
            parent.Nodes.Clear();
            foreach (var x in testDataSet.Реставрация.Where(r => r.Картина == int.Parse(parent.Name)))
            {
                var node = parent.Nodes.Add("Реставрация №" + x.Код_р + " от " + x.Дата_проведения.ToString("d"));
                node.ContextMenuStrip = RestStrip;
                node.Name = x.Код_р.ToString();
                node.Tag = "Rest";
            }
        }
        public void LoadPics(TreeNode parent)
        {
            parent.Nodes.Clear();
            foreach (var x in testDataSet.Картина.Where(p => p.Экспозиция == int.Parse(parent.Name)))
            {
                var node = parent.Nodes.Add(x.Название);
                node.ContextMenuStrip = PicStrip;
                node.Name = x.Код_К.ToString();
                node.Tag = "Pic";
                node.Nodes.Add("(Пусто)").Tag = "Empty";
            }
        }

        public void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes[0].Tag.ToString() == "Empty")
            {
                switch (node.Tag)
                {
                    case "Expo":
                        {
                            LoadPics(node);
                            break;
                        }
                    case "Pic":
                        {
                            LoadRests(node);
                            break;
                        }
                    default: { break; }
                }
            }
        }

        private void просмотретьизменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic picc = new pic(int.Parse(treeView1.SelectedNode.Name), this);
            picc.saveCh.Text = "Сохранить изменения";
            picc.label1.Text = "Просмотр/ изменение картины";
            picc.saveCh.Tag = "edit";
            picc.ShowDialog();
            Validate();
            testDataSetBindingSource.EndEdit();
            картинаTableAdapter.Update(testDataSet.Картина);
        }

        private void названиеTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void год_созданияTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void экспозицияComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void названиеLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void год_созданияLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            testDataSetBindingSource.EndEdit();
            экспозицияTableAdapter.Update(testDataSet.Экспозиция);
            картинаTableAdapter.Update(testDataSet.Картина);
            реставрацияTableAdapter.Update(testDataSet.Реставрация);
            Application.Exit();
        }

        private void saveCh_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
            }
        }

        private void addP_Click(object sender, EventArgs e)
        {
            pic picc = new pic(this);
            picc.saveCh.Text = "Добавить картину";
            picc.saveCh.Tag = "add";
            picc.label1.Text = "Добавление картины";
            picc.ShowDialog();
            Validate();
            картинаBindingSource.EndEdit();
            картинаTableAdapter.Update(testDataSet.Картина);
            testDataSetBindingSource.EndEdit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteP_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите удалить выбранную картину?\nВся её история реставрации также удалится.", "Удаление", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                картинаBindingSource.Position = testDataSet.Картина.AsParallel().ToList().FindIndex(p => p.Код_К == int.Parse(treeView1.SelectedNode.Name));
                картинаBindingSource.RemoveCurrent();
                Validate();
                картинаBindingSource.EndEdit();
                картинаTableAdapter.Update(testDataSet.Картина);
                MessageBox.Show("Картина успешно удалена!");
                LoadPics(treeView1.SelectedNode.Parent);
            }
        }

        private void editR_Click(object sender, EventArgs e)
        {
            Rest rest = new Rest(int.Parse(treeView1.SelectedNode.Name), this);
            rest.saveCh.Text = "Сохранить изменения";
            rest.label1.Text = "Просмотр/ изменение реставрации";
            rest.saveCh.Tag = "edit";
            rest.ShowDialog();
            Validate();
            testDataSetBindingSource.EndEdit();
            реставрацияTableAdapter.Update(testDataSet.Реставрация);
        }

        private void addR_Click(object sender, EventArgs e)
        {
            Rest rest = new Rest(this);
            rest.saveCh.Text = "Добавить реставрацию";
            rest.saveCh.Tag = "add";
            rest.label1.Text = "Добавление реставрации";
            rest.ShowDialog();
            Validate();
            testDataSetBindingSource.EndEdit();
            реставрацияTableAdapter.Update(testDataSet.Реставрация);
        }

        private void deleteR_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите удалить выбранную реставрацию?", "Удаление", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                реставрацияBindingSource.Position = testDataSet.Реставрация.AsParallel().ToList().FindIndex(p => p.Код_р == int.Parse(treeView1.SelectedNode.Name));
                реставрацияBindingSource.RemoveCurrent();
                Validate();
                testDataSetBindingSource.EndEdit();
                реставрацияTableAdapter.Update(testDataSet.Реставрация);
                MessageBox.Show("Реставрация успешно удалена!");
                LoadRests(treeView1.SelectedNode.Parent);
            }

        }

        private void addE_Click(object sender, EventArgs e)
        {
            Expo ex = new Expo(this);
            ex.saveCh.Text = "Добавить экспозицию";
            ex.saveCh.Tag = "add";
            ex.label1.Text = "Добавление экспозиции";
            ex.ShowDialog();
            Validate();
            testDataSetBindingSource.EndEdit();
            экспозицияTableAdapter.Update(testDataSet.Экспозиция);

        }

        private void deleteE_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите удалить выбранную экспозицию?\nВсе её картины с историями реставраций также удалятся.", "Удаление", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                экспозицияBindingSource.Position = testDataSet.Экспозиция.AsParallel().ToList().FindIndex(p => p.Код == int.Parse(treeView1.SelectedNode.Name));
                экспозицияBindingSource.RemoveCurrent();
                Validate();
                testDataSetBindingSource.EndEdit();
                экспозицияTableAdapter.Update(testDataSet.Экспозиция);
                MessageBox.Show("Экспозиция успешно удалена!");
                LoadDB();
            }
        }
    }
}
