using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARPO.Reposetory
{
    interface Financial_Reposetory
    {
        DataTable selectAll();
        DataTable selectBillNumber(string bull_number);
        DataTable getBillNumberByDate(string date);
        DataTable getBillNumberByDate(string start  , string end);
        DataTable selectRange(string startDate, string endDate);
        DataTable selectThisDate(string Date);
        DataTable selectThisBill(string Bill);
        DataTable serach(string paramter, string date);
        double totalPrice(string bull_number);
        DataTable getQuarry();
        double totalRange();

    }
}
