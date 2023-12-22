using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private Circle circle;
        private Square square;
        private Rhomb rhomb;

        public Form1()
        {
            InitializeComponent();
            circle = new Circle(10, 5, 30, this);
            square = new Square(50, 75, 40, this);
            rhomb = new Rhomb(100, 150, 80, 100, this);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            square.MoveRight();
        }

        private void RhombButton_Click(object sender, EventArgs e)
        {
            rhomb.MoveRight();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            circle.MoveRight();
        }
    }
}
