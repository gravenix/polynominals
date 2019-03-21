﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polynomials.Classes.Formula;

namespace Polynomials
{
    public partial class MainForm : Form
    {
        private int scale = 40;
        private Formula formula = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onDraw(object sender, EventArgs e)
        {
            formula = FormulaBuilder.BuildFromText(this.formulaBox.Text);
            PanelDrawing.Refresh();
        }

        private void drawFunction(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen mainPen = new Pen(Color.Black);
            mainPen.Width = 1;
            FlowLayoutPanel flp = (FlowLayoutPanel)sender;

            //Lines
            g.DrawLine(mainPen, 0, flp.Height / 2, flp.Width, flp.Height / 2);
            g.DrawLine(mainPen, flp.Width / 2, flp.Height, flp.Width / 2, 0);

            //scales
            int delta = 0;
            while (flp.Width / 2 - delta > 0)
            {
                delta += scale;
                //horizontal
                g.DrawLine(mainPen, flp.Width / 2 - delta, flp.Height / 2 + 3, flp.Width / 2 - delta, flp.Height / 2 - 3);
                g.DrawLine(mainPen, flp.Width / 2 + delta, flp.Height / 2 + 3, flp.Width / 2 + delta, flp.Height / 2 - 3);

                //vertical
                g.DrawLine(mainPen, flp.Width / 2 - 3, flp.Height / 2 + delta, flp.Width / 2 + 3, flp.Height / 2 + delta);
                g.DrawLine(mainPen, flp.Width / 2 - 3, flp.Height / 2 - delta, flp.Width / 2 + 3, flp.Height / 2 - delta);
            }

            if (formula == null) return;
            Bitmap pixel = new Bitmap(1, 1);
            pixel.SetPixel(0, 0, Color.Black);
            double k = 1.0 / scale;
            for(int x = 0; x < flp.Width; x++)
            {
                g.DrawImageUnscaled(pixel, x, Convert.ToInt32(-1*formula.exec((x-flp.Width/2)*k)*scale+flp.Height/2));
            }
            double x1 = formula.exec(0.0);
            return;
        }
    }
}
