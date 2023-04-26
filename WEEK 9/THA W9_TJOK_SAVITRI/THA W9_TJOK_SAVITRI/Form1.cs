using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W9_TJOK_SAVITRI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player_Data player_Data = new Player_Data();
            player_Data.MdiParent = this;
            player_Data.Dock = DockStyle.Fill;
            player_Data.FormBorderStyle = FormBorderStyle.None;
            player_Data.ControlBox = false;
            player_Data.Show();
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMatch showMatch = new ShowMatch();
            showMatch.MdiParent = this;
            showMatch.Dock = DockStyle.Fill;
            showMatch.FormBorderStyle = FormBorderStyle.None;
            showMatch.ControlBox = false;
            showMatch.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
