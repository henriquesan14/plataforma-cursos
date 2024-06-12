using Microsoft.EntityFrameworkCore.Storage;
using PlataformaCursos.Core.Repositories;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {


        private IDbContextTransaction _transaction;
        private readonly PlataformaCursosDbContext _dbContext;

        public UnitOfWork(IDbContextTransaction transaction, PlataformaCursosDbContext dbContext, ICourseRepository courses, ILessonRepository lessons,
            IModuleRepository modules, IPaymentSubscriptionRepository paymentSubscriptions, ISubscriptionRepository subscriptions,
            IUserLessonCompletedRepository userLessonsCompleted, IUserRepository users, IUserSubscriptionRepository userSubscriptions)
        {
            _transaction = transaction;
            _dbContext = dbContext;
            Courses = courses;
            Lessons = lessons;
            Modules = modules;
            PaymentSubscriptions = paymentSubscriptions;
            Subscriptions = subscriptions;
            UserLessonsCompleted = userLessonsCompleted;
            Users = users;
            UserSubscriptions = userSubscriptions;
        }

        public ICourseRepository Courses { get; }
        public ILessonRepository Lessons { get; }
        public IModuleRepository Modules { get; }
        public IPaymentSubscriptionRepository PaymentSubscriptions { get; }
        public ISubscriptionRepository Subscriptions { get; }
        public IUserLessonCompletedRepository UserLessonsCompleted { get; }
        public IUserRepository Users { get; }
        public IUserSubscriptionRepository UserSubscriptions { get; }

        public async Task BeginTransaction()
        {
            _transaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await _transaction.RollbackAsync();
                throw ex;
            }

        }

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            IsDisposing(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void IsDisposing(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}
