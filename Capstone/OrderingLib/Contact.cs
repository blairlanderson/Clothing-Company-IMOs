using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public abstract class Contact
    {
        //properties
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string addressLineA { get; set; }
        public string addressLineB { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }
        public string phoneNum { get; set; }
        public string altPhoneNum { get; set; }
        public string faxNum { get; set; }
        public string notes { get; set; }
        public DateTime dateEntered { get; set; }


        


    }
}
