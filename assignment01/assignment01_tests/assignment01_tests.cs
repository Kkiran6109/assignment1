using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment01;
using NUnit.Framework;

namespace assignment01_tests
{
    [TestFixture]
    class assignment01_tests
    {
        [Test]
        public void GetLength_input3_expectLengthEquals3()
        {
            //arrage
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int length = testRectangle.GetLength();

            //assert
            Assert.AreEqual(length, l);
        }

        [Test]
        public void SetLength_input6_expectLengthEquals6()
        {
            //arrage
            int l = 6;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int length = testRectangle.SetLength(6);

            //assert
            Assert.AreEqual(length, l);
        }

        [Test]
        public void GetWidth_input5_expectWidthEquals5()
        {
            //arrage
            int l = 1;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int width = testRectangle.GetWidth();

            //assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void SetWidth_input9_expectWidthEquals9()
        {
            //arrage
            int l = 6;
            int w = 9;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int width = testRectangle.SetWidth(9);

            //assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void GetArea_input8and4_Returns32()
        {
            //Arrange
            int length = 8;
            int width = 4;
            int expectedResult = length * width;
            Rectangle testRectangle = new Rectangle(length, width);
            //Act
            int actualResult = testRectangle.GetArea();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetParimeter_input5and3_Returns16()
        {
            //Arrange
            int length = 5;
            int width = 3;
            int expectedResult = (length * 2) + (width * 2);
            Rectangle testRectangle = new Rectangle(length, width);
            //Act
            int actualResult = testRectangle.GetPerimeter();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
