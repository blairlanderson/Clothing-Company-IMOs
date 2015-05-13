using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLib;

namespace OrderingUI
{
    public partial class ViewProdScreen : Form
    {
        ProductX viewing;

        public ViewProdScreen(ProductX p)
        {
            InitializeComponent();
            viewing = p;
        }

        private void ViewProdScreen_Load(object sender, EventArgs e)
        {
            txtProdName.Text = viewing.name;
            txtImageName.Text = viewing.imageName;
            txtSize.Text = viewing.size;
            txtPrice.Text = viewing.price;
            txtColour.Text = viewing.colour;
            txtStatus.Text = viewing.status;

            txtDescription.Text = viewing.description;
            txtNotes.Text = viewing.notes;
        }
    }
}
