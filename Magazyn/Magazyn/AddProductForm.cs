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
    public partial class AddProductForm : Form
    {
        public delegate void OnCloseEventHandler();
        public event OnCloseEventHandler OnClose;
        public AddProductForm()
        {
            InitializeComponent();
            DataBase db = DataBase.GetInstance;
            categoryComboBox.DataSource = db.CategoriesList;
            localizationComboBox.DataSource = db.LocalizationsList;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) || !string.IsNullOrWhiteSpace(codeTextBox.Text) || !string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                string name = nameTextBox.Text;
                string code = codeTextBox.Text;
                bool productNotUnique = false;
                DataBase db = DataBase.GetInstance;
                foreach (var item in db.ProductsList)
                {
                    if (item.Name == name)
                    {
                        MessageBox.Show("Produkt o podanej nazwie już istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productNotUnique = true;
                    }
                    else if (item.Code == code)
                    {
                        MessageBox.Show("Produkt o podanym kodzie już istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productNotUnique = true;
                    }
                }
                if (!productNotUnique)
                {
                    db.AddProduct(new Product(0, name, code, descriptionTextBox.Text, (int)quantityNumericUpDown.Value, (int)reservationNumericUpDown.Value, priceNumericUpDown.Value, ((Category)categoryComboBox.SelectedItem).Name, ((Localization)localizationComboBox.SelectedItem).Name));
                    if (DialogResult.Yes == MessageBox.Show("Produkt dodany poprawnie.\r\nChcesz dodać kolejny produkt?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        ClearForm();
                    }
                    else
                    {
                        CloseForm();
                    }
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
            OnClose?.Invoke();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = 0;
            localizationComboBox.SelectedIndex = 0;
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
    }
}
