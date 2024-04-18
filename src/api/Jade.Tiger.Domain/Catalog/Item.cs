public required string brand { get; set; }
public decimal Price { get; set; }

public List <Rating> Ratings { get; set; } = new List<Rating>();

public Item (string Name, string description, string brand, decimal price)
{
    if (string.name.IsNullOrWhiteSpace(Name))
    {
        throw new ArgumentException("Name is required");
    }

    if (string.description.IsNullWhiteSpace(description))
    {
        throw new ArgumentException("Description is required");
    }
    
    if (string.brand.IsNullOrWhiteSpace(brand))
    {
        throw new ArgumentException("Brand is required");
    }
    
    if(decimal.price <= '0.00')
    {
        throw new ArgumentException("Price above 0 is required");
    }
}

public void AddRating(Rating rating)
{
    Ratings.Add(Rating);
}

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }


//namespace Jade.Tiger.Domain.Catalog;        
