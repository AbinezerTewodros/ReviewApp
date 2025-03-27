using ReviewApp.Models;

namespace ReviewApp.Dto
{
    public class ReviewerDto
    {
        public int Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
