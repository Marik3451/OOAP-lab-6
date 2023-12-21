using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_lab_6
{
    class SimpleSoldier : ISoldier
    {
        private string name;

        public SimpleSoldier(string name)
        {
            this.name = name;
        }

        public void ExecuteOrder(string order, ListBox listBox)
        {
            MessageBox.Show($"{name}: {order}", "Order Execution");
            listBox.Items.Add($"{ name}: { order}");
        }
    }
}
