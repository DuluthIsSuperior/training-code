using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client {
  internal class Startup {
    internal Order CreateOrder(User user, Store store) {
      try {
        Order order = new Order();

        user.Orders.Add(order);
        store.Orders.Add(order);

        return order;
      } catch {
        return null;
      }
    }
  }
}