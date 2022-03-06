
namespace Tree
{
    partial class pic
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
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label год_созданияLabel;
            System.Windows.Forms.Label экспозицияLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.saveCh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.названиеTextBox1 = new System.Windows.Forms.TextBox();
            this.testDataSet = new Tree.testDataSet();
            this.год_созданияTextBox1 = new System.Windows.Forms.TextBox();
            this.экспозицияComboBox1 = new System.Windows.Forms.ComboBox();
            this.картинаTableAdapter = new Tree.testDataSetTableAdapters.КартинаTableAdapter();
            this.tableAdapterManager = new Tree.testDataSetTableAdapters.TableAdapterManager();
            this.реставрацияTableAdapter = new Tree.testDataSetTableAdapters.РеставрацияTableAdapter();
            this.экспозицияTableAdapter = new Tree.testDataSetTableAdapters.ЭкспозицияTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экспозицияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.картинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реставрацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            названиеLabel = new System.Windows.Forms.Label();
            год_созданияLabel = new System.Windows.Forms.Label();
            экспозицияLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экспозицияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картинаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реставрацияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            названиеLabel.Location = new System.Drawing.Point(19, 81);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(106, 22);
            названиеLabel.TabIndex = 13;
            названиеLabel.Text = "Название:";
            названиеLabel.Click += new System.EventHandler(this.названиеLabel_Click);
            // 
            // год_созданияLabel
            // 
            год_созданияLabel.AutoSize = true;
            год_созданияLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            год_созданияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            год_созданияLabel.Location = new System.Drawing.Point(19, 169);
            год_созданияLabel.Name = "год_созданияLabel";
            год_созданияLabel.Size = new System.Drawing.Size(141, 22);
            год_созданияLabel.TabIndex = 14;
            год_созданияLabel.Text = "Год создания:";
            // 
            // экспозицияLabel
            // 
            экспозицияLabel.AutoSize = true;
            экспозицияLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            экспозицияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            экспозицияLabel.Location = new System.Drawing.Point(19, 247);
            экспозицияLabel.Name = "экспозицияLabel";
            экспозицияLabel.Size = new System.Drawing.Size(127, 22);
            экспозицияLabel.TabIndex = 15;
            экспозицияLabel.Text = "Экспозиция:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 81);
            this.label1.TabIndex = 16;
            this.label1.Text = "Просмотр/ изменение картины";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveCh
            // 
            this.saveCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveCh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveCh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveCh.Location = new System.Drawing.Point(12, 337);
            this.saveCh.Name = "saveCh";
            this.saveCh.Size = new System.Drawing.Size(306, 91);
            this.saveCh.TabIndex = 17;
            this.saveCh.Text = "Сохранить изменения";
            this.saveCh.UseVisualStyleBackColor = false;
            this.saveCh.Click += new System.EventHandler(this.saveCh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.названиеTextBox1);
            this.panel1.Controls.Add(this.год_созданияTextBox1);
            this.panel1.Controls.Add(this.экспозицияComboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(названиеLabel);
            this.panel1.Controls.Add(год_созданияLabel);
            this.panel1.Controls.Add(экспозицияLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 321);
            this.panel1.TabIndex = 21;
            this.panel1.Tag = "panel";
            // 
            // названиеTextBox1
            // 
            this.названиеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.картинаBindingSource, "Название", true));
            this.названиеTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.названиеTextBox1.Location = new System.Drawing.Point(25, 106);
            this.названиеTextBox1.Name = "названиеTextBox1";
            this.названиеTextBox1.Size = new System.Drawing.Size(263, 27);
            this.названиеTextBox1.TabIndex = 22;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // год_созданияTextBox1
            // 
            this.год_созданияTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.картинаBindingSource, "Год_создания", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.год_созданияTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.год_созданияTextBox1.Location = new System.Drawing.Point(25, 194);
            this.год_созданияTextBox1.Name = "год_созданияTextBox1";
            this.год_созданияTextBox1.Size = new System.Drawing.Size(263, 27);
            this.год_созданияTextBox1.TabIndex = 24;
            this.год_созданияTextBox1.TextChanged += new System.EventHandler(this.год_созданияTextBox1_TextChanged);
            // 
            // экспозицияComboBox1
            // 
            this.экспозицияComboBox1.CausesValidation = false;
            this.экспозицияComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.картинаBindingSource, "Экспозиция", true));
            this.экспозицияComboBox1.DataSource = this.экспозицияBindingSource;
            this.экспозицияComboBox1.DisplayMember = "Название";
            this.экспозицияComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.экспозицияComboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.экспозицияComboBox1.FormattingEnabled = true;
            this.экспозицияComboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.экспозицияComboBox1.Location = new System.Drawing.Point(23, 272);
            this.экспозицияComboBox1.Name = "экспозицияComboBox1";
            this.экспозицияComboBox1.Size = new System.Drawing.Size(265, 29);
            this.экспозицияComboBox1.TabIndex = 26;
            this.экспозицияComboBox1.ValueMember = "Код";
            // 
            // картинаTableAdapter
            // 
            this.картинаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Tree.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КартинаTableAdapter = this.картинаTableAdapter;
            this.tableAdapterManager.РеставрацияTableAdapter = this.реставрацияTableAdapter;
            this.tableAdapterManager.ЭкспозицияTableAdapter = this.экспозицияTableAdapter;
            // 
            // реставрацияTableAdapter
            // 
            this.реставрацияTableAdapter.ClearBeforeFill = true;
            // 
            // экспозицияTableAdapter
            // 
            this.экспозицияTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // экспозицияBindingSource
            // 
            this.экспозицияBindingSource.DataMember = "Экспозиция";
            this.экспозицияBindingSource.DataSource = this.testDataSet;
            // 
            // картинаBindingSource
            // 
            this.картинаBindingSource.DataMember = "Картина";
            this.картинаBindingSource.DataSource = this.testDataSet;
            // 
            // реставрацияBindingSource
            // 
            this.реставрацияBindingSource.DataMember = "Реставрация";
            this.реставрацияBindingSource.DataSource = this.testDataSet;
            // 
            // pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(329, 491);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveCh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pic";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pic";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.pic_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экспозицияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картинаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реставрацияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private testDataSetTableAdapters.КартинаTableAdapter картинаTableAdapter;
        private testDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private testDataSetTableAdapters.ЭкспозицияTableAdapter экспозицияTableAdapter;
        private System.Windows.Forms.Button button1;
        private testDataSet testDataSet;
        private testDataSetTableAdapters.РеставрацияTableAdapter реставрацияTableAdapter;
        private System.Windows.Forms.TextBox названиеTextBox1;
        private System.Windows.Forms.TextBox год_созданияTextBox1;
        private System.Windows.Forms.ComboBox экспозицияComboBox1;
        public System.Windows.Forms.Button saveCh;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource картинаBindingSource;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private System.Windows.Forms.BindingSource экспозицияBindingSource;
        private System.Windows.Forms.BindingSource реставрацияBindingSource;
    }
}