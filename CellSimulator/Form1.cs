using CellSimulator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellSimulator
{
    public partial class Form1 : Form
    {
        private Rectangle Fish;
        public Form1()
        {
            InitializeComponent();
            this.Name = "Aquarium";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(800, 500);
            this.Fish = new Rectangle(this.Size.Width / 2 - 25, this.Height / 2 - 25, 50, 50);
            this.Paint += PaintEvent;
            this.Click += AddEntityEvent;
            list = new List<Rectangle>();
          //  this.Cursor.
        }

        private void AddEntityEvent(object sender, EventArgs e)
        {
            this.list.Add(new Rectangle(Cursor.Position.X-this.Location.X-25, Cursor.Position.Y-this.Location.Y-50,50,50));
        }

        private void PaintEvent(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Aquamarine);

            for(int i =0;i<list.Count;i++)
            {
                if (Fish.IntersectsWith(list[i]))
                {
                    list.Remove(list[i]);
                    //return;
                }
            }

            e.Graphics.FillRectangle(new SolidBrush(Color.Black), Fish);
            try
            {
                if (Fish.X - list[0].X < 0)
                {
                    Fish.X += 1;
                }
                else
                {
                    if (Fish.X != list[0].X)
                    {
                    Fish.X -= 1;

                    }
                }


                if (Fish.Y - list[0].Y < 0)
                {
                    Fish.Y += 1;
                }
                else
                {
                    if (Fish.Y != list[0].Y)
                    {
                        Fish.Y -= 1;
                    }
                }
            }
            catch(Exception)
            {

            }
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.DarkCyan), list[j]);
                }
                Thread.Sleep(10);
                this.Invalidate();
            }
        }
        List<Rectangle> list;
    }

}
