namespace Xp.Tests
{
    public class AppTestMain
    {
        private readonly IRepositoryTest _repositoryTest;

        public AppTestMain(IRepositoryTest repositoryTest)
        {
            _repositoryTest = repositoryTest;
        }

        public void Execute()
        {
            ValidateStructureLayer_Context();
            ValidateDomainLayer();
            ValidateRepositoryLayer();
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
    }
}
