using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarbleSystemApp
{
    class lueClass
    {
        public static void setDataSource(LookUpEdit lue, object data_source, string value_member, string display_member, bool show_value_column)
        {
            lue.Font = new System.Drawing.Font("Cairo", 10);
            lue.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 10);
            lue.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cairo", 10);
            lue.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cairo", 10);
            lue.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cairo", 10);
            lue.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cairo", 10);
            lue.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cairo", 10);
            lue.Properties.DisplayMember = display_member;
            lue.Properties.ValueMember = value_member;
            lue.Properties.DataSource = data_source;
            lue.Properties.ShowFooter = false;
            lue.Properties.ShowHeader = false;
            lue.Properties.PopulateColumns();
            lue.Properties.Columns[value_member].Visible = show_value_column;
        }

    }
}
