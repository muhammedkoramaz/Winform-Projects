using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.Extentions
{
    public static class FormExtentions
    {
        /// <summary>
        /// Formlar arasında geçiş yaparken biri açık ise onu minimize edip diğerini maximize eden extention method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parentForm"></param>
        public static void MinimizeAndShowChildForm<T>(this Form parentForm) where T : Form, new()
        {
            var childForm = parentForm.MdiChildren.FirstOrDefault(f => f is T);

            if (childForm == null)
            {
                childForm = new T
                {
                    MdiParent = parentForm,
                    WindowState = FormWindowState.Maximized
                };
            }

            childForm.WindowState = FormWindowState.Minimized;
            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized;
        }
    }
}
