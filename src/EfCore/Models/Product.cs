namespace EfCore.Models;

public class Product(string code, string name, decimal price, int stock, string category)
{
  public string Code {get; private set;} = code.Trim().ToUpperInvariant();
  public string Name {get; private set;} = name;
  public decimal Price {get; private set;} = price;
  public int Stock {get; private set;} = stock;
  public string Category{get; private set;} = category;

  public void UpdateDetail(string name, decimal price, int stock, string category)
  {
    var validated = new Product(Code, name, price, stock, category);
    
    Name = validated.Name;
    Price = validated.Price;
    Stock = validated.Stock;
    Category = validated.Category;
  }
}