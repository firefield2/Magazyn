using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    class Localization : INotifyPropertyChanged
    {
        public int Id { get; set; }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public Localization(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
