using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace A1
{
    public partial class Form1 : Form
    {
        ArrayList arrayList;
        public Form1()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f_name = textBox1.Text;
            string l_name = textBox2.Text;
            if (!string.IsNullOrEmpty(f_name) && !string.IsNullOrEmpty(l_name))
            {
                label3.Text = f_name + " " + l_name;
            }
            else
            {
                label3.Text = "fill the field";
                return;
            }
            bool check = checkBox1.Checked;
            string sub = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            if (check)
            {
                sub = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";

                if (!string.IsNullOrEmpty(sub))
                {
                    // Check if the item is already in the ListBox.
                    if (!listBox1.Items.Contains(sub))
                    {
                        listBox1.Items.Add(sub);
                        arrayList.Add(sub);
                    }
                    else
                    {
                        MessageBox.Show("Item is already in the list.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    return;
                }
            }

            else
            {
                label3.Text = "Please checked first to add";
                return;
            }

        }
    }
}
