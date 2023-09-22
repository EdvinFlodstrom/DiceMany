using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureShapes
{
    public partial class PictureForm : Form
    {
        private Dice[] dice = new Dice[5];        
        

        public PictureForm()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dice = new Dice();
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Dice();
                dice[i].Size = 15;
                dice[i].XPosition = i * dice[i].Size * 7 + 20;
                dice[i].MakeDice();
            }
            
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            canvas.Clear();
            //dice.Roll();
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();                
            }
        }
    }
}
