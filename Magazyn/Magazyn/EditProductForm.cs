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
    public partial class EditProductForm : Form
    {
        Product product;
        public delegate void OnCloseEventHandler();
        public event OnCloseEventHandler OnClose;
        public EditProductForm()
        {
            InitializeComponent();
            DataBase db = DataBase.GetInstance;
            categoryComboBox.DataSource = db.CategoriesList;
            localizationComboBox.DataSource = db.LocalizationsList;
        }
        public EditProductForm(Product product) : this()
        {
            DataBase db = DataBase.GetInstance;
            this.product = product;
            nameTextBox.Text = product.Name;
            codeTextBox.Text = product.Code;
            descriptionTextBox.Text = product.Description;
            priceNumericUpDown.Value = product.Price;
            quantityNumericUpDown.Value = product.Quantity;
            reservationNumericUpDown.Value = product.Reservation;
            categoryComboBox.SelectedItem = db.CategoriesList.FirstOrDefault(x => x.Name == product.Category);
            localizationComboBox.SelectedItem = db.LocalizationsList.FirstOrDefault(x => x.Name == product.Localization);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            OnClose?.Invoke();
            this.Close();
        }

        private void EditLocalizationButton_Click(object sender, EventArgs e)
        {
            LocalizationForm form = new LocalizationForm();
            form.ShowDialog();
        }

        private void EditCategoriesButton_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.ShowDialog();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) || !string.IsNullOrWhiteSpace(codeTextBox.Text) || !string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                string name = nameTextBox.Text;
                string code = codeTextBox.Text;
                bool productNotUnique = false;
                DataBase db = DataBase.GetInstance;
                foreach (var item in db.ProductsList)
                {
                    if (item.Name == name && item.Id!= product.Id)
                    {
                        MessageBox.Show("Produkt o podanej nazwie już istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productNotUnique = true;
                    }
                    else if (item.Code == code && item.Id != product.Id)
                    {
                        MessageBox.Show("Produkt o podanym kodzie już istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productNotUnique = true;
                    }
                }
                if (!productNotUnique)
                {
                    product.Name = name;
                    product.Code = code;
                    product.Description = descriptionTextBox.Text;
                    product.Quantity = (int)quantityNumericUpDown.Value;
                    product.Reservation = (int)reservationNumericUpDown.Value;
                    product.Price = priceNumericUpDown.Value;
                    product.Category = ((Category)categoryComboBox.SelectedItem).Name;
                    product.Localization = ((Localization)localizationComboBox.SelectedItem).Name;
                    db.EditProduct( product);
                    MessageBox.Show("Produkt edytowany poprawnie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseForm();
                }
            }
        }

        private void ClearForm()
        {
            nameTextBox.Clear();
            codeTextBox.Clear();
            descriptionTextBox.Clear();
            priceNumericUpDown.Value = 0;
            quantityNumericUpDown.Value = 0;
            reservationNumericUpDown.Value = 0;
            localizationComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClose?.Invoke();
        }

        private void ReservationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (reservationNumericUpDown.Value > quantityNumericUpDown.Value)
            {
                reservationNumericUpDown.Value = quantityNumericUpDown.Value;
                MessageBox.Show("Zarezerwowana ilość produktu nie może być większa od posiadanej ilości.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DescriptionTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TextBox textbox = (sender as TextBox);
                var position = textbox.SelectionStart;
                textbox.Text = textbox.Text.Insert(position," ");
                textbox.SelectionStart = position + 1;
            }
        }
    }
}
