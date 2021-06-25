using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Activity4
{
    class ChildClass
    {
        public static void CheckMdiChildren(Form form)
        {
            foreach (Form frm in Form1.ActiveForm.MdiChildren)
            {
                if (frm.GetType() == form.GetType())    
                {
                    frm.Focus();
                    return;
                } 
            }
            form.MdiParent = Form1.ActiveForm;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
