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
    public partial class NameBoxForm : Form
    {
        string newName;
        public NameBoxForm()
        {
            InitializeComponent();
        }

        public string NewName { get => newName; set => newName = value; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            newName = string.Empty;
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            newName = newNameTextBox.Text;
            this.Close();
        }

        private void NewNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AcceptButton_Click(null, null);
            }
        }
    }
}
