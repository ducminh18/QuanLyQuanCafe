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
    public class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get { if (instance == null) instance = new FoodBUS(); return FoodBUS.instance; }
            private set { FoodBUS.instance = value; }
        }

        private FoodBUS() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            return FoodDAO.Instance.GetFoodByCategoryID(id);
        }

        public List<Food> GetListFood()
        {
            return FoodDAO.Instance.GetListFood();
        }

        public List<Food> SearchFoodByName(string name)
        {

            return FoodDAO.Instance.SearchFoodByName(name);
        }

        public bool InsertFood(string name, int id, float price)
        {
            return FoodDAO.Instance.InsertFood(name, id, price);
        }

        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            return FoodDAO.Instance.UpdateFood(idFood, name, id, price);
        }

        public bool DeleteFood(int idFood)
        {
            return FoodDAO.Instance.DeleteFood(idFood);
        }
    }
}
