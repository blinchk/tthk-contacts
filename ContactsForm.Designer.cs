namespace tthk_contacts
{
    partial class ContactsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.contactsDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureLinkLabel = new System.Windows.Forms.Label();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.addPictureLinkButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.contactComboBox = new System.Windows.Forms.ComboBox();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.scholarshipCheckbox = new System.Windows.Forms.CheckBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.newGroupCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsDataSet = new tthk_contacts.ContactsDataSet();
            this.contactsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new tthk_contacts.ContactsDataSetTableAdapters.ContactsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scholarship = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(140, 127);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 26);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(140, 163);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(250, 26);
            this.phoneTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-post";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(140, 199);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 26);
            this.emailTextBox.TabIndex = 5;
            // 
            // groupComboBox
            // 
            this.groupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.groupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(956, 64);
            this.groupComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(206, 28);
            this.groupComboBox.TabIndex = 14;
            this.groupComboBox.Text = "Kõik";
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(896, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rühm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contactPictureBox
            // 
            this.contactPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactPictureBox.Location = new System.Drawing.Point(195, 273);
            this.contactPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactPictureBox.Name = "contactPictureBox";
            this.contactPictureBox.Size = new System.Drawing.Size(147, 145);
            this.contactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactPictureBox.TabIndex = 3;
            this.contactPictureBox.TabStop = false;
            this.contactPictureBox.Click += new System.EventHandler(this.contactPictureBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Otsing";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(144, 65);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 26);
            this.searchTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(140, 652);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(254, 46);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Lisa";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(404, 652);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(252, 46);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Muuda";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(664, 652);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(252, 46);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Kustuta";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(920, 652);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(117, 46);
            this.previousButton.TabIndex = 12;
            this.previousButton.Text = "<<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(1045, 652);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(117, 46);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = ">>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(402, 58);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 39);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Otsi";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // contactsDataGridView
            // 
            this.contactsDataGridView.AutoGenerateColumns = false;
            this.contactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.Scholarship,
            this.DateOfBirth});
            this.contactsDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.contactsBindingSource, "Id", true));
            this.contactsDataGridView.DataSource = this.contactsBindingSource;
            this.contactsDataGridView.Location = new System.Drawing.Point(402, 123);
            this.contactsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactsDataGridView.Name = "contactsDataGridView";
            this.contactsDataGridView.RowHeadersWidth = 62;
            this.contactsDataGridView.Size = new System.Drawing.Size(760, 458);
            this.contactsDataGridView.TabIndex = 15;
            this.contactsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContactsDataGridView_RowHeaderMouseClick);
            // 
            // pictureLinkLabel
            // 
            this.pictureLinkLabel.AutoSize = true;
            this.pictureLinkLabel.Location = new System.Drawing.Point(68, 502);
            this.pictureLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureLinkLabel.Name = "pictureLinkLabel";
            this.pictureLinkLabel.Size = new System.Drawing.Size(64, 20);
            this.pictureLinkLabel.TabIndex = 0;
            this.pictureLinkLabel.Text = "Pildi link";
            this.pictureLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Location = new System.Drawing.Point(140, 499);
            this.pictureTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(250, 26);
            this.pictureTextBox.TabIndex = 7;
            // 
            // addPictureLinkButton
            // 
            this.addPictureLinkButton.Location = new System.Drawing.Point(140, 535);
            this.addPictureLinkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPictureLinkButton.Name = "addPictureLinkButton";
            this.addPictureLinkButton.Size = new System.Drawing.Size(254, 46);
            this.addPictureLinkButton.TabIndex = 8;
            this.addPictureLinkButton.Text = "Lisa pilt";
            this.addPictureLinkButton.UseVisualStyleBackColor = true;
            this.addPictureLinkButton.Click += new System.EventHandler(this.AddPictureLinkButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rühm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contactComboBox
            // 
            this.contactComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.contactComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contactComboBox.FormattingEnabled = true;
            this.contactComboBox.Location = new System.Drawing.Point(140, 235);
            this.contactComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactComboBox.Name = "contactComboBox";
            this.contactComboBox.Size = new System.Drawing.Size(250, 28);
            this.contactComboBox.TabIndex = 6;
            this.contactComboBox.Text = "Pole";
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(140, 591);
            this.clearFieldsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(254, 46);
            this.clearFieldsButton.TabIndex = 9;
            this.clearFieldsButton.Text = "Kustuta väljud";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
            // 
            // scholarshipCheckbox
            // 
            this.scholarshipCheckbox.AutoSize = true;
            this.scholarshipCheckbox.Location = new System.Drawing.Point(213, 467);
            this.scholarshipCheckbox.Name = "scholarshipCheckbox";
            this.scholarshipCheckbox.Size = new System.Drawing.Size(84, 24);
            this.scholarshipCheckbox.TabIndex = 16;
            this.scholarshipCheckbox.Text = "Toetus";
            this.scholarshipCheckbox.UseVisualStyleBackColor = true;
            this.scholarshipCheckbox.CheckedChanged += new System.EventHandler(this.ScholarshipCheckbox_CheckedChanged);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(920, 596);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(242, 46);
            this.sendMessageButton.TabIndex = 9;
            this.sendMessageButton.Text = "Saada sõnum";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(715, 33);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(173, 35);
            this.addGroupButton.TabIndex = 2;
            this.addGroupButton.Text = "Lisa rühm";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // newGroupCodeTextBox
            // 
            this.newGroupCodeTextBox.Location = new System.Drawing.Point(562, 64);
            this.newGroupCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newGroupCodeTextBox.Name = "newGroupCodeTextBox";
            this.newGroupCodeTextBox.Size = new System.Drawing.Size(145, 26);
            this.newGroupCodeTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kood";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(715, 78);
            this.deleteGroupButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(173, 35);
            this.deleteGroupButton.TabIndex = 2;
            this.deleteGroupButton.Text = "Kustuta rühm";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(140, 426);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(250, 26);
            this.dateOfBirthPicker.TabIndex = 17;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.contactsDataSet;
            // 
            // contactsDataSet
            // 
            this.contactsDataSet.DataSetName = "ContactsDataSet";
            this.contactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsDataSetBindingSource
            // 
            this.contactsDataSetBindingSource.DataSource = this.contactsDataSet;
            this.contactsDataSetBindingSource.Position = 0;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Telefoninumber";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-post";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "Picture";
            this.pictureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.Visible = false;
            this.pictureDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.Visible = false;
            this.groupIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // Scholarship
            // 
            this.Scholarship.DataPropertyName = "Scholarship";
            this.Scholarship.HeaderText = "Toetus";
            this.Scholarship.MinimumWidth = 8;
            this.Scholarship.Name = "Scholarship";
            this.Scholarship.Width = 75;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.MinimumWidth = 8;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 150;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 738);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.scholarshipCheckbox);
            this.Controls.Add(this.contactsDataGridView);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addPictureLinkButton);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteGroupButton);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.contactPictureBox);
            this.Controls.Add(this.contactComboBox);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.pictureLinkLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newGroupCodeTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContactsForm";
            this.Text = "Kontaktid";
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox contactPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView contactsDataGridView;
        private System.Windows.Forms.BindingSource contactsDataSetBindingSource;
        private ContactsDataSet contactsDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private ContactsDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.Label pictureLinkLabel;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.Button addPictureLinkButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox contactComboBox;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.CheckBox scholarshipCheckbox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.TextBox newGroupCodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Scholarship;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
    }
}

