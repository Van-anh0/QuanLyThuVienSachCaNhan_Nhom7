using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MuonTra
    {
        public int ID { get; set; }
        public int MaSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public MuonTra()
        {

        }
        public MuonTra(int id, int maSach,DateTime ngayMuon, DateTime ngayTra)
        {
            ID = id;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }
    }
}
