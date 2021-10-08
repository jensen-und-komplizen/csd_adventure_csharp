using CsdTextAdventure;
using NUnit.Framework;

namespace TestProject1
{
    public class IOControllerTest
    {
        [Test]
        public void implements_IOInterface()
        {
            var IOController = new IOController();
            Assert.IsInstanceOf<IOInterface>(IOController);
        }
    }
}