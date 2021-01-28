﻿
namespace tthk_contacts
{
    partial class ParentsForm
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
            this.parentsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.childrenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.addParentButton = new System.Windows.Forms.Button();
            this.changeParentButton = new System.Windows.Forms.Button();
            this.deleteParentButton = new System.Windows.Forms.Button();
            this.dataPermissionCheckBox = new System.Windows.Forms.CheckBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.sendMessageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // parentsDataGridView
            // 
            this.parentsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.parentsDataGridView.AutoGenerateColumns = false;
            this.parentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.parentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.childrenIdDataGridViewTextBoxColumn});
            this.parentsDataGridView.DataSource = this.parentBindingSource;
            this.parentsDataGridView.Location = new System.Drawing.Point(15, 57);
            this.parentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parentsDataGridView.Name = "parentsDataGridView";
            this.parentsDataGridView.ReadOnly = true;
            this.parentsDataGridView.RowHeadersWidth = 50;
            this.parentsDataGridView.RowTemplate.Height = 28;
            this.parentsDataGridView.Size = new System.Drawing.Size(416, 251);
            this.parentsDataGridView.TabIndex = 0;
            this.parentsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.parentsDataGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Aktiivne";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // childrenIdDataGridViewTextBoxColumn
            // 
            this.childrenIdDataGridViewTextBoxColumn.DataPropertyName = "ChildrenId";
            this.childrenIdDataGridViewTextBoxColumn.HeaderText = "ChildrenId";
            this.childrenIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.childrenIdDataGridViewTextBoxColumn.Name = "childrenIdDataGridViewTextBoxColumn";
            this.childrenIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.childrenIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentBindingSource
            // 
            this.parentBindingSource.DataSource = typeof(tthk_contacts.Models.Parent);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(105, 317);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(166, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(72, 318);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(27, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nimi";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(105, 344);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(166, 20);
            this.phoneTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefoninumber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(105, 374);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(166, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-post";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.activeCheckBox.Location = new System.Drawing.Point(209, 395);
            this.activeCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(64, 17);
            this.activeCheckBox.TabIndex = 3;
            this.activeCheckBox.Text = "Aktiivne";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addParentButton
            // 
            this.addParentButton.Location = new System.Drawing.Point(284, 317);
            this.addParentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addParentButton.Name = "addParentButton";
            this.addParentButton.Size = new System.Drawing.Size(149, 35);
            this.addParentButton.TabIndex = 4;
            this.addParentButton.Text = "Lisa";
            this.addParentButton.UseVisualStyleBackColor = true;
            this.addParentButton.Click += new System.EventHandler(this.addParentButton_Click);
            // 
            // changeParentButton
            // 
            this.changeParentButton.Location = new System.Drawing.Point(284, 356);
            this.changeParentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeParentButton.Name = "changeParentButton";
            this.changeParentButton.Size = new System.Drawing.Size(149, 35);
            this.changeParentButton.TabIndex = 4;
            this.changeParentButton.Text = "Muuda";
            this.changeParentButton.UseVisualStyleBackColor = true;
            this.changeParentButton.Click += new System.EventHandler(this.changeParentButton_Click);
            // 
            // deleteParentButton
            // 
            this.deleteParentButton.Location = new System.Drawing.Point(284, 395);
            this.deleteParentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteParentButton.Name = "deleteParentButton";
            this.deleteParentButton.Size = new System.Drawing.Size(149, 35);
            this.deleteParentButton.TabIndex = 4;
            this.deleteParentButton.Text = "Kustuta";
            this.deleteParentButton.UseVisualStyleBackColor = true;
            this.deleteParentButton.Click += new System.EventHandler(this.deleteParentButton_Click);
            // 
            // dataPermissionCheckBox
            // 
            this.dataPermissionCheckBox.AutoSize = true;
            this.dataPermissionCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dataPermissionCheckBox.Checked = true;
            this.dataPermissionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dataPermissionCheckBox.Location = new System.Drawing.Point(17, 38);
            this.dataPermissionCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataPermissionCheckBox.Name = "dataPermissionCheckBox";
            this.dataPermissionCheckBox.Size = new System.Drawing.Size(170, 17);
            this.dataPermissionCheckBox.TabIndex = 3;
            this.dataPermissionCheckBox.Text = "Andmete kasutamise nõusolek";
            this.dataPermissionCheckBox.UseVisualStyleBackColor = true;
            this.dataPermissionCheckBox.CheckedChanged += new System.EventHandler(this.dataPermissionCheckBox_CheckedChanged);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(11, 23);
            this.studentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(63, 13);
            this.studentNameLabel.TabIndex = 2;
            this.studentNameLabel.Text = "Õppur nimi: ";
            this.studentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(284, 433);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(149, 35);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Saada sõnum";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // ParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 486);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.deleteParentButton);
            this.Controls.Add(this.changeParentButton);
            this.Controls.Add(this.addParentButton);
            this.Controls.Add(this.dataPermissionCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.parentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParentsForm";
            this.Text = "Lapsevanemad";
            ((System.ComponentModel.ISupportInitialize)(this.parentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parentsDataGridView;
        private System.Windows.Forms.BindingSource parentBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addParentButton;
        private System.Windows.Forms.Button changeParentButton;
        private System.Windows.Forms.Button deleteParentButton;
        private System.Windows.Forms.CheckBox dataPermissionCheckBox;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Button sendMessageButton;
    }
}