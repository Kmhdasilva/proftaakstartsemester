using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voedingskeuzeform
{
    public partial class Form1 : Form
    {
        private static List<Product> producten = new List<Product>();
        int scannedId = 0;
        int count = 0;
        string[,] products;
        string[] ingredienten;




        public Form1()
        {
            InitializeComponent();

            int count = 0;

            products = new string[,] { { "macaroni", "pasta", "Waarvan verzadigd 0.3 g,Totaal onverzadigde vetzuren 1 g,Koolhydraten 72 g,Waarvan suikers 3.2 g,Voedingsvezel 2.7 g,Eiwit 13 g,Zout 0 g" }, { "volkoren macaroni", "pasta", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "bonen", "groente", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "friet", "groente", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "iets", "test", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "test", "test", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "test1", "test1", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "test2", "test2", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" } };
            count += products.GetLength(0);
            database_connection();

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
            string MyConString = "SERVER=localhost;" + "DATABASE=healthy_scan;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select * from producten";
            connection.Open();
            Reader = command.ExecuteReader();
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
            connection.Close();
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
    }
}
