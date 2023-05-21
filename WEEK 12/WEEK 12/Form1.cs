using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WEEK_12
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtNation, dtTeamPlyr, dtTeamManager, dtPickTeam, dtPlayer, test, manager, jumlah;

        string connection = "server=localhost;uid=root;pwd=root;database=premier_league";
        string query = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxPickTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPlayer = new DataTable();
            updatePlayer();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int totalActivePlayer = 0;
            jumlah = new DataTable();
            string codee = $"select count(player_id)\r\nfrom player\r\nwhere `status` = 1 and team_id = '{comboBoxPickTeam.SelectedValue.ToString()}';";
            isiData(codee, jumlah);
            totalActivePlayer = Convert.ToInt32(jumlah.Rows[0][0].ToString());

            if (totalActivePlayer > 11)
            {
                string simpan = dataGridViewPlayer.CurrentRow.Cells["Name"].Value.ToString();
                string code = $"UPDATE player\r\nSET `status` = 0\r\nWHERE player_name = '{simpan}';"; // bingung
                command(code);
                updatePlayer();
            } else
            {
                MessageBox.Show("Player harus lebih dari 11");
            }          
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeManager();
        }  

        private void buttonUpdateManager_Click(object sender, EventArgs e)
        {
            string simpan = dataGridViewManager.CurrentRow.Cells["Name"].Value.ToString();
            string code = $"UPDATE manager\r\nSET working = 1\r\nWHERE manager_name = '{simpan}';";
            command(code);
            string code1 = $"UPDATE manager\r\nSET working = 0\r\nWHERE manager_name = '{labelManagerName.Text}';";
            command(code1);
            string code2 = $"update team\r\nset manager_id = (select manager_id from manager where manager_name = '{simpan}')\r\nwhere team_name = '{comboBoxTeam.Text}';";
            command(code2);
            updateManager(); activeManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // NATIONALITY
            dtNation = new DataTable();
            string code = "select nationality_id 'id', nation from nationality;";
            isiData(code, dtNation);
            comboBoxNationality.DataSource = dtNation;
            comboBoxNationality.DisplayMember = "nation";
            comboBoxNationality.ValueMember = "id";

            // combobox Team
            dtTeamPlyr = new DataTable(); isicmbTeam(dtTeamPlyr);
            comboBoxTeam.DataSource = dtTeamPlyr;
            comboBoxTeam.DisplayMember = "team";
            comboBoxTeam.ValueMember = "id";

            dtTeamManager = new DataTable(); isicmbTeam(dtTeamManager);
            comboBoxTeamName.DataSource = dtTeamManager;
            comboBoxTeamName.DisplayMember = "team";
            comboBoxTeamName.ValueMember = "id";

            dtPickTeam = new DataTable(); isicmbTeam(dtPickTeam);
            comboBoxPickTeam.DataSource = dtPickTeam;
            comboBoxPickTeam.DisplayMember = "team";
            comboBoxPickTeam.ValueMember = "id";

            this.ActiveControl = label1;
            updateManager();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            string birthdate = dtpBirthdate.Value.ToString("yyyy-MM-dd");
            string code = $"insert into player values ('{textBoxPlayerID.Text}','{textBoxTeamNumber.Text}','{textBoxNama.Text}','{comboBoxNationality.SelectedValue.ToString()}','{textBoxPosition.Text}',{textBoxHeight.Text},{textBoxWeight.Text},'{birthdate}','{comboBoxTeamName.SelectedValue.ToString()}',1,0);";
            command(code); updatePlayer();
        }

        void updatePlayer()
        {
            string code = $"SELECT p.player_name 'Name', n.nation 'Nationality', p.playing_pos 'Position', p.team_number 'Number', p.height, p.weight, p.birthdate\r\nfrom player p, nationality n, team t\r\nwhere n.nationality_id = p.nationality_id and t.team_id = p.team_id and p.team_id = '{comboBoxPickTeam.SelectedValue.ToString()}' and p.status = 1;";
            dtPlayer = new DataTable();
            isiData(code, dtPlayer);
            dataGridViewPlayer.DataSource = dtPlayer;
        }

        void isicmbTeam(DataTable dataTable)
        {
            try
            {
                sqlConnection = new MySqlConnection(connection);
                sqlConnection.Open();
                query = "select team_id 'id', team_name 'team' from team;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        void command(string code)
        {
            try
            {
                sqlConnection = new MySqlConnection(connection);
                sqlConnection.Open();
                query = code;
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void isiData(string code, DataTable data)
        {
            try
            {
                sqlConnection = new MySqlConnection(connection);
                sqlConnection.Open();
                query = code;
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        void updateManager()
        {
            test = new DataTable();
            string code = "select m.manager_name Name, n.nation Nationality, m.birthdate Birthdate\r\nfrom nationality n\r\njoin manager m on m.working = 0 AND m.nationality_id = n.nationality_id;";
            isiData(code, test);
            dataGridViewManager.DataSource = test;
        }

        void activeManager()
        {
            manager = new DataTable();
            string code = $"select m.manager_name Name, m.birthdate Birthdate, n.nation Nationality\r\nfrom team t\r\njoin manager m on t.manager_id = m.manager_id\r\nleft join nationality n on m.nationality_id = n.nationality_id\r\nwhere team_id = '{comboBoxTeam.SelectedValue.ToString()}';";
            isiData(code, manager);
            try
            {
                labelManagerName.Text = manager.Rows[0][0].ToString();
                labelTeamName.Text = comboBoxTeam.Text;
                labelBirthdate.Text = manager.Rows[0][1].ToString().Substring(0, 10);
                labelNationality.Text = manager.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
        }
    }
}