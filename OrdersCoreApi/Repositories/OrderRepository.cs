using OrdersCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersCoreApi.Repositories
{

    public interface IOrderRepository
    {

        IEnumerable<Order> GetAllOrders();


    }

    public class OrderRepository:IOrderRepository
    {
        public IEnumerable<Order> GetAllOrders()
        {
            var orders = new List<Order>()
            {
                new Order(){ id=101,name ="TV",desc="Samsung"},
                new Order(){ id=102,name ="IPhone",desc="Iphone11"},
                new Order(){ id=103,name ="Car",desc="Tesla"}


            };

            return orders;

        }
    }
}
