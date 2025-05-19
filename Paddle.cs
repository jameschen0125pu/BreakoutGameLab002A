namespace BreakoutGameLab001
{
    // 擋板類別
    class Paddle
    {
        // 屬性
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        // 建構子
        public Paddle(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }

        // 加入其他方法

        // 繪製擋板
        public void Draw(Graphics g)
        {
            // TODO - 繪製擋板
            g.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
        }

        // TODO: 左右移動擋板 : MoveLeft(), MoveRight()
        public void Move(int dx, int PanelWidth)
        {
            X += dx;
            // 限制擋板不超出邊界
            if (X < 0) X = 0;
            if (X + Width > PanelWidth) X = PanelWidth - Width; // 假設面板寬度為 800(PanelWidth)
        }
    }
}