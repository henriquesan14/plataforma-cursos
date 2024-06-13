namespace PlataformaCursos.Core.Entities
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }

        public virtual List<Module> Modules { get; set; }

        public int SubscriptionId { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
