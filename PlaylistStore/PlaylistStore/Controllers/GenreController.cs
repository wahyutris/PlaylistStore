﻿using PlaylistStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaylistStore.Controllers
{
    public class GenreController : Controller
    {
        private OperationDataContext context = null;

        public GenreController()
        {
            context = new OperationDataContext();
        }
        public ActionResult Index()
        {
            List<GenreModel> genreList = new List<GenreModel>();

            //Genres = nama table genre secara default pake linq to sql
            //var genres = from genre in context.Genres select genre;
            var query = from genre in context.Genres select genre;

            //gabisa karena genreList tipenya model
            //genreList = genres.ToList();

            var genres = query.ToList();
            foreach(var a in genres)
            {
                genreList.Add(new GenreModel()
                {
                    Id = a.Id,
                    Name = a.Name
                });
            }

            return View(genreList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GenreModel model)
        {
            try
            {
                Genre genre = new Genre()
                {
                    Name = model.Name
                };

                context.Genres.InsertOnSubmit(genre);
                context.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }            
        }
    }
}