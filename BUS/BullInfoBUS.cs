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
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;

        public static BillInfoBUS Instance
        {
            get { if (instance == null) instance = new BillInfoBUS(); return BillInfoBUS.instance; }
            private set { BillInfoBUS.instance = value; }
        }

        private BillInfoBUS() { }

        public void DeleteBillInfoByFoodID(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(id);
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            return BillInfoDAO.Instance.GetListBillInfo(id);
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
        }
    }
}
