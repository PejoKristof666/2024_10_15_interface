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
        }
    }
}
