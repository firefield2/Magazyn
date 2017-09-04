using Be.Timvw.Framework.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magazyn
{
    public class Delivery
    {
        private int id;
        private string name;
        private string code;
        private string date;
        SortableBindingList<ProductOnMove> productsList = new SortableBindingList<ProductOnMove>();

        public Delivery()
        {
        }

        public Delivery(int id, string code, string name, string date)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.code = code;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public string Code { get => code; set => code = value; }
        public SortableBindingList<ProductOnMove> ProductsList { get => productsList; set => productsList = value; }

        public Delivery Clone()
        {
            return new Delivery(id, code ,name, date);
        }

        public List<ProductOnMove> GetDeliveryDetails()
        {
            productsList = DataBase.GetInstance.GetDeliveryProducts(code);
            return productsList.ToList();
        }
    }
}