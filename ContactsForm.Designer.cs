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
            this.contactGroupComboBox = new System.Windows.Forms.ComboBox();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.scholarshipCheckbox = new System.Windows.Forms.CheckBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.newGroupCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.parentsButton = new System.Windows.Forms.Button();
            this.activeCheckbox = new System.Windows.Forms.CheckBox();
            this.showInactivesCheckbox = new System.Windows.Forms.CheckBox();
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
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataPermission = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(93, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(93, 106);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(168, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-post";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(93, 129);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // groupComboBox
            // 
            this.groupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.groupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(723, 53);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(139, 21);
            this.groupComboBox.TabIndex = 14;
            this.groupComboBox.Text = "Kõik";
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
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
            this.contactPictureBox.Location = new System.Drawing.Point(114, 177);
            this.contactPictureBox.Name = "contactPictureBox";
            this.contactPictureBox.Size = new System.Drawing.Size(116, 94);
            this.contactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactPictureBox.TabIndex = 3;
            this.contactPictureBox.TabStop = false;
            this.contactPictureBox.Click += new System.EventHandler(this.contactPictureBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Otsing";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(96, 42);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 424);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(169, 30);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Lisa";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(269, 424);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(168, 30);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Muuda";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(443, 424);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(168, 30);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Kustuta";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(613, 424);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(78, 30);
            this.previousButton.TabIndex = 12;
            this.previousButton.Text = "<<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(697, 424);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(78, 30);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = ">>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(268, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(65, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Otsi";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // contactsDataGridView
            // 
            this.contactsDataGridView.AutoGenerateColumns = false;
            this.contactsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.Scholarship,
            this.DateOfBirth,
            this.Active,
            this.DataPermission});
            this.contactsDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.contactsBindingSource, "Id", true));
            this.contactsDataGridView.DataSource = this.contactsBindingSource;
            this.contactsDataGridView.Location = new System.Drawing.Point(268, 80);
            this.contactsDataGridView.Name = "contactsDataGridView";
            this.contactsDataGridView.ReadOnly = true;
            this.contactsDataGridView.RowHeadersWidth = 62;
            this.contactsDataGridView.Size = new System.Drawing.Size(593, 298);
            this.contactsDataGridView.TabIndex = 15;
            this.contactsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContactsDataGridView_RowHeaderMouseClick);
            // 
            // pictureLinkLabel
            // 
            this.pictureLinkLabel.AutoSize = true;
            this.pictureLinkLabel.Location = new System.Drawing.Point(45, 326);
            this.pictureLinkLabel.Name = "pictureLinkLabel";
            this.pictureLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.pictureLinkLabel.TabIndex = 0;
            this.pictureLinkLabel.Text = "Pildi link";
            this.pictureLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Location = new System.Drawing.Point(93, 324);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(168, 20);
            this.pictureTextBox.TabIndex = 7;
            // 
            // addPictureLinkButton
            // 
            this.addPictureLinkButton.Location = new System.Drawing.Point(93, 348);
            this.addPictureLinkButton.Name = "addPictureLinkButton";
            this.addPictureLinkButton.Size = new System.Drawing.Size(169, 30);
            this.addPictureLinkButton.TabIndex = 8;
            this.addPictureLinkButton.Text = "Lisa pilt";
            this.addPictureLinkButton.UseVisualStyleBackColor = true;
            this.addPictureLinkButton.Click += new System.EventHandler(this.AddPictureLinkButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rühm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contactGroupComboBox
            // 
            this.contactGroupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.contactGroupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contactGroupComboBox.FormattingEnabled = true;
            this.contactGroupComboBox.Location = new System.Drawing.Point(93, 153);
            this.contactGroupComboBox.Name = "contactGroupComboBox";
            this.contactGroupComboBox.Size = new System.Drawing.Size(168, 21);
            this.contactGroupComboBox.TabIndex = 6;
            this.contactGroupComboBox.Text = "Pole";
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(93, 384);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(169, 30);
            this.clearFieldsButton.TabIndex = 9;
            this.clearFieldsButton.Text = "Kustuta väljud";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
            // 
            // scholarshipCheckbox
            // 
            this.scholarshipCheckbox.AutoSize = true;
            this.scholarshipCheckbox.Location = new System.Drawing.Point(97, 304);
            this.scholarshipCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scholarshipCheckbox.Name = "scholarshipCheckbox";
            this.scholarshipCheckbox.Size = new System.Drawing.Size(59, 17);
            this.scholarshipCheckbox.TabIndex = 16;
            this.scholarshipCheckbox.Text = "Toetus";
            this.scholarshipCheckbox.UseVisualStyleBackColor = true;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(613, 387);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(161, 30);
            this.sendMessageButton.TabIndex = 9;
            this.sendMessageButton.Text = "Saada sõnum";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(492, 21);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(186, 23);
            this.addGroupButton.TabIndex = 2;
            this.addGroupButton.Text = "Lisa rühm";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // newGroupCodeTextBox
            // 
            this.newGroupCodeTextBox.Location = new System.Drawing.Point(723, 30);
            this.newGroupCodeTextBox.Name = "newGroupCodeTextBox";
            this.newGroupCodeTextBox.Size = new System.Drawing.Size(98, 20);
            this.newGroupCodeTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kood";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(492, 51);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(186, 23);
            this.deleteGroupButton.TabIndex = 2;
            this.deleteGroupButton.Text = "Kustuta rühm";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(93, 277);
            this.dateOfBirthPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(168, 20);
            this.dateOfBirthPicker.TabIndex = 17;
            // 
            // parentsButton
            // 
            this.parentsButton.Location = new System.Drawing.Point(269, 384);
            this.parentsButton.Name = "parentsButton";
            this.parentsButton.Size = new System.Drawing.Size(168, 30);
            this.parentsButton.TabIndex = 9;
            this.parentsButton.Text = "Lapsevanemad";
            this.parentsButton.UseVisualStyleBackColor = true;
            this.parentsButton.Click += new System.EventHandler(this.parentsButton_Click);
            // 
            // activeCheckbox
            // 
            this.activeCheckbox.AutoSize = true;
            this.activeCheckbox.Location = new System.Drawing.Point(197, 304);
            this.activeCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activeCheckbox.Name = "activeCheckbox";
            this.activeCheckbox.Size = new System.Drawing.Size(64, 17);
            this.activeCheckbox.TabIndex = 16;
            this.activeCheckbox.Text = "Aktiivne";
            this.activeCheckbox.UseVisualStyleBackColor = true;
            // 
            // showInactivesCheckbox
            // 
            this.showInactivesCheckbox.AutoSize = true;
            this.showInactivesCheckbox.Location = new System.Drawing.Point(338, 44);
            this.showInactivesCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showInactivesCheckbox.Name = "showInactivesCheckbox";
            this.showInactivesCheckbox.Size = new System.Drawing.Size(118, 17);
            this.showInactivesCheckbox.TabIndex = 16;
            this.showInactivesCheckbox.Text = "Näita mitteaktiivsed";
            this.showInactivesCheckbox.UseVisualStyleBackColor = true;
            this.showInactivesCheckbox.CheckedChanged += new System.EventHandler(this.showInactivesCheckbox_CheckedChanged);
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
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Telefoninumber";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-post";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "Picture";
            this.pictureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.ReadOnly = true;
            this.pictureDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Scholarship
            // 
            this.Scholarship.DataPropertyName = "Scholarship";
            this.Scholarship.HeaderText = "Toetus";
            this.Scholarship.MinimumWidth = 8;
            this.Scholarship.Name = "Scholarship";
            this.Scholarship.ReadOnly = true;
            this.Scholarship.Visible = false;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Sünniaeg";
            this.DateOfBirth.MinimumWidth = 8;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 8;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            // 
            // DataPermission
            // 
            this.DataPermission.DataPropertyName = "DataPermission";
            this.DataPermission.HeaderText = "DataPermission";
            this.DataPermission.Name = "DataPermission";
            this.DataPermission.ReadOnly = true;
            this.DataPermission.Visible = false;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(889, 480);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.showInactivesCheckbox);
            this.Controls.Add(this.activeCheckbox);
            this.Controls.Add(this.scholarshipCheckbox);
            this.Controls.Add(this.contactsDataGridView);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addPictureLinkButton);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.parentsButton);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteGroupButton);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.contactPictureBox);
            this.Controls.Add(this.contactGroupComboBox);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private tthk_contacts.ContactsDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.Label pictureLinkLabel;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.Button addPictureLinkButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox contactGroupComboBox;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.CheckBox scholarshipCheckbox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.TextBox newGroupCodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Button parentsButton;
        private System.Windows.Forms.CheckBox activeCheckbox;
        private System.Windows.Forms.CheckBox showInactivesCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Scholarship;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataPermission;
    }
}

