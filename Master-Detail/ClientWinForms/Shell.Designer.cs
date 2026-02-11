namespace ClientWinForms
{
    partial class Shell
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shell));
            bindingSource = new BindingSource(components);
            dataGridViewDoc = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewSpec = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            masterViewIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            detailsBindingSource = new BindingSource(components);
            toolStrip = new ToolStrip();
            toolStripBtnReresh = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripBtnDocAdd = new ToolStripButton();
            toolStripBtnDocEdit = new ToolStripButton();
            toolStripBtnDocDel = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripBtnSpecAdd = new ToolStripButton();
            toolStripBtnSpecEdit = new ToolStripButton();
            toolStripBtnSpecDel = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatus = new ToolStripStatusLabel();
            toolStripStatusValue = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            groupBoxDoc = new GroupBox();
            groupBoxSpec = new GroupBox();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).BeginInit();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxDoc.SuspendLayout();
            groupBoxSpec.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSource
            // 
            bindingSource.DataSource = typeof(Model.MasterView);
            bindingSource.Sort = "";
            // 
            // dataGridViewDoc
            // 
            dataGridViewDoc.AllowUserToAddRows = false;
            dataGridViewDoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewDoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDoc.AutoGenerateColumns = false;
            dataGridViewDoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoc.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, numberDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn });
            dataGridViewDoc.DataSource = bindingSource;
            dataGridViewDoc.Dock = DockStyle.Fill;
            dataGridViewDoc.Location = new Point(3, 19);
            dataGridViewDoc.Name = "dataGridViewDoc";
            dataGridViewDoc.ReadOnly = true;
            dataGridViewDoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDoc.Size = new Size(794, 179);
            dataGridViewDoc.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.ReadOnly = true;
            numberDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            sumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            noteDataGridViewTextBoxColumn.ReadOnly = true;
            noteDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewSpec
            // 
            dataGridViewSpec.AllowUserToAddRows = false;
            dataGridViewSpec.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewSpec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSpec.AutoGenerateColumns = false;
            dataGridViewSpec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpec.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, masterViewIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn1 });
            dataGridViewSpec.DataSource = detailsBindingSource;
            dataGridViewSpec.Dock = DockStyle.Fill;
            dataGridViewSpec.Location = new Point(3, 19);
            dataGridViewSpec.Name = "dataGridViewSpec";
            dataGridViewSpec.ReadOnly = true;
            dataGridViewSpec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSpec.Size = new Size(794, 176);
            dataGridViewSpec.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // masterViewIdDataGridViewTextBoxColumn
            // 
            masterViewIdDataGridViewTextBoxColumn.DataPropertyName = "MasterViewId";
            masterViewIdDataGridViewTextBoxColumn.HeaderText = "Id документа";
            masterViewIdDataGridViewTextBoxColumn.Name = "masterViewIdDataGridViewTextBoxColumn";
            masterViewIdDataGridViewTextBoxColumn.ReadOnly = true;
            masterViewIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // sumDataGridViewTextBoxColumn1
            // 
            sumDataGridViewTextBoxColumn1.DataPropertyName = "Sum";
            sumDataGridViewTextBoxColumn1.HeaderText = "Сумма";
            sumDataGridViewTextBoxColumn1.Name = "sumDataGridViewTextBoxColumn1";
            sumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // detailsBindingSource
            // 
            detailsBindingSource.DataMember = "Details";
            detailsBindingSource.DataSource = bindingSource;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripBtnReresh, toolStripSeparator1, toolStripBtnDocAdd, toolStripBtnDocEdit, toolStripBtnDocDel, toolStripSeparator2, toolStripBtnSpecAdd, toolStripBtnSpecEdit, toolStripBtnSpecDel });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 25);
            toolStrip.TabIndex = 3;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripBtnReresh
            // 
            toolStripBtnReresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnReresh.Image = (Image)resources.GetObject("toolStripBtnReresh.Image");
            toolStripBtnReresh.ImageTransparentColor = Color.Magenta;
            toolStripBtnReresh.Name = "toolStripBtnReresh";
            toolStripBtnReresh.Size = new Size(23, 22);
            toolStripBtnReresh.Text = "Обновить";
            toolStripBtnReresh.Click += toolStripBtnReresh_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripBtnDocAdd
            // 
            toolStripBtnDocAdd.Image = (Image)resources.GetObject("toolStripBtnDocAdd.Image");
            toolStripBtnDocAdd.ImageTransparentColor = Color.Magenta;
            toolStripBtnDocAdd.Name = "toolStripBtnDocAdd";
            toolStripBtnDocAdd.Size = new Size(81, 22);
            toolStripBtnDocAdd.Text = "Документ";
            toolStripBtnDocAdd.ToolTipText = "Добавить документ";
            toolStripBtnDocAdd.Click += toolStripBtnDocAdd_Click;
            // 
            // toolStripBtnDocEdit
            // 
            toolStripBtnDocEdit.Image = (Image)resources.GetObject("toolStripBtnDocEdit.Image");
            toolStripBtnDocEdit.ImageTransparentColor = Color.Magenta;
            toolStripBtnDocEdit.Name = "toolStripBtnDocEdit";
            toolStripBtnDocEdit.Size = new Size(81, 22);
            toolStripBtnDocEdit.Text = "Документ";
            toolStripBtnDocEdit.ToolTipText = "Изменить документ";
            toolStripBtnDocEdit.Click += toolStripBtnDocEdit_Click;
            // 
            // toolStripBtnDocDel
            // 
            toolStripBtnDocDel.Image = (Image)resources.GetObject("toolStripBtnDocDel.Image");
            toolStripBtnDocDel.ImageTransparentColor = Color.Magenta;
            toolStripBtnDocDel.Name = "toolStripBtnDocDel";
            toolStripBtnDocDel.Size = new Size(81, 22);
            toolStripBtnDocDel.Text = "Документ";
            toolStripBtnDocDel.ToolTipText = "Уданить документ";
            toolStripBtnDocDel.Click += toolStripBtnDocDel_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripBtnSpecAdd
            // 
            toolStripBtnSpecAdd.Image = (Image)resources.GetObject("toolStripBtnSpecAdd.Image");
            toolStripBtnSpecAdd.ImageTransparentColor = Color.Magenta;
            toolStripBtnSpecAdd.Name = "toolStripBtnSpecAdd";
            toolStripBtnSpecAdd.Size = new Size(58, 22);
            toolStripBtnSpecAdd.Text = "Спец.";
            toolStripBtnSpecAdd.ToolTipText = "Добавить спецификацию";
            toolStripBtnSpecAdd.Click += toolStripBtnSpecAdd_Click;
            // 
            // toolStripBtnSpecEdit
            // 
            toolStripBtnSpecEdit.Image = (Image)resources.GetObject("toolStripBtnSpecEdit.Image");
            toolStripBtnSpecEdit.ImageTransparentColor = Color.Magenta;
            toolStripBtnSpecEdit.Name = "toolStripBtnSpecEdit";
            toolStripBtnSpecEdit.Size = new Size(58, 22);
            toolStripBtnSpecEdit.Text = "Спец.";
            toolStripBtnSpecEdit.ToolTipText = "Изменить спецификацию";
            toolStripBtnSpecEdit.Click += toolStripBtnSpecEdit_Click;
            // 
            // toolStripBtnSpecDel
            // 
            toolStripBtnSpecDel.Image = (Image)resources.GetObject("toolStripBtnSpecDel.Image");
            toolStripBtnSpecDel.ImageTransparentColor = Color.Magenta;
            toolStripBtnSpecDel.Name = "toolStripBtnSpecDel";
            toolStripBtnSpecDel.Size = new Size(58, 22);
            toolStripBtnSpecDel.Text = "Спец.";
            toolStripBtnSpecDel.ToolTipText = "Удалить спецификацию";
            toolStripBtnSpecDel.Click += toolStripBtnSpecDel_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatus, toolStripStatusValue });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            toolStripStatus.Name = "toolStripStatus";
            toolStripStatus.Size = new Size(46, 17);
            toolStripStatus.Text = "Статус:";
            // 
            // toolStripStatusValue
            // 
            toolStripStatusValue.Name = "toolStripStatusValue";
            toolStripStatusValue.Size = new Size(38, 17);
            toolStripStatusValue.Text = "Готов";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxDoc);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxSpec);
            splitContainer1.Size = new Size(800, 403);
            splitContainer1.SplitterDistance = 201;
            splitContainer1.TabIndex = 5;
            // 
            // groupBoxDoc
            // 
            groupBoxDoc.Controls.Add(dataGridViewDoc);
            groupBoxDoc.Dock = DockStyle.Fill;
            groupBoxDoc.ForeColor = Color.RoyalBlue;
            groupBoxDoc.Location = new Point(0, 0);
            groupBoxDoc.Name = "groupBoxDoc";
            groupBoxDoc.Size = new Size(800, 201);
            groupBoxDoc.TabIndex = 1;
            groupBoxDoc.TabStop = false;
            groupBoxDoc.Text = "Документы";
            // 
            // groupBoxSpec
            // 
            groupBoxSpec.Controls.Add(dataGridViewSpec);
            groupBoxSpec.Dock = DockStyle.Fill;
            groupBoxSpec.ForeColor = Color.RoyalBlue;
            groupBoxSpec.Location = new Point(0, 0);
            groupBoxSpec.Name = "groupBoxSpec";
            groupBoxSpec.Size = new Size(800, 198);
            groupBoxSpec.TabIndex = 2;
            groupBoxSpec.TabStop = false;
            groupBoxSpec.Text = "Спуцификации:";
            // 
            // Shell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Name = "Shell";
            Text = "Master-Detail";
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpec).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxDoc.ResumeLayout(false);
            groupBoxSpec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource;
        private DataGridView dataGridViewDoc;
        private DataGridView dataGridViewSpec;
        private BindingSource detailsBindingSource;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripBtnReresh;
        private ToolStripButton toolStripBtnDocAdd;
        private ToolStripButton toolStripBtnSpecAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripBtnDocEdit;
        private ToolStripButton toolStripBtnDocDel;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripBtnSpecEdit;
        private ToolStripButton toolStripBtnSpecDel;
        private StatusStrip statusStrip;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxDoc;
        private GroupBox groupBoxSpec;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn masterViewIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn1;
        private ToolStripStatusLabel toolStripStatus;
        private ToolStripStatusLabel toolStripStatusValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}
