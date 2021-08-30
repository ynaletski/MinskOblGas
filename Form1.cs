using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_reader_for_MinskOblGas
{
    public partial class DatabaseReader : Form
    {
        public DatabaseReader()
        {
            InitializeComponent();
            comboBoxObject.SelectedIndex = 0;
            comboBoxSensorNumber.SelectedIndex = 0;
        }

        private void DatabaseReader_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1200, 750);
        }
    }
}
