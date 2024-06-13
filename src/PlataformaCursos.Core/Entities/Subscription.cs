namespace PlataformaCursos.Core.Entities
{
    public class Subscription : EntityBase
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public virtual List<Course> Courses { get; set; }

        public virtual List<UserSubscription> UserSubscriptions { get; set; }
    }
}
