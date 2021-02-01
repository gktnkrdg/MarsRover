using MarsRover.Core;
using System;
using Xunit;

namespace MarsRover.Test
{
    public class PlateauTest
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(4, 5)]
        [InlineData(3, 1)]
        [InlineData(5, 6)]
        public void CreatePlateau_ValidWidthHeight_Success(int width, int height)
        {

            Plateau plateau = new Plateau(width, height);

            Assert.Equal(height, plateau.Height);
            Assert.Equal(width, plateau.Width);
        }

        [Theory]
        [InlineData(0,1)]
        [InlineData(5,0)]
        [InlineData(0,0)]
        public void CreatePlateau_WrongWidthHeight_ThrowArgumentException(int width,int height)
        {
            Action act = () => new Plateau(width, height);

            Assert.Throws<ArgumentException>(act);
        }
    }
}
