using System.Drawing;

namespace TestCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testing_RotateMethod()
        {

            Compass myCompass = new Compass();
            Point compassPosition = myCompass.Rotate(Point.NORTH, Direction.RIGHT);

            compassPosition.ShouldBe(Point.EAST);


        }
    }
}