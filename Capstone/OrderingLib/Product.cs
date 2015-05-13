using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public class ProductX
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string imageName{ get; set; }
        public string size { get; set; }
        public string colour { get; set; }
        public string status { get; set; }
        public string notes { get; set; }

        public ProductX()
        {
            id = 0;
            name = description = price = imageName = size = 
                colour = status = notes = "";
                
        }

        public ProductX(int idIn, string nameIn, string desc, 
            string cost, string img, string sizeIn, 
            string col, string stat, string misc)
        {
            this.id = idIn;
            this.name = nameIn;
            this.price = cost;
            this.imageName = img;
            this.size  = sizeIn;
            this.colour = col;
            this.status = stat;

            this.description = desc;
            this.notes = misc;
            
        }
    }
}
