using System.Collections.Generic;

namespace PizzaStore.Domain.Models {
  public class Store {
    public List<Order> Orders;

    public Store() {
      Orders = new List<Order>();
    }
  }
}