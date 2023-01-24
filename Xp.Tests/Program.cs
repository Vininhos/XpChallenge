// See https://aka.ms/new-console-template for more information
using Xp.Tests;

ValidateStructureLayer_Context();
ValidateDomainLayer();

void ValidateStructureLayer_Context()
{
    FakeContextTests fakeContextTests = new FakeContextTests();
    fakeContextTests.TestList();
    fakeContextTests.TestInclusion();
}

void ValidateDomainLayer()
{
    DomainTests tests = new DomainTests();
    tests.TestEntity();
    tests.TestDto();
    tests.TestConvertionEntityToDto();
    tests.TestConvertionDtoToEntity();
}