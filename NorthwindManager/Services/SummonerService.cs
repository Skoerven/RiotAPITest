using Newtonsoft.Json;
using NorthwindManager.Dtos;
using RiotManagerDb;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NorthwindManager.Services
{
    public class SummonerService
    {
        private const string token = "RGAPI-41f5cb9d-f1df-476c-a44a-add0e592c315";

        private WebResponse webResponse;
        private Stream webStream;
        private StreamReader reader;
        private readonly RiotManagerContext db;

        public SummonerService(RiotManagerContext db)
        {
            this.db = db;
        }




        public List<SummonerDto> GetAllSummoner()
        {

            return ConvertSummonerListToDto(db.Summoners.ToList());
        }

        public SummonerDto GetSummonerWithName(string name)
        {
            var summ = new SummonerDto();
            var url = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name;



            string data = GetRequest(url);

            var result = JsonConvert.DeserializeObject<Summoner>(data);

            db.Summoners.Add(result);
            db.SaveChanges();

            return ConvertSummonerToDto(result);
        }

        public MatchDto GetMatch(string MatchId)
        {
            var url = "https://europe.api.riotgames.com/lol/match/v5/matches/" + MatchId;
            var data = GetRequest(url);
            return JsonConvert.DeserializeObject<MatchDto>(GetRequest(url));
        }
        public List<MatchDto> GetAllMatches(string name)
        {
            var sum = db.Summoners.Where(x => x.Name.Equals(name)).FirstOrDefault();
            if (sum == null)
            {
                sum = ConvertDtoToSummoner(GetSummonerWithName(name));
                GetGames(sum.puuid);
            }

            var games = db.Matches.Where(x => x.puuid == sum.puuid).Select(x => x.matchid).ToList();
            var res = new List<MatchDto>();
            foreach (var item in games)
            {
                var match = GetMatch(item);
                res.Add(match);
                var pac = match.Info.participants.Where(x => x.puuid.Equals(GetPuuid(name))).FirstOrDefault();
                db.Participants.Add(ConvertDtoToParticipant(pac, item));

            }
            db.SaveChanges();
            return res;
        }

        public List<string> GetGames(string puuid)
        {
            var games = GetGameId(puuid);
            foreach (var item in games)
            {
                db.Matches.Add(new Matches
                {
                    matchid = item,
                    puuid = puuid
                });
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

        #region Converter

        private Participant ConvertDtoToParticipant(ParticipantDto part, string matchid)
        {
            return new Participant
            {
                assists = part.assists,
                baronKills = part.baronKills,
                bountyLevel = part.bountyLevel,
                champExperience = part.champExperience,
                championId = part.championId,
                championName = part.championName,
                championTransform = part.championTransform,
                champLevel = part.champLevel,
                consumablesPurchased = part.consumablesPurchased,
                damageDealtToBuildings = part.damageDealtToBuildings,
                damageDealtToObjectives = part.damageDealtToObjectives,
                damageDealtToTurrets = part.damageDealtToTurrets,
                damageSelfMitigated = part.damageSelfMitigated,
                deaths = part.deaths,
                detectorWardsPlaced = part.detectorWardsPlaced,
                doubleKills = part.doubleKills,
                dragonKills = part.dragonKills,
                firstBloodAssist = part.firstBloodAssist,
                firstBloodKill = part.firstBloodKill,
                firstTowerAssist = part.firstTowerAssist,
                firstTowerKill = part.firstTowerKill,
                gameEndedInEarlySurrender = part.gameEndedInEarlySurrender,
                gameEndedInSurrender = part.gameEndedInSurrender,
                goldEarned = part.goldEarned,
                goldSpent = part.goldSpent,
                individualPosition = part.individualPosition,
                inhibitorKills = part.inhibitorKills,
                inhibitorsLost = part.inhibitorsLost,
                inhibitorTakedowns = part.inhibitorTakedowns,
                item0 = part.item0,
                item1 = part.item1,
                item2 = part.item2,
                item3 = part.item3,
                item4 = part.item4,
                item5 = part.item5,
                item6 = part.item6,
                itemsPurchased = part.itemsPurchased,
                killingSprees = part.killingSprees,
                kills = part.kills,
                lane = part.lane,
                largestCriticalStrike = part.largestCriticalStrike,
                largestKillingSpree = part.largestKillingSpree,
                largestMultiKill = part.largestMultiKill,
                longestTimeSpentLiving = part.longestTimeSpentLiving,
                magicDamageDealt = part.magicDamageDealt,
                magicDamageDealtToChampions = part.magicDamageDealtToChampions,
                magicDamageTaken = part.magicDamageTaken,
                matchid = matchid,
                neutralMinionsKilled = part.neutralMinionsKilled,
                nexusKills = part.nexusKills,
                nexusLost = part.nexusLost,
                nexusTakedowns = part.nexusTakedowns,
                objectivesStolen = part.objectivesStolen,
                objectivesStolenAssists = part.objectivesStolenAssists,
                participantId = part.participantId,
                pentaKills = part.pentaKills,
                physicalDamageDealt = part.physicalDamageDealt,
                physicalDamageDealtToChampions = part.physicalDamageDealtToChampions,
                physicalDamageTaken = part.physicalDamageTaken,
                profileIcon = part.profileIcon,
                puuid = part.puuid,
                quadraKills = part.quadraKills,
                riotIdName = part.riotIdName,
                riotIdTagline = part.riotIdTagline,
                role = part.role,
                sightWardsBoughtInGame = part.sightWardsBoughtInGame,
                spell1Casts = part.spell1Casts,
                spell2Casts = part.spell2Casts,
                spell3Casts = part.spell3Casts,
                spell4Casts = part.spell4Casts,
                summoner1Casts = part.summoner1Casts,
                summoner1Id = part.summoner1Id,
                summoner2Casts = part.summoner2Casts,
                summoner2Id = part.summoner2Id,
                summonerId = part.summonerId,
                summonerLevel = part.summonerLevel,
                summonerName = part.summonerName,
                teamEarlySurrendered = part.teamEarlySurrendered,
                teamId = part.teamId,
                teamPosition = part.teamPosition,
                timeCCingOthers = part.timeCCingOthers,
                timePlayed = part.timePlayed,
                totalDamageDealt = part.totalDamageDealt,
                totalDamageDealtToChampions = part.totalDamageDealtToChampions,
                totalDamageShieldedOnTeammates = part.totalDamageShieldedOnTeammates,
                totalDamageTaken = part.totalDamageTaken,
                totalHeal = part.totalHeal,
                totalHealsOnTeammates = part.totalHealsOnTeammates,
                totalMinionsKilled = part.totalMinionsKilled,
                totalTimeCCDealt = part.totalTimeCCDealt,
                totalTimeSpentDead = part.totalTimeSpentDead,
                totalUnitsHealed = part.totalUnitsHealed,
                tripleKills = part.tripleKills,
                trueDamageDealt = part.trueDamageDealt,
                trueDamageDealtToChampions = part.trueDamageDealtToChampions,
                trueDamageTaken = part.trueDamageTaken,
                turretKills = part.turretKills,
                turretsLost = part.turretsLost,
                turretTakedowns = part.turretTakedowns,
                unrealKills = part.unrealKills,
                visionScore = part.visionScore,
                visionWardsBoughtInGame = part.visionWardsBoughtInGame,
                wardsKilled = part.wardsKilled,
                wardsPlaced = part.wardsPlaced,
                win = part.win,

            };
        }
        private List<SummonerDto> ConvertSummonerListToDto(List<Summoner> sum)
        {
            var res = new List<SummonerDto>();
            foreach (var item in sum)
            {
                res.Add(ConvertSummonerToDto(item));
            }

            return res;
        }

        private SummonerDto ConvertSummonerToDto(Summoner item)
        {
            return new SummonerDto
            {
                AccountId = item.AccountId,
                Id = item.Id,
                Name = item.Name,
                ProfileIconId = item.ProfileIconId,
                puuid = item.puuid,
                RevisionDate = item.RevisionDate,
                SummonerLevel = item.SummonerLevel
            };
        }

        private Summoner ConvertDtoToSummoner(SummonerDto item)
        {
            return new Summoner
            {
                AccountId = item.AccountId,
                Id = item.Id,
                Name = item.Name,
                ProfileIconId = item.ProfileIconId,
                puuid = item.puuid,
                RevisionDate = item.RevisionDate,
                SummonerLevel = item.SummonerLevel

            };
        }

        #endregion
    }
}
