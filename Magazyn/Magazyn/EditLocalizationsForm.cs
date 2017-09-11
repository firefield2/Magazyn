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
    public partial class LocalizationForm : Form
    {
        public LocalizationForm()
        {
            InitializeComponent();
            localizationListBox.DataSource = DataBase.GetInstance.LocalizationsList;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (localizationListBox.SelectedIndex!=0)
            {
                mainGroupBox.Visible = false;
                localizationNameGB.Visible = true;
                localizationNameTB.Clear();
                localizationNameTB.Text = ((Localization)localizationListBox.SelectedItem).Name;
            }
            else
            {
                MessageBox.Show("Zaznacz lokalizację do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(localizationNameTB.Text))
            {
                if (CheckNameAvailibility(localizationNameTB.Text))
                {
                    DataBase db = DataBase.GetInstance;
                    db.UpdateLocalization(localizationNameTB.Text, ((Localization)localizationListBox.SelectedItem).Id);
                    db.GetLocalizations();
                    mainGroupBox.Visible = true;
                    localizationNameGB.Visible = false;
                }
                else
                {
                    MessageBox.Show("Podana lokalizacja już istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int number = localizationListBox.Items.Count;
            string name = "Lokalizacja";
            while (!CheckNameAvailibility(name + number))
            {
                number++;
            }
            name += number;
            DataBase db = DataBase.GetInstance;
            db.CreateLocalization(name);
            db.GetLocalizations();
            mainGroupBox.Visible = false;
            localizationNameGB.Visible = true;
            localizationNameTB.Clear();
            localizationListBox.SelectedItem = db.LocalizationsList.FirstOrDefault(x => x.Name == name);
            localizationNameTB.Text = name;
            localizationNameTB.Focus();
            localizationNameTB.SelectAll();
        }

        private bool CheckNameAvailibility(string name)
        {
            
            return DataBase.GetInstance.LocalizationsList.FirstOrDefault(x => x.Name == name) == null;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            localizationNameTB.Clear();
            mainGroupBox.Visible = true;
            localizationNameGB.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (localizationListBox.SelectedIndex != 0)
            {
                Localization localization = ((Localization)localizationListBox.SelectedItem);
                if (DialogResult.Yes == MessageBox.Show("Na pewno usunąć lokalizację \"" + localization.Name + "\"?","Pytanie.", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    DataBase db = DataBase.GetInstance;
                    db.DeleteLocalization(localization);
                    db.GetLocalizations();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz lokalizację do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void localizationNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmButton_Click(sender, null);
            }
        }
    }
}
