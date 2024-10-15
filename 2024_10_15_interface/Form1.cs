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
            db.readAll();
            guna2TextBox2.PasswordChar = '*';
            guna2Button1.Click += LoginEvent;
            guna2Button2.Click += RegisterEvent;
        }

        public void LoginEvent(object s, EventArgs e)
        {
            foreach (user item in user.allUser)
            {
                if (guna2TextBox1.Text == item.username && guna2TextBox2.Text == item.password)
                {
                    MessageBox.Show("Sikeres Login");
                    break;
                }
            }
        }
        public void RegisterEvent(object s, EventArgs e)
        {

        }
    }
}
