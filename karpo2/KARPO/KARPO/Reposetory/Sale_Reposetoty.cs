using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARPO.Reposetory
{
    interface sale_Reposetory
    {
        double selectRow(string name, string type);
        bool delate(double ID);
        bool insertNew(string name,double quantity,string type,double price, double total, string bil_number);
        bool update(double id, string name, string type, double sale, double price);
        DataTable selectAllByBillNumber(string bill_no);
        DataTable selectAllByDate(string date);
        bool updateStock(string name,string  type, double seale);
        double selectAllPriceByDate(string date);
    }
}
