using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizMaster
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        // Store the original positions of the PictureBoxes
        Point[] positions;

        public Form1()
        {
            InitializeComponent();

            // Save the original positions
            positions = new Point[]
            {
                pcbTriangle.Location,
                pcbDiamond.Location,
                pcbCircle.Location,
                pcbCube.Location
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ShufflePictureBoxes()
        {
            PictureBox[] boxes =
            {
                pcbTriangle,
                pcbDiamond,
                pcbCircle,
                pcbCube
            };

            // Shuffle the positions
            Point[] shuffledPositions = positions
                .OrderBy(x => random.Next())
                .ToArray();

            // Give each PictureBox a new position
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].Location = shuffledPositions[i];
            }
        }
    }
}