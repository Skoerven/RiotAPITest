using Newtonsoft.Json;
using NorthwindManager.Dtos;
using NorthwindManager.Helper;
using RiotManagerDb;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;


namespace NorthwindManager.Services
{
    public class SummonerService
    {
        private const string token = "RGAPI-29a84c28-31a0-452b-8cb6-0d712c22cc04";
      
        private WebResponse webResponse;
        private Stream webStream;
        private StreamReader reader;
        private readonly RiotManagerContext db;
        private readonly DtoConverter converter;

        public SummonerService(RiotManagerContext db, DtoConverter converter)
        {
            this.db = db;
            this.converter = converter;
        }




        public List<SummonerDto> GetAllSummoner()
        {

            return DtoConverter.ConvertSummonerListToDto(db.Summoners.ToList());
        }

        public SummonerDto GetSummonerWithName(string name)
        {

            if (db.Summoners.Select(x => x.Name.Equals(name)).FirstOrDefault()) return DtoConverter.ConvertSummonerToDto(db.Summoners.Where(x => x.Name.Equals(name)).FirstOrDefault());

            var url = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name;



            string data = GetRequest(url);

            var result = JsonConvert.DeserializeObject<Summoner>(data);

            db.Summoners.Add(result);
            db.SaveChanges();

            return DtoConverter.ConvertSummonerToDto(result);
        }

        public MatchDto GetMatch(string matchid)
        {
            if(db.Matches.Where(x => x.MatchId.Equals(matchid)).FirstOrDefault() != null)
            {    
                var g = db.Matches
     
                    .Where(x => x.MatchId.Equals(matchid))
                    .Select(x => x)
                    .FirstOrDefault();
                var cov = converter.ConvertDbToDto(g);
                return cov;
            }
            var url = "https://europe.api.riotgames.com/lol/match/v5/matches/" + matchid;
            var data = GetRequest(url);
            var match = JsonConvert.DeserializeObject<MatchDto>(GetRequest(url));
            SaveMatchInDb(match, matchid);
            return match;

        }

        private void SaveMatchInDb(MatchDto match, string matchid)
        {
            var id = match.Info.gameId;
            var dbmatch = new Match
            {
                MatchId = matchid,        
            
            };
            var info = converter.ConvertDtoToDb(match.Info);
            var meta = converter.ConvertDtoToDb(match.MetaData, info.Id);
            db.Matches.Add(dbmatch);
            db.Infos.Add(info);
            db.MetaDatas.Add(meta);
            db.SaveChanges();


        }



        public List<MatchDto> GetAllMatches(string name)
        {
            var sum = db.Summoners.Where(x => x.Name.Equals(name)).FirstOrDefault();
            if (sum == null)
            {
                sum = DtoConverter.ConvertDtoToSummoner(GetSummonerWithName(name));
                GetGames(sum.puuid);
            }

            var games = db.MatchesInfo.Where(x => x.puuid == sum.puuid).Select(x => x.matchid).ToList();
            var res = new List<MatchDto>();

            db.SaveChanges();
            return res;
        }

        public List<string> GetGames(string puuid)
        {
            var games = GetGameId(puuid);
            foreach (var item in games)
            {
                if (db.MatchesInfo.Where(x => x.matchid.Equals(item)).Select(x => x).FirstOrDefault() == null)
                {
                    db.MatchesInfo.Add(new MatchIdStorage
                    {
                        matchid = item,
                        puuid = puuid
                    });
                }

            }
            db.SaveChanges();
            return games;
        }

        private List<string> GetGameId(string puuid)
        {
            var url = "https://europe.api.riotgames.com/lol/match/v5/matches/by-puuid/" + puuid + "/ids?start=0&count=20";
            return JsonConvert.DeserializeObject<List<string>>(GetRequest(url));


        }



        #region Helper

        private string GetPuuid(string username)
        {
            var res = db.Summoners.Where(x => x.Name.Equals(username)).FirstOrDefault();
            if (res == null) return GetSummonerWithName(username).puuid;
            return res.puuid;
        }

        private string GetRequest(string url)
        {
            var data = "";
            var request = WebRequest.Create(url);
            request.Method = "GET";
            request.Headers["X-Riot-Token"] = token;
            webResponse = request.GetResponse();
            webStream = webResponse.GetResponseStream();
            reader = new StreamReader(webStream);
            data = reader.ReadToEnd();
            return data;
        }

        public void FillDb()
        {
            for (int i = 0; i < 10; i++)
            {
                db.Summoners.Add(new Summoner
                {
                    AccountId = "aaaaa" + i.ToString(),
                    Id = i.ToString(),
                    Name = i.ToString(),
                    ProfileIconId = i,
                    puuid = i.ToString(),
                    RevisionDate = i,
                    SummonerLevel = i

                });
            }
            db.SaveChanges();
        }

        public void ClearDb()
        {
            foreach (var entity in db.Summoners)
                db.Summoners.Remove(entity);
            db.SaveChanges();
        }

        #endregion

      
    }
}
