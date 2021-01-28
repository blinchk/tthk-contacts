
namespace tthk_contacts
{
    partial class SendMailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.recepientTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.wholeContactsButton = new System.Windows.Forms.Button();
            this.addScholarshipFileCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addLunchscholarshipCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saaja";
            // 
            // recepientTextBox
            // 
            this.recepientTextBox.Location = new System.Drawing.Point(66, 36);
            this.recepientTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recepientTextBox.Name = "recepientTextBox";
            this.recepientTextBox.Size = new System.Drawing.Size(476, 20);
            this.recepientTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teema";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(66, 57);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(476, 20);
            this.subjectTextBox.TabIndex = 5;
            this.subjectTextBox.Text = "Eritoetus.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kiri";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(66, 78);
            this.contentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(476, 191);
            this.contentTextBox.TabIndex = 6;
            this.contentTextBox.Text = "Tere!\nSaadan info eritoetuse kohta.\n\nAvaldus asub manuses.\n\nLugupidamisega\nMarina" +
    " Oleinik\nRühmajuhataja\n\n\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vali saaja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(384, 272);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(157, 43);
            this.sendMessageButton.TabIndex = 7;
            this.sendMessageButton.Text = "Saata";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // wholeContactsButton
            // 
            this.wholeContactsButton.Location = new System.Drawing.Point(146, 8);
            this.wholeContactsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wholeContactsButton.Name = "wholeContactsButton";
            this.wholeContactsButton.Size = new System.Drawing.Size(91, 23);
            this.wholeContactsButton.TabIndex = 3;
            this.wholeContactsButton.Text = "Kõik kontaktid";
            this.wholeContactsButton.UseVisualStyleBackColor = true;
            this.wholeContactsButton.Click += new System.EventHandler(this.wholeContactsButton_Click);
            // 
            // addScholarshipFileCheckbox
            // 
            this.addScholarshipFileCheckbox.AutoSize = true;
            this.addScholarshipFileCheckbox.Location = new System.Drawing.Point(66, 272);
            this.addScholarshipFileCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addScholarshipFileCheckbox.Name = "addScholarshipFileCheckbox";
            this.addScholarshipFileCheckbox.Size = new System.Drawing.Size(134, 17);
            this.addScholarshipFileCheckbox.TabIndex = 8;
            this.addScholarshipFileCheckbox.Text = "Lisa eritoetuse avaldus";
            this.addScholarshipFileCheckbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lisa fail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.wholeContactsButton_Click);
            // 
            // addLunchscholarshipCheckBox
            // 
            this.addLunchscholarshipCheckBox.AutoSize = true;
            this.addLunchscholarshipCheckBox.Location = new System.Drawing.Point(66, 293);
            this.addLunchscholarshipCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.addLunchscholarshipCheckBox.Name = "addLunchscholarshipCheckBox";
            this.addLunchscholarshipCheckBox.Size = new System.Drawing.Size(171, 17);
            this.addLunchscholarshipCheckBox.TabIndex = 8;
            this.addLunchscholarshipCheckBox.Text = "Lisa koolilõunatoetuse avaldus";
            this.addLunchscholarshipCheckBox.UseVisualStyleBackColor = true;
            // 
            // SendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 339);
            this.Controls.Add(this.addLunchscholarshipCheckBox);
            this.Controls.Add(this.addScholarshipFileCheckbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wholeContactsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recepientTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SendMailForm";
            this.Text = "Saatmisvorm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recepientTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button wholeContactsButton;
        private System.Windows.Forms.CheckBox addScholarshipFileCheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox addLunchscholarshipCheckBox;
    }
}