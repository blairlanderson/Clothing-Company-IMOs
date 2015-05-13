using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public static class Globals
    {
        //Global Porperties
        public static List<Company> companies = new List<Company>();
        public static List<int> compIds = new List<int>();
        public static List<CompanyContact> contacts = new List<CompanyContact>();
        public static List<Order> orders = new List<Order>();
        public static List<OrderItem> orderItems = new List<OrderItem>();
        public static List<ProductX> products = new List<ProductX>();

        //active elements for editing
        public static Company activeCompany { get; set; }
        public static CompanyContact activeContact { get; set; }

        public static Order activeOrder { get; set; }
        public static OrderItem activeOrderItem { get; set; }
        public static ProductX activeProduct { get; set; }

    }
}
