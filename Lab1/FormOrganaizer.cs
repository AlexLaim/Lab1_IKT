using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab1
{
    public partial class FormOrganaizer : Form
    {
        // private List<string[]> rows;
        public static string filename = Directory.GetCurrentDirectory() + "\\data.txt";
        public static List<string[]> rows = new List<string[]>();
        public static List<string[]> finded = new List<string[]>();
        public static bool ToFind = false;
        public static bool edit = false;
        public static string Item;
        public static int RemoveItem;
        public FormOrganaizer()
        {           
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            using (StreamReader streamreader = new StreamReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                while (streamreader.Peek() > -1)
                {
                    rows.Add(streamreader.ReadLine().Split());                   
                }
            }
        }
        private void RefreshList(List<string[]> list)
        {
            lvTable.Items.Clear();
            foreach (string[] s in list)
            {
                lvTable.Items.Add(new ListViewItem(s));
            }
        }
        private void FormOrganaizer_Load(object sender, EventArgs e)
        {
            RefreshList(rows);

        }
        private void add_Click(object sender, EventArgs e)
        {
            
                AddForm form3 = new AddForm();
                form3.ShowDialog();
            
        }
        private void FormOrganaizer_Activated(object sender, EventArgs e)
        {
            if (ToFind)
               RefreshList(finded);
            else
                RefreshList(rows);
        }

        private void category_CheckedChanged(object sender, EventArgs e)
        {
            if (category.Checked && list.Text != string.Empty)
            {
                finded.Clear();
                foreach (string[] row in rows)
                {
                    if (row[3] == list.Text)
                    {
                        finded.Add(row);
                    }
                }
                RefreshList(finded);
            }
            if (category.Checked && list.Text == string.Empty)
            {
                events.Checked = true;
                MessageBox.Show(
                "Для начала выберите один из вариантов категории",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void events_CheckedChanged(object sender, EventArgs e)
        {          
            if (events.Checked)
            {
                RefreshList(rows);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category.Checked && list.Text != string.Empty)
            {
                finded.Clear();
                foreach (string[] row in rows)
                {
                    if (row[3] == list.Text)
                    {
                        finded.Add(row);
                    }
                }
                RefreshList(finded);
            }           
        }

        private void filter_Click(object sender, EventArgs e)
        {
            rows = (from row in rows
                    orderby row[0]
                    select row).ToList();
            RefreshList(rows);
            category.Checked = false;
            events.Checked = true;
        }

        private void find_Click(object sender, EventArgs e)
        {
            FindForm form3 = new FindForm();
            form3.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            edit = true;
            AddForm form3 = new AddForm();
            form3.ShowDialog();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            foreach (var row in rows)
            {
                if (row[0] == lvTable.FocusedItem.Text)
                {
                    int index = rows.IndexOf(row);
                    RemoveItem = index;
                    break;
                }
            }
            RemoveForm form5 = new RemoveForm();
            form5.ShowDialog();
            RefreshList(rows);
        }

      

        private void lvTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvTable.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                    Item = lvTable.FocusedItem.Text;
                }
            }
        }

        private void lvTable_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Delete)
                {
                    foreach (var row in rows)
                    {
                        if (row[0] == lvTable.FocusedItem.Text)
                        {
                            int index = rows.IndexOf(row);
                            RemoveItem = index;
                            break;
                        }
                    }
                    RemoveForm form5 = new RemoveForm();
                    form5.ShowDialog();
                    RefreshList(rows);
                }
                if (e.Control && e.KeyCode.Equals(Keys.S))
                {
                    using (StreamWriter streamwriter = new StreamWriter(filename, false))
                    {
                        for (int i = 0; i < rows.Count; i++)
                        {
                            string action = string.Join(" ", rows[i]);
                            streamwriter.WriteLine(action + " ");
                        }
                    }              
                    MessageBox.Show(
                    "Данные успешно сохранены!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                if (e.Control && e.KeyCode.Equals(Keys.O))
                {
                    Process.Start(filename);
                }
            }
            catch { }
        }
    }
}

