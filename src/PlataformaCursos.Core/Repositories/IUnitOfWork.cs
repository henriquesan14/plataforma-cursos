namespace PlataformaCursos.Core.Repositories
{
    public interface IUnitOfWork
    {
        public ICourseRepository Courses { get;}
        public ILessonRepository Lessons { get; }
        public IModuleRepository Modules { get; }
        public IPaymentSubscriptionRepository PaymentSubscriptions { get;}
        public ISubscriptionRepository Subscriptions { get; }
        public IUserLessonCompletedRepository UserLessonsCompleted { get;}
        public IUserRepository Users { get;}
        public IUserSubscriptionRepository UserSubscriptions { get;}

        Task<int> CompleteAsync();
        Task BeginTransaction();
        Task CommitAsync();
    }
}
