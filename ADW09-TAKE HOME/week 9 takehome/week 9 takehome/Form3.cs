using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace ADW09_TAKE_HOME
{
    public partial class Form3 : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string query;
        DataTable dtData = new DataTable();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable dtTeam = new DataTable();
            query = "SELECT team_id as 'Team id', team_name as `Team name` from team;";
            sqlConnect = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cmbTeam.DataSource = dtTeam;
            cmbTeam.DisplayMember = "Team name";
            cmbTeam.SelectedIndex = -1;
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtData.Clear();
            string tampung = cmbTeam.Text;
            query = "SELECT m.match_id as 'ID', t.team_name as `Team Home` , tm.team_name as `Away Team`, t.team_id as 'ID HOME', tm.team_id as 'ID AWAY'\r\nfrom `match` m , team t , team tm \r\nwhere t.team_id = m.team_home and tm.team_id = m.team_away and t.team_name = '" + tampung + "'\r\nunion \r\nSELECT m.match_id as 'ID', t.team_name as `Team Home` , tm.team_name as `Away Team`, t.team_id as 'ID HOME', tm.team_id as 'ID AWAY'\r\nfrom `match` m , team t , team tm \r\nwhere t.team_id = m.team_home and tm.team_id = m.team_away and tm.team_name = '" + tampung + "';";
            sqlConnect = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtData);
            cmbMatch.DisplayMember = "Date";
            cmbMatch.ValueMember = "ID";
            cmbMatch.Items.Clear();
            for (int i = 0; i < dtData.Rows.Count; i++)
            {
                string home = dtData.Rows[i][1].ToString();
                string away = dtData.Rows[i][2].ToString();
                string homevsaway = dtData.Rows[i][1].ToString() + " vs " + dtData.Rows[i][2].ToString();
                cmbMatch.Items.Add(homevsaway);
            }

        }
        private void cmbMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtHome = new DataTable();
            query = "SELECT t.team_name as 'Team Name', p.player_name as 'Player Name', p.team_number as 'Player Number', case p.playing_pos \r\n\twhen 'G' then \r\n    'Goal Keeper' \r\n    when 'M' then \r\n    'Mid Fielder' \r\n    when 'D' then \r\n    'Defender' \r\n    when 'F' then \r\n    'Forward' \r\nend as 'Position'\r\nFROM player P, team t\r\nWHERE p.team_id = t.team_id and p.team_id = '" + dtData.Rows[cmbMatch.SelectedIndex][3] + "';";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHome);
            dgvHome.DataSource = dtHome;

            DataTable dtAway = new DataTable();
            query = "SELECT t.team_name as 'Team Name', p.player_name 'Player Name', p.team_number as 'Player Number', case p.playing_pos \r\n\twhen 'G' then \r\n    'Goal Keeper' \r\n    when 'M' then \r\n    'Mid Fielder' \r\n    when 'D' then \r\n    'Defender' \r\n    when 'F' then \r\n    'Forward' \r\nend as 'Position'\r\nFROM player P, team t\r\nWHERE p.team_id = t.team_id and p.team_id = '" + dtData.Rows[cmbMatch.SelectedIndex][4] + "';";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtAway);
            dgvAway.DataSource = dtAway;

            DataTable dtDetails = new DataTable();
            query = "SELECT team.team_name as'Team Name', player.player_name as 'Player Name',\r\nCASE dmatch.type\r\nWHEN 'CY' THEN 'Yellow Card'\r\nWHEN 'CR' THEN 'Red Card'\r\nWHEN 'GO' THEN 'Goal Scored'\r\nWHEN 'PM' THEN 'Penalty Missed'\r\nWHEN 'GP' THEN 'Goal Penalty'\r\nWHEN 'GW' THEN 'Own Goal'\r\nEND as 'Type',  \r\ndmatch.minute as 'Minute'\r\nFROM player, `match`, team, dmatch \r\nWHERE team.team_id = dmatch.team_id and team.team_id = player.team_id and player.player_id = dmatch.player_id and dmatch.match_id = `match`.match_id\r\nand dmatch.match_id = '" + dtData.Rows[cmbMatch.SelectedIndex][0].ToString() + "';";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetails);
            dgvDetail.DataSource = dtDetails;

        }
    }
       
}
