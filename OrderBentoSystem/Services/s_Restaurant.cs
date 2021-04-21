using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBentoSystem.Services
{
    public class s_Restaurant : Entities
    {
        private List<Proc_GetRestaurant_Result> List_Restaurant = null;
        private List<Proc_GetFood_Result> List_Menu = null;
        public List<Proc_GetRestaurant_Result> list_Restaurant
        {
            get => this.List_Restaurant;
            set => this.List_Restaurant = value;
        }
        public List<Proc_GetFood_Result> list_Menu
        {
            get => this.List_Menu;
            set => this.List_Menu = value;
        }
        // 存放篩選後的菜單
        public List<Proc_GetFood_Result> Filter_Mune = null;
        // 存放選擇的資料(靜態?
        public static Proc_GetRestaurant_Result Select_Restaurant = null;
        public static Proc_GetFood_Result Select_Menu = null;
        // UI的下拉式修改資料要跟著調整選擇的資料
        // 餐廳資料
        public void setSelectClass(int Index)
        {
            Select_Restaurant = List_Restaurant[Index];
        }
        // 食物資料
        public void setSelectStudent(int Index)
        {
            Select_Menu = Filter_Mune[Index];
        }
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <returns></returns>
        public rMessage GetInfo()
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 取得餐廳資料
                var temp_Restaurant = context.Proc_GetRestaurant("");
                // 轉換List
                List_Restaurant = temp_Restaurant.ToList();

                // 取得食物資料
                var temp_Menu = context.Proc_GetFood("");
                List_Menu = temp_Menu.ToList();

                msgInfo.isSuccess = true;
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "查詢餐廳與菜單發生錯誤!!";
            }
            return msgInfo;
        }
        /// <summary>
        /// 輸出餐廳
        /// </summary>
        /// <returns></returns>
        public List<string> OutPutRestaurant()
        {
            List<string> data = new List<string>();
            foreach (var Restaurant in List_Restaurant)
            {
                data.Add(Restaurant.Res_Name);
            }
            return data;
        }
        /// <summary>
        /// 輸出菜單
        /// </summary>
        /// <returns></returns>
        public List<string> OutPutMenu()
        {
            List<string> data = new List<string>();
            Filter_Mune = List_Menu.Where(r => r.Res_Code == Select_Restaurant.Res_Code).ToList();
            // 這邊需要特別去判斷所選班級 (管理值需要篩選)
            foreach (var item in Filter_Mune)
            {
                data.Add(item.Res_Name);
            }
            return data;
        }
    }
}
