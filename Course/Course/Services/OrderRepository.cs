using Course.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    public class OrderRepository
    {
        public List<Order> FindByDate(DateTime minDate, DateTime maxDate);
    }
}
