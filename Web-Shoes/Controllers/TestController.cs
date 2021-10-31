
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
            string IdOrder = "#1112";
            string MailTo = "thaibao0225@gmail.com";
            string Subject = "Order Confirm #111";
            string NameUser = "NameUser";
            string Phone = "0123456789";
            string Address = "HCM";
            string Email = "test@gmail.com";
            int Price = 2000;


            //"+ Price + "
            string productList ="";
            foreach (var item in productsLists)
            {
                productList += "<tr><td>" + item.pd_Name + "</td><td>" + item.pd_Size + "</td><td>" + item.pd_Color + "</td><td>" + item.pd_Rate + "</td><td>" + item.pd_Price + "</td></tr>";
            }


            string contentOfProductList = "<div><table cellpadding=\"0\" cellspacing=\"0\" width=\"700\" align=\"left\" border=\"1\" ><thead><tr><th> Name </th><th> Size </th><th> Color </th><th> Amount </th><th> Price </th></tr></thead><tbody> " +
                productList +
                "<tr><td colspan=\"3\"></td><td>Ship:</td><td>1$</td></tr><tr>"+
                "<td colspan=\"3\"></td><td>Discount:</td><td>5$</td></tr><tr>"+
                "<td colspan=\"3\"></td><td>Sum Price:</td><td>2000$</td></tr>"+
                "</tbody></table></div>";

            MailContent content = new MailContent
            {
                To = MailTo,
                Subject = Subject,
                Body = "<div><div><center> <h2> Order confirmation "+ IdOrder + "</h2> </center></div>" +
                "<div><table class='table'><tr><th>:</th>" +
                "<td>" + NameUser + "</td></tr><tr><th>Phone:</th><td>" + Phone + "</td></tr><tr><th>Address:</th><td>" + Address + "</td></tr><tr><th>Email:</th>" +
                "<td>" + Email + "</td></tr><tr><th>Price:</th><td>" + Price + "$ </td></tr></table></div>" +
                contentOfProductList +
                "</div>" 
            };

            await _sendMailService.SendMail(content);


            return View();
        }



    }


    

}


