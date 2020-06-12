using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTTKeToan.utils
{
    public class ViewUtils
    {
        public static void setDefaulCbText(ComboBox comboBox, String text)
        {
            comboBox.Items.Add(text);
            comboBox.SelectedIndex = 0;
        }
    }
}
