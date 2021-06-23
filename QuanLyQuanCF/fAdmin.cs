using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCF
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();

        BindingSource accountList = new BindingSource();

        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        #region methods

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodBUS.Instance.SearchFoodByName(name);

            return listFood;
        }
        void LoadData()
        {
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;

            LoadDateTimePickerBill();
            //LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadAccount();
            //LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountBUS.Instance.GetListAccount();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            //dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            //dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            //dtgvBill.DataSource = BillBUS.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void AddFoodBinding()
        {
            txtFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryBUS.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodBUS.Instance.GetListFood();
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountBUS.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountBUS.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountBUS.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountBUS.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        #endregion

        #region events
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmFoodPrice.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmFoodPrice.Value;

            EditAccount(userName, displayName, type);
        }


        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            ResetPass(userName);
        }


        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }


        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtSearchFoodName.Text);
        }
        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryBUS.Instance.GetCategoryByID(id);

                    cbxFoodCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbxFoodCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbxFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int categoryID = (cbxFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodBUS.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int categoryID = (cbxFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txtFoodID.Text);

            if (FoodBUS.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFoodID.Text);

            if (FoodBUS.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            //LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        #endregion              

        private void btnFristBillPage_Click(object sender, EventArgs e)
        {
            txtPageBill.Text = "1";
        }

        //private void btnLastBillPage_Click(object sender, EventArgs e)
        //{
        //    int sumRecord = BillBUS.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

        //    int lastPage = sumRecord / 10;

        //    if (sumRecord % 10 != 0)
        //        lastPage++;

        //    txtPageBill.Text = lastPage.ToString();
        //}

        //private void txtPageBill_TextChanged(object sender, EventArgs e)
        //{
        //    dtgvBill.DataSource = BillBUS.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txtPageBill.Text));
        //}

        //private void btnPrevioursBillPage_Click(object sender, EventArgs e)
        //{
        //    int page = Convert.ToInt32(txtPageBill.Text);

        //    if (page > 1)
        //        page--;

        //    txtPageBill.Text = page.ToString();
        //}

        //private void btnNextBillPage_Click(object sender, EventArgs e)
        //{
        //    int page = Convert.ToInt32(txtPageBill.Text);
        //    int sumRecord = BillBUS.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

        //    if (page < sumRecord)
        //        page++;

        //    txtPageBill.Text = page.ToString();
        //}

        private void fAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyQuanCafeDataSet2.USP_GetListBillByDateForReport' table. You can move, or remove it, as needed.
        }
    }
}
