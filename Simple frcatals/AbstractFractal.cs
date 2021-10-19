using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple_frcatals
{
    /// <summary>
    /// Abstract class that contians common methods and fields for all fractals.
    /// </summary>
    abstract class AbstractFractal
    {
        public static Pen blackPen = new Pen(Color.Black, 2);
        public static Pen thinBlackPen = new Pen(Color.Black);
        // Used in Serpinski triangle for better detailnig.

        public static Pen whitePen = new Pen(Color.White, 2);
        
        public static Pen extraThickBlackPen = new Pen(Color.Black, 10);
        // Thick pen is used in Kantor`s set.
        
        public static int totalAmountOfIterations;
        // Amount of iterations, printeed by user.


        public abstract void GetCorrectAmountOfIterations(int iterations);

    }
}
