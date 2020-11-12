using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voedingskeuzeform
{
    class Product
    {
        private string productId;
        private string productNm;
        private string foto;
        private string desc;
        private string ing;
        private string alt;
        private string kleur;
        private string bar;

        public Product(string id, string prodname, string fotdo, string dsec, string ingg, string altt, string kleurr, string barr)
        {
            productId = id;
            productNm = prodname;
            foto = fotdo;
            desc = dsec;
            ing = ingg;
            alt = altt;
            kleur = kleurr;
            bar = barr;
        }

        public string Product_id
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Productnaam
        {
            get { return productNm; }
            set { productNm = value; }
        }
        public string Image
        {
            get { return foto; }
            set { foto = value; }
        }

        public string Beschrijving
        {
            get { return desc; }
            set { desc = value; }
        }
        public string Ingredienten
        {
            get { return ing; }
            set { ing = value; }
        }
        public string Alternatieven
        {
            get { return alt; }
            set { alt = value; }
        }
        public string KleurCode
        {
            get { return kleur; }
            set { kleur = value; }
        }
        public string Barcode
        {
            get { return bar; }
            set { bar = value; }
        }
    }
}
