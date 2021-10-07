using NUnit.Framework;

namespace TextAdventure.UnitTests
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