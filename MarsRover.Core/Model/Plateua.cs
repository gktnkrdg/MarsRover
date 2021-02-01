using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core
{
    public class Plateau
    {
            
        public int Width { get; }
        public int Height { get; }
        

        public Plateau(int width, int height)
        {
            if (!IsValidSize(width, height))
            {
                throw new ArgumentException("Width height must greater than zero");
            } 
            Width = width;
            Height = height;
        }

        private bool IsValidSize(int width,int height)
        {
            if (width > 0 && height > 0)
                return true;
            return false;
        }
        





    }
}
