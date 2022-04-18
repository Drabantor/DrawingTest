
namespace DrawingTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            //***Dirt and House using retangles***

            Graphics g = e.Graphics; //create a Graphics object

            Pen myDrawingPen = new Pen(Color.White); //create a pen object
            Brush myDrawingBrush = new SolidBrush(Color.Brown); //create a brush object

            g.FillRectangle(myDrawingBrush, 0, 760, 1425, 50);
            g.DrawRectangle(myDrawingPen, 620, 510, 250, 250);


            //***Draw a Bezier curve***

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points for curve.
            Point start = new Point(100, 100);
            Point control1 = new Point(200, 10);
            Point control2 = new Point(350, 50);
            Point end = new Point(500, 100);

            // Draw arc to screen.
            e.Graphics.DrawBezier(blackPen, start, control1, control2, end);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}