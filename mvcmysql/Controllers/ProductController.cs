﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcmysql.Models;

namespace mvcmysql.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<product> productlist = new List<product>();
            using (DBModelsEntities dBModels = new DBModelsEntities())
            {
                productlist = dBModels.product.ToList<product>();
            }
                return View(productlist);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            product productModel = new product();
            using (DBModelsEntities dBModel = new DBModelsEntities())
            {
                productModel = dBModel.product.Where(x => x.ProductID == id).FirstOrDefault();
            }
                
                return View(productModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new product());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(product productModel)
        {
            using (DBModelsEntities dBModels = new DBModelsEntities())
            {
                dBModels.product.Add(productModel);
                dBModels.SaveChanges();
                    
            }
            return RedirectToAction("Index");
            
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            product productModel = new product();
            using (DBModelsEntities dBModel = new DBModelsEntities())
            {
                productModel = dBModel.product.Where(x => x.ProductID == id).FirstOrDefault();
            }

            return View(productModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(product productModel)
        {
            using (DBModelsEntities dBModel = new DBModelsEntities())
            {
                dBModel.Entry(productModel).State = System.Data.EntityState.Modified;
                dBModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            product productModel = new product();
            using (DBModelsEntities dBModel = new DBModelsEntities())
            {
                productModel = dBModel.product.Where(x => x.ProductID == id).FirstOrDefault();
            }

            return View(productModel);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            using (DBModelsEntities dBModel = new DBModelsEntities())
            {
                product productModel = dBModel.product.Where(x => x.ProductID == id).FirstOrDefault();
                dBModel.product.Remove(productModel);
                dBModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
