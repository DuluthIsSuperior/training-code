using System.Collections.Generic;

namespace PizzaStore.Domain.Models {
  public class Pizza {
    // STATE
    // fields
    // properties
    private string _imaqeUrl = "";
    private double _diameter = 0;
    public string Size = "";

    private List<string> _toppings = new List<string>();
    public string Crust = "";

    // properties

    public List<string> toppings {
      get {
        return _toppings;
      }
    }

    // BEHAVIOR
    // methods
    void AddToppings(string topping) {
      toppings.Add(topping);
    }
    
    public override string ToString() {
      return $"{Size} {Crust} {toppings}";
    }
    // constructors
    public Pizza(string size, string crust, List<string> toppings) {
      Size = size;
      Crust = crust;
      _toppings.AddRange(toppings);
    }
    // finalizers or destructors
  }
}