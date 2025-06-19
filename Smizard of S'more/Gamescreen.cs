using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smizard_of_S_more
{
    public partial class Gamescreen : UserControl
    {

        //I didn't have time to add comments sorry!
        public static List<gameBlock> blocks = new List<gameBlock>();

        public int borderSize = 20;
        public static int playScreenX;
        public static int playScreenY;

        Rectangle lWall, rWall, tWall, bWall, midWall, _player;

        Player player;
        Monster Myrme;
        Rectangle goal;

        SolidBrush wallBrush = new SolidBrush(Color.MediumBlue);
        SolidBrush playerBrush = new SolidBrush(Color.Gold);
        SolidBrush goyleBrush = new SolidBrush(Color.RoyalBlue);
        SolidBrush wyrmBrush = new SolidBrush(Color.Yellow);
        SolidBrush myrmeBrush = new SolidBrush(Color.Red);
        SolidBrush warlukBrush = new SolidBrush(Color.Lime);

        public bool rPressed, lPressed, uPressed, dPressed;
        bool makePoint = true;

        public Random monMover = new Random();

        public Gamescreen()
        {
            InitializeComponent();
            SetMap();
            rPressed = lPressed = uPressed = dPressed = false;
        }

        private void Gamescreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    lPressed = true;
                    break;
                case Keys.Right:
                    rPressed = true;
                    break;
                case Keys.Up:
                    uPressed = true;
                    break;
                case Keys.Down:
                    dPressed = true;
                    break;
            }
        }

        private void Gamescreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    lPressed = false;
                    break;
                case Keys.Right:
                    rPressed = false;
                    break;
                case Keys.Up:
                    uPressed = false;
                    break;
                case Keys.Down:
                    dPressed = false;
                    break;
            }

        }

        private void Gamescreen_Load(object sender, EventArgs e)
        {
            gameTimer.Start();
            player = new Player();
            Myrme = new Monster();

            lWall = new Rectangle(0, 0, borderSize, Height);
            rWall = new Rectangle(Width - borderSize, 0, borderSize, Height);
            tWall = new Rectangle(0, 0, Width, borderSize);
            bWall = new Rectangle(0, Height - borderSize, Width, borderSize);
            midWall = new Rectangle(320, 320, 4 * gameBlock.size, gameBlock.size);

            _player = new Rectangle(player.x, player.y, Player.width, Player.height);
        }

        private void SetMap()
        {
            playScreenX = this.Width - 2 * borderSize;
            playScreenY = this.Height - 2 * borderSize;

            #region movement values
            blocks.Add(new DAndR(borderSize, borderSize));
            blocks.Add(new LeftNRight(borderSize + gameBlock.size, borderSize));
            blocks.Add(new LeftNRight(borderSize + 2 * gameBlock.size, borderSize));
            blocks.Add(new LeftNRight(borderSize + 3 * gameBlock.size, borderSize));
            blocks.Add(new TIntDown(borderSize + 4 * gameBlock.size, borderSize));
            blocks.Add(new LeftNRight(borderSize + 5 * gameBlock.size, borderSize));
            blocks.Add(new LeftNRight(borderSize + 6 * gameBlock.size, borderSize));
            blocks.Add(new LeftNRight(borderSize + 7 * gameBlock.size, borderSize));
            blocks.Add(new LeftNRight(borderSize + 8 * gameBlock.size, borderSize));
            blocks.Add(new DAndL(borderSize + 9 * gameBlock.size, borderSize));

            blocks.Add(new UpNDown(borderSize, borderSize + gameBlock.size));
            blocks.Add(new DAndR(borderSize + gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 2 * gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 3 * gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new FourWay(borderSize + 4 * gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 5 * gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 6 * gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 7 * gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new DAndL(borderSize + 8 * gameBlock.size, borderSize + gameBlock.size));
            blocks.Add(new UpNDown(borderSize + 9 * gameBlock.size, borderSize + gameBlock.size));

            blocks.Add(new UpNDown(borderSize, borderSize + 2 * gameBlock.size));
            blocks.Add(new UpNDown(borderSize + gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new DAndR(borderSize + 2 * gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 3 * gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new TIntUp(borderSize + 4 * gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 5 * gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 6 * gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new DAndL(borderSize + 7 * gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new UpNDown(borderSize + 8 * gameBlock.size, borderSize + 2 * gameBlock.size));
            blocks.Add(new UpNDown(borderSize + 9 * gameBlock.size, borderSize + 2 * gameBlock.size));

            blocks.Add(new TIntRight(borderSize, borderSize + 3 * gameBlock.size));
            blocks.Add(new FourWay(borderSize + gameBlock.size, borderSize + 3 * gameBlock.size));
            blocks.Add(new TIntLeft(borderSize + 2 * gameBlock.size, borderSize + 3 * gameBlock.size));
            blocks.Add(new TIntRight(borderSize + 7 * gameBlock.size, borderSize + 3 * gameBlock.size));
            blocks.Add(new FourWay(borderSize + 8 * gameBlock.size, borderSize + 3 * gameBlock.size));
            blocks.Add(new TIntLeft(borderSize + 9 * gameBlock.size, borderSize + 3 * gameBlock.size));

            blocks.Add(new UpNDown(borderSize, borderSize + 4 * gameBlock.size));
            blocks.Add(new UpNDown(borderSize + gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new UAndR(borderSize + 2 * gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 3 * gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 4 * gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new TIntDown(borderSize + 5 * gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 6 * gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new UAndL(borderSize + 7 * gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new UpNDown(borderSize + 8 * gameBlock.size, borderSize + 4 * gameBlock.size));
            blocks.Add(new UpNDown(borderSize + 9 * gameBlock.size, borderSize + 4 * gameBlock.size));

            blocks.Add(new UpNDown(borderSize, borderSize + 5 * gameBlock.size));
            blocks.Add(new UAndR(borderSize + gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 2 * gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 3 * gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 4 * gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new FourWay(borderSize + 5 * gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 6 * gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 7 * gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new UAndL(borderSize + 8 * gameBlock.size, borderSize + 5 * gameBlock.size));
            blocks.Add(new UpNDown(borderSize + 9 * gameBlock.size, borderSize + 5 * gameBlock.size));

            blocks.Add(new UAndR(borderSize, borderSize + 6 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 2 * gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 3 * gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 4 * gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new TIntUp(borderSize + 5 * gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 6 * gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 7 * gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new LeftNRight(borderSize + 8 * gameBlock.size, borderSize + 6 * gameBlock.size));
            blocks.Add(new UAndL(borderSize + 9 * gameBlock.size, borderSize + 6 * gameBlock.size));
            #endregion

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region moving
            _player.X = player.x;
            _player.Y = player.y;

            gameBlock curBlock = blocks.Find(g => player.x >= g.x && player.x < g.x + gameBlock.size && player.y >= g.y && player.y < g.y + gameBlock.size);
            gameBlock enemyBlock = blocks.Find(g => Myrme.x >= g.x && Myrme.x < g.x + gameBlock.size && Myrme.y >= g.y && Myrme.y < g.y + gameBlock.size);

            if (rPressed == true && curBlock.rightAllowed == true)
            {
                player.Move("right");
            }
            if (lPressed == true && curBlock.leftAllowed == true)
            {
                player.Move("left");
            }
            if (uPressed == true && curBlock.upAllowed == true)
            {
                player.Move("up");
            }
            if (dPressed == true && curBlock.downAllowed == true)
            {
                player.Move("down");
            }

            int monMove = monMover.Next(1, 5);
            if (monMove == 1 && enemyBlock.rightAllowed == true)
            {
                Myrme.Move("right");
            }
            if (monMove == 2 && enemyBlock.leftAllowed == true)
            {
                Myrme.Move("left");
            }
            if (monMove == 3 && enemyBlock.upAllowed == true)
            {
                Myrme.Move("up");
            }
            if (monMove == 4 && enemyBlock.downAllowed == true)
            {
                Myrme.Move("down");
            }
            #endregion

            if(_player.IntersectsWith(Myrme.monBox))
            {
                Refresh();
                Thread.Sleep(500);
                gameTimer.Stop();
                Form1.ScreenChanger(this, new Menu());
            }

            SetPoint();
            Refresh();
        }

        public void SetPoint()
        {
            Random setValue = new Random();
            int value;

            int pWidth = 8;
            int pHeight = 18;

            value = setValue.Next(1, blocks.Count + 1);

            if (makePoint == true)
            {
                goal = new Rectangle(blocks[value].x + (gameBlock.size / 2) - pWidth / 2, blocks[value].y + (gameBlock.size / 2) - pHeight/2, pWidth, pHeight);
                makePoint = false;
            }
            
            if (_player.IntersectsWith(goal))
            {
                value = setValue.Next(1, blocks.Count + 1);
               makePoint = true;
            }
        }

        private void Gamescreen_Paint(object sender, PaintEventArgs e)
        {
            if (gameTimer.Enabled == true)
            {
                e.Graphics.FillRectangle(wallBrush, lWall);
                e.Graphics.FillRectangle(wallBrush, rWall);
                e.Graphics.FillRectangle(wallBrush, tWall);
                e.Graphics.FillRectangle(wallBrush, bWall);
                e.Graphics.FillRectangle(wallBrush, midWall);


                foreach (gameBlock u in blocks)
                {

                    for (int i = 0; i < u.walls.Count; i++)
                    {
                        e.Graphics.FillRectangle(wallBrush, u.walls[i]);
                    }
                }
            }
            e.Graphics.FillRectangle(myrmeBrush, Myrme.monBox);
            e.Graphics.FillRectangle(playerBrush, _player);

            e.Graphics.FillRectangle(warlukBrush, goal);
        }
    }
}
