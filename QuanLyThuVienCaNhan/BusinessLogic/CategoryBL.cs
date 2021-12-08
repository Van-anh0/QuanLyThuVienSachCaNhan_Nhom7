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
        public int ThemTL(Category category)
        {
            return categoryDA.Them_Xoa_Sua(category, 0);
        }
        public int Sua(Category category)
        {
            return categoryDA.Them_Xoa_Sua(category, 1);
        }
        public int Xoa(Category category)
        {
            return categoryDA.Them_Xoa_Sua(category, 2);
        }

    }
}
