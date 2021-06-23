using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;


        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return instance; }
            private set { instance = value; }
        }

        private AccountBUS() { }

        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            return AccountDAO.Instance.UpdateAccount(userName, displayName, pass, newPass);
        }

        public DataTable GetListAccount()
        {
            return AccountDAO.Instance.GetListAccount();
        }

        public Account GetAccountByUserName(string userName)
        {
            return AccountDAO.Instance.GetAccountByUserName(userName);
        }

        public bool InsertAccount(string name, string displayName, int type)
        {
            return AccountDAO.Instance.InsertAccount(name, displayName, type);
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            return AccountDAO.Instance.UpdateAccount(name, displayName, type);
        }

        public bool DeleteAccount(string name)
        {
            return AccountDAO.Instance.DeleteAccount(name);
        }

        public bool ResetPassword(string name)
        {
            return AccountDAO.Instance.ResetPassword(name);
        }
    }
}
