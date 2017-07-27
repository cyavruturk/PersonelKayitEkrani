using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_odev2
{
    class HelperTemizle
    {
        public void temizle(Control pertemizle)
        {
            foreach (Control tmz in pertemizle.Controls)
            {
                if (tmz is TextBox)
                {
                    TextBox txt = (TextBox)tmz;
                    txt.Clear();

                }
            }

        }
    }
}
