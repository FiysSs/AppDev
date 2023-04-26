using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W9_TJOK_SAVITRI
{
    public partial class ShowMatch : Form
    {
        public ShowMatch()
        {
            InitializeComponent();
        }
        string connection = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        DataTable dtTeam, dtMatch, dtDetails, dtHehe, dtHome, dtAway;
         string sqlQuery;

        private void ShowMatch_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connection);
            sqlConnect.Open();

            dtTeam = new DataTable();
            sqlQuery = "select team_id as 'ID', team_name as 'Nama Team' from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            comboBoxTeam.DataSource = dtTeam;
            comboBoxTeam.ValueMember = "ID";
            comboBoxTeam.DisplayMember = "Nama Team";
            comboBoxMatch.Enabled = false;
            button1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {         
            string namaTeam = comboBoxTeam.Text;

            dtHehe = new DataTable();
            sqlConnect = new MySqlConnection(connection);
            sqlQuery = $"select t1.team_name, t2.team_name\r\nfrom `match` m, team t1, team t2\r\nwhere m.team_home = t1.team_id and m.team_away = t2.team_id and m.match_id = '{comboBoxMatch.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHehe);

            labelHome.Visible = true;
            labelHome.Text = dtHehe.Rows[0][0].ToString();

            labelAway.Visible = true;
            labelAway.Text = dtHehe.Rows[0][1].ToString();

            dtHome = new DataTable();
            update(labelHome.Text, dtHome);
            dgvHome.DataSource = dtHome;

            dtAway = new DataTable();
            update(labelAway.Text, dtAway);
            dgvAway.DataSource = dtAway;

            dtDetails = new DataTable();
            sqlConnect = new MySqlConnection(connection);
            sqlQuery = $"select d.`minute` as 'Minute', t.team_name as 'Team Name', p.player_name as 'Player Name',  d.`type` as 'Type'\r\nfrom `match` m, dmatch d, player p, team t\r\nwhere  m.match_id = d.match_id  and (t.team_id = d.team_id or t.team_id = d.team_id) and p.player_id = d.player_id and d.match_id = '{comboBoxMatch.SelectedValue.ToString()}' order by d.`minute`;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetails);


            for (int i = 0; i < dtDetails.Rows.Count; i++)
            {
                string type = dtDetails.Rows[i][3].ToString();
                switch (type)
                {
                    case "CY":
                        dtDetails.Rows[i][3] = "Yellow Card";
                        break;
                    case "CR":
                        dtDetails.Rows[i][3] = "Red Card";
                        break;
                    case "GO":
                        dtDetails.Rows[i][3] = "Goal";
                        break;
                    case "GP":
                        dtDetails.Rows[i][3] = "Goal Penalty";
                        break;
                    case "GW":
                        dtDetails.Rows[i][3] = "Own Goal";
                        break;
                    case "PM":
                        dtDetails.Rows[i][3] = "Penalty Miss";
                        break;
                }
            }
            dgvDetails.DataSource = dtDetails;
        }

        void update(string aaa, DataTable data)
        {
            sqlConnect = new MySqlConnection(connection);
            sqlQuery = $"select t.team_name as 'Team Name', p.player_name 'Player Name', p.playing_pos as 'Position'\r\nfrom team t, player p\r\nwhere t.team_id = p.team_id and t.team_name = '{aaa}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string simpan = data.Rows[i][2].ToString();
                switch (simpan)
                {
                    case "G":
                        data.Rows[i][2] = "Goalkeeper";
                        break;
                    case "D":
                        data.Rows[i][2] = "Defender";
                        break;
                    case "M":
                        data.Rows[i][2] = "Midfielder";
                        break;
                    case "F":
                        data.Rows[i][2] = "Forward";
                        break;
                }
            }
        }

        private void comboBoxMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMatch.Enabled = true;
            button1.Enabled = false;
            dtMatch = new DataTable();
            string namaTeam = comboBoxTeam.Text;
            sqlConnect = new MySqlConnection(connection);
            sqlQuery = $"select d.match_id as 'Match', m.match_date as 'Date'\r\nfrom `dmatch` d, team t, `match` m \r\nwhere d.team_id = t.team_id and d.match_id = m.match_id and t.team_name = '{namaTeam}'\r\ngroup by  d.match_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            comboBoxMatch.DataSource = dtMatch;
            comboBoxMatch.ValueMember = "Match";
            comboBoxMatch.DisplayMember = "Date";
            comboBoxMatch.Text = "";
            button1.Enabled = false;
        }

       
       
    }
}
