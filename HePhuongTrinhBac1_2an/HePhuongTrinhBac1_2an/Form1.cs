namespace HePhuongTrinhBac1_2an
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        /*
        private bool Kiemtraheso(string valHs, string message)
        {
            if (!double.TryParse(valHs, out _))
            {
                MessageBox.Show(message, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        return true;
        } 
        string a1 = txt_ai.Text.Trim();
        if(!Kiemtraheso(a1, "a1 Phai la so"))
        {
            return;
        }
        */
            private void calc_Click(object sender, EventArgs e)
        {
            string a1 = txt_a1.Text.Trim();
            string b1 = txt_b1.Text.Trim();
            string c1 = txt_c1.Text.Trim();
            string a2 = txt_a2.Text.Trim();
            string b2 = txt_b2.Text.Trim();
            string c2 = txt_c2.Text.Trim();
            if (!double.TryParse(a1, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return; 
            }
            else if (!double.TryParse(b2, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return;
            }
            else if (!double.TryParse(c2, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return;
            }
            else if (!double.TryParse(c1, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return;
            }
            else if (!double.TryParse(b1, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return;
            }
            else if (!double.TryParse(a2, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return;
            }
            else
            {
                double val_a1 = Convert.ToDouble(a1);
                double val_b1 = Convert.ToDouble(b1);
                double val_c1 = Convert.ToDouble(c1);
                double val_a2 = Convert.ToDouble(a2);
                double val_b2 = Convert.ToDouble(b2);
                double val_c2 = Convert.ToDouble(c2);
                // định thức của ma trận các hệ số 
                double det = (val_a1 * val_b2) - (val_b1 * val_a2);
                double det_x = (val_c1 * val_b2) - (val_c2 * val_b1);
                double det_y = (val_a1 * val_c2) - (val_a2 * val_c1);
                if (det == 0)
                {
                    if (det_x == 0 && det_y == 0)
                    {
                        string vsn = "Vô số nghiệm";
                        txt_x.Text = vsn;
                        txt_y.Text = vsn;
                        return;
                    }
                    else
                    {
                        string vn = "Vô nghiệm";
                        txt_y.Text = vn;
                        txt_x.Text = vn;
                        return ;
                    }                   
                }
                else
                {
                    double x = (det_x / det);
                    double y = (det_y / det);
                    txt_x.Text = Convert.ToString(x);
                    txt_y.Text = Convert.ToString(y);
                    return;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_a1.Clear();
            txt_a2.Clear();
            txt_c1.Clear();
            txt_c2.Clear();
            txt_x.Clear();
            txt_y.Clear();
            txt_b1.Clear();
            txt_b2.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muón thoát không ?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {

        }
    }
}
