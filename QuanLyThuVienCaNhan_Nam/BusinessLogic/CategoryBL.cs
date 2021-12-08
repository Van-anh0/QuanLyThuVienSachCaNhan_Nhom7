using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;



namespace BusinessLogic
{
    public class CategoryBL
    {
        CategoryDA categoryDA = new CategoryDA();
        public List<Category> GetAll()
        {
            return categoryDA.GetAll() ;
        }

    }
}
