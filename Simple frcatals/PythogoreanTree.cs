using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple_frcatals
{
    /// <summary>
    /// Class that contains all the info needed to draw the PythegoreanTree fractal.
    /// Also it contains the method that actually draws this fractal.
    /// </summary>
    class PythogoreanTree : AbstractFractal
    {

        // Gets amount if iteration, that user printed and the graphics field, where to work.
        // Also gets values of angles (those, which will not be chabged during the program).
        public PythogoreanTree(int iterations, Graphics gr ,int leftAngle, int rightAngle)
        {
            totalAmountOfIterations = iterations;
            graphics = gr;
            initialLeftAngle = leftAngle;
            initialRightAngle = rightAngle;
        }

        Graphics graphics;
        public int initialLeftAngle;
        public int initialRightAngle;

        /// <summary>
        /// Draws the Pythogorean tree fractal using recursion.
        /// </summary>
        /// <param name="startingPoint"> starting point of drawing next iteration </param>
        /// <param name="iterationsLeft"> amount of iterations left to do</param>
        /// <param name="initialLength"> length of the first line segment</param>
        /// <param name="currentLeftAngle"> current angle (angle between vector of the current left line and the horizontal line)</param>
        /// <param name="currentRightAngle">current angle (angle between vector of the current right line and the horizontal line)</param>
        /// <param name="lengthRatio">ratio of the line segment in iteration to the line segment in next iteration </param>
        public void DrawPythogoreanFractalTree(PointF startingPoint, int iterationsLeft,
            double initialLength, int currentLeftAngle, int currentRightAngle, double lengthRatio)
        {
            if (iterationsLeft == totalAmountOfIterations)
            {
                PointF endingPoint = new PointF(startingPoint.X, (float)(startingPoint.Y - initialLength));
                // Point right above the starting point.
                graphics.DrawLine(blackPen, startingPoint, endingPoint);
                DrawPythogoreanFractalTree(endingPoint, iterationsLeft - 1,
                    initialLength, currentLeftAngle, currentRightAngle, lengthRatio);
            }
            else if (iterationsLeft >= 1)
            {
                double newLength = lengthRatio * initialLength;
                double Xcoordinate = startingPoint.X - newLength * Math.Sin(currentLeftAngle * Math.PI / 180);
                double Ycoordinate = startingPoint.Y - newLength * Math.Cos(currentLeftAngle * Math.PI / 180);
                // Coordinates of the ending point of the current left line.

                PointF newLeftPoint = new PointF((float)Xcoordinate, (float)Ycoordinate);
                graphics.DrawLine(blackPen, startingPoint, newLeftPoint);

                Xcoordinate = startingPoint.X + newLength * Math.Sin(currentRightAngle * Math.PI / 180);
                Ycoordinate = startingPoint.Y - newLength * Math.Cos(currentRightAngle * Math.PI / 180);
                // Coordinates of the ending point of the current right line.
                PointF newRightPoint = new PointF((float)Xcoordinate, (float)Ycoordinate);
                graphics.DrawLine(blackPen, startingPoint, newRightPoint);
                DrawPythogoreanFractalTree(newLeftPoint, iterationsLeft - 1, newLength, currentLeftAngle + initialLeftAngle,
                    currentRightAngle - initialLeftAngle, lengthRatio);
                DrawPythogoreanFractalTree(newRightPoint, iterationsLeft - 1, newLength, currentLeftAngle - initialRightAngle,
                    currentRightAngle + initialRightAngle, lengthRatio);
            }

        }
        public override void GetCorrectAmountOfIterations(int iterations)
        {
            totalAmountOfIterations = iterations;
        }
    }
}
