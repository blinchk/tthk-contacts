
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
            this.linkFileButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.wholeContactsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saaja";
            // 
            // recepientTextBox
            // 
            this.recepientTextBox.Location = new System.Drawing.Point(99, 55);
            this.recepientTextBox.Name = "recepientTextBox";
            this.recepientTextBox.Size = new System.Drawing.Size(712, 26);
            this.recepientTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teema";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(99, 87);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(712, 26);
            this.subjectTextBox.TabIndex = 5;
            this.subjectTextBox.Text = "Eritoetus.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kiri";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(99, 120);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(712, 292);
            this.contentTextBox.TabIndex = 6;
            this.contentTextBox.Text = "Tere!\nSaadan info eritoetuse kohta.\n\nAvaldus asub manuses.\n\nLugupidamisega\nMarina" +
    " Oleinik\nRühmajuhataja\n\n\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vali saaja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // linkFileButton
            // 
            this.linkFileButton.Location = new System.Drawing.Point(219, 12);
            this.linkFileButton.Name = "linkFileButton";
            this.linkFileButton.Size = new System.Drawing.Size(114, 36);
            this.linkFileButton.TabIndex = 2;
            this.linkFileButton.Text = "Lisa fail";
            this.linkFileButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(576, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 66);
            this.button4.TabIndex = 7;
            this.button4.Text = "Saata";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // wholeContactsButton
            // 
            this.wholeContactsButton.Location = new System.Drawing.Point(339, 13);
            this.wholeContactsButton.Name = "wholeContactsButton";
            this.wholeContactsButton.Size = new System.Drawing.Size(136, 36);
            this.wholeContactsButton.TabIndex = 3;
            this.wholeContactsButton.Text = "Kõik kontaktid";
            this.wholeContactsButton.UseVisualStyleBackColor = true;
            // 
            // SendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 521);
            this.Controls.Add(this.linkFileButton);
            this.Controls.Add(this.wholeContactsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recepientTextBox);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button linkFileButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button wholeContactsButton;
    }
}