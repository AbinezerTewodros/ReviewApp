namespace ReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Owner> Owners { get; set; }
    }
}
