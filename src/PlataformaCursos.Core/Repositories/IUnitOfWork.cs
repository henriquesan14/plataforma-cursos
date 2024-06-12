namespace PlataformaCursos.Core.Repositories
{
    public interface IUnitOfWork
    {
        public ICourseRepository Courses { get; set; }
        public ILessonRepository Lessons { get; set; }
        public IModuleRepository Modules { get; set; }
        public IPaymentSubscriptionRepository PaymentSubscriptions { get; set; }
        public ISubscriptionRepository Subscriptions { get; set; }
        public IUserLessonCompletedRepository UserLessonsCompleted { get; set; }
        public IUserRepository Users { get; set; }
        public IUserSubscriptionRepository UserSubscriptions { get; set; }

        Task<int> CompleteAsync();
        Task BeginTransaction();
        Task CommitAsync();
    }
}
