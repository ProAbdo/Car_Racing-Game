using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace F_Project
{
    class Car_Racing
    {
        Random r = new Random();
        public enum Direction{ Left,Right,None};
        public Direction dir;
        public int speed; 
        public int score;
        public Car_Racing()
        {
            dir = Direction.None;
            speed = 5;
            score = 0;
        }
        public Car_Racing(PictureBox[] cars,PictureBox player)
        {
            player.Left = 255;
            cars[0].Left = 71;cars[0].Top = 154;
            cars[1].Left = 310; cars[1].Top = 45;
            cars[2].Left = 496; cars[2].Top = 266;
            dir = Direction.None;
            speed=5;
            score = 0;
        }
        public void move_lines(PictureBox[] lines,Panel panalGame)
        {
           for(int i=0;i< lines.Length; i++)
            {
                lines[i].Top += speed;
                if (lines[i].Top > panalGame.Height) lines[i].Top = -lines[i].Height;
            }  
        }
        public void move_car(PictureBox[] cars, Panel panalGame,PictureBox player)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Top += speed;
                if (cars[i].Top > panalGame.Height)
                {
                    cars[i].Top = -cars[i].Height;
                    if (i == 0)
                        cars[i].Left = r.Next(panalGame.Width / 3);
                    else if (i == 1)
                        cars[i].Left = r.Next(panalGame.Width / 3, panalGame.Width / 3 * 2);
                    else
                        cars[i].Left = r.Next(panalGame.Width / 3 * 2, (panalGame.Width - cars[i].Width));
                    // change Color
                    int change_car_color = r.Next(5);
                    if (change_car_color == 0) cars[i].Image = Properties.Resources.car0;
                    if (change_car_color == 1) cars[i].Image = Properties.Resources.car1;
                    if (change_car_color == 2) cars[i].Image = Properties.Resources.car2;
                    if (change_car_color == 3) cars[i].Image = Properties.Resources.car3;
                    if (change_car_color == 4) cars[i].Image = Properties.Resources.car4;
                }
            }
        }
       public bool check_accident(PictureBox[] cars,PictureBox player)
        {
            for(int i = 0; i < cars.Length; i++)
            {
                if (player.Bounds.IntersectsWith(cars[i].Bounds))
                {
                    return true;     
                }
            }
            return false;
        }
        public void Game_difficulty()
        {
            if (score % 1000 == 0)
                speed++;
        }
        public void getkeydata(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                dir = Direction.Left;
            else if (e.KeyData == Keys.Right)
                dir = Direction.Right;
            else
                dir = Direction.None;
        }
        public void move_player(PictureBox player,Panel panalGame)
        {
            if (dir == Direction.Left&&player.Left>0)
                player.Left -= speed;
            if (dir == Direction.Right&&player.Left<panalGame.Width-player.Width)
                player.Left += speed;
        }
    }
}
