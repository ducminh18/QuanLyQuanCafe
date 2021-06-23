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
    public class BillBUS
    {
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return BillBUS.instance; }
            private set { BillBUS.instance = value; }
        }

        private BillBUS() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            return BillDAO.Instance.GetUncheckBillIDByTableID(id);
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            BillDAO.Instance.CheckOut(id, discount, totalPrice);
        }
        public void InsertBill(int id)
        {
            BillDAO.Instance.InsertBill(id);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        public DataTable GetBillListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            return BillDAO.Instance.GetBillListByDateAndPage(checkIn, checkOut, pageNum);
        }

        public int GetNumBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return BillDAO.Instance.GetNumBillListByDate(checkIn, checkOut);
        }

        public int GetMaxIDBill()
        {
            return BillDAO.Instance.GetMaxIDBill();
        }
    }
}
