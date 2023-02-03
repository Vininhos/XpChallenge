namespace Xp.Tests
{
    public interface IRepositoryTest
    {
        void Execute();
        void ValidateRegistrationCliente();
        void ValidateSearchByIdCliente();
        void ValidateUpdateCliente();
        void ValidateDeleteCliente();
    }
}