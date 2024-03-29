﻿using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IScientificNameServices
    {
        ScientificName GetScientificNameByID(int id);
        void InsertScientificName(ScientificName ScientificName);
        void UpdateScientificName(ScientificName ScientificName);
        void DeleteScientificName(int id);
        IEnumerable<ScientificName> GetAllScientificNames();
    }
}
