
using System;
using System.Linq;
using HWInflation.Data;
using HWInflation.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HWInflation.Repositories;

namespace HWInflation.Controllers
{
    public class StoreScrapperController : Controller
    {

        private readonly HWInflationDBContext _dbContext;
        private readonly IStoreScrapperRepository _scrapperRepository;

        public StoreScrapperController(IStoreScrapperRepository storeScrapper)
        {
            _scrapperRepository = storeScrapper;
        }

        // GET: StoreScrapperController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StoreScrapperController/Details/5
        public ActionResult Details(int id)
        {
            var test = _scrapperRepository.GetStorieScrappers();
            return View(test.Result);
        }

        // GET: StoreScrapperController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreScrapperController/Create
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

        // GET: StoreScrapperController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreScrapperController/Edit/5
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

        // GET: StoreScrapperController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreScrapperController/Delete/5
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
