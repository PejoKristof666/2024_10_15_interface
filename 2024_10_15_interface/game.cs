using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_10_15_interface
{
    public partial class game : Form
    {
        car c;
        public bool hit;
        public Timer t = new Timer();
        public user loggedInUser { get; set; }
        public game(user loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            label1.Text = $"Üdv. {loggedInUser.username}\nPontjaid száma: {loggedInUser.point}";
            label1.AutoSize = true;
            
            t.Interval = 2000;
            t.Start();
            t.Tick += (s, e) =>
            {
                label1.Hide();
                
            };
            CarMake();
            if (hit == true)
            {
                CarMake();
            }
        }

        public void CarMake()
        {
            Timer carTimer = new Timer();
            car c = new car();
            
            Controls.Add(c);
            c.Width = 50;
            c.Height = road.Height / 2;
            c.Location = new Point(road.Left + c.Width, road.Top + c.Height / 2);
            c.BringToFront();
            c.BackColor = Color.Red;

            
            carTimer.Interval = 10;
            carTimer.Start();
            carTimer.Tick += (s, e) =>
            {
                c.Left += 2;
                //if (c.Right < c.Left - 20)
                //{
                //    carTimer.Stop();
                //}
                //else
                //{
                //    carTimer.Start();
                //}
                if (c.Left >= (road.Right + c.Width))
                {

                    Controls.Remove(c);
                    c.Hide();
                    hit = true;
                    carTimer.Stop();
                }

            };
            

        }













        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
