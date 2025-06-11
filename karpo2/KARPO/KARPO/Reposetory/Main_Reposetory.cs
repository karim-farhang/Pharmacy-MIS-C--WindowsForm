using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KARPO.Reposetory
{
    interface stock_Reposetooty
    {
        bool insert(string name, double quntity, string type, double price , string expire_date, string import_date);
        bool delate(double id);
        bool update(string name, double quntity, string type,double price, string expire_date, string import_date, double id);
       
        DataTable selectAll();
       // string getExpire_date(string name,string type);
        DataTable serach(string paramter);
       
    }
}
