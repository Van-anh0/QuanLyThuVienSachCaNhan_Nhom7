using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BanDoc
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public DateTime NgayMuon { get; set; }
        public BanDoc()
        {

        }
        public BanDoc (int id, string ten, string diaChi, string soDT, DateTime ngayMuon)
        {
            ID = id;
            Ten = ten;
            DiaChi = diaChi;
            SoDT = soDT;
            NgayMuon = ngayMuon;
        }
    }

}
