using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
   public class BorrowerBL
    {
        BorrowerDA borrowerDA = new BorrowerDA();
        public int ThemBanDoc(Borrower borrower)
        {
           return borrowerDA.ThemBD(borrower);
        }

        public int SuaBanDoc(Borrower borrower)
        {
            return borrowerDA.SuaBD(borrower);
        }

    }
}
