using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public class Product : INotifyPropertyChanged
    {
        int id;
        string name;
        string code;
        string description;
        int quantity;
        int reservation;
        decimal price;
        string category;
        string localization;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
            }
        }
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
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Code"));
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity"));
            }
        }
        public int Reservation
        {
            get
            {
                return reservation;
            }
            set
            {
                reservation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Reservation"));
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Category"));
            }
        }
        public string Localization
        {
            get
            {
                return localization;
            }
            set
            {
                localization = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Localization"));
            }
        }

        public Product(int id, string name, string code, string description, int quantity, int reservation, decimal price, string category, string localization)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
            this.Description = description;
            this.Quantity = quantity;
            this.Reservation = reservation;
            this.Price = price;
            this.Category = category;
            this.Localization = localization;
        }
        protected void OnPropertyChanged(string arg)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(arg));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
