using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Entity;
using Web_Fashion.Models;
using Web_Fashion.StatisFile;

namespace Web_Fashion.Controllers
{
    public class ProductDetailController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;


        string namePc = Environment.MachineName;

        string checkLogin;

        public ProductDetailController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;

        }




        [Route("/productdetail")]
        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {
  

            

            // cart 
            string countCart = HttpContext.Session.GetString(KeySession.cartHomeSession);
            ViewBag.cartCount = countCart;

            /// product detail 
            var productDetailQuery = _context.Products.FirstOrDefault(a => a.pd_Id == id);


            ViewBag.Id = productDetailQuery.pd_Id;
            ViewBag.Img1 = productDetailQuery.pd_Img1;
            ViewBag.Img2 = productDetailQuery.pd_Img2;
            ViewBag.Img3 = productDetailQuery.pd_Img3;
            ViewBag.Img4 = productDetailQuery.pd_Img4;

            ViewBag.NameProduct = productDetailQuery.pd_Name;
            ViewBag.Price = productDetailQuery.pd_Price;
            ViewBag.Rate = productDetailQuery.pd_Rate;
            ViewBag.ShortDescription = productDetailQuery.pd_ShortDescription;
            ViewBag.Description = productDetailQuery.pd_Description;
            ViewBag.Code = productDetailQuery.pd_Code;

            var review = from a in _context.AppUser
                         join b in _context.Reviews on a.Id equals b.review_UserId
                         join c in _context.ReviewInproduct on b.review_id equals c.rip_ReviewId
                         join d in _context.Products on c.rip_ProductId equals d.pd_Id
                         select new { a, b, c, d };

            var SubReview = from a in _context.AppUser
                            join b in _context.SubReview on a.Id equals b.subReview_UserId
                            join c in _context.SubReviewInReview on b.subReview_Id equals c.SRiR_SubReviewId
                            join d in _context.Reviews on c.SRiR_ReviewId equals d.review_id
                            select new { a, b, c, d };


            review = review.Where(x => x.d.pd_Id == id && x.b.review_HideStatus == false);

            review = review.OrderByDescending(a => a.b.review_UploadTime);

            var reviewQuery = review.Select(x => new ReviewModel()
            {
                // table Review
                review_id = x.b.review_id,
                review_UserId = x.a.Id,
                review_ProductId = x.d.pd_Id,
                review_Comment = x.b.review_Comment,
                review_UserName = x.a.UserName,
                review_UploadTime = x.b.review_UploadTime,

                review_CountSubReview = 1

            });

            SubReview = SubReview.Where(x => x.b.subReview_HideStatus == false);

            var subReviewQuery = SubReview.Select(x => new SubreviewModel()
            {
                subReview_Subid = x.b.subReview_Id,
                subReview_SubComment = x.b.subReview_Commnet,
                subReview_SubUserId = x.b.subReview_UserId,
                subReview_SubUploadTime = x.b.subReview_DateCommnet,
                subReview_UserName = x.a.UserName,
                subReview_ReviewId = x.d.review_id
            });

            List<ReviewModel> reviewAdd = new List<ReviewModel>();

            ViewBag.CountReview = reviewQuery.Count();

            //Query of Review
            foreach (var itemReview in reviewQuery)
            {

                List<SubreviewModel> subreviewAddList = new List<SubreviewModel>();
                //Query of SubReview
                foreach (var itemSubReview in subReviewQuery)
                {
                    //If SubReview In Review
                    if (itemReview.review_id == itemSubReview.subReview_ReviewId)
                    {
                        subreviewAddList.Add(itemSubReview);
                    }
                }

                itemReview.review_SubreviewModelList = subreviewAddList;
                itemReview.review_CountSubReview = subreviewAddList.Count();
                reviewAdd.Add(itemReview);
            }


            var reviewQuery1 = reviewAdd.Cast<ReviewModel>().ToArray();

            

            return View(reviewQuery1);
        }

        [Route("/productdetailadd")]
        [HttpGet("{productid}&{quantity}&{color}&{size}")]
        public IActionResult Productdetailadd(int productid, string quantity, string color, string size)
        {
            try
            {
                var userId = HttpContext.Session.GetString(KeySession.userIdSession);
                string cartId = HttpContext.Session.GetString(KeySession.cartIdSession);
                checkLogin = HttpContext.Session.GetString(KeySession.CheckLoginSession);

                int quantityProduct = Int16.Parse(quantity);
                if (checkLogin == "True")
                {

                    // Logined
                    //Query Proudct in User


                    var queryProductUser = from b in _context.Cart
                                       join c in _context.ProductInCart on b.cart_Id equals c.pic_CartId
                                       select new { b, c, };

                //check the same product
                queryProductUser = queryProductUser.Where(a => a.b.cart_Id == cartId
                    && a.c.pic_ProductId == productid
                    && a.c.pic_size == size
                    && a.c.pic_color == color
                    );

                int count = queryProductUser.Count();

                if (count == 0)
                {
                    //Create ProductInCart
                    var ProductInCartCreate = new ProductInCart()
                    {
                        pic_Id = Guid.NewGuid().ToString(),
                        pic_CartId = cartId,
                        pic_ProductId = productid,
                        pic_amount = quantityProduct,
                        pic_size = size,
                        pic_color = color
                    };
                    _context.ProductInCart.Add(ProductInCartCreate);
                }
                else
                {
                        try
                        {
                            string QueryCartId = "";
                            foreach (var item in queryProductUser)
                            {
                                QueryCartId = item.b.cart_Id;
                            }
                            var productInCartQuery = _context.ProductInCart.FirstOrDefault(a => a.pic_CartId == QueryCartId && a.pic_ProductId == productid);
                            productInCartQuery.pic_amount = productInCartQuery.pic_amount + quantityProduct;

                        }
                        catch
                        {

                            throw;
                        }

                    }

                }

                _context.SaveChanges();

                return Redirect("/cart");
            }
            catch
            {
                throw;
            }
        }

        [Route("/productcomment")]
        [HttpPost]
        public async Task<IActionResult> Comment()
        {

            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);

                string reviewId = Guid.NewGuid().ToString();
               

                string idproduct = Request.Form["idproduct"];
                if (Request.Form["comment"] != "")
                {
                    var reviews = new Reviews()
                    {
                        review_id = reviewId,
                        review_Comment = Request.Form["comment"],
                        review_UserId = userId,
                        review_UploadTime = DateTime.Now,
                        review_HideStatus = false,
                        review_ReviewType = "Review"
                    };

                    int idProductInt = Int32.Parse(idproduct);

                    _context.Reviews.Add(reviews);

                    var reviewInProduct = new ReviewInproduct()
                    {
                        rip_ProductId = idProductInt,
                        rip_ReviewId = reviewId
                    };
                    _context.ReviewInproduct.Add(reviewInProduct);


                    await _context.SaveChangesAsync();
                }



                return Redirect("/productdetail?id=" + idproduct);
            }
            catch
            {
                ViewBag.thongbao = "Cann't create";
                return View();
            }

        }

        [Route("/productcommentreply")]
        [HttpPost]
        public async Task<IActionResult> Commentreply()
        {

            try
            {

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var userName = User.FindFirstValue(ClaimTypes.Name);

                string SubReviewId = Guid.NewGuid().ToString();

                string idproduct = Request.Form["idproduct"];
                if (Request.Form["subcomment"] != "")
                {
                    var SubReviews = new SubReview()
                    {
                        subReview_Id = SubReviewId,
                        subReview_Commnet = Request.Form["subcomment"],
                        subReview_DateCommnet = DateTime.Now,
                        subReview_UserId = userId,
                        subReview_HideStatus = false,
                        subreview_SubReviewType = "SubReview"
                    };




                    string idCommentMain = Request.Form["idcommentmain"];

                    int idProductInt = Int32.Parse(idproduct);

                    _context.SubReview.Add(SubReviews);

                    var SubReviewInReview = new SubReviewInReview()
                    {
                        SRiR_ReviewId = idCommentMain,
                        SRiR_SubReviewId = SubReviewId
                    };
                    _context.SubReviewInReview.Add(SubReviewInReview);


                    await _context.SaveChangesAsync();
                }


                return Redirect("/productdetail?id=" + idproduct);
            }
            catch
            {
                ViewBag.thongbao = "Cann't create";
                return View();
            }

        }

    }
}
