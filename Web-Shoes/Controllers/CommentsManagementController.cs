﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Entity;
using Web_Fashion.Models;

namespace Web_Fashion.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CommentsManagementController : Controller
    {
        private readonly ApplicationDbContext _context;


        public CommentsManagementController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: CommentsManagementController
        [Route("/commentsmanagement")]
        [HttpGet]
        public ActionResult Index()
        {


            //var productDetailQuery = _context.Products.FirstOrDefault(a => a.pd_Id == id);





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


            //review = review.Where(x => x.b.review_HideStatus == false);

            var reviewQuery = review.Select(x => new ReviewModel()
            {
                // table Review
                review_id = x.b.review_id,
                review_UserId = x.a.Id,
                
                review_Comment = x.b.review_Comment,
                review_UserName = x.a.UserName,
                review_UploadTime = x.b.review_UploadTime,
                review_HideStatus = x.b.review_HideStatus,
                review_ReviewType = x.b.review_ReviewType,


                review_CountSubReview = 1, //demo


                //Table Product 
                review_ProductId = x.d.pd_Id,
                review_ProductName = x.d.pd_Name,
                review_ProductIMG1 = x.d.pd_NameImg1,
                review_ProductDecription = x.d.pd_Description,
                review_ProductPrice = x.d.pd_Price,
                review_ProductRate = x.d.pd_Rate,
                

                //// table SubReview



            });

            //SubReview = SubReview.Where(x => x.b.subReview_HideStatus == false);

            var subReviewQuery = SubReview.Select(x => new SubreviewModel()
            {
                subReview_Subid = x.b.subReview_Id,
                subReview_SubComment = x.b.subReview_Commnet,
                subReview_SubUserId = x.b.subReview_UserId,
                subReview_SubUploadTime = x.b.subReview_DateCommnet,
                subReview_UserName = x.a.UserName,
                subReview_ReviewId = x.d.review_id,
                subReview_HideStatus = x.b.subReview_HideStatus,
                subReview_SubReviewType = x.b.subreview_SubReviewType
                
                
                
            });

            List<ReviewModel> reviewAdd = new List<ReviewModel>();



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

        [HttpGet("/commentsmanagement/AllowAction/{ReviewId:alpha?}/")]
        // GET: CommentsManagementController/Details/5
        public ActionResult AllowAction(string ReviewId,string Type)
        {
            try
            {
                if (Type =="Review")
                {
                    var reviewQuery = _context.Reviews.FirstOrDefault(x => x.review_id == ReviewId);

                    reviewQuery.review_HideStatus = false;
                }
                else
                {
                    var subreviewQuery = _context.SubReview.FirstOrDefault(x => x.subReview_Id == ReviewId);

                    subreviewQuery.subReview_HideStatus = false;
                }
                

                _context.SaveChanges();


                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet("/commentsmanagement/DenyAction/{ReviewId:alpha?}/")]
        // GET: CommentsManagementController/Details/5
        public ActionResult DenyAction(string ReviewId, string Type)
        {
            try
            {
                if (Type == "Review")
                {
                    var reviewQuery = _context.Reviews.FirstOrDefault(x => x.review_id == ReviewId);

                    reviewQuery.review_HideStatus = true;
                }
                else
                {
                    var subreviewQuery = _context.SubReview.FirstOrDefault(x => x.subReview_Id == ReviewId);

                    subreviewQuery.subReview_HideStatus = true;
                }


                _context.SaveChanges();


                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // GET: CommentsManagementController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch 
            {

                return RedirectToAction(nameof(Index));
            }
            
        }

        // GET: CommentsManagementController/Create
        public ActionResult Create()
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch 
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // POST: CommentsManagementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentsManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommentsManagementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentsManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommentsManagementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
