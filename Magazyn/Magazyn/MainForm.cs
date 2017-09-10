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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataBase.GetInstance.InitiateDataBase();
            DataBase db = DataBase.GetInstance;
            productDataGridView.AutoGenerateColumns = false;
            productDataGridView.DataSource = db.ProductsList;
            categoryComboBox.DataSource = db.CategoriesList;
            localizationComboBox.DataSource = db.LocalizationsList;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataBase db = DataBase.GetInstance;
            db.SearchProducts(((Category)categoryComboBox.SelectedItem)?.Name, ((Localization)localizationComboBox.SelectedItem)?.Name, searchTextBox.Text);
            db.GetCategories();
            db.GetLocalizations();
            LoadDeliveries();
        }

        private void LoadDeliveries()
        {
            DataBase db = DataBase.GetInstance;
            db.GetDeliveries();
            currentDeliveriesToolStripMenuItem.DropDownItems.Clear();
            foreach (var item in db.DeliveriesList)
            {
                ToolStripItem newItem = new ToolStripMenuItem(item.Name)
                {
                    Name = item.Code
                };
                newItem.Click += DeliveryMenuItem_Click;
                currentDeliveriesToolStripMenuItem.DropDownItems.Add(newItem);
            }
        }

        private void DeliveryMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryForm deliveryForm = new DeliveryForm((sender as ToolStripItem).Name);
            deliveryForm.ShowDialog();
            LoadDeliveries();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.OnClose += Search;
            addProductForm.ShowDialog();
        }

        private void Search()
        {
            DataBase.GetInstance.SearchProducts(((Category)categoryComboBox.SelectedItem)?.Name, ((Localization)localizationComboBox.SelectedItem)?.Name, searchTextBox.Text);
        }


        private void EditCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.ShowDialog();
        }

        private void EditLocaloizationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalizationForm form = new LocalizationForm();
            form.ShowDialog();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
            EditProductForm editProductForm = new EditProductForm(product);
            editProductForm.OnClose += Search;
            editProductForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
            if (DialogResult.Yes == MessageBox.Show("Czy na pewno usunąć produkt \"" + product.Name + "\"?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DataBase.GetInstance.DeleteProduct(product);
                Search();
            }
        }

        private void NewDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase db = DataBase.GetInstance;
            string deliveryCode = FindDeliveryCode();
            db.CreateDelivery("Nowa dostawa", deliveryCode, DateTime.Today.ToShortDateString());
            db.GetDeliveries();
            DeliveryForm deliveryForm = new DeliveryForm(deliveryCode);
            deliveryForm.ShowDialog();
            LoadDeliveries();
        }
        private string FindDeliveryCode()
        {
            DataBase db = DataBase.GetInstance;
            int number = db.DeliveriesList.Count;
            string name = "delivery";
            while (db.DeliveriesList.FirstOrDefault(x => x.Name == name + number) != null)
            {
                number++;
            }
            return name + number;
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = 0;
            localizationComboBox.SelectedIndex = 0;
            searchTextBox.Text = "";
            Search();
        }
    }
}


