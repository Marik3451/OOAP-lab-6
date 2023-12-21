using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_lab_6
{
    public partial class Form1 : Form
    {
        private ISoldier soldier1, soldier2, soldier3;
        private CompositeSoldier group1, group2;

        public Form1()
        {
            InitializeComponent();
            InitializeSoldiersAndGroups();
        }

        private void InitializeSoldiersAndGroups()
        {
            soldier1 = new SimpleSoldier("Soldier 1");
            soldier2 = new SimpleSoldier("Soldier 2");
            soldier3 = new SimpleSoldier("Soldier 3");

            group1 = new CompositeSoldier();
            group1.AddSoldier(soldier1);
            group1.AddSoldier(soldier2);

            group2 = new CompositeSoldier();
            group2.AddSoldier(group1);
            group2.AddSoldier(soldier3);

        }

        private void btnSoldier1_Click(object sender, EventArgs e)
        {
            soldier1.ExecuteOrder("March forward", listBox1);
        }

        private void btnSoldier2_Click(object sender, EventArgs e)
        {
            soldier2.ExecuteOrder("March forward", listBox1);
        }

        private void btnSoldier3_Click(object sender, EventArgs e)
        {
            soldier3.ExecuteOrder("March forward", listBox1);
        }

        private void btnGroup1_Click(object sender, EventArgs e)
        {
            group1.ExecuteOrder("March forward", listBox1);
        }

        private void btnGroup2_Click(object sender, EventArgs e)
        {
            group2.ExecuteOrder("March forward", listBox1);
        }
    }

}
