using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetris_game_MHERLEIN
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Brush bloque = new SolidBrush(Color.LightBlue);
        Brush fondo = new SolidBrush(Color.Black);
        int bloqueX = 50;
        int bloqueY = 0;
        //Rectangle rectangle1 = new Rectangle(50, 0, 50, 50);   
        Keys teclaPresionada;
        bool teclaNueva;
        //int[,] cuadricula = new int[,] { { 0, 0 }, { 0, 51 }, { 0, 102 },
        //                                 { 51, 0 }, { 51, 51 }, { 51, 102 }};


        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            teclaPresionada = e.KeyCode;
            teclaNueva = true;
            System.Console.WriteLine(e.KeyCode);
        }

        public void Process()
        {          
                if (teclaNueva == true)
                {
                if (teclaPresionada == Keys.D)
                    {
                        bloqueX += 50;
                    }
                    if (teclaPresionada == Keys.A)
                    {
                        bloqueX -= 50;
                    }
                }
            if (bloqueY >= 0 && bloqueY <= 205)
            {
                bloqueY += 5;
            }
            
                
                teclaNueva = false;                
            }          
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process();
            Render();
        }
        private void Render()
        {
            graphics.FillRectangle(fondo, 0, 0, this.Width, this.Height);
            graphics.FillRectangle(bloque, bloqueX, bloqueY, 50, 50);
        }


    }
}
