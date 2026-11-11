using CsdTextAdventure;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1
{
    public class TimeServiceTest
    {
        [Test]
        public void current_time_looks_good()
        {
            TimeService.CurrentTime("Europe/Berlin").Should().BeGreaterThan(-1L);
        }
    }
}
