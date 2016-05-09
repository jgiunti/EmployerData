using System.Windows.Forms;
using System;

namespace EDAW.Forms
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var connection = Properties.Settings.Default.host;

            listView1.Items.Add(connection);

            var db = Properties.Settings.Default.database;

            lvDb.Items.Add(db);

            base.OnLoad(e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.host = textBox1.Text;
            Properties.Settings.Default.Save();
            refreshConn();
        }

        private void lvDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDb.Text = lvDb.SelectedItems[0].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.database = txtDb.Text;
            Properties.Settings.Default.Save();
            refreshDB();
        }

        private void refreshDB()
        {
            lvDb.Clear();
            var db = Properties.Settings.Default.database;

            lvDb.Items.Add(db);
        }

        private void refreshConn()
        {
            listView1.Clear();
            var conn = Properties.Settings.Default.host;

            listView1.Items.Add(conn);
        }
    }
}
