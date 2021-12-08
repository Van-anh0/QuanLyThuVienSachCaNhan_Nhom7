using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussinessLogic
{
    public class StatisticalBL
    {
       StatisticalDA statisticalDA = new StatisticalDA();

        public DataTable ThongKeTL()
        {
            return statisticalDA.TK_TheLoai();
        }
        
        public DataTable ThongKeTG()
        {
            return statisticalDA.TK_TacGia();
        }

        public DataTable ThongKeSM()
        {
            return statisticalDA.TK_SachMuon();
        }

        public DataTable ThongKeThoiGian()
        {
            return statisticalDA.TK_ThoiGian();
        }
    }
}
