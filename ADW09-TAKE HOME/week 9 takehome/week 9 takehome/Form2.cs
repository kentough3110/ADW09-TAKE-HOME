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
using MySql.Data.MySqlClient;

namespace ADW09_TAKE_HOME
{
    public partial class Form2 : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string query;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTeam.Text = string.Format("Team: ");
            lblName.Text = string.Format("Name: ");
            lblPosition.Text = string.Format("Position: ");
            lblNation.Text = string.Format("Nationality: ");
            lblNum.Text = string.Format("Player Number: ");
            lblRC.Text = string.Format("Red Card: ");
            lblYC.Text = string.Format("Yellow Card: ");
            lblGO.Text = string.Format("Goal Scored: ");
            lblPM.Text = string.Format("Penalty Missed: ");
            lblGP.Text = string.Format("Goal Penalty: ");
            lblGW.Text = string.Format("Own Goal: ");
            DataTable dtTeam = new DataTable();
            query = "SELECT team_id as 'Team id', team_name as `Team name` from team;";
            sqlConnect = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cmbTeam.DataSource = dtTeam;
            cmbTeam.DisplayMember = "Team name";
            cmbTeam.Text = "";
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tampung = cmbTeam.Text;
            DataTable dtPlayer = new DataTable();
            query = "SELECT player_name as 'Player Name' from player, team WHERE team.team_id = player.team_id and team.team_name = '" + tampung + "';";
            sqlConnect = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            cmbPlayer.DataSource = dtPlayer;
            cmbPlayer.DisplayMember = "Player Name";
            cmbPlayer.SelectedIndex = -1;
        }

        private void cmbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTeam.Text) || string.IsNullOrEmpty(cmbPlayer.Text))
            {
                MessageBox.Show("All fields need to be filled!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string tampung1 = cmbPlayer.Text;
                string tampung2 = cmbTeam.Text;
                DataTable dtAll = new DataTable();
                query = "SELECT player.player_name as 'Player Name', team.team_name as 'Team Name', \r\nnationality.nation as 'Nation', player.team_number as 'Player Number', \r\ncase player.playing_pos \r\n\twhen 'G' then \r\n    'Goal Keeper' \r\n    when 'M' then \r\n    'Mid Fielder' \r\n    when 'D' then \r\n    'Defender' \r\n    when 'F' then \r\n    'Forward' \r\nend as 'Position' \r\nFROM nationality, player, team \r\nWHERE nationality.nationality_id = player.nationality_id and player.team_id = team.team_id and \r\nteam.team_name = '" + tampung2 + "' and player.player_name ='" + tampung1 + "';";
                sqlConnect = new MySqlConnection(connectionString);
                sqlCommand = new MySqlCommand(query,sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAll);
                if(!string.IsNullOrEmpty(cmbTeam.Text)||!string.IsNullOrEmpty(cmbPlayer.Text))
                {
                    lblTeam.Text = string.Format("Team: {0}", tampung2);
                    lblName.Text = string.Format("Name: {0}", tampung1);
                    lblPosition.Text = string.Format("Position: {0}", dtAll.Rows[0]["Position"].ToString());
                    lblNation.Text = string.Format("Nationality: {0}", dtAll.Rows[0]["Nation"].ToString());
                    lblNum.Text = string.Format("Player Number: {0}", dtAll.Rows[0]["Player Number"].ToString());
                }
                
                DataTable dtAll2 = new DataTable();
                query = "SELECT IFNULL(COUNT(case when dmatch.type = 'CY' then 1 end), 0) as 'Yellow Card',\r\nIFNULL(COUNT(case when dmatch.type = 'CR' then 1 end), 0) as 'Red Card',\r\nIFNULL(COUNT(case when dmatch.type = 'GO' then 1 end), 0) as 'Goal Scored',\r\nIFNULL(COUNT(case when dmatch.type = 'PM' then 1 end), 0) as 'Penalty Missed',\r\nIFNULL(COUNT(case when dmatch.type = 'GP' then 1 end), 0) as 'Goal Penalty',\r\nIFNULL(COUNT(case when dmatch.type = 'GW' then 1 end), 0) as 'Own Goal'\r\nFROM player\r\nLEFT JOIN team on team.team_id = player.team_id\r\nLEFT JOIN dmatch on player.player_id = dmatch.player_id\r\nWHERE player.player_name = '"+tampung1+"'\r\nGROUP BY player.player_name, team.team_name;";
                sqlConnect = new MySqlConnection(connectionString);
                sqlCommand = new MySqlCommand(query,sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAll2);
                if (!string.IsNullOrEmpty(cmbTeam.Text) || !string.IsNullOrEmpty(cmbPlayer.Text))
                {
                    lblRC.Text = string.Format("Red Card: {0}", dtAll2.Rows[0]["Red Card"].ToString());
                    lblGO.Text = string.Format("Goal: {0}", dtAll2.Rows[0]["Goal Scored"].ToString());
                    lblYC.Text = string.Format("Yellow Card: {0}", dtAll2.Rows[0]["Yellow Card"].ToString());
                    lblPM.Text = string.Format("Penalty Missed: {0}", dtAll2.Rows[0]["Penalty Missed"].ToString());
                    lblGP.Text = string.Format("Goal Penalty: {0}", dtAll2.Rows[0]["Goal Penalty"].ToString());
                    lblGW.Text = string.Format("Own Goal: {0}", dtAll2.Rows[0]["Own Goal"].ToString());
                }
            }
            
        }

        
    }
}
