using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xp.Tests
{
    public class AppTestMain
    {
        public AppTestMain() { }

        public void Execute()
        {
            ValidateStructureLayer_Context();
            ValidateDomainLayer();
        }
        private void ValidateStructureLayer_Context()
        {
            FakeContextTests fakeContextTests = new FakeContextTests();
            fakeContextTests.TestList();
            fakeContextTests.TestInclusion();
            fakeContextTests.GetRandomPeopleAsync().Wait();
        }

        private void ValidateDomainLayer()
        {
            DomainTests tests = new DomainTests();
            tests.TestEntity();
            tests.TestDto();
            tests.TestConvertionEntityToDto();
            tests.TestConvertionDtoToEntity();
        }
    }
}
