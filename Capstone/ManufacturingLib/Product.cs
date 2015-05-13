using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Product
    {
        int productId;
        string productName;
        string description;
        decimal retailPrice;
        
        //add'l props
        string imageFile;
        string size;
        string colour;
        string status;
        string notes;


        public Product() { }

        public Product(int x)
        {
            productId = x;
        }

        public int ProductlID
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Decimal RetailPrice
        {
            get { return retailPrice; }
            set { retailPrice = value; }
        }

        

        public string ImageFile
        {
            get { return imageFile; }
            set { imageFile = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        
        

    }
}
