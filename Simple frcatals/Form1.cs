using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_frcatals
{
    public partial class FractslForm : Form
    {

        static PointF startingPoint;
        static Graphics graphics;
        static Pen blackPen;
        static Pen whitePen;
        public static int totalAmountOfIterations;
        public static int initialLeftAngle;
        public static int initialRightAngle;
        public static int lengthBetweenLines;
        static int fractalChoice;
        static double lineLengthRatio;
        static int initialLineLength;


        public static int pictureBoxHeight;
        public static int pictureBoxWidth;
        public FractslForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads all necessary info such as pens and pictureBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            whitePen = new Pen(Color.White, 2);
            blackPen = new Pen(Color.Black, 2);
            graphics = fractalPicture.CreateGraphics();
            graphics.Clear(Color.White);
            pictureBoxHeight = fractalPicture.Height;
            pictureBoxWidth = fractalPicture.Width;
            MessageBox.Show("Hello, user, take in mind that because of computer`s personal settings" +
                " different fractals might be drawing differently.So on bigger amount of iterations the program " +
                "might work incorrectly on your computer, while on mine everything works fine." + Environment.NewLine +
                "Have fun!");
        }


        /// <summary>
        /// Draws the fractal that user chose in the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawingButton_Click(object sender, EventArgs e)
        {
            startingPoint = new PointF(fractalPicture.Width / 2, fractalPicture.Height / 10 * 9);
            bool areConditionsCorrect = false;
            switch (fractalChoice)
            {
                case 1:
                    {
                        // Here the program checks all 5 parameters nedeed for the Pythigorean tree fractal.
                        if (CheckIfConditionsForDrawingFractalAreCorrect(iterationsTextBox.Text,
                                        initialLineLengthTextBox.Text, lineRatioTextBox.Text, leftAngleTextBox.Text,
                                        rightAngleTextBox.Text) == true)
                        {
                            // Parses all nedeed info for the fractal.
                            totalAmountOfIterations = int.Parse(iterationsTextBox.Text);
                            initialLineLength = int.Parse(initialLineLengthTextBox.Text);
                            lineLengthRatio = double.Parse(lineRatioTextBox.Text);
                            initialLeftAngle = int.Parse(leftAngleTextBox.Text);
                            initialRightAngle = int.Parse(rightAngleTextBox.Text);
                            areConditionsCorrect = true;
                        }
                        break;
                    }
                case 2:
                case 3:
                case 4:
                    {
                        // In these 3 cases only 1 parameter is needed - amount of iterations.
                        if (CheckIfConditionsForDrawingFractalAreCorrect(iterationsTextBox.Text) == true)
                        {
                            totalAmountOfIterations = int.Parse(iterationsTextBox.Text);
                            areConditionsCorrect = true;
                        }
                        break;
                    }
                case 5:
                    {
                        // Checks 2 pararmeters - amount of iterations and elngth between lines.
                        if (CheckIfConditionsForDrawingFractalAreCorrect(iterationsTextBox.Text, lengthBetweenLinesTextBox.Text) == true)
                        {
                            totalAmountOfIterations = int.Parse(iterationsTextBox.Text);
                            lengthBetweenLines = int.Parse(lengthBetweenLinesTextBox.Text);
                            areConditionsCorrect = true;
                        }
                        break;
                    }
            }

            if (areConditionsCorrect == true)
            {
                // If all of the info was correctly entered by user, then the progtam proceeds to drawing the fractal.
                GetCorrcetFractal(fractalPicture);
            }
        }

        /// <summary>
        /// This method defines which fractal to draw by user`s choise in the menu.
        /// </summary>
        /// <param name="fractalPicture"> integer number that changes its value from 1 to 5, ddepending on user`s choice of fractal.</param>
        static void GetCorrcetFractal(PictureBox fractalPicture)
        {
            fractalPicture.Refresh();
            switch (fractalChoice)
            {
                // PythogoreanTree fractal.
                case 1:
                    {
                        

                        PythogoreanTree pythogoreanTree = new PythogoreanTree(totalAmountOfIterations, graphics,
                            initialLeftAngle, initialRightAngle);

                        pythogoreanTree.DrawPythogoreanFractalTree(startingPoint, totalAmountOfIterations, initialLineLength,
                            initialLeftAngle, initialRightAngle, lineLengthRatio);
                        break;
                    }
                // Koch Curve fractal.
                case 2:
                    {
                        PointF leftPoint = new PointF(pictureBoxWidth / 5, pictureBoxHeight / 2);
                        PointF rightPoint = new PointF(pictureBoxWidth * 4 / 5, pictureBoxHeight / 2);
                        PointF thirdPoint = new PointF((float)((rightPoint.X + leftPoint.X) / 2), (float)(rightPoint.Y + Math.Sin(Math.PI / 3) *
                             (rightPoint.X + leftPoint.X) / 2));
                        KochCurve kochCurve = new KochCurve(totalAmountOfIterations, graphics);
                        kochCurve.DrawKochCurveFractal(leftPoint, rightPoint, thirdPoint, totalAmountOfIterations + 1);
                        break;
                    }
                // Serpinski triangle fractal.
                case 3:
                    {
                        PointF leftPoint = new PointF(pictureBoxWidth / 5, pictureBoxHeight * 9 / 10);
                        PointF rightPoint = new PointF(pictureBoxWidth * 4 / 5, pictureBoxHeight * 9 / 10);
                        PointF middlePoint = new PointF((leftPoint.X + rightPoint.X) / 2, rightPoint.Y - (float)Math.Sin(Math.PI / 3) * (rightPoint.X - leftPoint.X));
                        SerpinskiTriangle serpinskiTriangle = new SerpinskiTriangle(totalAmountOfIterations, graphics);
                        serpinskiTriangle.GetCorrectAmountOfIterations(totalAmountOfIterations);
                        serpinskiTriangle.DrawSerpinskiTriangle(totalAmountOfIterations, leftPoint, middlePoint, rightPoint);
                        break;
                    }
                //Serpinski carpet fractal.
                case 4:
                    {
                        float side = pictureBoxHeight;
                        float Xcoordinate = (pictureBoxWidth - pictureBoxWidth) / 2;
                        PointF topRightPoint = new PointF((pictureBoxWidth - pictureBoxHeight) / 2, 0);
                        SerpinskiCarpet serpinskiCarpet = new SerpinskiCarpet(graphics, totalAmountOfIterations);
                        serpinskiCarpet.DrawSerpinskiCarpet(totalAmountOfIterations, topRightPoint, side);
                        break;
                    }
                // Kantor`s set fractal.
                case 5:
                    {                       
                        PointF leftPoint = new PointF(0,5);
                        PointF rightPoint = new PointF(pictureBoxWidth, 5);
                        KantorSet kantorSet = new KantorSet(totalAmountOfIterations, graphics);
                        kantorSet.DrawKantorsSet(leftPoint, rightPoint ,totalAmountOfIterations, lengthBetweenLines);
                        break;
                    }
            }
        }

        /// <summary>
        /// Checks all 5 parameters nedeed for the Pythigorean tree fractal, that user has entered.
        /// </summary>
        /// <param name="iterationsText">iterarions text</param>
        /// <param name="initialLengthText">length of the first line text </param>
        /// <param name="lengthRatioText">length ratio text</param>
        /// <param name="leftAngleText">left angle text</param>
        /// <param name="rightAngleText">right angle text</param>
        /// <returns>true if all pararmeters are correct; false if one of parameters is wrong.</returns>
        static bool CheckIfConditionsForDrawingFractalAreCorrect(string iterationsText, string initialLengthText,
            string lengthRatioText, string leftAngleText, string rightAngleText)
        {
            if (int.TryParse(iterationsText, out int iterations) && iterations > 0 && iterations <= 15)
            {
                if (int.TryParse(initialLengthText, out int length) && length > 0)
                {
                    if (double.TryParse(lengthRatioText, out double ratio) && ratio <= 1 && ratio > 0)
                    {
                        if (int.TryParse(leftAngleText, out int leftAngle) && leftAngle > 0 && leftAngle < 180)
                        {
                            if (int.TryParse(rightAngleText, out int rightAngle) && rightAngle > 0 && rightAngle < 180)
                            {
                                return true;
                            }
                            else
                                MessageBox.Show("Angle value must be in range from 1 to 179");
                        }
                        else
                            MessageBox.Show("Angle value must be in range from 1 to 179");
                    }
                    else
                        MessageBox.Show("Line ratio must be a double number in range from 0 to 1 (excluding 0)");
                }
                else
                    MessageBox.Show("Length must be an integer number > 0");
            }
            else
                MessageBox.Show("Amount of iterations must be an int number in range from 1 to 15");
            return false;
        }

        /// <summary>
        /// Checks 1 pararmeters - amount of iterations.
        /// </summary>
        /// <param name="iterationsText">iterarions text</param>
        /// <returns>true if all pararmeters are correct; false if one of parameters is wrong.</returns>
        static bool CheckIfConditionsForDrawingFractalAreCorrect(string iterationsText)
        {
            if (int.TryParse(iterationsText, out int iterations) && iterations >= 1 && iterations <= 12)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Amount of iterations must be an int number in range from 1 to 12");
                return false;
            }
        }

        /// <summary>
        /// Checks 1 pararmeters - amount of iterations and length between lines.
        /// </summary>
        /// <param name="iterationsText">iterarions text</param>
        /// <param name="lengthBetweenLinesText">length between lines text</param>
        /// <returns>true if all pararmeters are correct; false if one of parameters is wrong.</returns>
        static bool CheckIfConditionsForDrawingFractalAreCorrect(string iterationsText, string lengthBetweenLinesText)
        {
            if (int.TryParse(iterationsText, out int iterations) && iterations >= 1 && iterations <= 10)
            {
                if (int.TryParse(lengthBetweenLinesText, out int length) && length <= 50 && length >= 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("length between lines must be an integer number in range from 0 to 50");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Amount of iterations must be an int number in range from 1 to 10");
                return false;
            }
        }

        /// <summary>
        /// Returns user to the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = false;
            }
            // Makes all of the contros invisible.


            choosePythogoreanTreeButton.Visible = true;
            chooseKochCurveButton.Visible = true;
            chooseSerpinskiTriangleButton.Visible = true;
            chooseSerpinskiCarpetButton.Visible = true;
            chooseKantorsSetButton.Visible = true;
            menuLabel.Visible = true;
            menuButton.Visible = false;
        }


        /// <summary>
        /// Opens Pythogorean tree fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choosePythogoreanTreeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = !Controls[i].Visible;
            }
            // Makes all of the contros invisible.

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
            // Clears all the text values in text boxes that user printed there for other fractals.
            lengthBetweenLinesTextBox.Visible = false;
            lengthBetweenLinesLabel.Visible = false;

            fractalChoice = 1;
        }


        /// <summary>
        /// Opens Koch curve.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseKochCurveButton_Click(object sender, EventArgs e)
        {
            drawingButton.Visible = true;
            fractalPicture.Visible = true;
            menuButton.Visible = true;
            iterationsLabel.Visible = true;
            iterationsTextBox.Visible = true;
            helpButton.Visible = true;

            iterationsTextBox.Text = "";
            menuLabel.Visible = false;
            choosePythogoreanTreeButton.Visible = false;
            chooseKochCurveButton.Visible = false;
            chooseSerpinskiCarpetButton.Visible = false;
            chooseSerpinskiTriangleButton.Visible = false;
            chooseKantorsSetButton.Visible = false;
            fractalChoice = 2;

            // Clears all the text values in text boxes that user printed there for other fractals.
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseSerpinskiTriangleButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = false;
            }
            // Makes all of the contros invisible.

            iterationsTextBox.Text = "";
            drawingButton.Visible = true;
            fractalPicture.Visible = true;
            menuButton.Visible = true;
            iterationsLabel.Visible = true;
            iterationsTextBox.Visible = true;
            helpButton.Visible = true;

            fractalChoice = 3;
        }

        /// <summary>
        /// Opens Serpinski carpet fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseSerpinskiCarpetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = false;
            }
            // Makes all of the contros invisible.

            helpButton.Visible = true;
            iterationsTextBox.Text = "";
            drawingButton.Visible = true;
            fractalPicture.Visible = true;
            menuButton.Visible = true;
            iterationsLabel.Visible = true;
            iterationsTextBox.Visible = true;


            fractalChoice = 4;
        }


        private void chooseKantorsSet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = false;
            }
            // Makes all of the contros invisible.

            iterationsTextBox.Text = "";
            menuButton.Visible = true;
            helpButton.Visible = true;
            drawingButton.Visible = true;
            iterationsLabel.Visible = true;
            iterationsTextBox.Visible = true;
            fractalPicture.Visible = true;
            lengthBetweenLinesLabel.Visible = true;
            lengthBetweenLinesTextBox.Visible = true;

            fractalChoice = 5;
        }

        /// <summary>
        /// A helpful information pops up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are different parameters for the fractals, that you must fill."
                + Environment.NewLine + "For every parameter recommended input will be written" +
                "next to it in []." + Environment.NewLine + 
                "1)COMMON parameters: " + Environment.NewLine +
                "-amount of iterations - necessary for all of fratalcs - defines how much time the " +
                "recursion will work.[1 <= input <= 10]" + Environment.NewLine +
                "2)PARAMETERS FOR PYTHOGOREAN TREE:" + Environment.NewLine +
                "-length of the first line (in pixels)[80 <= input <= 130]" + Environment.NewLine +
                "-ratio of line lengths - defines how many times more is the next lline," +
                " compared to the previous. [0,7]" + Environment.NewLine +
                "-left/right angle - defines angle between the vector of the previous" +
                " line and the vector of the next line.[0 <= input <= 179]" + Environment.NewLine + 
                "3)PARAMETER FOR KANTOR`S SET:" + Environment.NewLine +
                "-length between the lines - defines how many pixels should be between iterations.[30]");
        }
    }
}
