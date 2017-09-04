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
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
            productDataGridView.AutoGenerateColumns = false;
        }
        Delivery delivery;
        public DeliveryForm(string deliveryCode):this()
        {
            DataBase db = DataBase.GetInstance;
            delivery = db.DeliveriesList.FirstOrDefault(x => x.Code == deliveryCode).Clone();
            deliveryNameLabel.Text = delivery.Name;
            delivery.GetDeliveryDetails();
            productDataGridView.DataSource = delivery.ProductsList;
        }

        private void DisplayDeliveryInfo()
        {
            int productsCount=0;
            decimal value=0;
            foreach (var item in delivery.ProductsList)
            {
                productsCount += item.QuantityOnMove;
                value += (item.Price * item.QuantityOnMove);
            }
            totalQuantityLabel.Text = productsCount.ToString();
            totalPriceLabel.Text = value.ToString("c");
            creationDateLabel.Text = delivery.Date;
        }

        private void ProductDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DisplayDeliveryInfo();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            delivery.ProductsList.Remove(productDataGridView.CurrentRow.DataBoundItem as ProductOnMove);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            SortableBindingList<Product> productsList = new SortableBindingList<Product>();
            DataBase db = DataBase.GetInstance;
            foreach (var item in db.ProductsList)
            {
                if (delivery.ProductsList.FirstOrDefault(x => x.Id == item.Id) == null)
                {
                    productsList.Add(item);
                }
            }
            ChooseProductsForm chooseProductsForm = new ChooseProductsForm(productsList);
            chooseProductsForm.ShowDialog();
            foreach (var item in chooseProductsForm.ChoosenProductsList)
            {
                delivery.ProductsList.Add(new ProductOnMove(item));
            }
        }

        private void ChangeDeliveryNameButton_Click(object sender, EventArgs e)
        {
            NameBoxForm newNameForm = new NameBoxForm();
            newNameForm.ShowDialog();
            string newName = newNameForm.NewName;
            if (!string.IsNullOrWhiteSpace(newName))
            {
                delivery.Name = newName;
                deliveryNameLabel.Text = newName;
            }
        }

        private void ProductDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductOnMove product = (ProductOnMove) productDataGridView.CurrentRow.DataBoundItem;
            productNameLabel.Text = product.Name;
            productCodeLabel.Text = product.Code;
            actualQuantityLabel.Text = product.Quantity.ToString();
            productPriceLabel.Text = product.Price.ToString("c");
            productReservationLabel.Text = product.Reservation.ToString();
            countProductsNumericUpDown.Value = product.QuantityOnMove;
            productNameGroupBox.Visible = true;
            doubleClickLabel.Visible = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            productNameLabel.Text = "";
            productCodeLabel.Text = "";
            actualQuantityLabel.Text = "";
            productPriceLabel.Text = "";
            productReservationLabel.Text = "";
            countProductsNumericUpDown.Value = 0;
            productNameGroupBox.Visible = false;
            doubleClickLabel.Visible = true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            delivery.ProductsList.FirstOrDefault(x => x.Code == productCodeLabel.Text && x.Name == productNameLabel.Text).QuantityOnMove = (int)countProductsNumericUpDown.Value;
            productNameGroupBox.Visible = false;
            doubleClickLabel.Visible = true;
        }

        private void SaveDeliveryButton_Click(object sender, EventArgs e)
        {
            DataBase.GetInstance.UpdateDelivery(delivery);
        }

        private void DeleteDeliveryButton_Click(object sender, EventArgs e)
        {
            DataBase.GetInstance.DeleteDelivery(delivery);
            this.Close();
            
        }

        private void MakeDeliveryButton_Click(object sender, EventArgs e)
        {
            DataBase db = DataBase.GetInstance;
            foreach (var item in delivery.ProductsList)
            {
                db.ProductsList.FirstOrDefault(x => x.Id == item.Id).Quantity += item.QuantityOnMove;
            }
            db.DeleteDelivery(delivery);
            this.Close();
        }
    }
}
