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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            categoryListBox.DataSource = DataBase.GetInstance.CategoriesList;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedIndex!=0)
            {
                mainGroupBox.Visible = false;
                categoryNameGB.Visible = true;
                categoryNameTB.Clear();
                categoryNameTB.Text = ((Category)categoryListBox.SelectedItem).Name;
            }
            else
            {
                MessageBox.Show("Zaznacz kategorię do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoryNameTB.Text))
            {
                if (CheckNameAvailibility(categoryNameTB.Text))
                {
                    DataBase db = DataBase.GetInstance;
                    db.UpdateCategory(categoryNameTB.Text, ((Category)categoryListBox.SelectedItem).Id);
                    db.GetCategories();
                    mainGroupBox.Visible = true;
                    categoryNameGB.Visible = false;
                }
                else
                {
                    MessageBox.Show("Podana kategoria już istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int number = categoryListBox.Items.Count;
            string name = "Kategoria";
            while (!CheckNameAvailibility(name + number))
            {
                number++;
            }
            name += number;
            DataBase db = DataBase.GetInstance;
            db.CreateCategory(name);
            db.GetCategories();
            mainGroupBox.Visible = false;
            categoryNameGB.Visible = true;
            categoryNameTB.Clear();
            categoryListBox.SelectedItem = db.CategoriesList.FirstOrDefault(x => x.Name == name);
            categoryNameTB.Text = name;
            categoryNameTB.Focus();
            categoryNameTB.SelectAll();
        }

        private bool CheckNameAvailibility(string name)
        {
            
            return DataBase.GetInstance.CategoriesList.FirstOrDefault(x => x.Name == name) == null;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            categoryNameTB.Clear();
            mainGroupBox.Visible = true;
            categoryNameGB.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedIndex != 0)
            {
                Category category = ((Category)categoryListBox.SelectedItem);
                if (DialogResult.Yes == MessageBox.Show("Na pewno usunąć kategorię \"" + category.Name + "\"?","Pytanie.", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    DataBase db = DataBase.GetInstance;
                    db.DeleteCategory(category);
                    db.GetCategories();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz kategorię do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CategoryNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmButton_Click(sender, null);
            }
        }
    }
}
