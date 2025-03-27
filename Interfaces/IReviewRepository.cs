using ReviewApp.Models;

namespace ReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int ownerId);
        bool ReviewExists(int reviewId);

    }
}
