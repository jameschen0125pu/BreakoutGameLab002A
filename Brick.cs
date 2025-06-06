﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakoutGameLab001
{
    // 磚塊類別
    class Brick
    {
        // 屬性
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        // 建構子
        public Brick(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }

        // 加入其他方法

        // 繪製磚塊
        public void Draw(Graphics g)
        {
            // TODO - 繪製磚塊
            g.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
            g.DrawRectangle(new Pen(Color.Black, 2), X, Y, Width, Height);
        }
    }
}
