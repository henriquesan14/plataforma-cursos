namespace PlataformaCursos.Core.Entities
{
    public class Module : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Lesson> Lessons { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
