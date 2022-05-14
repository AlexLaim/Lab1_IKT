using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrganaizer.finded.Clear();
            foreach (string[] row in FormOrganaizer.rows)
            {
                if (row[1] == dateTimePicker1.Text)
                {
                    FormOrganaizer.finded.Add(row);
                }
            }
            FormOrganaizer.isNeedToFind = true;
            this.Close();
        }
    }
}
