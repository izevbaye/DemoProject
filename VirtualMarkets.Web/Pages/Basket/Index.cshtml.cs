using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoProject.DataContext;
using DemoProject.Models.Security;
using DemoProject.Models.Shops;
using DemoProject.Models.Shops.Work;
using DemoProject.Services.Shops;

namespace DemoProject.Web.Pages.Basket
{
    public class IndexModel : PageModel
    {
        private readonly MyDataContext _context;
        //   private readonly MyDataContext _dbcontext;
        // private readonly ICarService _carService;
        private readonly IBasket _Ibasket;
        public string Message { get; set; }

        public IndexModel(MyDataContext context, IBasket Ibasket)//, MyDataContext dbcontext)
        {
            _context = context;
            // _dbcontext = dbcontext;
            _Ibasket = Ibasket;
        }

        public IList<Tbl_Shopping_Basket> Tbl_Shopping_Basket { get; set; }

        public async Task OnGetAsync()
        {

            //var user = "ehi";
            //Tbl_Shopping_Basket = await  _context.Tbl_Shopping_Basket
            //    .FromSqlRaw<Tbl_Shopping_Basket>("USP_Select_Shops_Basket {0}", user)
            //    .ToListAsync();

            try
            {

                Tbl_Shopping_Basket = await _context.Tbl_Shopping_Basket
                  //  .Include(t => t.Tbl_Products)
                    // .ThenInclude( x => x.Tbl_Products_BulkPurchase)
                    // .Include(x => x.Tbl_Products_BulkPurchase)
                   // .Where(c => c.IsCompleted)
                    .ToListAsync();
            }catch (Exception err)
            { Message = err.Message.ToString(); }
        }


     

        //public void OnPost()
        //{
        //    Message = "Post used";
        //}

        //[Route("Cart")]
        //[Route("Basket")]
        //public async Task OnPostAsync()
        //{
        //    var message = new
        //    {
        //        thea = "Ehi Likes Thea, and even though she pretends. She likes Ehi a lot <3"
        //    };
        //    return new JsonResult(message);//https://stackoverflow.com/questions/4074199/jquery-ajax-calls-and-the-html-antiforgerytoken
        //}


        public JsonResult OnPostAsync(W_S_Basket_Update model, Security_Authentication m2, Work_Shopping_Basket m1)
        {
            Message = "Get used";
            //var message = "User: " + data.Username + " Password: " + data.ProductID;
            // Message = await Message.ToString();
            // return (message);
            m2.IP = "192";
            m2.Authentication = "I love Thea";
            m2.Platform = "web";
            model.Username = "Ehi";




            try
            {
                _Ibasket.Update(model, m2);
            }
            catch (Exception err)
            { var e = err.Message.ToString(); }
            if (ModelState.IsValid)
            {


            }
            var message = new
            {
                thea = "Ehi Likes Thea, and even though she pretends. She likes Ehi a lot <3"
            };
            return new JsonResult(Message);
        }
        //public void OnGet()
        //{
        //}
    }
}
