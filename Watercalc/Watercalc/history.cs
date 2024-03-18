using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static Watercalc.Main_interface;

namespace Watercalc
{
    public partial class History : Form
    {
        //Truyền dữ liệu từ calc vào history
        public void data_transm(string theName, int theIndex, double theConsump, double theMoney)
        {
            dataGrid.Rows.Add(theIndex, theName, theConsump, theMoney);
        }

        public History()
        {
            InitializeComponent();
            if (night.nightmode)
            {
                ForeColor = Color.White;
                this.BackColor = Color.Black;
                btn_exit.BackColor = Color.Black;
                dataGrid.ForeColor = Color.Black;
            }
            if (!night.nightmode)
            {
                this.BackColor = SystemColors.Control;
                btn_exit.BackColor = Color.White;
                ForeColor = Color.Black;
                dataGrid.ForeColor = Color.Black;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
