using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple_frcatals
{
    class KantorSet : AbstractFractal
    {

        public static Graphics graphics;


        // Gets amount if iteration, that user printed and the graphics field, where to work.
        public KantorSet(int iterations, Graphics gr)
        {
            totalAmountOfIterations = iterations;
            graphics = gr;
        }


        /// <summary>
        /// Draws the Kantor`s set fractal using recursion.
        /// </summary>
        /// <param name="iterations">amount of iterations left to do</param>
        public override void GetCorrectAmountOfIterations(int iterations)
        {
            totalAmountOfIterations = iterations;
        }
        public void DrawKantorsSet(PointF leftPoint, PointF rightPoint,int iterationsLeft, float lengthBetweenLines)
        {
            if (iterationsLeft == totalAmountOfIterations)
            {
                graphics.Clear(Color.White);
                graphics.DrawLine(extraThickBlackPen,leftPoint, rightPoint);
                PointF newLeftPoint = new PointF(leftPoint.X, rightPoint.Y + lengthBetweenLines);
                PointF newRightPoint = new PointF(rightPoint.X / 3, rightPoint.Y + lengthBetweenLines);
                // Two points defining the beginning and the end of the left line of the next iteration.
                DrawKantorsSet(newLeftPoint,newRightPoint ,iterationsLeft - 1, lengthBetweenLines);
                // Recursion for these two new points.
                newLeftPoint = new PointF(rightPoint.X / 3 * 2, rightPoint.Y + lengthBetweenLines);
                newRightPoint = new PointF(rightPoint.X, rightPoint.Y + lengthBetweenLines);
                // Two points defining the beginning and the end of the right line of the next iteration.
                DrawKantorsSet(newLeftPoint , newRightPoint ,iterationsLeft - 1, lengthBetweenLines);
                // Recursion for these two new points.
            }
            else if (iterationsLeft >= 1)
            {
                graphics.DrawLine(extraThickBlackPen, leftPoint, rightPoint);
                PointF newLeftPoint = new PointF(leftPoint.X, rightPoint.Y + lengthBetweenLines);
                PointF newRightPoint = new PointF(newLeftPoint.X + (rightPoint.X - leftPoint.X) / 3, rightPoint.Y + lengthBetweenLines);
                // Two points defining the beginning and the end of the left line of the next iteration.
                DrawKantorsSet(newLeftPoint, newRightPoint, iterationsLeft - 1, lengthBetweenLines);
                // Recursion for these two new points.
                newLeftPoint = new PointF(rightPoint.X - (rightPoint.X - leftPoint.X)/3 , leftPoint.Y + lengthBetweenLines);
                newRightPoint = new PointF(rightPoint.X, rightPoint.Y + lengthBetweenLines);
                // Two points defining the beginning and the end of the right line of the next iteration.
                DrawKantorsSet(newLeftPoint, newRightPoint, iterationsLeft - 1, lengthBetweenLines);
                // Recursion for these two new points.
            }
        }

    }
}
