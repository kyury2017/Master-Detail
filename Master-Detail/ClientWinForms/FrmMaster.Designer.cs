namespace ClientWinForms
{
    partial class FrmMaster
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
            components = new System.ComponentModel.Container();
            labelId = new Label();
            labelNote = new Label();
            labelSum = new Label();
            labelData = new Label();
            labelNum = new Label();
            textBoxId = new TextBox();
            bindingSource = new BindingSource(components);
            textBoxNum = new TextBox();
            textBoxNote = new TextBox();
            btnCnc = new Button();
            btnOk = new Button();
            dateTimePicker = new DateTimePicker();
            numericUpDownSum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(93, 16);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 0;
            labelId.Text = "ID:";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(33, 133);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(81, 15);
            labelNote.TabIndex = 1;
            labelNote.Text = "Примечание:";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(66, 104);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(48, 15);
            labelSum.TabIndex = 2;
            labelSum.Text = "Сумма:";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(79, 75);
            labelData.Name = "labelData";
            labelData.Size = new Size(35, 15);
            labelData.TabIndex = 3;
            labelData.Text = "Дата:";
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Location = new Point(66, 46);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(48, 15);
            labelNum.TabIndex = 4;
            labelNum.Text = "Номер:";
            // 
            // textBoxId
            // 
            textBoxId.DataBindings.Add(new Binding("Text", bindingSource, "Id", true));
            textBoxId.Location = new Point(120, 13);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(299, 23);
            textBoxId.TabIndex = 0;
            textBoxId.TabStop = false;
            // 
            // bindingSource
            // 
            bindingSource.DataSource = typeof(Model.MasterView);
            // 
            // textBoxNum
            // 
            textBoxNum.DataBindings.Add(new Binding("Text", bindingSource, "Number", true));
            textBoxNum.Location = new Point(120, 43);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(297, 23);
            textBoxNum.TabIndex = 2;
            // 
            // textBoxNote
            // 
            textBoxNote.DataBindings.Add(new Binding("Text", bindingSource, "Note", true));
            textBoxNote.Location = new Point(120, 130);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(297, 23);
            textBoxNote.TabIndex = 5;
            // 
            // btnCnc
            // 
            btnCnc.DialogResult = DialogResult.Cancel;
            btnCnc.Location = new Point(344, 184);
            btnCnc.Name = "btnCnc";
            btnCnc.Size = new Size(75, 23);
            btnCnc.TabIndex = 7;
            btnCnc.Text = "Отмена";
            btnCnc.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(263, 184);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(120, 72);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(297, 23);
            dateTimePicker.TabIndex = 3;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // numericUpDownSum
            // 
            numericUpDownSum.DecimalPlaces = 2;
            numericUpDownSum.Location = new Point(120, 101);
            numericUpDownSum.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownSum.Name = "numericUpDownSum";
            numericUpDownSum.ReadOnly = true;
            numericUpDownSum.Size = new Size(294, 23);
            numericUpDownSum.TabIndex = 4;
            // 
            // FrmMaster
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCnc;
            ClientSize = new Size(429, 219);
            Controls.Add(numericUpDownSum);
            Controls.Add(dateTimePicker);
            Controls.Add(btnOk);
            Controls.Add(btnCnc);
            Controls.Add(textBoxNote);
            Controls.Add(textBoxNum);
            Controls.Add(textBoxId);
            Controls.Add(labelNum);
            Controls.Add(labelData);
            Controls.Add(labelSum);
            Controls.Add(labelNote);
            Controls.Add(labelId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMaster";
            Text = "Документ";
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelNote;
        private Label labelSum;
        private Label labelData;
        private Label labelNum;
        private TextBox textBoxId;
        private TextBox textBoxNum;
        private TextBox textBoxNote;
        private Button btnCnc;
        private Button btnOk;
        private BindingSource bindingSource;
        private DateTimePicker dateTimePicker;
        private NumericUpDown numericUpDownSum;
    }
}