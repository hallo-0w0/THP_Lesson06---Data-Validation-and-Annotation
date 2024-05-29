using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThpLession06.Models;

namespace ThpLession06.Controllers
{
    public class ThpSongController : Controller
    {
        private static List<ThpSong> thpSongs = new List<ThpSong>()
        {
            new ThpSong{Id=2210900054, ThpTitle="Trinh Huu Phuc", ThpAuthor="K22CNT3", ThpArtist="NTU", ThpYearRelease=2020},
            new ThpSong{Id=1, ThpTitle="Trinh Huu Phuc", ThpAuthor="K22CNT3", ThpArtist="NTU", ThpYearRelease=2020}
        };


        // GET: ThpSong
        /// <summary>
        /// Hiển thi danh sách bài hát
        /// Author: Trịnh Hữu Phúc 
        /// </summary>
        /// <returns></returns>
        public ActionResult ThpIndex()
        {
            return View(thpSongs);
        }
        //Get: ThpCreate
        /// <summary>
        /// Add new song
        /// Author: Trịnh Hữu Phúc 
        /// </summary>
        /// <returns></returns>
        public ActionResult ThpCreate()
        {
            var thpSong = new ThpSong();
            return View(thpSong);
        }
    }
}
