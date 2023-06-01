using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ITeacherRatingServices
    {
        TeacherRating GetTeacherRatingByID(int id);
        void InsertTeacherRating(TeacherRating rating);
        void UpdateTeacherRating(TeacherRating rating);
        void DeleteTeacherRating(int id);
        IEnumerable<TeacherRating> GetAllTeacherRatings();
    }
}
