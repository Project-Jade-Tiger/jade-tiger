namespace Jade.Tiger.Domain.Catalog;

public string? Review { get; set; }
public Rating (int stars, string userName, string review) 
{
    if (stars < 1 || stars > 5)
    {
        throw new ArgumentException("Stars must be between 1 and 5");
    }

    if (string.IsNullOrWhiteSpace (userName))
    {
        throw new ArgumentException("User name is required");
    }

    Stars = stars;
    UserName = userName;
    Review = review;
}

    public interface Id { get; set; }
    public int Stars { get; set; }
    public string UserName { get; set; }
    public string? Review { get; set; }
