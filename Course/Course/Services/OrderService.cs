using Course.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    public class OrderService
    {
        public void Save(Order order);
        public List<Order> Search(DateTime minDate, DateTime maxDate);
    }
}
