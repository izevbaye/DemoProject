using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DemoProject.DataContext;
using DemoProject.Models.Shops;
using DemoProject.Models.Security;
using DemoProject.Models.Shops.Work;

namespace DemoProject.Services.Shops
{
    // private readonly IWebHostEnvironment he;
   
    public interface IBasket // Loose coupling
    {

 

        List<Tbl_Shopping_Basket> ReadAll();
        void Create(Tbl_Shopping_Basket car);
        Tbl_Shopping_Basket Read(int id);
        void Update(W_S_Basket_Update model, Security_Authentication model2);
        void Delete(W_S_Basket_Delete model, Security_Authentication model2);
    }
    public class BasketService : IBasket
    {
        private readonly IMemoryCache _cache;
        private readonly MyDataContext _context;
        public BasketService(IMemoryCache cache, MyDataContext context)
        {
            _cache = cache;

            _context = context;
        }

        public void Create(Tbl_Shopping_Basket car)
        {
            throw new NotImplementedException();
        }

        public void Delete(W_S_Basket_Delete model, Security_Authentication model2)
        {
            var output = new SqlParameter();
            output.ParameterName = "@return";
            output.SqlDbType = SqlDbType.Int;
            output.Direction = ParameterDirection.Output;

            var output123 = 12;
            //  output123 = int.Parse(output123);

            _context.Database.ExecuteSqlRawAsync(
        "EXEC [USP_Shops_Tbl_Shopping_Basket3]{0}, {1}, {2}", model.Username, model.ProductID, output123);


            return;
        }

        public Tbl_Shopping_Basket Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tbl_Shopping_Basket> ReadAll()
        {
            throw new NotImplementedException();
        }

        public   void Update(W_S_Basket_Update model, Security_Authentication model2)
        {


            var output = new SqlParameter();
            output.ParameterName = "@return";
            output.SqlDbType = SqlDbType.Int;
            output.Direction = ParameterDirection.Output;

            var output123 = 12;
            //  output123 = int.Parse(output123);

             _context.Database.ExecuteSqlRawAsync(
            "EXEC [USP_Shops_Tbl_Shopping_Basket_Update]{0}, {1}, {2},{3}", model.Username, model.BasketID, model.Quantity, output123);


            return;



        }
    }
    }
