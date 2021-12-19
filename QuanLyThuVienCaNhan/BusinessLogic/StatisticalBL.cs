using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class StatisticalBL
    {
        StatisticalDA statisticalDA = new StatisticalDA();

        public DataTable ThongKeTL()
        {
            return statisticalDA.TK_Category();
        }

        public DataTable ThongKeTG()
        {
            return statisticalDA.TK_Author();
        }

        public DataTable ThongKeSM()
        {
            return statisticalDA.TK_BorrowedBook();
        }

        public DataTable ThongKeThoiGian()
        {
            return statisticalDA.TK_Time();
        }

        public DataTable ThongTinMT(int maSach)
        {
            return statisticalDA.Get_MT(maSach);
        }
    }
}
