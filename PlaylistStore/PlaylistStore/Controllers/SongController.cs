using PlaylistStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaylistStore.Controllers
{
    public class SongController : Controller
    {
        private OperationDataContext context = null;

        public SongController()
        {
            context = new OperationDataContext();
        }

        // GET: Song
        public ActionResult Index()
        {
            List<SongModel> songList = new List<SongModel>();

            //Songs = nama table genre secara default pake linq to sql
            var query = from song in context.Songs
                        join genre in context.Genres
                        on song.GenreId equals genre.Id
                        select new SongModel
                        {
                            Id = song.Id,
                            Title = song.Title,
                            Writer = song.Writer,
                            Singer = song.Singer,
                            Year = song.Year,
                            GenreName = genre.Name
                        };

            songList = query.ToList();

            return View(songList);
        }

        // GET: Song/Create
        public ActionResult Create()
        {
            SongModel model = new SongModel();
            PreparePublisher(model);

            return View(model);
        }

        // POST: Song/Create
        [HttpPost]
        public ActionResult Create(SongModel model)
        {
            try
            {
                // TODO: Add insert logic here

                Song song = new Song()
                {
                    Title = model.Title,
                    Writer = model.Writer,
                    Singer = model.Singer,
                    Year = model.Year,
                    GenreId = model.GenreID
                };

                context.Songs.InsertOnSubmit(song);
                context.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Song/Edit/5
        public ActionResult Edit(int id)
        {
            SongModel model = context.Songs.Where(some => some.Id == id).Select(
                some => new SongModel()
                {
                    Id = some.Id,
                    Title = some.Title,
                    Singer = some.Singer,
                    Writer = some.Writer,
                    Year = some.Year,
                    GenreID = some.GenreId
                }).SingleOrDefault();

            PreparePublisher(model);
            return View(model);
        }

        // POST: Song/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SongModel model)
        {
            try
            {
                // TODO: Add update logic here

                Song song = context.Songs.Where(some => some.Id == model.Id).Single<Song>();
                song.Title = model.Title;
                song.Singer = model.Singer;
                song.Year = model.Year;
                song.Writer = model.Writer;
                song.GenreId = model.GenreID;
                context.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Song/Delete/5
        public ActionResult Delete(int id)
        {
            SongModel model = context.Songs.Where(some => some.Id == id).Select(
                some => new SongModel()
                {
                    Id = some.Id,
                    Title = some.Title,
                    Singer = some.Singer,
                    Writer = some.Writer,
                    Year = some.Year,
                    GenreID = some.GenreId
                }).SingleOrDefault();

            PreparePublisher(model);
            return View(model);
        }

        // POST: Song/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SongModel model)
        {
            try
            {
                // TODO: Add delete logic here
                Song song = context.Songs.Where(some => some.Id == model.Id).Single<Song>();

                context.Songs.DeleteOnSubmit(song);
                context.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private void PreparePublisher(SongModel model)
        {
            model.Genres = context.Genres.AsQueryable<Genre>().Select(x =>
                            new SelectListItem()
                            {
                                Text = x.Name,
                                Value = x.Id.ToString()
                            });
        }
    }
}
