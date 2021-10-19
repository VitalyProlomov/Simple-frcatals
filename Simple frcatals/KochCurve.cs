using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple_frcatals
{
    /// <summary>
    /// Class that holds all necessary info and a method for drawing for Koch curve fractal
    /// </summary>
    class KochCurve : AbstractFractal
    {
        public int totalAmountOfIterations;
        public Graphics graphics;

        // Gets amount if iteration, that user printed and the graphics field, where to work.
        public KochCurve(int iterations, Graphics gr)
        {
            this.totalAmountOfIterations = iterations;
            this.graphics = gr;
        }


        /// <summary>
        /// Draws the Koch curve fractal using recursion.
        /// </summary>
        /// <param name="leftPoint">left point of the straight line that is going to be transformed into curve</param>
        /// <param name="rightPoint">right point of the straight line that is going to be transformed into curve</param>
        /// <param name="thirdPointOfEquilateralTriangle"> point that creates an equilateral triangle with previous two (the upper point)</param>
        /// <param name="iterationsLeft">amount of iterations left to do</param>
        public void DrawKochCurveFractal(PointF leftPoint, PointF rightPoint, PointF thirdPointOfEquilateralTriangle, int iterationsLeft)
        {

            if (iterationsLeft == totalAmountOfIterations + 1)
            {
                graphics.Clear(Color.White);
                graphics.DrawLine(blackPen, leftPoint, rightPoint);
                DrawKochCurveFractal(leftPoint, rightPoint, thirdPointOfEquilateralTriangle, iterationsLeft - 1);

            }
            else if (iterationsLeft >= 1)
            {

                PointF firstBreakPoint = new PointF((rightPoint.X + 2 * leftPoint.X) / 3, (rightPoint.Y + 2 * leftPoint.Y) / 3);
                PointF secondBreakPoint = new PointF((2 * rightPoint.X + leftPoint.X) / 3, (2 * rightPoint.Y + leftPoint.Y) / 3);
                PointF MiddlePoint = new PointF((rightPoint.X + leftPoint.X) / 2, (rightPoint.Y + leftPoint.Y) / 2);
                PointF connectionPoint = new PointF((4 * MiddlePoint.X - thirdPointOfEquilateralTriangle.X) / 3, (4 * MiddlePoint.Y - thirdPointOfEquilateralTriangle.Y) / 3);
                // Ending point of the lines that will create the curve of the current iteration.
                graphics.DrawLine(blackPen, firstBreakPoint, connectionPoint);
                graphics.DrawLine(blackPen, secondBreakPoint, connectionPoint);
                graphics.DrawLine(whitePen, firstBreakPoint, secondBreakPoint);

                DrawKochCurveFractal(firstBreakPoint, connectionPoint, secondBreakPoint, iterationsLeft - 1);
                DrawKochCurveFractal(connectionPoint, secondBreakPoint, firstBreakPoint, iterationsLeft - 1);
                // Recursion.
                DrawKochCurveFractal(leftPoint, firstBreakPoint, new PointF((2 * leftPoint.X + thirdPointOfEquilateralTriangle.X) / 3, (2 * leftPoint.Y + thirdPointOfEquilateralTriangle.Y) / 3), iterationsLeft - 1);
                DrawKochCurveFractal(secondBreakPoint, rightPoint, new PointF((2 * rightPoint.X + thirdPointOfEquilateralTriangle.X) / 3, (2 * rightPoint.Y + thirdPointOfEquilateralTriangle.Y) / 3), iterationsLeft - 1);
                // Recursion.
            }
        }
        public override void GetCorrectAmountOfIterations(int iterations)
        {
            totalAmountOfIterations = iterations;
        }
    }
}

