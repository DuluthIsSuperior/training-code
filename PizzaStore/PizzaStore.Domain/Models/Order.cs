using System.Collections.Generic;

namespace PizzaStore.Domain.Models {
  public class Order {
    public List<Pizza> Pizzas { get; set; }

    public void CreatePizza(string size, string crust, List<string> toppings) {
      Pizzas.Add(new Pizza(size, crust, toppings));
    }

    public Order() {
      Pizzas = new List<Pizza>();
    }
  }
}