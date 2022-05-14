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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label1.Text = $"Are you sure you want to delete the record: \n{FormOrganaizer.rows[FormOrganaizer.RemoveItem][0]} {FormOrganaizer.rows[FormOrganaizer.RemoveItem][1]} {FormOrganaizer.rows[FormOrganaizer.RemoveItem][2]} {FormOrganaizer.rows[FormOrganaizer.RemoveItem][3]}";
        }

        private void Yes_Click(object sender, EventArgs e)
        {
           FormOrganaizer.rows.RemoveAt(FormOrganaizer.RemoveItem);
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
