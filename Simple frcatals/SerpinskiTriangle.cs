using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple_frcatals
{
    class SerpinskiTriangle : AbstractFractal
    {
        //public static int totalAmountOfIterations;
        public Graphics graphics;


        // Gets amount if iteration, that user printed and the graphics field, where to work.
        public SerpinskiTriangle(int iterations, Graphics graphics)
        {
            totalAmountOfIterations = iterations;
            this.graphics = graphics;
        }

        
        public override void GetCorrectAmountOfIterations(int iterations)
        {
            AbstractFractal.totalAmountOfIterations = iterations;
        }


        /// <summary>
        /// /\/// <summary>
        /// Draws the Serpinski triangle fractal using recursion.
        /// <param name="iterationsLeft">amount of iterations left to do</param>
        /// <param name="leftPoint"> left point of the traingle</param>
        /// <param name="middlePoint">middle point of the traingle</param>
        /// <param name="rightPoint">right popint of the traingle</param>
        public void DrawSerpinskiTriangle(int iterationsLeft, PointF leftPoint,
             PointF middlePoint, PointF rightPoint)
        {
            if (totalAmountOfIterations == iterationsLeft)
            {
                graphics.DrawLine(thinBlackPen, leftPoint, rightPoint);
                graphics.DrawLine(thinBlackPen, leftPoint, middlePoint);
                graphics.DrawLine(thinBlackPen, rightPoint, middlePoint);
                PointF firstBreakPoint = new PointF((middlePoint.X + leftPoint.X) / 2,
                    (middlePoint.Y + leftPoint.Y) / 2);
                PointF secondBreakPoint = new PointF((rightPoint.X + middlePoint.X) / 2,
                    (rightPoint.Y + middlePoint.Y) / 2);
                PointF thirdBreakPoint = new PointF((leftPoint.X + rightPoint.X) / 2,
                    (leftPoint.Y + rightPoint.Y) / 2);
                // Three points located in the middle points of three line segments, that are created by three points given as parameters. 
                DrawSerpinskiTriangle(iterationsLeft - 1, leftPoint, firstBreakPoint, thirdBreakPoint);
                DrawSerpinskiTriangle(iterationsLeft - 1, firstBreakPoint, middlePoint, secondBreakPoint);
                DrawSerpinskiTriangle(iterationsLeft - 1, thirdBreakPoint, secondBreakPoint, rightPoint);
            }
            else if (iterationsLeft >= 1)
            {
                graphics.DrawLine(thinBlackPen, leftPoint, rightPoint);
                graphics.DrawLine(thinBlackPen, leftPoint, (PointF)middlePoint);
                graphics.DrawLine(thinBlackPen, rightPoint, (PointF)middlePoint);

                PointF firstBreakPoint = new PointF((middlePoint.X + leftPoint.X) / 2,
                    (middlePoint.Y + leftPoint.Y) / 2);
                PointF secondBreakPoint = new PointF((rightPoint.X + middlePoint.X) / 2,
                    (rightPoint.Y + middlePoint.Y) / 2);
                PointF thirdBreakPoint = new PointF((leftPoint.X + rightPoint.X) / 2,
                    (leftPoint.Y + rightPoint.Y) / 2);
                // Three points located in the middle points of three line segments, that are created by three points given as parameters. 
                DrawSerpinskiTriangle(iterationsLeft - 1, leftPoint, firstBreakPoint, thirdBreakPoint);
                DrawSerpinskiTriangle(iterationsLeft - 1, firstBreakPoint, middlePoint, secondBreakPoint);
                DrawSerpinskiTriangle(iterationsLeft - 1, thirdBreakPoint, secondBreakPoint, rightPoint);
            }
        }

    }
}
