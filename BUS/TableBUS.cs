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
    public class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get { if (instance == null) instance = new TableBUS(); return TableBUS.instance; }
            private set { TableBUS.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private TableBUS() { }

        public void SwitchTable(int id1, int id2)
        {
            TableDAO.Instance.SwitchTable(id1, id2);
        }

        public List<Table> LoadTableList()
        {
            return TableDAO.Instance.LoadTableList();
        }
    }
}
