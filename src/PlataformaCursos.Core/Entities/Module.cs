namespace PlataformaCursos.Core.Entities
{
    public class Module : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Lesson> Lessons { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
