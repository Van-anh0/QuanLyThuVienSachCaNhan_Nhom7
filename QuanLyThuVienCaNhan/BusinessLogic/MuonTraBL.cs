using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
    public class MuonTraBL
    {
        MuonTraDA mtDA = new MuonTraDA();
        public int ThemMuon(int IdBD, int maSach, DateTime ngayMuon, DateTime ngayTra)
        {
            return mtDA.ThemMuon(IdBD, maSach, ngayMuon, ngayTra);
        }

        public int ThemTra(int IdBD, int maSach, DateTime ngayTra)
        {
            return mtDA.ThemTra(IdBD, maSach,ngayTra);
        }


    }
}
