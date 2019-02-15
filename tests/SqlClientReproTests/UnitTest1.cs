using ClassLibrary1;
using NUnit.Framework;

namespace SqlClientReproTests
{
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
            var repo = new FooRepository();
            var foos = repo.GetFoos();
            Assert.NotNull(foos);
        }
    }
}
