namespace BestRestaurant.Models
{
  public class Restaurant 
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public string Rating { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    
  }
}