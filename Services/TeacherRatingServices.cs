using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class TeacherRatingServices : ITeacherRatingServices
    {
        private IRepository<TeacherRating> _repository;

        public TeacherRatingServices(IRepository<TeacherRating> repository)
        {
            _repository = repository;
        }
        public TeacherRating GetTeacherRatingByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertTeacherRating(TeacherRating TeacherRating)
        {
            _repository.Insert(TeacherRating);
        }
        public void UpdateTeacherRating(TeacherRating TeacherRating)
        {
            _repository.Update(TeacherRating);
        }
        public void DeleteTeacherRating(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<TeacherRating> GetAllTeacherRatings()
        {
            return _repository.GetAll;
        }
    }
}
