using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voedingskeuzeform
{
    public partial class Form1 : Form
    {
        int scannedId = 1;
        int count = 0;
        string[,] products;
        string[] ingredienten;


        public Form1()
        {
            InitializeComponent();

            int count = 0;

            products = new string[,] { { "macaroni", "pasta", "Waarvan verzadigd 0.3 g,Totaal onverzadigde vetzuren 1 g,Koolhydraten 72 g,Waarvan suikers 3.2 g,Voedingsvezel 2.7 g,Eiwit 13 g,Zout 0 g" }, { "volkoren macaroni", "pasta", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "bonen", "groente", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "friet", "groente", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "iets", "test", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "test", "test", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "test1", "test1", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" }, { "test2", "test2", "Waarvan verzadigd	0.3 g,Totaal onverzadigde vetzuren    1 g,Koolhydraten    72 g,Waarvan suikers 3.2 g,Voedingsvezel   2.7 g,Eiwitten    13 g,Zout    0 g" } };
            count += products.GetLength(0);
        }

        private void product1button_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = productPage;
            productNaam.Text = products[scannedId, 0];
            productbeschrijving.Text = products[scannedId, 1];
            ingredienten = products[count, 2].Split(',');
            productingredienten.Items.AddRange(ingredienten);

        }
    }
}
