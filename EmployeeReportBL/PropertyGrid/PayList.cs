using System;
using System.Collections.Generic;

namespace EmployeeReportBL.PropertyGrid
{
    [Serializable]
    public class PayList
    {
        private List<string> payList;

        public PayList() 
        {
            payList = new List<string>();
        }

        public PayList(List<string> payList)
        {
            this.payList = payList ?? new List<string>();
        }

        public List<string> PayLists
        {
            get { return payList; }
            set { payList = value; }
        }

        public override string ToString()
        {
            string pay = string.Empty;

            foreach (var item in payList)
            {
                pay += $"{item}; ";
            }

            return pay;
        }
    }
}
