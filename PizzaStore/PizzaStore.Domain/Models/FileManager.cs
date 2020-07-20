using System;
using System.IO;
using System.Xml.Serialization;

namespace PizzaStore.Domain.Models
{
  public class FileManager
  {
    //XML = extensible markup language

    private const string _path = @"data/pizza_store.xml";

    public Order Read() {
      var reader = new StreamReader(_path);
      var xml = new XmlSerializer(typeof(Order));

      return xml.Deserialize(reader) as Order;
    }

    public void Write(Order order) {
      bool tryAgain = true;
      while (tryAgain) {
        try {
          StreamWriter writer = new StreamWriter(_path);
          XmlSerializer xml = new XmlSerializer(typeof(Order));
          xml.Serialize(writer, order);
          tryAgain = false;
        } catch (DirectoryNotFoundException) {
          Directory.CreateDirectory("data");
        } catch (Exception e) {
          Console.WriteLine(e.GetType().FullName + e.Message);
        }
      }
    }
  }
}