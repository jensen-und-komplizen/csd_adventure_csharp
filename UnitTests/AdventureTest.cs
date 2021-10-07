using NUnit.Framework;
using Moq;
using FluentAssertions;

namespace TextAdventure.UnitTests
{
    public class AdventureTest
    {
        private Mock<IOInterface> _ioInterfaceMock;
        private Adventure _adventure;


        [SetUp]
        public void SetUp()
        {
            _ioInterfaceMock = new Mock<IOInterface>();
            _adventure = new Adventure(_ioInterfaceMock.Object);
        }

        [Test]
        public void Adventure_can_be_started()
        {
            Adventure adventure = new Adventure(null);
            Assert.IsInstanceOf<Adventure>(adventure);
        }

        [Test]
        public void running_shows_Introduction()
        {
            _ioInterfaceMock.Setup(x => x.ReadLine()).Returns("quit");
            _adventure.Begin();
            _ioInterfaceMock.Verify((x) => x.WriteLine("Welcome to our new Adventure!"), Times.Once);
        }
        
        [Test]
        public void that_I_can_look_around()
        {
            var ioInterfaceMock = new Mock<IOInterface>();
            ioInterfaceMock.SetupSequence(x => x.ReadLine())
                .Returns("look around")
                .Returns("quit");
            Adventure adventure = new Adventure(ioInterfaceMock.Object);
            adventure.Begin();
            ioInterfaceMock.Verify((x) => x.WriteLine(It.IsRegex("You see a pretty dirty door.*")), Times.Once);
        }
        
        [Test]
        public void that_I_can_look_at_magazines()
        {
            var ioInterfaceMock = new Mock<IOInterface>();
            ioInterfaceMock.SetupSequence(x => x.ReadLine())
                .Returns("look at magazines")
                .Returns("quit");
            Adventure adventure = new Adventure(ioInterfaceMock.Object);
            adventure.Begin();
            ioInterfaceMock.Verify((x) => x.WriteLine(It.IsRegex(".*see.*Micky Mouse magazine.*")), Times.Once);
        }    
    }
}