using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_lab_6
{
    class CompositeSoldier : ISoldier
    {
        private List<ISoldier> soldiers = new List<ISoldier>();

        public void AddSoldier(ISoldier soldier)
        {
            soldiers.Add(soldier);
        }

        public void RemoveSoldier(ISoldier soldier)
        {
            soldiers.Remove(soldier);
        }

        public void ExecuteOrder(string order, ListBox listBox)
        {
            listBox.Items.Add($"Group executing order: {order}");
            foreach (var soldier in soldiers)
            {
                soldier.ExecuteOrder(order, listBox);
            }
        }
    }
}
