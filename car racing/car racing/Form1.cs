namespace car_racing
{
    public partial class Form1 : Form
    {
        int collectedGold = 0;
        Random r = new Random();
        int x;
        public Form1()
        {
            InitializeComponent();
            gameoverLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void collection()
        {
            if (mainCar.Bounds.IntersectsWith(car1.Bounds))
            {
                collectedGold++;
                coinLabel.Text = "Coins=" + collectedGold.ToString();
                car1.Location = new Point(x, 0);
            }
            if (mainCar.Bounds.IntersectsWith(car2.Bounds))
            {
                collectedGold++;
                coinLabel.Text = "Coins=" + collectedGold.ToString();
                car2.Location = new Point(x, 0);


            }
            if (mainCar.Bounds.IntersectsWith(car3.Bounds))
            {
                collectedGold++;
                coinLabel.Text = "Coins=" + collectedGold.ToString();
                car3.Location = new Point(x, 0);

            }

        }
        void gameover()
        {
            if (mainCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                timer1.Enabled = false;
                gameoverLabel.Visible = true;
            }
            if (mainCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                timer1.Enabled = false;
                gameoverLabel.Visible = true;
            }
            if (mainCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                timer1.Enabled = false;
                gameoverLabel.Visible = true;
            }
        }
        void moveline(int speed)
        {
            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemies(gamespeed);
            gameover();
            gold(gamespeed);
            collection();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        int gamespeed = 2;
        int carspeed = 8;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (mainCar.Left > 15)
                    mainCar.Left += -carspeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (mainCar.Right < 385)
                    mainCar.Left += carspeed;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (carspeed < 24)
                    carspeed += 4;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (carspeed > 8)
                    carspeed -= 4;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        private void dragon1_Click(object sender, EventArgs e)
        {
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        void enemies(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        { }


        void gold(int speed)
        {
            if (car1.Top >= 500)
            {
                x = r.Next(0, 400);
                car1.Location = new Point(x, 0);
            }
            else
            {
                car1.Top += speed;
            }
            if (car2.Top >= 500)
            {
                x = r.Next(0, 400);
                car2.Location = new Point(x, 0);
            }
            else
            {
                car2.Top += speed;
            }
            if (car3.Top >= 500)
            {
                x = r.Next(0, 400);
                car3.Location = new Point(x, 0);
            }
            else
            {
                car3.Top += speed;
            }
        }
    }
}
