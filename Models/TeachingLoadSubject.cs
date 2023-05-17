namespace TeachingLoadInfoSystem.Models
{
    public class TeachingLoadSubject : EntityBase
    {
        public int TeachingLoadID { get; set; }
        public virtual Subject Subjects { get; set; }
        public int SubjectID { get; set; }
        public int ExerciseFirstSem { get; set; }
        public int LectureFirstSem { get; set; }
        public int LaboratoryFirstSem { get; set; }
        public int RecommendationFirstSem { get; set; }
        public int ExamFirstSem { get; set; }
        public int FirstSemSum { get; set; }
        public int ExerciseSecondSem { get; set; }
        public int LectureSecondSem { get; set; }
        public int LaboratorySecondSem { get; set; }
        public int RecommendationSecondSem { get; set; }
        public int ExamSecondSem { get; set; }
        public int PrLeader { get; set; }
        public int Practise { get; set; }
        public int EPedTETedTTKITA { get; set; }
        public int Thesis { get; set; }
        public int MasterThesis { get; set; }
        public int Doctorate { get; set; }
        public int SecondSemSum { get; set; }
        public int FinalResult { get; set; }
    }
}
