
namespace Tree
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ExpStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editE = new System.Windows.Forms.ToolStripMenuItem();
            this.addE = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteE = new System.Windows.Forms.ToolStripMenuItem();
            this.PicStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editP = new System.Windows.Forms.ToolStripMenuItem();
            this.addP = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteP = new System.Windows.Forms.ToolStripMenuItem();
            this.RestStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editR = new System.Windows.Forms.ToolStripMenuItem();
            this.addR = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteR = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Tree.testDataSet();
            this.картинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.картинаTableAdapter = new Tree.testDataSetTableAdapters.КартинаTableAdapter();
            this.реставрацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реставрацияTableAdapter = new Tree.testDataSetTableAdapters.РеставрацияTableAdapter();
            this.экспозицияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экспозицияTableAdapter = new Tree.testDataSetTableAdapters.ЭкспозицияTableAdapter();
            this.treeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКартинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРеставрациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpStrip.SuspendLayout();
            this.PicStrip.SuspendLayout();
            this.RestStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картинаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реставрацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экспозицияBindingSource)).BeginInit();
            this.treeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.ContextMenuStrip = this.treeMenu;
            this.treeView1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView1.Location = new System.Drawing.Point(12, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(290, 463);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // ExpStrip
            // 
            this.ExpStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editE,
            this.addE,
            this.deleteE});
            this.ExpStrip.Name = "ExpStrip";
            this.ExpStrip.Size = new System.Drawing.Size(215, 70);
            // 
            // editE
            // 
            this.editE.Name = "editE";
            this.editE.Size = new System.Drawing.Size(214, 22);
            this.editE.Text = "Просмотреть/изменить...";
            this.editE.Click += new System.EventHandler(this.просмотретьToolStripMenuItem_Click);
            // 
            // addE
            // 
            this.addE.Name = "addE";
            this.addE.Size = new System.Drawing.Size(214, 22);
            this.addE.Text = "Добавить...";
            this.addE.Click += new System.EventHandler(this.addE_Click);
            // 
            // deleteE
            // 
            this.deleteE.Name = "deleteE";
            this.deleteE.Size = new System.Drawing.Size(214, 22);
            this.deleteE.Text = "Удалить...";
            this.deleteE.Click += new System.EventHandler(this.deleteE_Click);
            // 
            // PicStrip
            // 
            this.PicStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editP,
            this.addP,
            this.deleteP});
            this.PicStrip.Name = "PicStrip";
            this.PicStrip.Size = new System.Drawing.Size(215, 70);
            // 
            // editP
            // 
            this.editP.Name = "editP";
            this.editP.Size = new System.Drawing.Size(214, 22);
            this.editP.Text = "Просмотреть/изменить...";
            this.editP.Click += new System.EventHandler(this.просмотретьизменитьToolStripMenuItem_Click);
            // 
            // addP
            // 
            this.addP.Name = "addP";
            this.addP.Size = new System.Drawing.Size(214, 22);
            this.addP.Text = "Добавить...";
            this.addP.Click += new System.EventHandler(this.addP_Click);
            // 
            // deleteP
            // 
            this.deleteP.Name = "deleteP";
            this.deleteP.Size = new System.Drawing.Size(214, 22);
            this.deleteP.Text = "Удалить...";
            this.deleteP.Click += new System.EventHandler(this.deleteP_Click);
            // 
            // RestStrip
            // 
            this.RestStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editR,
            this.addR,
            this.deleteR});
            this.RestStrip.Name = "RestStrip";
            this.RestStrip.Size = new System.Drawing.Size(215, 70);
            // 
            // editR
            // 
            this.editR.Name = "editR";
            this.editR.Size = new System.Drawing.Size(214, 22);
            this.editR.Text = "Просмотреть/изменить...";
            this.editR.Click += new System.EventHandler(this.editR_Click);
            // 
            // addR
            // 
            this.addR.Name = "addR";
            this.addR.Size = new System.Drawing.Size(214, 22);
            this.addR.Text = "Добавить...";
            this.addR.Click += new System.EventHandler(this.addR_Click);
            // 
            // deleteR
            // 
            this.deleteR.Name = "deleteR";
            this.deleteR.Size = new System.Drawing.Size(214, 22);
            this.deleteR.Text = "Удалить...";
            this.deleteR.Click += new System.EventHandler(this.deleteR_Click);
            // 
            // ConnectDB
            // 
            this.ConnectDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConnectDB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectDB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConnectDB.Location = new System.Drawing.Point(12, 12);
            this.ConnectDB.Name = "ConnectDB";
            this.ConnectDB.Size = new System.Drawing.Size(290, 37);
            this.ConnectDB.TabIndex = 3;
            this.ConnectDB.Text = "Подключиться к БД";
            this.ConnectDB.UseVisualStyleBackColor = false;
            this.ConnectDB.Click += new System.EventHandler(this.ConnectDB_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // картинаBindingSource
            // 
            this.картинаBindingSource.DataMember = "Картина";
            this.картинаBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // картинаTableAdapter
            // 
            this.картинаTableAdapter.ClearBeforeFill = true;
            // 
            // реставрацияBindingSource
            // 
            this.реставрацияBindingSource.DataMember = "Реставрация";
            this.реставрацияBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // реставрацияTableAdapter
            // 
            this.реставрацияTableAdapter.ClearBeforeFill = true;
            // 
            // экспозицияBindingSource
            // 
            this.экспозицияBindingSource.DataMember = "Экспозиция";
            this.экспозицияBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // экспозицияTableAdapter
            // 
            this.экспозицияTableAdapter.ClearBeforeFill = true;
            // 
            // treeMenu
            // 
            this.treeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.добавитьКартинуToolStripMenuItem,
            this.добавитьРеставрациюToolStripMenuItem});
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.Size = new System.Drawing.Size(212, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Enabled = false;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить экспозицию...";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.addE_Click);
            // 
            // добавитьКартинуToolStripMenuItem
            // 
            this.добавитьКартинуToolStripMenuItem.Enabled = false;
            this.добавитьКартинуToolStripMenuItem.Name = "добавитьКартинуToolStripMenuItem";
            this.добавитьКартинуToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьКартинуToolStripMenuItem.Text = "Добавить картину...";
            this.добавитьКартинуToolStripMenuItem.Click += new System.EventHandler(this.addP_Click);
            // 
            // добавитьРеставрациюToolStripMenuItem
            // 
            this.добавитьРеставрациюToolStripMenuItem.Enabled = false;
            this.добавитьРеставрациюToolStripMenuItem.Name = "добавитьРеставрациюToolStripMenuItem";
            this.добавитьРеставрациюToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьРеставрациюToolStripMenuItem.Text = "Добавить реставрацию...";
            this.добавитьРеставрациюToolStripMenuItem.Click += new System.EventHandler(this.addR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(315, 573);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConnectDB);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ExpStrip.ResumeLayout(false);
            this.PicStrip.ResumeLayout(false);
            this.RestStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картинаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реставрацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экспозицияBindingSource)).EndInit();
            this.treeMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ExpStrip;
        private System.Windows.Forms.ContextMenuStrip PicStrip;
        private System.Windows.Forms.ContextMenuStrip RestStrip;
        private System.Windows.Forms.Button ConnectDB;
        private System.Windows.Forms.ToolStripMenuItem editE;
        private System.Windows.Forms.ToolStripMenuItem addE;
        private System.Windows.Forms.ToolStripMenuItem deleteE;
        private System.Windows.Forms.ToolStripMenuItem editP;
        private System.Windows.Forms.ToolStripMenuItem addP;
        private System.Windows.Forms.ToolStripMenuItem deleteP;
        private System.Windows.Forms.ToolStripMenuItem editR;
        private System.Windows.Forms.ToolStripMenuItem addR;
        private System.Windows.Forms.ToolStripMenuItem deleteR;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.BindingSource testDataSetBindingSource;
        public testDataSet testDataSet;
        public System.Windows.Forms.BindingSource картинаBindingSource;
        public System.Windows.Forms.BindingSource реставрацияBindingSource;
        public System.Windows.Forms.BindingSource экспозицияBindingSource;
        public testDataSetTableAdapters.КартинаTableAdapter картинаTableAdapter;
        public testDataSetTableAdapters.РеставрацияTableAdapter реставрацияTableAdapter;
        public testDataSetTableAdapters.ЭкспозицияTableAdapter экспозицияTableAdapter;
        private System.Windows.Forms.ContextMenuStrip treeMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКартинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРеставрациюToolStripMenuItem;
    }
}

