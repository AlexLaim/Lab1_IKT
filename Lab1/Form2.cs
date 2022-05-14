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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormOrganaizer.edit == false)
            {
                DateTime date = monthCalendar1.SelectionStart;
                FormOrganaizer.rows.Add(new string[] { string.Format("{0}.{1}.{2}", date.Day, date.Month, date.Year), dateTimePicker1.Text, textBox1.Text, comboBox1.Text });
                
                this.Close();

            }
            else
            {
                foreach (var row in FormOrganaizer.rows)
                {
                    if (row[0] == FormOrganaizer.Item)
                    {
                        int index = FormOrganaizer.rows.IndexOf(row);
                        DateTime date = monthCalendar1.SelectionStart;
                        FormOrganaizer.rows[index] = (new string[] { string.Format("{0}.{1}.{2}", date.Day, date.Month, date.Year), dateTimePicker1.Text, textBox1.Text, comboBox1.Text });
                        FormOrganaizer.edit = false;
                        break;

                    }
                }
                this.Close();
            }
        }

      
    }
}
