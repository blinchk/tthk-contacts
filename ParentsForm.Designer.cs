
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.childrenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.parentsDataGridView.Location = new System.Drawing.Point(23, 88);
            this.parentsDataGridView.Name = "parentsDataGridView";
            this.parentsDataGridView.ReadOnly = true;
            this.parentsDataGridView.RowHeadersWidth = 50;
            this.parentsDataGridView.RowTemplate.Height = 28;
            this.parentsDataGridView.Size = new System.Drawing.Size(624, 386);
            this.parentsDataGridView.TabIndex = 0;
            this.parentsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.parentsDataGridView_RowHeaderMouseClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(157, 487);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(247, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(108, 490);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nimi";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(157, 529);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(247, 26);
            this.phoneTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefoninumber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(157, 575);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(247, 26);
            this.emailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-post";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.activeCheckBox.Location = new System.Drawing.Point(314, 607);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(90, 24);
            this.activeCheckBox.TabIndex = 3;
            this.activeCheckBox.Text = "Aktiivne";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addParentButton
            // 
            this.addParentButton.Location = new System.Drawing.Point(426, 487);
            this.addParentButton.Name = "addParentButton";
            this.addParentButton.Size = new System.Drawing.Size(223, 54);
            this.addParentButton.TabIndex = 4;
            this.addParentButton.Text = "Lisa";
            this.addParentButton.UseVisualStyleBackColor = true;
            this.addParentButton.Click += new System.EventHandler(this.addParentButton_Click);
            // 
            // changeParentButton
            // 
            this.changeParentButton.Location = new System.Drawing.Point(426, 547);
            this.changeParentButton.Name = "changeParentButton";
            this.changeParentButton.Size = new System.Drawing.Size(223, 54);
            this.changeParentButton.TabIndex = 4;
            this.changeParentButton.Text = "Muuda";
            this.changeParentButton.UseVisualStyleBackColor = true;
            this.changeParentButton.Click += new System.EventHandler(this.changeParentButton_Click);
            // 
            // deleteParentButton
            // 
            this.deleteParentButton.Location = new System.Drawing.Point(426, 607);
            this.deleteParentButton.Name = "deleteParentButton";
            this.deleteParentButton.Size = new System.Drawing.Size(223, 54);
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
            this.dataPermissionCheckBox.Location = new System.Drawing.Point(25, 58);
            this.dataPermissionCheckBox.Name = "dataPermissionCheckBox";
            this.dataPermissionCheckBox.Size = new System.Drawing.Size(232, 24);
            this.dataPermissionCheckBox.TabIndex = 3;
            this.dataPermissionCheckBox.Text = "Andmete andmise nõusolek";
            this.dataPermissionCheckBox.UseVisualStyleBackColor = true;
            this.dataPermissionCheckBox.CheckedChanged += new System.EventHandler(this.dataPermissionCheckBox_CheckedChanged);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(17, 35);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(93, 20);
            this.studentNameLabel.TabIndex = 2;
            this.studentNameLabel.Text = "Õppur nimi: ";
            this.studentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(426, 666);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(223, 54);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Saada sõnum";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
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
            // ParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 748);
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