using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voedingskeuzeform
{
    public partial class Form1 : Form
    {
        private static List<Product> producten = new List<Product>();
        public string database = "SERVER=84.24.134.80;PORT=33598;DATABASE=scannerapp;UID=scannerapp;PASSWORD=0dt3WgKj%#2EZUY;";
        public string database_login = "SERVER=84.24.134.80;PORT=33598;DATABASE=scannerapp_login;UID=scannerapp;PASSWORD=0dt3WgKj%#2EZUY;";
        int scannedId = 0;

        public Form1()
        {
            InitializeComponent();
            database_connection();
            Tabs.SelectedTab = ScanTab;
        }


        private void product1button_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 1;
            product_detail(scannedId);

        }

        private void product_detail(int scannedId)
        {
            foreach (Product details in producten)
            {
                if (details.Product_id == scannedId.ToString())
                {
                    productNaam.Text = details.Productnaam;
                    productBeschrijving.Text = details.Beschrijving;
                    productingredienten.Text = details.Ingredienten;
                    alternatief.Text = details.Alternatieven;
                }
            }
        }

        private void database_connection()
        {
            MySqlConnection databaseConnection = new MySqlConnection(database);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            MySqlDataReader Reader;
            commandDatabase.CommandText = "SELECT * FROM Producten";
            databaseConnection.Open();
            Reader = commandDatabase.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + ",";

                producten.Add(new Product(
                    Reader.GetString("Product_id"),
                    Reader.GetString("Productnaam"),
                    Reader.GetString("Image"),
                    Reader.GetString("Beschrijving"),
                    Reader.GetString("Ingrediënten"),
                    Reader.GetString("Alternatieven"),
                    Reader.GetString("KleurCode"),
                    Reader.GetString("Barcode")
                ));
            }
            databaseConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 2;
            product_detail(scannedId);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 3;
            product_detail(scannedId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 4;
            product_detail(scannedId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 5;
            product_detail(scannedId);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 6;
            product_detail(scannedId);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 7;
            product_detail(scannedId);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            scannedId = 8;
            product_detail(scannedId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gebruikersnaam = loginEmailInput.Text;
            if (Gebruikersnaam != "")
            {
                MessageBox.Show("U bent nu ingelogd als " + Gebruikersnaam);
            }

            if (String.IsNullOrEmpty(loginEmailInput.Text))
            {
                MessageBox.Show("Email is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginEmailInput.Focus();
                return;
            }
            if (String.IsNullOrEmpty(loginPasswordInput.Text))
            {
                MessageBox.Show("Wachtwoord is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginPasswordInput.Focus();
                return;
            }
            MySqlConnection databaseConnectie = new MySqlConnection(database_login);
            MySqlCommand queryDatabase = databaseConnectie.CreateCommand();
            MySqlDataReader reader;

            string Email = loginEmailInput.Text;
            string Password = Hash(loginPasswordInput.Text);

            queryDatabase.CommandText = "SELECT email, password FROM LoginTable WHERE email = '" + Email + "' AND password = '" + Password + "'";

            databaseConnectie.Open();
            reader = queryDatabase.ExecuteReader();

            if (reader.Read() == true)
            {
                MessageBox.Show("U bent succesvol ingelogd.");
            }
            else
            {
                MessageBox.Show("Login is mislukt. Probeer het opnieuw.", "Login mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginEmailInput.Clear();
                loginPasswordInput.Clear();
                loginEmailInput.Focus();
            }
            databaseConnectie.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Gebruikersnaam = loginEmailInput.Text;
            if (Gebruikersnaam != "")
            {
                scanning();
            }
        }

        private void scanning()
        {
            string Gebruikersnaam = loginEmailInput.Text;
            int scannumber = 0;

            MySqlConnection databaseConnectie = new MySqlConnection(database_login);
            MySqlCommand queryDatabase = databaseConnectie.CreateCommand();
            MySqlDataReader reader;
            
            queryDatabase.CommandText = "SELECT * FROM LoginTable WHERE username = '" + Gebruikersnaam + "'";
            databaseConnectie.Open();
            reader = queryDatabase.ExecuteReader();
            while (reader.Read())
            {
                scannumber = reader.GetInt32(4);
                scannumber++;
            }
            databaseConnectie.Close();

            queryDatabase.CommandText = "UPDATE LoginTable SET scanned=" + scannumber + " WHERE username = '" + Gebruikersnaam + "'";
            databaseConnectie.Open();
            reader = queryDatabase.ExecuteReader();
            databaseConnectie.Close();

            queryDatabase.CommandText = "SELECT * FROM LoginTable WHERE username = '" + Gebruikersnaam + "'";
            databaseConnectie.Open();
            reader = queryDatabase.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1) + " = " + reader.GetString(4));
            }

            databaseConnectie.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = LoginTab;

            //var loginPopup = new Form();
            //loginPopup.ShowDialog(this);

            //LoginForm LoginForm = new LoginForm();
            //LoginForm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = RegisterTab;

            //var registerPopup = new Form();
            //registerPopup.ShowDialog(this);

            //RegisterForm RegisterForm = new RegisterForm();
            //RegisterForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show("Gebruikersnaam is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameInput.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(emailInput.Text))
            {
                MessageBox.Show("Email is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailInput.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(passwordInput.Text))
            {
                MessageBox.Show("Wachtwoord is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordInput.Focus();
                return;
            }
            else if (passwordInput.Text != confirmPasswordInput.Text)
            {
                MessageBox.Show("De opgegeven wachtwoorden komen niet overeen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordInput.Focus();
                return;
            }
            else if (passwordInput.TextLength < 8)
            {
                MessageBox.Show("Het wachtwoord moet minimaal 8 karakters lang zijn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordInput.Focus();
                return;
            }
            MySqlConnection databaseConnectie = new MySqlConnection(database_login);
            MySqlCommand queryDatabase = databaseConnectie.CreateCommand();
            MySqlDataReader reader;

            queryDatabase.CommandText = "INSERT INTO LoginTable(`username`, `email`, `password`, `scanned`) VALUES ('" + usernameInput.Text + "', '" + emailInput.Text + "', '" + Hash(passwordInput.Text) + "', '0')";

            databaseConnectie.Open();
            reader = queryDatabase.ExecuteReader();
            MessageBox.Show("U bent succesvol aangemaakt.");
            databaseConnectie.Close();
        }
        static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }
    }
}
