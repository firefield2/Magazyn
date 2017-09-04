using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be.Timvw.Framework.ComponentModel;

namespace Magazyn
{
    public class ProductOnMove : Product
    {
        int quantityOnMove;

        public ProductOnMove(Product item): base(item.Id,item.Name,item.Code,item.Description,item.Quantity,item.Reservation,item.Price,item.Category,item.Localization)
        {
            quantityOnMove = 0;

        }

        public ProductOnMove(int id, string name, string code, string description, int quantity, int reservation,int quantityOnMove, decimal price, string category, string localization) : base(id, name, code, description, quantity, reservation, price, category, localization)
        {
            this.quantityOnMove = quantityOnMove;
        }

        public int QuantityOnMove
        {
            get
            {
                return quantityOnMove;
            }
            set
            {
                quantityOnMove = value;
                OnPropertyChanged("QuantityOnMove");
            }
        }
    }
}
