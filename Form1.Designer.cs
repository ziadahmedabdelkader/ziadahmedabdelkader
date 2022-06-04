namespace payment
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
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label patient_NameLabel;
            System.Windows.Forms.Label payedLabel;
            System.Windows.Forms.Label reservationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new payment.Database1DataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new payment.Database1DataSetTableAdapters.paymentTableAdapter();
            this.tableAdapterManager = new payment.Database1DataSetTableAdapters.TableAdapterManager();
            this.paymentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.paymentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.patient_NameTextBox = new System.Windows.Forms.TextBox();
            this.payedTextBox = new System.Windows.Forms.TextBox();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new payment.Database1DataSet2();
            this.database1DataSet1 = new payment.Database1DataSet1();
            this.discBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discTableAdapter = new payment.Database1DataSet1TableAdapters.discTableAdapter();
            this.tableTableAdapter = new payment.Database1DataSet2TableAdapters.TableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.reservationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Ratio = new System.Windows.Forms.TextBox();
            this.cash_radio = new System.Windows.Forms.RadioButton();
            this.visa_radio = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            patient_IDLabel = new System.Windows.Forms.Label();
            patient_NameLabel = new System.Windows.Forms.Label();
            payedLabel = new System.Windows.Forms.Label();
            reservationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).BeginInit();
            this.paymentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Location = new System.Drawing.Point(18, 156);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(57, 13);
            patient_IDLabel.TabIndex = 1;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // patient_NameLabel
            // 
            patient_NameLabel.AutoSize = true;
            patient_NameLabel.Location = new System.Drawing.Point(18, 182);
            patient_NameLabel.Name = "patient_NameLabel";
            patient_NameLabel.Size = new System.Drawing.Size(74, 13);
            patient_NameLabel.TabIndex = 3;
            patient_NameLabel.Text = "Patient Name:";
            // 
            // payedLabel
            // 
            payedLabel.AutoSize = true;
            payedLabel.Location = new System.Drawing.Point(30, 286);
            payedLabel.Name = "payedLabel";
            payedLabel.Size = new System.Drawing.Size(40, 13);
            payedLabel.TabIndex = 7;
            payedLabel.Text = "Payed:";
            // 
            // reservationLabel
            // 
            reservationLabel.AutoSize = true;
            reservationLabel.Location = new System.Drawing.Point(18, 208);
            reservationLabel.Name = "reservationLabel";
            reservationLabel.Size = new System.Drawing.Size(67, 13);
            reservationLabel.TabIndex = 5;
            reservationLabel.Text = "Reservation:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.database1DataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.paymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.UpdateOrder = payment.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentBindingNavigator
            // 
            this.paymentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentBindingNavigator.BindingSource = this.paymentBindingSource;
            this.paymentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.paymentBindingNavigatorSaveItem});
            this.paymentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentBindingNavigator.Name = "paymentBindingNavigator";
            this.paymentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.paymentBindingNavigator.TabIndex = 0;
            this.paymentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // paymentBindingNavigatorSaveItem
            // 
            this.paymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentBindingNavigatorSaveItem.Image")));
            this.paymentBindingNavigatorSaveItem.Name = "paymentBindingNavigatorSaveItem";
            this.paymentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentBindingNavigatorSaveItem_Click);
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Enabled = false;
            this.patient_IDTextBox.Location = new System.Drawing.Point(98, 153);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_IDTextBox.TabIndex = 2;
            // 
            // patient_NameTextBox
            // 
            this.patient_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient Name", true));
            this.patient_NameTextBox.Enabled = false;
            this.patient_NameTextBox.Location = new System.Drawing.Point(98, 179);
            this.patient_NameTextBox.Name = "patient_NameTextBox";
            this.patient_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_NameTextBox.TabIndex = 4;
            // 
            // payedTextBox
            // 
            this.payedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Payed", true));
            this.payedTextBox.Enabled = false;
            this.payedTextBox.Location = new System.Drawing.Point(98, 279);
            this.payedTextBox.Name = "payedTextBox";
            this.payedTextBox.Size = new System.Drawing.Size(100, 20);
            this.payedTextBox.TabIndex = 8;
            this.payedTextBox.TextChanged += new System.EventHandler(this.payedTextBox_TextChanged);
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.paymentDataGridView.DataSource = this.paymentBindingSource;
            this.paymentDataGridView.Location = new System.Drawing.Point(299, 40);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.Size = new System.Drawing.Size(501, 220);
            this.paymentDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patient Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Reservation";
            this.dataGridViewTextBoxColumn3.HeaderText = "Reservation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Payed";
            this.dataGridViewTextBoxColumn4.HeaderText = "Payed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tableBindingSource, "ratio", true));
            this.comboBox1.DataSource = this.tableBindingSource;
            this.comboBox1.DisplayMember = "company name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "ratio";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discBindingSource
            // 
            this.discBindingSource.DataMember = "disc";
            this.discBindingSource.DataSource = this.database1DataSet1;
            // 
            // discTableAdapter
            // 
            this.discTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 81);
            this.button1.TabIndex = 11;
            this.button1.Text = "checked";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservationTextBox
            // 
            this.reservationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Reservation", true));
            this.reservationTextBox.Enabled = false;
            this.reservationTextBox.Location = new System.Drawing.Point(98, 205);
            this.reservationTextBox.Name = "reservationTextBox";
            this.reservationTextBox.Size = new System.Drawing.Size(100, 20);
            this.reservationTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Discount Ratio :";
            // 
            // text_Ratio
            // 
            this.text_Ratio.Enabled = false;
            this.text_Ratio.Location = new System.Drawing.Point(98, 240);
            this.text_Ratio.Name = "text_Ratio";
            this.text_Ratio.Size = new System.Drawing.Size(100, 20);
            this.text_Ratio.TabIndex = 13;
            // 
            // cash_radio
            // 
            this.cash_radio.AutoSize = true;
            this.cash_radio.Location = new System.Drawing.Point(21, 321);
            this.cash_radio.Name = "cash_radio";
            this.cash_radio.Size = new System.Drawing.Size(49, 17);
            this.cash_radio.TabIndex = 14;
            this.cash_radio.TabStop = true;
            this.cash_radio.Text = "Cash";
            this.cash_radio.UseVisualStyleBackColor = true;
            // 
            // visa_radio
            // 
            this.visa_radio.AutoSize = true;
            this.visa_radio.Location = new System.Drawing.Point(164, 321);
            this.visa_radio.Name = "visa_radio";
            this.visa_radio.Size = new System.Drawing.Size(45, 17);
            this.visa_radio.TabIndex = 15;
            this.visa_radio.TabStop = true;
            this.visa_radio.Text = "Visa";
            this.visa_radio.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sequence number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Health Insurance ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 85);
            this.button2.TabIndex = 19;
            this.button2.Text = "Exite";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.visa_radio);
            this.Controls.Add(this.cash_radio);
            this.Controls.Add(this.text_Ratio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.paymentDataGridView);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(patient_NameLabel);
            this.Controls.Add(this.patient_NameTextBox);
            this.Controls.Add(reservationLabel);
            this.Controls.Add(this.reservationTextBox);
            this.Controls.Add(payedLabel);
            this.Controls.Add(this.payedTextBox);
            this.Controls.Add(this.paymentBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).EndInit();
            this.paymentBindingNavigator.ResumeLayout(false);
            this.paymentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Database1DataSetTableAdapters.paymentTableAdapter paymentTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton paymentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox patient_NameTextBox;
        private System.Windows.Forms.TextBox payedTextBox;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource discBindingSource;
        private Database1DataSet1TableAdapters.discTableAdapter discTableAdapter;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSet2TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox reservationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Ratio;
        private System.Windows.Forms.RadioButton cash_radio;
        private System.Windows.Forms.RadioButton visa_radio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

