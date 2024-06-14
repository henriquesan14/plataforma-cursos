namespace PlataformaCursos.Core.Entities
{
    public class Lesson : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LinkVideo { get; set; }
        public int Duration { get; set; }
        public int VimeoClipId { get; set; }

        public virtual List<UserLessonCompleted> UserLessonsCompleted { get; set; }
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }
    }
}
