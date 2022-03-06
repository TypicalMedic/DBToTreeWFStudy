
namespace Tree
{
    partial class Rest
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
            System.Windows.Forms.Label год_созданияLabel;
            System.Windows.Forms.Label названиеLabel;
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Tree.testDataSet();
            this.экспозицияTableAdapter = new Tree.testDataSetTableAdapters.ЭкспозицияTableAdapter();
            this.реставрацияTableAdapter = new Tree.testDataSetTableAdapters.РеставрацияTableAdapter();
            this.tableAdapterManager = new Tree.testDataSetTableAdapters.TableAdapterManager();
            this.картинаTableAdapter = new Tree.testDataSetTableAdapters.КартинаTableAdapter();
            this.экспозицияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.картинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveCh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.дата_проведенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.реставрацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.картинаComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            год_созданияLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экспозицияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картинаBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.реставрацияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // год_созданияLabel
            // 
            год_созданияLabel.AutoSize = true;
            год_созданияLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            год_созданияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            год_созданияLabel.Location = new System.Drawing.Point(19, 169);
            год_созданияLabel.Name = "год_созданияLabel";
            год_созданияLabel.Size = new System.Drawing.Size(262, 22);
            год_созданияLabel.TabIndex = 14;
            год_созданияLabel.Text = "Реставрируемая картина:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            названиеLabel.Location = new System.Drawing.Point(19, 81);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(199, 22);
            названиеLabel.TabIndex = 13;
            названиеLabel.Text = "Дата начала работ:";
            названиеLabel.Click += new System.EventHandler(this.названиеLabel_Click);
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
            // экспозицияTableAdapter
            // 
            this.экспозицияTableAdapter.ClearBeforeFill = true;
            // 
            // реставрацияTableAdapter
            // 
            this.реставрацияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Tree.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КартинаTableAdapter = this.картинаTableAdapter;
            this.tableAdapterManager.РеставрацияTableAdapter = this.реставрацияTableAdapter;
            this.tableAdapterManager.ЭкспозицияTableAdapter = this.экспозицияTableAdapter;
            // 
            // картинаTableAdapter
            // 
            this.картинаTableAdapter.ClearBeforeFill = true;
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
            // saveCh
            // 
            this.saveCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveCh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveCh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveCh.Location = new System.Drawing.Point(12, 263);
            this.saveCh.Name = "saveCh";
            this.saveCh.Size = new System.Drawing.Size(306, 91);
            this.saveCh.TabIndex = 23;
            this.saveCh.Text = "Сохранить изменения";
            this.saveCh.UseVisualStyleBackColor = false;
            this.saveCh.Click += new System.EventHandler(this.saveCh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.дата_проведенияDateTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.картинаComboBox);
            this.panel1.Controls.Add(названиеLabel);
            this.panel1.Controls.Add(год_созданияLabel);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 245);
            this.panel1.TabIndex = 24;
            this.panel1.Tag = "panel";
            // 
            // дата_проведенияDateTimePicker
            // 
            this.дата_проведенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.реставрацияBindingSource, "Дата_проведения", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.дата_проведенияDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_проведенияDateTimePicker.Location = new System.Drawing.Point(23, 106);
            this.дата_проведенияDateTimePicker.Name = "дата_проведенияDateTimePicker";
            this.дата_проведенияDateTimePicker.Size = new System.Drawing.Size(258, 27);
            this.дата_проведенияDateTimePicker.TabIndex = 26;
            // 
            // реставрацияBindingSource
            // 
            this.реставрацияBindingSource.DataMember = "Реставрация";
            this.реставрацияBindingSource.DataSource = this.testDataSet;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 81);
            this.label1.TabIndex = 16;
            this.label1.Text = "Просмотр/ изменение реставрации";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // картинаComboBox
            // 
            this.картинаComboBox.CausesValidation = false;
            this.картинаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.реставрацияBindingSource, "Картина", true));
            this.картинаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.реставрацияBindingSource, "Картина", true));
            this.картинаComboBox.DataSource = this.картинаBindingSource;
            this.картинаComboBox.DisplayMember = "Название";
            this.картинаComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.картинаComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.картинаComboBox.FormattingEnabled = true;
            this.картинаComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.картинаComboBox.Location = new System.Drawing.Point(23, 194);
            this.картинаComboBox.Name = "картинаComboBox";
            this.картинаComboBox.Size = new System.Drawing.Size(258, 29);
            this.картинаComboBox.TabIndex = 28;
            this.картинаComboBox.ValueMember = "Код_К";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(329, 411);
            this.ControlBox = false;
            this.Controls.Add(this.saveCh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Rest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest";
            this.Load += new System.EventHandler(this.Rest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экспозицияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картинаBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.реставрацияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private testDataSet testDataSet;
        private testDataSetTableAdapters.ЭкспозицияTableAdapter экспозицияTableAdapter;
        private testDataSetTableAdapters.РеставрацияTableAdapter реставрацияTableAdapter;
        private testDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private testDataSetTableAdapters.КартинаTableAdapter картинаTableAdapter;
        private System.Windows.Forms.BindingSource экспозицияBindingSource;
        private System.Windows.Forms.BindingSource картинаBindingSource;
        public System.Windows.Forms.Button saveCh;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker дата_проведенияDateTimePicker;
        private System.Windows.Forms.BindingSource реставрацияBindingSource;
        private System.Windows.Forms.ComboBox картинаComboBox;
    }
}