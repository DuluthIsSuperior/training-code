using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models {
  public class Pizza {
    // STATE
    //fields
    private readonly string _imageUrl = "https://some-url";
    private const double _diameter = 0;
    private static string _name = "pizza";
    private List<string> _toppings = new List<string>();

    //properties
    public string Crust { get; }
    public string Size { get; } // size
    public List<string> Toppings {
      get {
        return _toppings; // backing field
      }
    }

    // BEHAVIOR
    //constructors
    public Pizza(string size, string crust, List<string> toppings) {
      Size = size;
      Crust = crust;
      Toppings.AddRange(toppings);
    }

    public Pizza() {
      Size = "";
      Crust = "";
      // intentionally empty
    }

    //methods
    void AddToppings(string topping) {
      Toppings.Add(topping);
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder();

      for (int i = 0; i < Toppings.Count; i++) {
        sb.Append(Toppings[i]);
        if (i != Toppings.Count - 1) {
          sb.Append(", ");
        }
      }

      return $"{Crust} {Size} {sb}";
    }

    //finalizers or destructors
  }
}