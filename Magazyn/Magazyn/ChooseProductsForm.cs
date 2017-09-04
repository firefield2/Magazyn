using Be.Timvw.Framework.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class ChooseProductsForm : Form
    {
        SortableBindingList<Product> primaryProductsList= new SortableBindingList<Product>();
        SortableBindingList<Product> choosenProductsList = new SortableBindingList<Product>();

        public SortableBindingList<Product> ChoosenProductsList { get => choosenProductsList; set => choosenProductsList = value; }

        public ChooseProductsForm(SortableBindingList<Product> list)
        {
            InitializeComponent();
            productsDataGridView.AutoGenerateColumns = false;
            choosenProductsDataGridView.AutoGenerateColumns = false;
            primaryProductsList = list;
            productsDataGridView.DataSource = primaryProductsList;
            choosenProductsDataGridView.DataSource = choosenProductsList;
        }


        private void ToRightButton_Click(object sender, EventArgs e)
        {
            Product product;
            product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
            primaryProductsList.Remove(product);
            choosenProductsList.Add(product);
        }

        private void ToLeftButton_Click(object sender, EventArgs e)
        {
            Product product;
            product = (Product)choosenProductsDataGridView.CurrentRow.DataBoundItem;
            primaryProductsList.Add(product);
            choosenProductsList.Remove(product);
        }

        private void CancellButton_Click(object sender, EventArgs e)
        {
            choosenProductsList.Clear();
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
