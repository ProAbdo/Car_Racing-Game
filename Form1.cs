using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Project
{
    public partial class Form1 : Form
    {
        Car_Racing Run = new Car_Racing();
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {   
            //timerAction
            PictureBox[] cars = { car1, car2, car3 };
            PictureBox[] lines = { L1, L2, L3, L4, L5, L6, L7, L8, L9 };
            Run.move_lines(lines, panalGame);
            Run.move_player(Player,panalGame);
            Run.move_car(cars,panalGame);
            lbscore.Text = "Score : " + Run.score;
            Run.Game_difficulty();
            if (Run.check_accident(cars, Player))
            {
                timeAction.Enabled = false;
                Run=new Car_Racing(cars,Player);
                timerwait.Enabled = true;
            }
            Run.score++;
        }
        private void timerwait_Tick(object sender, EventArgs e)
        {
            //timerwait
            labGameOver.Visible = true;
            lbwait.Visible = true;
            if (lbwait.ForeColor == Color.Black)
                lbwait.ForeColor = Color.Red;
            else
                lbwait.ForeColor = Color.Black;
            if (labGameOver.ForeColor == Color.Firebrick)
                labGameOver.ForeColor = Color.Black;
            else
                labGameOver.ForeColor = Color.Firebrick;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Run.getkeydata(e);
            if (e.KeyCode == Keys.Enter)
            {
                lbwait.Visible = false;
                labGameOver.Visible = false;
                timerwait.Enabled = false;
                timeAction.Enabled = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Run.dir = Car_Racing.Direction.None;
        }
        private void L1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void car3_Click(object sender, EventArgs e)
        {

        }
        private void car1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void labGameOver_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void L4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
