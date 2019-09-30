using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace EmployeeReportBL.PropertyGrid
{
    public class PaysDropDownEditor : UITypeEditor
    {
        /// <summary>
        /// Реализация метода редактирования
        /// </summary>
        public override Object EditValue(ITypeDescriptorContext context, IServiceProvider provider, Object value)
        {
            if ((context != null) && (provider != null))
            {
                // Access the Property Browser's UI display service
                IWindowsFormsEditorService svc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

                if (svc != null)
                {
                    //var payControl = new PayControl<List<string>>();
                    //payControl.Tag = svc;
                    //svc.DropDownControl(payControl);

                    //value = ReportSettings.settings.OtherIncentivePayments;

                    var payList = new PayControl((PayList)value);
                    payList.Tag = svc;
                    svc.DropDownControl(payList);

                    value = payList.PayList;
                }
            }

            return base.EditValue(context, provider, value);
        }

        /// <summary>
        /// Возвращаем стиль редактора - выпадающее окно
        /// </summary>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context != null)
                return UITypeEditorEditStyle.DropDown;
            else
                return base.GetEditStyle(context);
        }
    }
}