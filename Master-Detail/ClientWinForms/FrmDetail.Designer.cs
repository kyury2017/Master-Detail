namespace ClientWinForms
{
    partial class FrmDetail
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
            labelMasterId = new Label();
            labelName = new Label();
            labelSum = new Label();
            textBoxMasterId = new TextBox();
            bindingSource = new BindingSource(components);
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            numericUpDownSum = new NumericUpDown();
            buttonCncl = new Button();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(105, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 0;
            labelId.Text = "Id";
            // 
            // labelMasterId
            // 
            labelMasterId.AutoSize = true;
            labelMasterId.Location = new Point(20, 37);
            labelMasterId.Name = "labelMasterId";
            labelMasterId.Size = new Size(102, 15);
            labelMasterId.TabIndex = 1;
            labelMasterId.Text = "Иден. документа:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(60, 66);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Название:";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(74, 93);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(48, 15);
            labelSum.TabIndex = 3;
            labelSum.Text = "Сумма:";
            // 
            // textBoxMasterId
            // 
            textBoxMasterId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMasterId.DataBindings.Add(new Binding("Text", bindingSource, "MasterViewId", true));
            textBoxMasterId.Location = new Point(132, 34);
            textBoxMasterId.Name = "textBoxMasterId";
            textBoxMasterId.ReadOnly = true;
            textBoxMasterId.Size = new Size(285, 23);
            textBoxMasterId.TabIndex = 0;
            textBoxMasterId.TabStop = false;
            // 
            // bindingSource
            // 
            bindingSource.DataSource = typeof(Model.DetailView);
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxId.DataBindings.Add(new Binding("Text", bindingSource, "Id", true));
            textBoxId.Location = new Point(132, 6);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(285, 23);
            textBoxId.TabIndex = 0;
            textBoxId.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.DataBindings.Add(new Binding("Text", bindingSource, "Name", true));
            textBoxName.Location = new Point(132, 63);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(285, 23);
            textBoxName.TabIndex = 1;
            // 
            // numericUpDownSum
            // 
            numericUpDownSum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownSum.DataBindings.Add(new Binding("Value", bindingSource, "Sum", true));
            numericUpDownSum.DecimalPlaces = 2;
            numericUpDownSum.Location = new Point(132, 91);
            numericUpDownSum.Name = "numericUpDownSum";
            numericUpDownSum.Size = new Size(285, 23);
            numericUpDownSum.TabIndex = 2;
            // 
            // buttonCncl
            // 
            buttonCncl.DialogResult = DialogResult.Cancel;
            buttonCncl.Location = new Point(342, 184);
            buttonCncl.Name = "buttonCncl";
            buttonCncl.Size = new Size(75, 23);
            buttonCncl.TabIndex = 4;
            buttonCncl.Text = "Отмена";
            buttonCncl.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(261, 184);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // FrmDetail
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCncl;
            ClientSize = new Size(429, 219);
            Controls.Add(buttonOk);
            Controls.Add(buttonCncl);
            Controls.Add(numericUpDownSum);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(textBoxMasterId);
            Controls.Add(labelSum);
            Controls.Add(labelName);
            Controls.Add(labelMasterId);
            Controls.Add(labelId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спецификация";
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelMasterId;
        private Label labelName;
        private Label labelSum;
        private TextBox textBoxMasterId;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownSum;
        private Button buttonCncl;
        private Button buttonOk;
        private BindingSource bindingSource;
    }
}