using System.Security.Cryptography.X509Certificates;

namespace Watercalc
{
    public partial class Main_interface : Form
    {
        public class Type_customer
        {
            public static string type = "";
        }
        public class night
        {
            public static bool nightmode = false;
        }

        public Main_interface()
        {
            InitializeComponent();
        }
        private void btn_night_Click(object sender, EventArgs e)
        {
            night.nightmode = !night.nightmode;
            if (night.nightmode)
            {
                this.BackColor = Color.Black;
                ForeColor = Color.White;
                btn_a.BackColor = Color.Black;
                btn_h.BackColor = Color.Black;
                btn_p.BackColor = Color.Black;
                btn_b.BackColor = Color.Black;
                btn_cost.BackColor = Color.Black;
                btn_history.BackColor = Color.Black;
                btn_night.BackColor = Color.Black;

            }
            if (!night.nightmode)
            {
                this.BackColor = SystemColors.Control;
                ForeColor = Color.Black;
                btn_a.BackColor = Color.White;
                btn_h.BackColor = Color.White;
                btn_p.BackColor = Color.White;
                btn_b.BackColor = Color.White;
                btn_cost.BackColor = Color.White;
                btn_history.BackColor = Color.White;
                btn_night.BackColor = Color.White;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            calc window_calc = new calc();
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            Type_customer.type = "a";
            calc window_calc = new calc();
            window_calc.txt_numMem.Enabled = false;
            window_calc.txt_numMem.BackColor = Color.Black;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            Type_customer.type = "p";
            calc window_calc = new calc();
            window_calc.txt_numMem.Enabled = false;
            window_calc.txt_numMem.BackColor = Color.Black;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            Type_customer.type = "b";
            calc window_calc = new calc();
            window_calc.txt_numMem.Enabled = false;
            window_calc.txt_numMem.BackColor = Color.Black;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_cost_Click(object sender, EventArgs e)
        {
            cost cost = new cost();
            this.Hide();
            cost.ShowDialog();
            cost.Close();
            this.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            History history = new History();
            this.Hide();
            history.ShowDialog();
            history.Close();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
