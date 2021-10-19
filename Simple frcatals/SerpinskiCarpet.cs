using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple_frcatals
{
    class SerpinskiCarpet : AbstractFractal
    {
        static Graphics graphics;
        static Pen bluePen = new Pen(Color.Blue);


        // Gets amount if iteration, that user printed and the graphics field, where to work.
        public SerpinskiCarpet(Graphics gr, int iterations)
        {
           graphics = gr;
           totalAmountOfIterations = iterations;
        }


        /// <summary>
        /// Draws the Serpinski carpet fractal using recursion.
        /// </summary>
        /// <param name="iterationsLeft">amount of iterations left to do</param>
        /// <param name="topRightPoint"></param>
        /// <param name="side"></param>
        public void DrawSerpinskiCarpet(int iterationsLeft, PointF topRightPoint, float side)
        {            

            if (totalAmountOfIterations == iterationsLeft)
            {                
                RectangleF blueSquare = new RectangleF(topRightPoint.X, topRightPoint.Y, side, side);
                graphics.FillRectangle(bluePen.Brush, blueSquare);
                PointF newTopRightPoint = new PointF(topRightPoint.X + side / 3, topRightPoint.Y + side / 3);
                RectangleF square = new RectangleF(newTopRightPoint.X, newTopRightPoint.Y, side / 3, side / 3);
                graphics.FillRectangle(whitePen.Brush, square);

                // The next eight points are upper right points of the little squares, that are going to be used 
                // in the next iterations as the main squares.

                // All points are going to be numerated starting from top right (its number is 1), going clockwise.
                PointF secondPoint = new PointF(topRightPoint.X + side / 3, topRightPoint.Y);
                PointF thirdPoint = new PointF(secondPoint.X + side / 3, secondPoint.Y);
                PointF fourthPoint = new PointF(thirdPoint.X , thirdPoint.Y + side/3);
                PointF fifthPoint = new PointF(fourthPoint.X, fourthPoint.Y + side / 3);
                PointF sixthPoint = new PointF(fifthPoint.X - side / 3, fifthPoint.Y);
                PointF seventhPoint = new PointF(sixthPoint.X - side / 3, sixthPoint.Y);
                PointF eighthpoint = new PointF(seventhPoint.X, seventhPoint.Y - side / 3);

                // Now the recursion is going to work 8 times for each of the 8 smaller squares.
                DrawSerpinskiCarpet(iterationsLeft - 1, topRightPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, secondPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, thirdPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, fourthPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, fifthPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, sixthPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, seventhPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, eighthpoint, side / 3);
            }
            else if (iterationsLeft >=1)
            {
                PointF newTopRightPoint = new PointF(topRightPoint.X + side / 3, topRightPoint.Y + side / 3);
                RectangleF square = new RectangleF(newTopRightPoint.X, newTopRightPoint.Y, side / 3, side / 3);
                graphics.FillRectangle(whitePen.Brush, square);

                // The next eight points are upper right points of the little squares, that are going to be used 
                // in the next iterations as the main squares.

                // All points are going to be numerated starting from top right (its number is 1), going clockwise.
                PointF secondPoint = new PointF(topRightPoint.X + side / 3, topRightPoint.Y);
                PointF thirdPoint = new PointF(secondPoint.X + side / 3, secondPoint.Y);
                PointF fourthPoint = new PointF(thirdPoint.X, thirdPoint.Y + side / 3);
                PointF fifthPoint = new PointF(fourthPoint.X, fourthPoint.Y + side / 3);
                PointF sixthPoint = new PointF(fifthPoint.X - side / 3, fifthPoint.Y);
                PointF seventhPoint = new PointF(sixthPoint.X - side / 3, sixthPoint.Y);
                PointF eighthpoint = new PointF(seventhPoint.X, seventhPoint.Y - side / 3);

                // Now the recursion is going to work 8 times for each of the 8 smaller squares.
                DrawSerpinskiCarpet(iterationsLeft - 1, topRightPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, secondPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, thirdPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, fourthPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, fifthPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, sixthPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, seventhPoint, side / 3);
                DrawSerpinskiCarpet(iterationsLeft - 1, eighthpoint, side / 3);
            }
        }
        public override void GetCorrectAmountOfIterations(int iterations)
        {
            totalAmountOfIterations = iterations;
        }
    }
}
