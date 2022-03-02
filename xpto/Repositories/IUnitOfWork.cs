using System;

namespace xpto.Repositories
{
    public interface IUnitOfWork
    {
        IMedicationRepository Medications { get; }

        void Commit();

        void Commit<T>(T pData) where T : class;
    }
}
