namespace PlataformaCursos.Core.Entities
{
    public class EntityBase
    {
        public int Id { get; protected set; }
        public int CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
