using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities.Enums;

namespace Course.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Moment: {Moment}\n" +
                   $"Status: {Status}\n";
        }

        public void AddItem(OrdemItem ordem)
        {

        }
        public void RemoveItem(OrdemItem item)
        {

        }
        public double Total()
        {

        }
    }
}
