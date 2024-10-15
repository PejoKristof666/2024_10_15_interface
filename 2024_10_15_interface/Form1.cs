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
    public partial class Form1 : Form
    {
        dbHandler db;
        
        public Form1()
        {
            InitializeComponent();
            Start();
            
        }
        public void Start()
        {
            db = new dbHandler();
            guna2TextBox2.PasswordChar = '*';
            guna2Button1.Click += LoginEvent;
            guna2Button2.Click += RegisterEvent;
        }

        public void LoginEvent(object s, EventArgs e)
        {
            db.readAll();
            foreach (user item in user.allUser)
            {
                if (guna2TextBox1.Text == item.username && guna2TextBox2.Text == item.password)
                {
                    MessageBox.Show("Sikeres Login");

                    game G = new game(item);
                    G.Show();
                    this.Hide();
                    G.FormClosing += (ss, ee) =>
                    {
                        Application.Exit();
                    };

                    break;
                }
            }
        }
        public void RegisterEvent(object s, EventArgs e)
        {
            user oneUser = new user();
            oneUser.username = guna2TextBox1.Text;
            oneUser.password = guna2TextBox2.Text;
            oneUser.point = 0;
            db.InsertOne(oneUser);
        }
    }
}
