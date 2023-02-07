namespace Xp.Tests
{
    public class AppTestMain
    {
        private readonly RepositoryTest _repositoryTest;
        private readonly ServiceTest _serviceTest;

        public AppTestMain(RepositoryTest repositoryTest, ServiceTest serviceTest)
        {
            _repositoryTest = repositoryTest;
            _serviceTest = serviceTest;
        }

        public void Execute()
        {
            ValidateStructureLayer_Context();
            ValidateDomainLayer();
            ValidateRepositoryLayer();
            ValidateServiceLayer();
        }
        private void ValidateStructureLayer_Context()
        {
            FakeContextTests fakeContextTests = new FakeContextTests();
            fakeContextTests.Execute();
        }

        private void ValidateDomainLayer()
        {
            DomainTests tests = new DomainTests();
            tests.Execute();
        }

        private void ValidateRepositoryLayer()
        {
            _repositoryTest.Execute();
        }

        private void ValidateServiceLayer()
        {
            _serviceTest.Execute();
        }
    }
}
