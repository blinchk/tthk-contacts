﻿using System;
using System.Windows.Forms;

namespace tthk_contacts
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void RequestAuthorize()
        {
            if (!string.IsNullOrEmpty(loginTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                var success = Authorize(loginTextBox.Text, passwordTextBox.Text);
                if (success)
                {
                    var contactsForm = new ContactsForm();
                    Hide();
                    contactsForm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Kasutajanimi või salasõna on vale!");
                }
            }
            else
            {
                MessageBox.Show("Sisestage kasutajanimi ja salasõna!");
            }
        }

        private bool Authorize(string login, string password)
        {
            var dataService = new DataService();
            if (dataService.GetPassword(login) == password) return true;

            return false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            RequestAuthorize();
        }

        private void loginTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RequestAuthorize();
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RequestAuthorize();
                e.Handled = true;
            }
        }
    }
}