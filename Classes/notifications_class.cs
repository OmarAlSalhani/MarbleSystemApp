using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OmarMessageBox.Enums;

namespace MarbleSystemApp
{
    class notifications_class
    {
        public static void success(string ar)
        {
            OmarNotifications.Alert.ShowSucess(ar);
        }
        public static void error(string ar)
        {
            OmarNotifications.Alert.ShowError(ar);
        }
        public static void info(string ar)
        {
            OmarNotifications.Alert.ShowInformation(ar);
        }
        public static MessageResult yes_no()
        {
            OmarMessageBox.OmarMessageClass.NoText = "لا";
            OmarMessageBox.OmarMessageClass.YesText = "نعم";

            return OmarMessageBox.OmarMessageClass.ShowMessage("رسالة معلومات", "هل أنت متأكد ؟", MessageButton.YesNo, MessageImage.INFORMATION);
        }
        public static void ok(string ar)
        {
            OmarMessageBox.OmarMessageClass.OKText = "حسناً";
            OmarMessageBox.OmarMessageClass.ShowMessage("رسالة معلومات", ar, MessageButton.OK, MessageImage.INFORMATION);

        }
    }
}
