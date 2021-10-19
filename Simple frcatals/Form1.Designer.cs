namespace Simple_frcatals
{
    partial class FractslForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fractalPicture = new System.Windows.Forms.PictureBox();
            this.drawingButton = new System.Windows.Forms.Button();
            this.choosePythogoreanTreeButton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.initialLineLengthLabel = new System.Windows.Forms.Label();
            this.initialLineLengthTextBox = new System.Windows.Forms.TextBox();
            this.lineRatioTextBox = new System.Windows.Forms.TextBox();
            this.linesRatioLabel = new System.Windows.Forms.Label();
            this.leftAngleLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.leftAngleTextBox = new System.Windows.Forms.TextBox();
            this.rightAngleLabel = new System.Windows.Forms.Label();
            this.rightAngleTextBox = new System.Windows.Forms.TextBox();
            this.chooseKochCurveButton = new System.Windows.Forms.Button();
            this.chooseSerpinskiTriangleButton = new System.Windows.Forms.Button();
            this.chooseSerpinskiCarpetButton = new System.Windows.Forms.Button();
            this.chooseKantorsSetButton = new System.Windows.Forms.Button();
            this.lengthBetweenLinesLabel = new System.Windows.Forms.Label();
            this.lengthBetweenLinesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalPicture
            // 
            this.fractalPicture.Location = new System.Drawing.Point(96, 2);
            this.fractalPicture.Name = "fractalPicture";
            this.fractalPicture.Size = new System.Drawing.Size(895, 525);
            this.fractalPicture.TabIndex = 0;
            this.fractalPicture.TabStop = false;
            this.fractalPicture.Visible = false;

            // 
            // drawingButton
            // 
            this.drawingButton.Location = new System.Drawing.Point(432, 556);
            this.drawingButton.Name = "drawingButton";
            this.drawingButton.Size = new System.Drawing.Size(117, 56);
            this.drawingButton.TabIndex = 1;
            this.drawingButton.Text = "draw fractal";
            this.drawingButton.UseVisualStyleBackColor = true;
            this.drawingButton.Visible = false;
            this.drawingButton.Click += new System.EventHandler(this.drawingButton_Click);
            // 
            // choosePythogoreanTreeButton
            // 
            this.choosePythogoreanTreeButton.Location = new System.Drawing.Point(40, 307);
            this.choosePythogoreanTreeButton.Name = "choosePythogoreanTreeButton";
            this.choosePythogoreanTreeButton.Size = new System.Drawing.Size(119, 59);
            this.choosePythogoreanTreeButton.TabIndex = 2;
            this.choosePythogoreanTreeButton.Text = "Pythogorean tree";
            this.choosePythogoreanTreeButton.UseVisualStyleBackColor = true;
            this.choosePythogoreanTreeButton.Click += new System.EventHandler(this.choosePythogoreanTreeButton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(316, 147);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(318, 40);
            this.menuLabel.TabIndex = 3;
            this.menuLabel.Text = "Choose one of 5 fractals that you want to draw\r\nand press the button of the confo" +
    "rming fractal\r\n";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(183, 533);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(44, 27);
            this.iterationsTextBox.TabIndex = 4;
            this.iterationsTextBox.Visible = false;
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(30, 536);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(147, 20);
            this.iterationsLabel.TabIndex = 5;
            this.iterationsLabel.Text = "amount of iterations:";
            this.iterationsLabel.Visible = false;
            // 
            // initialLineLengthLabel
            // 
            this.initialLineLengthLabel.AutoSize = true;
            this.initialLineLengthLabel.Location = new System.Drawing.Point(30, 571);
            this.initialLineLengthLabel.Name = "initialLineLengthLabel";
            this.initialLineLengthLabel.Size = new System.Drawing.Size(129, 20);
            this.initialLineLengthLabel.TabIndex = 6;
            this.initialLineLengthLabel.Text = "length of first line:";
            this.initialLineLengthLabel.Visible = false;
            // 
            // initialLineLengthTextBox
            // 
            this.initialLineLengthTextBox.Location = new System.Drawing.Point(183, 568);
            this.initialLineLengthTextBox.Name = "initialLineLengthTextBox";
            this.initialLineLengthTextBox.Size = new System.Drawing.Size(44, 27);
            this.initialLineLengthTextBox.TabIndex = 7;
            this.initialLineLengthTextBox.Visible = false;
            // 
            // lineRatioTextBox
            // 
            this.lineRatioTextBox.Location = new System.Drawing.Point(183, 604);
            this.lineRatioTextBox.Name = "lineRatioTextBox";
            this.lineRatioTextBox.Size = new System.Drawing.Size(44, 27);
            this.lineRatioTextBox.TabIndex = 8;
            this.lineRatioTextBox.Visible = false;
            // 
            // linesRatioLabel
            // 
            this.linesRatioLabel.AutoSize = true;
            this.linesRatioLabel.Location = new System.Drawing.Point(30, 607);
            this.linesRatioLabel.Name = "linesRatioLabel";
            this.linesRatioLabel.Size = new System.Drawing.Size(141, 20);
            this.linesRatioLabel.TabIndex = 9;
            this.linesRatioLabel.Text = "ratio of line lengths:";
            this.linesRatioLabel.Visible = false;
            // 
            // leftAngleLabel
            // 
            this.leftAngleLabel.AutoSize = true;
            this.leftAngleLabel.Location = new System.Drawing.Point(677, 540);
            this.leftAngleLabel.Name = "leftAngleLabel";
            this.leftAngleLabel.Size = new System.Drawing.Size(158, 20);
            this.leftAngleLabel.TabIndex = 10;
            this.leftAngleLabel.Text = "left angle (in degrees):";
            this.leftAngleLabel.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(23, 22);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(67, 36);
            this.menuButton.TabIndex = 11;
            this.menuButton.Text = "menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(23, 78);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(67, 47);
            this.helpButton.TabIndex = 12;
            this.helpButton.Text = "help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Visible = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // leftAngleTextBox
            // 
            this.leftAngleTextBox.Location = new System.Drawing.Point(851, 537);
            this.leftAngleTextBox.Name = "leftAngleTextBox";
            this.leftAngleTextBox.Size = new System.Drawing.Size(48, 27);
            this.leftAngleTextBox.TabIndex = 13;
            this.leftAngleTextBox.Visible = false;
            // 
            // rightAngleLabel
            // 
            this.rightAngleLabel.AutoSize = true;
            this.rightAngleLabel.Location = new System.Drawing.Point(677, 582);
            this.rightAngleLabel.Name = "rightAngleLabel";
            this.rightAngleLabel.Size = new System.Drawing.Size(167, 20);
            this.rightAngleLabel.TabIndex = 14;
            this.rightAngleLabel.Text = "right angle (in degrees):";
            this.rightAngleLabel.Visible = false;
            // 
            // rightAngleTextBox
            // 
            this.rightAngleTextBox.Location = new System.Drawing.Point(851, 579);
            this.rightAngleTextBox.Name = "rightAngleTextBox";
            this.rightAngleTextBox.Size = new System.Drawing.Size(48, 27);
            this.rightAngleTextBox.TabIndex = 15;
            this.rightAngleTextBox.Visible = false;
            // 
            // chooseKochCurveButton
            // 
            this.chooseKochCurveButton.Location = new System.Drawing.Point(237, 307);
            this.chooseKochCurveButton.Name = "chooseKochCurveButton";
            this.chooseKochCurveButton.Size = new System.Drawing.Size(119, 59);
            this.chooseKochCurveButton.TabIndex = 16;
            this.chooseKochCurveButton.Text = "Koch curve";
            this.chooseKochCurveButton.UseVisualStyleBackColor = true;
            this.chooseKochCurveButton.Click += new System.EventHandler(this.chooseKochCurveButton_Click);
            // 
            // chooseSerpinskiTriangleButton
            // 
            this.chooseSerpinskiTriangleButton.Location = new System.Drawing.Point(658, 307);
            this.chooseSerpinskiTriangleButton.Name = "chooseSerpinskiTriangleButton";
            this.chooseSerpinskiTriangleButton.Size = new System.Drawing.Size(119, 59);
            this.chooseSerpinskiTriangleButton.TabIndex = 17;
            this.chooseSerpinskiTriangleButton.Text = "Serpinski triangle";
            this.chooseSerpinskiTriangleButton.UseVisualStyleBackColor = true;
            this.chooseSerpinskiTriangleButton.Click += new System.EventHandler(this.chooseSerpinskiTriangleButton_Click);
            // 
            // chooseSerpinskiCarpetButton
            // 
            this.chooseSerpinskiCarpetButton.Location = new System.Drawing.Point(454, 307);
            this.chooseSerpinskiCarpetButton.Name = "chooseSerpinskiCarpetButton";
            this.chooseSerpinskiCarpetButton.Size = new System.Drawing.Size(119, 59);
            this.chooseSerpinskiCarpetButton.TabIndex = 18;
            this.chooseSerpinskiCarpetButton.Text = "Serpinski carpet";
            this.chooseSerpinskiCarpetButton.UseVisualStyleBackColor = true;
            this.chooseSerpinskiCarpetButton.Click += new System.EventHandler(this.chooseSerpinskiCarpetButton_Click);
            // 
            // chooseKantorsSetButton
            // 
            this.chooseKantorsSetButton.Location = new System.Drawing.Point(842, 307);
            this.chooseKantorsSetButton.Name = "chooseKantorsSetButton";
            this.chooseKantorsSetButton.Size = new System.Drawing.Size(119, 59);
            this.chooseKantorsSetButton.TabIndex = 19;
            this.chooseKantorsSetButton.Text = "Kantor`s set";
            this.chooseKantorsSetButton.UseVisualStyleBackColor = true;
            this.chooseKantorsSetButton.Click += new System.EventHandler(this.chooseKantorsSet_Click);
            // 
            // lengthBetweenLinesLabel
            // 
            this.lengthBetweenLinesLabel.AutoSize = true;
            this.lengthBetweenLinesLabel.Location = new System.Drawing.Point(30, 571);
            this.lengthBetweenLinesLabel.Name = "lengthBetweenLinesLabel";
            this.lengthBetweenLinesLabel.Size = new System.Drawing.Size(149, 20);
            this.lengthBetweenLinesLabel.TabIndex = 20;
            this.lengthBetweenLinesLabel.Text = "length between lines:";
            this.lengthBetweenLinesLabel.Visible = false;
            // 
            // lengthBetweenLinesTextBox
            // 
            this.lengthBetweenLinesTextBox.Location = new System.Drawing.Point(183, 568);
            this.lengthBetweenLinesTextBox.Name = "lengthBetweenLinesTextBox";
            this.lengthBetweenLinesTextBox.Size = new System.Drawing.Size(44, 27);
            this.lengthBetweenLinesTextBox.TabIndex = 21;
            this.lengthBetweenLinesTextBox.Visible = false;
            // 
            // FractslForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 646);
            this.Controls.Add(this.lengthBetweenLinesLabel);
            this.Controls.Add(this.lengthBetweenLinesTextBox);
            this.Controls.Add(this.chooseKantorsSetButton);
            this.Controls.Add(this.chooseSerpinskiCarpetButton);
            this.Controls.Add(this.chooseSerpinskiTriangleButton);
            this.Controls.Add(this.drawingButton);
            this.Controls.Add(this.chooseKochCurveButton);
            this.Controls.Add(this.rightAngleTextBox);
            this.Controls.Add(this.rightAngleLabel);
            this.Controls.Add(this.leftAngleTextBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.leftAngleLabel);
            this.Controls.Add(this.linesRatioLabel);
            this.Controls.Add(this.lineRatioTextBox);
            this.Controls.Add(this.initialLineLengthTextBox);
            this.Controls.Add(this.initialLineLengthLabel);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.choosePythogoreanTreeButton);
            this.Controls.Add(this.fractalPicture);
            this.MinimumSize = new System.Drawing.Size(1021, 693);
            this.Name = "FractslForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fractalPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox fractalPicture;
        private System.Windows.Forms.Button drawingButton;
        private System.Windows.Forms.Button choosePythogoreanTreeButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label initialLineLengthLabel;
        private System.Windows.Forms.TextBox initialLineLengthTextBox;
        private System.Windows.Forms.TextBox lineRatioTextBox;
        private System.Windows.Forms.Label linesRatioLabel;
        private System.Windows.Forms.Label leftAngleLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TextBox leftAngleTextBox;
        private System.Windows.Forms.Label rightAngleLabel;
        private System.Windows.Forms.TextBox rightAngleTextBox;
        private System.Windows.Forms.Button chooseKochCurveButton;
        private System.Windows.Forms.Button chooseSerpinskiTriangleButton;
        private System.Windows.Forms.Button chooseSerpinskiCarpetButton;
        private System.Windows.Forms.Button chooseKantorsSetButton;
        private System.Windows.Forms.Label lengthBetweenLinesLabel;
        private System.Windows.Forms.TextBox lengthBetweenLinesTextBox;
    }
}

