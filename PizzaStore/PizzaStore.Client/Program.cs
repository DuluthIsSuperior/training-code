using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

//dotnet run -p PizzaStore/PizzaStore.Client/PizzaStore.Client.csproj

namespace PizzaStore.Client {
  class Program {
    static void Main() {
      System.Console.WriteLine("Welcome to PizzaWorld! The best pizza in the World!\n");

      Starter starter = new Starter();
      User user = new User();
      Store store = new Store();

      try {
        Menu(starter.CreateOrder(user, store));
      } catch (Exception ex) {
        Console.WriteLine($"An unknown error has occurred. Please try again later. Error details: {ex.Message}");
      }
    }

    static void Menu(Order cart) {
      bool exit = false;

      do {
        Starter.PrintMenu();
        int select;
        if (int.TryParse(Console.ReadLine(), out select)) {
          switch (select) {
            case 1:
              cart.CreatePizza("L", "Stuffed", new List<string> { "cheese" });
              System.Console.WriteLine("added Cheese");
              break;
            case 2:
              cart.CreatePizza("L", "Stuffed", new List<string> { "pepperoni" });
              System.Console.WriteLine("added Pepperoni");
              break;
            case 3:
              cart.CreatePizza("L", "Stuffed", new List<string> { "pineapple" });
              System.Console.WriteLine("added Pineapple");
              break;
            case 4:
              cart.CreatePizza("L", "Stuffed", new List<string> { "custom" });
              System.Console.WriteLine("added Custom");
              break;
            case 5:
              DisplayCart(cart);
              break;
            case 6:
              var fmw = new FileManager();
              fmw.Write(cart);
              Console.WriteLine("Thank you, Goodbye!");
              exit = true;
              break;
            case 7:
              var fmr = new FileManager();
              DisplayCart(fmr.Read());
              break;
          }
        }
      } while (!exit);
    }

    static void DisplayCart(Order cart) {
      foreach (Pizza pizza in cart.Pizzas) {
        System.Console.WriteLine(pizza);
      }
    }
  }
}
