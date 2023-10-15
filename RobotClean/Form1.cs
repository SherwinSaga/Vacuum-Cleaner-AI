using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotClean
{
    public partial class Form1 : Form
    {
        private Image image;
        private Timer timer;
        private Robot robot;

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            image = Properties.Resources.ROBOT;
            Bitmap bm = new Bitmap(image, 150, 150);
            pictureBox1.Image = bm;
            pictureBox1.Visible = false;

            robot = new Robot();
            setLabels();
    
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);

            g.DrawLine(p, 5, 5, 5, 600);
            g.DrawLine(p, 5, 5, 600, 5);
            g.DrawLine(p, 5, 600, 600, 600);
            g.DrawLine(p, 600, 5, 600, 600);

            g.DrawLine(p, 300, 5, 300, 300);
            g.DrawLine(p, 5, 300, 300, 300);
            g.DrawLine(p, 300, 600, 300, 300);
            g.DrawLine(p, 300, 300, 600, 300);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (robot.IsDirty())
            {
                int x = robot.GetLocationX();
                int y = robot.GetLocationY();
                robot.Clean();
                verifyEnvironment();
                Console.WriteLine($"Robot cleaned dirt at ({x}, {y})");

            }
            else
            {
                Action move = robot.RandomMove();
                int x = robot.GetLocationX();
                int y = robot.GetLocationY();
                Console.WriteLine($"NoOp - Robot moved {move} to ({x}, {y})");
                robotCurrentLocation();
            }
        }

        private void robotCurrentLocation()
        {
            int x = robot.GetLocationX();
            int y = robot.GetLocationY();
            int tempx = 0;
            int tempy = 0;
            if (x == 0 && y == 0)
            {
                tempx = 150;
                tempy = 150;
            }
            else if (x == 0 && y == 1)
            {
                tempx = 450;
                tempy = 150;
            }
            else if (x == 1 && y == 0)
            {
                tempx = 150;
                tempy = 450;
            }
            else if (x == 1 && y == 1)
            {
                tempx = 450;
                tempy = 450;
            }
            pictureBox1.Location = new Point(tempx -75, tempy-75);
        }

        private void setLabels()
        {
            quadrantA.Location = new Point(125, 50);
            quadrantB.Location = new Point(425, 50);
            quadrantC.Location = new Point(425, 350);
            quadrantD.Location = new Point(125, 350);
        }

        private void verifyEnvironment()
        {
            int[,] temp = robot.getEnvironment();

            if(temp[0, 0] == 1)
            {
                quadrantA.Text = "DIRTY";
                quadrantA.ForeColor = Color.Red;
            }
            else
            {
                quadrantA.Text = "CLEAN";
                quadrantA.ForeColor = Color.Black;
            }

            if (temp[0, 1] == 1)
            {
                quadrantB.Text = "DIRTY";
                quadrantB.ForeColor = Color.Red;
            }
            else
            {
                quadrantB.Text = "CLEAN";
                quadrantB.ForeColor = Color.Black;
            }

            if (temp[1, 0] == 1)
            {
                quadrantD.Text = "DIRTY";
                quadrantD.ForeColor = Color.Red;
            }
            else
            {
                quadrantD.Text = "CLEAN";
                quadrantD.ForeColor = Color.Black;
            }

            if (temp[1, 1] == 1)
            {
                quadrantC.Text = "DIRTY";
                quadrantC.ForeColor = Color.Red;
            }
            else
            {
                quadrantC.Text = "CLEAN";
                quadrantC.ForeColor = Color.Black;
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            robotCurrentLocation();
            verifyEnvironment();
            timer = new Timer();
            timer.Interval = 1500;
            timer.Tick += timer1_Tick;
            timer.Start();

            pictureBox1.Visible = true;
            this.BackColor = Color.WhiteSmoke;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(timer != null)
            {
                timer.Stop();
                this.BackColor = Color.IndianRed;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

    public class Robot
    {
        private int currX;
        private int currY;
        private int[,] environment; // 1 = dirty, 0 = clean
        private Random random;

        public Robot()
        {
            random = new Random();
            currX = random.Next(2); 
            currY = random.Next(2); 

            environment = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    environment[i, j] = random.Next(2);
                }
            }
        }

      

        public Action RandomMove()
        {
            int choose = random.Next(2);
            if(GetLocationX() == 0 && GetLocationY() == 0)
            {
                
                if(choose == 0)//right
                {
                    currY++;
                    return Action.Right;
                }
                else //down
                {
                    currX++;
                    return Action.Down;
                }

            }

            if (GetLocationX() == 0 && GetLocationY() == 1)
            {
                if (choose == 0)//left
                {
                    currY--;
                    return Action.Left;
                }
                else //down
                {
                    currX++;
                    return Action.Down;
                }
            }
            if (GetLocationX() == 1 && GetLocationY() == 0)
            {
                if (choose == 0)//right
                {
                    currY++;
                    return Action.Right;
                }
                else //up
                {
                    currX--;
                    return Action.Up;
                }
            }
            if (GetLocationX() == 1 && GetLocationY() == 1)
            {
                if (choose == 0)//left
                {
                    currY--;
                    return Action.Left;
                }
                else //up
                {
                    currX--;
                    return Action.Up;
                }
            }

            return Action.NoOp;

        }

        public bool IsDirty()
        {
            return environment[currX, currY] == 1;
        }

        public int[,] getEnvironment()
        {
            return environment;
        }

        public void Clean()
        {
            environment[currX, currY] = 0;
        }

        public int GetLocationX()
        {
            return currX;
        }

        public int GetLocationY()
        {
            return currY;
        }
    }

    public enum Action
    {
        Up,
        Down,
        Left,
        Right,
        NoOp
    }
}
