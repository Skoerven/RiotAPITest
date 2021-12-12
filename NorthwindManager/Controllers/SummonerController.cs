using Microsoft.AspNetCore.Mvc;
using NorthwindManager.Dtos;
using NorthwindManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NorthwindManager.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class SummonerController : ControllerBase
  {
        private readonly SummonerService servcie;

        public SummonerController(SummonerService servcie)
    {
            this.servcie = servcie;
        }

        [HttpGet("FillSummoner")]
        public IActionResult FillDb()
        {
            servcie.FillDb();
            return Ok();
        }

        [HttpGet("DeletSummoners")]
        public IActionResult EmptyDb()
        {
            servcie.ClearDb();
            return Ok();
        }

        [HttpGet("GetSummoners")]
        public IActionResult GetSummoners()
        {
            return Ok(servcie.GetAllSummoner());
        }
        [HttpGet("GetSummoner/{name}")]
        public IActionResult GetSummoner(string name)
        {
            return Ok(servcie.GetSummonerWithName(name));
        }

        [HttpGet("GetGameId/{puuid}")]
        public IActionResult GetGameId(string puuid)
        {
            return Ok(servcie.GetGames(puuid));
        }

        [HttpGet("GetMatch/{matchid}")]
        public IActionResult GetMatch(string matchid)
        {
            return Ok(servcie.GetMatch(matchid));
        }
        [HttpGet("GetAllMatches/{username}")]
        public IActionResult GetAllMatch(string username)
        {
            return Ok(servcie.GetAllMatches(username));
        }



    }
}
