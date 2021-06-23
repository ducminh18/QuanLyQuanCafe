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
    public class MenuBUS
    {
        private static MenuBUS instance;

        public static MenuBUS Instance
        {
            get { if (instance == null) instance = new MenuBUS(); return MenuBUS.instance; }
            private set { MenuBUS.instance = value; }
        }

        private MenuBUS() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            return MenuDAO.Instance.GetListMenuByTable(id);
        }
    }
}
