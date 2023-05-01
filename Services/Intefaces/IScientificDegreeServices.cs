using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IScientificDegreeServices
    {
        ScientificDegree GetScientificDegreeByID(int id);
        void InsertScientificDegree(ScientificDegree scientificDegree);
        void UpdateScientificDegree(ScientificDegree scientificDegree);
        void DeleteScientificDegree(int id);
        IEnumerable<ScientificDegree> GetAllScientificDegrees();
    }
}
