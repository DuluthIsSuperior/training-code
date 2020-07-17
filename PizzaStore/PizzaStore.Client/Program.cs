using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client {
    class Program {
        static void Main() {
            Welcome();
        }

        static void Welcome() {
          Console.WriteLine("Welcome to PizzaWorld");
          Console.WriteLine("Best Pizza in the World");
          Console.WriteLine();

          string[] cart1 = {"", "", ""};
          string[] cart2 = new string[3];
          string[] cart3 = new string[]{"", "", ""};
          List<string> cart4 = new List<string>{"", "", ""};  // initial values
          List<Pizza> cart5 = new List<Pizza>();  // default values

          // Menu(cart5);

          Startup startup = new Startup();
          User user = new User();
          Store store = new Store();

          try {
            Menu(startup.CreateOrder(user, store));
          } catch (Exception e) {
            Console.WriteLine(e.Message);
          }

          // if (order != null) {
          //   Menu(order);
          // } else {
          //   Console.WriteLine("Technical difficulties");
          // }
        }
        
        static void Menu(Order cart) {
          bool exit = false;
          Startup startup = new Startup();
          do {
            Console.WriteLine("Select 1 for Cheese Pizza");
            Console.WriteLine("Select 2 for Pepperoni Pizza");
            Console.WriteLine("Select 3 for Hawaiian Pizza");
            Console.WriteLine("Select 4 for Custom Pizza");
            Console.WriteLine("Select 5 to show cart");
            Console.WriteLine("Select 6 to Exit Pizza");
            Console.WriteLine();

            int select;

            int.TryParse(Console.ReadLine(), out select);
            
            switch (select) {
              case 1:
                cart.CreatePizza("L", "Stuffed", new List<string>{"cheese"});
                Console.WriteLine("added Cheese");
                break;
              case 2:
                cart.CreatePizza("L", "Stuffed", new List<string>{"pepperoni"});
                Console.WriteLine("added Pepperoni");
                break;
              case 3:
                cart.CreatePizza("L", "Stuffed", new List<string>{"pineapple"});
                Console.WriteLine("added Pineapple");
                break;
              case 4:
                cart.CreatePizza("L", "Stuffed", new List<string>{"custom"});
                Console.WriteLine("added Custom");
                break;
              case 5:
                DisplayCart(cart);
                break;
              case 6:
                Console.WriteLine("Thank you! Goodbye!");
                exit = true;
                break;
            }
          } while (!exit);
        }

        static void DisplayCart(Order cart) {
          foreach (Pizza pizza in cart.Pizzas) {
            Console.WriteLine(pizza);
          }
        }
    }
}
