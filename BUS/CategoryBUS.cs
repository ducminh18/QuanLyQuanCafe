using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.BUS
{
    public class CategoryBUS
    {
        private static CategoryBUS instance;

        public static CategoryBUS Instance
        {
            get { if (instance == null) instance = new CategoryBUS(); return CategoryBUS.instance; }
            private set { CategoryBUS.instance = value; }
        }

        private CategoryBUS() { }

        public List<Category> GetListCategory()
        {
            return CategoryDAO.Instance.GetListCategory();
        }

        public Category GetCategoryByID(int id)
        {
            return CategoryDAO.Instance.GetCategoryByID(id);
        }
    }
}
