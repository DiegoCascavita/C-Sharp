using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphExample {
    public partial class Form1 : Form {
        private readonly int[] data = { 20, 40, 30, 50, 10 }; // Sample data for the graph

        public Form1() {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue);
            int width = this.ClientSize.Width / data.Length;

            for (int i = 0; i < data.Length; i++) {
                int height = (data[i] * this.ClientSize.Height) / data.Max();
                g.DrawLine(pen, i * width, this.ClientSize.Height, i * width, this.ClientSize.Height - height);
            }
        }
    }

    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
