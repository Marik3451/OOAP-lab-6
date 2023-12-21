using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_lab_6
{
    interface ISoldier
    {
        void ExecuteOrder(string order, ListBox listBox);
    }

}
