
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;

namespace Web_Shoes.Controllers
{
    public class TestController : Controller
    {

        private readonly ApplicationDbContext _context;


        private readonly ISendMailService _sendMailService;
        public TestController(ApplicationDbContext context, ISendMailService sendMailService)
        {
            _context = context;
            _sendMailService = sendMailService;
        }


        //[Route("/test")]
        //[HttpGet]
        //public IActionResult Index()
        //{

        //    return View();
        //}


        [Route("/test")]
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            //List product
            List<Products> productsLists = new List<Products>();

            productsLists.Add(new Products() {
                pd_Name = "Product 1",
                pd_Size = "L",
                pd_Color = "Red",
                pd_Id = 1,
                pd_Price = 100
            });

            productsLists.Add(new Products()
            {
                pd_Name = "Product 2",
                pd_Size = "L",
                pd_Color = "Red",
                pd_Id = 1,
                pd_Price = 100
            });

            productsLists.Add(new Products()
            {
                pd_Name = "Product 3",
                pd_Size = "L",
                pd_Color = "Red",
                pd_Id = 1,
                pd_Price = 100
            });



            //Confirm Mail
            string MailTo = "thaibao0225@gmail.com";
            string Subject = "Order Confirm #111";
            

            MailContent content = new MailContent
            {
                To = MailTo,
                Subject = Subject,
                Body = "<div><div><center> <h2> Order confirmation #1111 </h2> </center></div><div><table class='table'><tr><th>Name:</th>" +
                "<td>Name</td></tr><tr><th>Phone:</th><td>0123456789</td></tr><tr><th>Address:</th><td>HCM,1223.</td></tr><tr><th>Email:</th>" +
                "<td>email@gmail.com</td></tr><tr><th>Price:</th><td>2000$</td></tr></table></div>" +
                "<div><table cellpadding=\"0\" cellspacing=\"0\" width=\"700\" align=\"left\" border=\"1\" ><thead><tr><th scope=\"col\">Name</th><th scope=\"col\">Size</th><th scope=\"col\">Color</th>" +
                "<th scope=\"col\">Amount</th><th scope=\"col\">Price</th></tr></thead><tbody><tr><td>Name1</td><td>Size1</td><td>Color1</td><td>Amount1</td>" +
                "<td>Price1</td></tr><tr><td colspan=\"3\"></td><td>Ship:</td><td>1$</td></tr><tr><td colspan=\"3\"></td><tr><td colspan=\"3\"></td><td>Sum Price:</td>" +
                "<td>2000$</td></tr></tbody></table></div>" +
                "</div>" 
            };

            await _sendMailService.SendMail(content);
            return View();
        }



    }


    

}


