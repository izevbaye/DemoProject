using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using DemoProject.DataContext;
using DemoProject.Models.Department;

namespace DemoProject.Services.Departments
{
    public interface IDepartment
    {
        List<Tbl_Departments> ReadAll();
        void Create(Tbl_Departments car);
        Tbl_Departments Read(int id);
        //void Update(W_S_Departments_Update model, Security_Authentication model2);
        //void Delete(W_S_Departments_Delete model, Security_Authentication model2);
    }
    public class DepartmentsService : IDepartment
    {
        private readonly IMemoryCache _cache;
        private readonly MyDataContext _context;
        public DepartmentsService(IMemoryCache cache, MyDataContext context)
        {
            _cache = cache;

            _context = context;
        }

        public void Create(Tbl_Departments car)
        {
            throw new NotImplementedException();
        }

        //public void Delete(W_S_Departments_Delete model, Security_Authentication model2)
        //{
        //    var output = new SqlParameter();
        //    output.ParameterName = "@return";
        //    output.SqlDbType = SqlDbType.Int;
        //    output.Direction = ParameterDirection.Output;

        //    var output123 = 12;
        //    //  output123 = int.Parse(output123);

        //    _context.Database.ExecuteSqlRawAsync(
        //"EXEC [USP_Shops_Tbl_Shopping_Departments3]{0}, {1}, {2}", model.Username, model.ProductID, output123);


        //    return;
        //}

        public Tbl_Departments Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tbl_Departments> ReadAll()
        {
            throw new NotImplementedException();
        }

        //public void Update(W_S_Departments_Update model, Security_Authentication model2)
        //{


        //    var output = new SqlParameter();
        //    output.ParameterName = "@return";
        //    output.SqlDbType = SqlDbType.Int;
        //    output.Direction = ParameterDirection.Output;

        //    var output123 = 12;
        //    //  output123 = int.Parse(output123);

        //    _context.Database.ExecuteSqlRawAsync(
        //   "EXEC [USP_Shops_Tbl_Shopping_Departments_Update]{0}, {1}, {2},{3}", model.Username, model.DepartmentsID, model.Quantity, output123);


           // return;



        }
   
}
