using Club_Start.Services;

namespace Club_Start
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.GetSportsmens();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.GetCoaches();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.GetAttendances();
        }
    }
}
