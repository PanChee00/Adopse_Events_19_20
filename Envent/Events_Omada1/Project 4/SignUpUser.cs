﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Project_4
{
    public partial class SignUpUser : UserControl
    {
        public SignUpUser()
        {
            InitializeComponent();
        }

        private void SignUpUser_Load(object sender, EventArgs e)
        {
            Register.Enabled = false;
            maleRadioButton.Checked = true;
        }


        private void Onoma_MouseClick(object sender, EventArgs e)
        {

            Onoma.ForeColor = Color.Black;
            if (Onoma.Text == "Όνομα" || Onoma.Text == "Συμπλήρωσε Όνομα")
            {
                Onoma.Text = "";
                Onoma.ForeColor = Color.Black;
            }
        }

        private void Epitheto_MouseClick(object sender, EventArgs e)
        {
            Epitheto.ForeColor = Color.Black;
            if (Epitheto.Text == "Επώνυμο" || Epitheto.Text == "Συμπλήρωσε Επίθετο")
            {

                Epitheto.Text = "";
                Epitheto.ForeColor = Color.Black;

            }

        }
        private void username1_MouseClick(object sender, EventArgs e)
        {
            username1.ForeColor = Color.Black;
            if (username1.Text == "Username" || username1.Text == "Συμπλήρωσε Username")
            {

                username1.Text = "";
                username1.ForeColor = Color.Black;

            }
        }

        private void Email1_MouseClick(object sender, EventArgs e)
        {
            Email1.ForeColor = Color.Black;
            if (Email1.Text == "Email" || Email1.Text == "Συμπλήρωσε Email")
            {

                Email1.Text = "";
                Email1.ForeColor = Color.Black;

            }
        }
        private void address_MouseClick(object sender, EventArgs e)
        {
            address.ForeColor = Color.Black;
            if (address.Text == "Περιοχή" || address.Text == "Συμπλήρωσε Περιοχή")
            {

                address.Text = "";
                address.ForeColor = Color.Black;

            }
        }
        private void Kodikos1_MouseClick(object sender, EventArgs e)
        {
            Kodikos1.ForeColor = Color.Black;
            if (Kodikos1.Text == "Κωδικός" || Kodikos1.Text == "Συμπλήρωσε Kωδικό")
            {

                Kodikos1.Text = "";
                Kodikos1.ForeColor = Color.Black;
                Kodikos1.PasswordChar = '*';
            }

        }

        private void Kodikos2_MouseClick(object sender, EventArgs e)
        {
            Kodikos2.ForeColor = Color.Black;
            if (Kodikos2.Text == "Επαλήθευση Κωδικού" || Kodikos2.Text == "Συμπλήρωσε Κωδικό Επαλήθευσης")
            {

                Kodikos2.Text = "";
                Kodikos2.ForeColor = Color.Black;
                Kodikos2.PasswordChar = '*';
            }
        }

        private Boolean AllCheck()
        {

            Boolean deiktislathwn = false;
            messagefullo.Visible = false;
            messageLabel.Visible = false;

            if (!(nameLabel.Text==""))
            {
                deiktislathwn = true;
            }else if (!(usernameLabel.Text == ""))
            {
                deiktislathwn = true;
            }else if (!(emailLabel.Text == ""))
            {
                deiktislathwn = true;
            }else if (!(passwordLabel.Text == ""))
            {
                deiktislathwn = true;
            }else if (!(addressLabel.Text == ""))
            {
                deiktislathwn = true;
            }
            else if (!(confimrpassLabel.Text == ""))
            {
                deiktislathwn = true;
            }
            return deiktislathwn;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            var buttons = radioButtonBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            User_Classes.UserProfile profile = new User_Classes.UserProfile(Onoma.Text,Epitheto.Text,Email1.Text,address.Text,
                buttons.Text,dobPicker.Value);
            string userName = username1.Text;
            string passWord = Kodikos1.Text;
            User_Classes.Visitor.signUpAsUser(profile, userName, passWord);
        }

        private void Kodikos1_TextChanged(object sender, EventArgs e)
        {
            if (Kodikos1.TextLength == 0)
            {
                passwordLabel.Text = "Παρακαλώ συμπληρώστε password";
            }
            else
            {
                if (!App_Code.StaticMethods.ValidationCheck.PasswordIsValid(Kodikos1.Text))
                {
                    passwordLabel.Text = "Ο κωδικός πρέπει να περιέχει τουλάχιστον 8 χαρακτήρε , κεφαλαιο γράμμα και νούμερο.";
                }
                else
                {
                    passwordLabel.Text = "";
                }
            }
        }

        private void Onoma_TextChanged(object sender, EventArgs e)
        {
            if (Onoma.TextLength == 0)
            {
                nameLabel.Text = "Παρακαλώ συμπληρώστε όνομα";
            }else
            {
                nameLabel.Text = "";
            }
        }

        private void Epitheto_TextChanged(object sender, EventArgs e)
        {
            if (Epitheto.TextLength == 0)
            {
                nameLabel.Text = "Παρακαλώ συμπληρώστε όνομα";
            }
            else
            {
                nameLabel.Text = "";
            }
        }

        private void username1_TextChanged(object sender, EventArgs e)
        {
            if (username1.TextLength == 0)
            {
                usernameLabel.Text = "Παρακαλώ συμπληρώστε ψευδόνυμο";
            }
            else
            {
                enventDataSetTableAdapters.userTableAdapter checkUserName = new enventDataSetTableAdapters.userTableAdapter();
                if (Convert.ToInt32(checkUserName.tryLogInAsUser(username1.Text)) > 0)
                {
                    usernameLabel.Text = "Το ψευδόνυμο που επιλέξατε χρησιμοποιείται.";
                }
                else
                {
                    usernameLabel.Text = "";
                }
            }
        }

        private void Email1_TextChanged(object sender, EventArgs e)
        {
            if (Email1.TextLength == 0)
            {
                emailLabel.Text = "Παρακαλώ συμπληρώστε email";
            }
            else
            {
                if (!App_Code.StaticMethods.ValidationCheck.EmailIsValid(Email1.Text))
                {
                    emailLabel.Text = "To email δεν είναι έγκυρο.";
                }
                else
                {
                    emailLabel.Text = "";
                }
            }
        }

        private void Kodikos2_TextChanged(object sender, EventArgs e)
        {
            if (Kodikos2.TextLength == 0)
            {
                confimrpassLabel.Text = "Παρακαλώ συμπληρώστε password";
            }
            else
            {
                if (!App_Code.StaticMethods.ValidationCheck.ConfirmPasswordIsValid(Kodikos1.Text,Kodikos2.Text))
                {
                    confimrpassLabel.Text = "Ο κωδικός δεν ταιριάζει.";
                }
                else
                {
                    confimrpassLabel.Text = "";
                }
            }
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            if (address.TextLength == 0)
            {
                addressLabel.Text = "Παρακαλώ συμπληρώστε διέυθυνση";
            }
            else
            {
                addressLabel.Text = "";
            }
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            if (!AllCheck())
            {
                Register.Enabled = true;
            }
            else
            {
                Register.Enabled = false;
            }
        }
    }
}