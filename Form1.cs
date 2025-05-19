
using System.Reflection.Metadata;

namespace BreakoutGameLab001
{
    public partial class Form1 : Form
    {
        // 遊戲面板控制項
        BrickGamePanel gamePanel;
        //
        public Form1()
        {
            InitializeComponent();
            //
            InitializeGame();
        }

        private void InitializeGame()
        {
            // 移除 測試用 panel2 控制項
            Controls.Remove(panel2);
            //
            gamePanel = new BrickGamePanel(panel2.Width, panel2.Height);
            gamePanel.Dock = DockStyle.Fill;
            gamePanel.Location = new Point(0, 61);
            gamePanel.Name = "BrickoutGamePanel";
            gamePanel.Size = new Size(panel2.Width, panel2.Height);
            gamePanel.TabIndex = 1;
            //
            gamePanel.Initialize();
            //
            Controls.Add(gamePanel);
            //
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            // 判斷按下的鍵盤
            if (key == (int)Keys.Left)
            {
                // 左鍵
                gamePanel.paddleMoveLeft();
            }
            else if (key == (int)Keys.Right)
            {
                // 右鍵
                gamePanel.paddleMoveRight();
            }
            else if (key == (int)Keys.Escape)
            {
                // ESC 鍵
                this.Close();
            }

        }
    }
}
