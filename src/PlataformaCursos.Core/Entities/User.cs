using PlataformaCursos.Core.Enums;

namespace PlataformaCursos.Core.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly BirthDate{ get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
        public RoleEnum Role { get; set; }
        public bool Active { get; set; }

        public virtual List<UserSubscription> UserSubscriptions { get; set; }

        public virtual List<UserLessonCompleted> UserLessonsCompleted { get; set; }
    }
}
