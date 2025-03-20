namespace ReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
        
    }
}
