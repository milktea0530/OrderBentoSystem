//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderBentoSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OrderBentoSystemEntities : DbContext
    {
        public OrderBentoSystemEntities()
            : base("name=OrderBentoSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Additional> Additional { get; set; }
        public virtual DbSet<ClassInfo> ClassInfo { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<OnDutyInfo> OnDutyInfo { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<StudentInfo> StudentInfo { get; set; }
        public virtual DbSet<Sys_Account> Sys_Account { get; set; }
    
        public virtual ObjectResult<Proc_GetAdditional_Result> Proc_GetAdditional(string a_Code)
        {
            var a_CodeParameter = a_Code != null ?
                new ObjectParameter("A_Code", a_Code) :
                new ObjectParameter("A_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetAdditional_Result>("Proc_GetAdditional", a_CodeParameter);
        }
    
        public virtual ObjectResult<Proc_GetClass_Result> Proc_GetClass(string c_Code)
        {
            var c_CodeParameter = c_Code != null ?
                new ObjectParameter("C_Code", c_Code) :
                new ObjectParameter("C_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetClass_Result>("Proc_GetClass", c_CodeParameter);
        }
    
        public virtual ObjectResult<Proc_GetFood_Result> Proc_GetFood(string r_Code)
        {
            var r_CodeParameter = r_Code != null ?
                new ObjectParameter("R_Code", r_Code) :
                new ObjectParameter("R_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetFood_Result>("Proc_GetFood", r_CodeParameter);
        }
    
        public virtual ObjectResult<Proc_GetOnDuty_Result> Proc_GetOnDuty(string c_Code, string s_Code, string onDutyDate)
        {
            var c_CodeParameter = c_Code != null ?
                new ObjectParameter("C_Code", c_Code) :
                new ObjectParameter("C_Code", typeof(string));
    
            var s_CodeParameter = s_Code != null ?
                new ObjectParameter("S_Code", s_Code) :
                new ObjectParameter("S_Code", typeof(string));
    
            var onDutyDateParameter = onDutyDate != null ?
                new ObjectParameter("OnDutyDate", onDutyDate) :
                new ObjectParameter("OnDutyDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetOnDuty_Result>("Proc_GetOnDuty", c_CodeParameter, s_CodeParameter, onDutyDateParameter);
        }
    
        public virtual ObjectResult<Proc_GetOrder_Result> Proc_GetOrder(string o_Number)
        {
            var o_NumberParameter = o_Number != null ?
                new ObjectParameter("O_Number", o_Number) :
                new ObjectParameter("O_Number", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetOrder_Result>("Proc_GetOrder", o_NumberParameter);
        }
    
        public virtual ObjectResult<Proc_GetODStatistics_Result> Proc_GetODStatistics(string o_Number)
        {
            var o_NumberParameter = o_Number != null ?
                new ObjectParameter("O_Number", o_Number) :
                new ObjectParameter("O_Number", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetODStatistics_Result>("Proc_GetODStatistics", o_NumberParameter);
        }
    
        public virtual ObjectResult<Proc_GetOrderDetail_Result> Proc_GetOrderDetail(string o_Number, string res_Code)
        {
            var o_NumberParameter = o_Number != null ?
                new ObjectParameter("O_Number", o_Number) :
                new ObjectParameter("O_Number", typeof(string));
    
            var res_CodeParameter = res_Code != null ?
                new ObjectParameter("Res_Code", res_Code) :
                new ObjectParameter("Res_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetOrderDetail_Result>("Proc_GetOrderDetail", o_NumberParameter, res_CodeParameter);
        }
    
        public virtual ObjectResult<Proc_GetStudent_Result> Proc_GetStudent(string c_Code, string s_Code)
        {
            var c_CodeParameter = c_Code != null ?
                new ObjectParameter("C_Code", c_Code) :
                new ObjectParameter("C_Code", typeof(string));
    
            var s_CodeParameter = s_Code != null ?
                new ObjectParameter("S_Code", s_Code) :
                new ObjectParameter("S_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetStudent_Result>("Proc_GetStudent", c_CodeParameter, s_CodeParameter);
        }
    
        public virtual ObjectResult<Proc_GetRestaurant_Result> Proc_GetRestaurant(string r_Code)
        {
            var r_CodeParameter = r_Code != null ?
                new ObjectParameter("R_Code", r_Code) :
                new ObjectParameter("R_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetRestaurant_Result>("Proc_GetRestaurant", r_CodeParameter);
        }
    
        public virtual int Proc_UpdateFood(string foodName, Nullable<decimal> foodPrice, string add_Code, string foodCode)
        {
            var foodNameParameter = foodName != null ?
                new ObjectParameter("FoodName", foodName) :
                new ObjectParameter("FoodName", typeof(string));
    
            var foodPriceParameter = foodPrice.HasValue ?
                new ObjectParameter("FoodPrice", foodPrice) :
                new ObjectParameter("FoodPrice", typeof(decimal));
    
            var add_CodeParameter = add_Code != null ?
                new ObjectParameter("Add_Code", add_Code) :
                new ObjectParameter("Add_Code", typeof(string));
    
            var foodCodeParameter = foodCode != null ?
                new ObjectParameter("FoodCode", foodCode) :
                new ObjectParameter("FoodCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_UpdateFood", foodNameParameter, foodPriceParameter, add_CodeParameter, foodCodeParameter);
        }
    }
}
