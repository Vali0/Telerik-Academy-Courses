using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BullsAndCows.Data;

namespace BullsAndCows.Web.Controllers
{
    public class GamesController : ApiController
    {
        protected  data;

        public GamesController(IBullsAndCowsData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var games = this.data.Games.All().OrderBy(x => x.State).ThenBy(x => x.Name).ThenBy(x => x.CreatedDate).ThenBy(x => x.RedPlayer.UserName).Take(10);

            return Ok(games);
        }
    }
}
