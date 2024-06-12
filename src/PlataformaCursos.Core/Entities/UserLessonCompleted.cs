namespace PlataformaCursos.Core.Entities
{
    public class UserLessonCompleted : EntityBase
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }
        public DateOnly EndDate { get; set; }
        public int Grade { get; set; }
    }
}
