using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace THA_W9_TJOK_SAVITRI
{
    public partial class Player_Data : Form
    {
        public Player_Data()
        {
            InitializeComponent();
        }
        string connection = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        DataTable dtTeam, dtListPlayer, dtPlayer, dtType;
        string sqlQuery;


        private void Player_Data_Load(object sender, EventArgs e)
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
            comboBoxTeam.Text = "";
            comboBoxPlayer.Enabled = false;
            comboBoxPlayer.Text = "";

            labelPlayerName.Visible = false;
            labelTeam.Visible = false;
            labelPosition.Visible = false;
            labelNation.Visible = false;
            labelPos.Visible = false;
            labelYellow.Visible = false;
            labelRed.Visible = false;
            labelGoal.Visible = false;
            labelPenalty.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtPlayer = new DataTable();
            sqlConnect = new MySqlConnection(connection);
            sqlQuery = $"select p.playing_pos , n.nation, p.team_number\r\nfrom player p, nationality n\r\nwhere n.nationality_id = p.nationality_id and p.player_name ='{comboBoxPlayer.Text}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            labelPos.Visible = true;
            labelPos.Text = dtPlayer.Rows[0][2].ToString();

            labelNation.Visible = true;
            labelNation.Text = dtPlayer.Rows[0][1].ToString();

            // player's team
            labelTeam.Visible = true;
            labelTeam.Text = comboBoxTeam.Text;

            // player's name
            labelPlayerName.Visible = true;
            labelPlayerName.Text = comboBoxPlayer.Text;
            /*  G goalkeeper
              D defender
              M midfielder
              F forward */
            string posisi = dtPlayer.Rows[0][0].ToString();
            switch (posisi)
            {
                case "G":
                    labelPosition.Visible = true;
                    labelPosition.Text = "Goalkeeper";
                    break;
                case "D":
                    labelPosition.Visible = true;
                    labelPosition.Text = "Defender";
                    break;
                case "M":
                    labelPosition.Visible = true;
                    labelPosition.Text = "Midfielder";
                    break;
                case "F":
                    labelPosition.Visible = true;
                    labelPosition.Text = "Forward";
                    break;
            }
            /*cy yellow card
                cr red card
                go goal
                gp goal penalty
                gw own goal
                pm penalty miss*/
            dtType = new DataTable();
            sqlConnect = new MySqlConnection(connection);
            sqlQuery = $"select d.type from dmatch d where d.player_id = '{comboBoxPlayer.SelectedValue.ToString()}'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtType);

            int red = 0; int yellow = 0; int goal = 0; int penalty = 0;
            if (dtType.Rows.Count>0)
            {
                for (int i = 0; i < dtType.Rows.Count; i++)
                {
                    string type = dtType.Rows[i][0].ToString();
                    switch (type)
                    {
                        case "CY":
                            yellow++;
                            break;
                        case "CR":
                            red++;
                            break;
                        case "GO":
                            goal++;
                            break;
                        case "PM":
                            penalty++;
                            break;
                    }
                }
            }            
            labelYellow.Visible = true; labelYellow.Text = yellow.ToString();

            labelRed.Visible = true; labelRed.Text = red.ToString();

            labelGoal.Visible = true; labelGoal.Text = goal.ToString();

            labelPenalty.Visible = true; labelPenalty.Text = penalty.ToString();

        }

        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPlayer.Enabled = true;
            dtListPlayer = new DataTable();
            string namaTeam = comboBoxTeam.Text;
            sqlConnect = new MySqlConnection(connection);
            sqlQuery = $"select p.player_name as 'Player Name', p.player_id as 'ID' from player p, team t where t.team_id = p.team_id and t.team_name ='{namaTeam}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtListPlayer);
            comboBoxPlayer.DataSource = dtListPlayer;
           comboBoxPlayer.ValueMember = "ID";
            comboBoxPlayer.DisplayMember = "Player Name";

            comboBoxPlayer.Text = "";
            labelPlayerName.Visible = false; labelTeam.Visible = false; labelPosition.Visible = false;
            labelNation.Visible = false; labelPos.Visible = false; labelYellow.Visible = false;
            labelRed.Visible = false; labelGoal.Visible = false; labelPenalty.Visible = false;
            button1.Enabled = false;
        }

    }
}
