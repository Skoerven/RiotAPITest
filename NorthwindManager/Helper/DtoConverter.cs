using NorthwindManager.Dtos;
using RiotManagerDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindManager.Helper
{
    public  class DtoConverter
    {
        private readonly RiotManagerContext db;

        public DtoConverter(RiotManagerContext db)
        {
            this.db = db;
        }
        
        public  MetaData ConvertDtoToDb(MetaDataDto metaData, long id)
        {
            return new MetaData
            {
                Id = id,
                dataVersion = metaData.dataVersion,
                Participants = metaData.participants
            };
        }
        public  Info ConvertDtoToDb(InfoDto info)
        {
            var res = new Info
            {

                gameCreation = info.gameCreation,
                gameDuration = info.gameDuration,
                gameEndTimestamp = info.gameEndTimestamp,
                gameId = info.gameId,
                gameMode = info.gameMode,
                gameName = info.gameName,
                gameStartTimestamp = info.gameStartTimestamp,
                gameType = info.gameType,
                gameVersion = info.gameVersion,
                mapId = info.mapId,
                platformId = info.platformId,
                queueId = info.queueId,
                tournamentCode = info.tournamentCode,
            };
            res.team1Id = ConvertDtoToDb(info.teams[0]);
            res.team2Id = ConvertDtoToDb(info.teams[1]);
            res.participants = ConvertDtoToDb(info.participants, res.Id);
           


            return res;
        }

        private long ConvertDtoToDb(TeamDto teamDto)
        {
            var t = new Team
            {
                banID = ConvertDtoToDb(teamDto.bans),
                objectiveId = ConvertDtoToDb(teamDto.objectives),
                teamId = teamDto.teamId,
                win = teamDto.win
            };
            db.Teams.Add(t);
            return t.Id;
        }

        private long ConvertDtoToDb(ObjectivesDto objectives)
        {
            throw new NotImplementedException();
        }

        private long ConvertDtoToDb(List<BanDto> bans)
        {
            var b = new Ban
            {

            };
            return 0;
        }

        public  List<Team> ConvertDtoToDb(List<TeamDto> teams, long id)
        {
            var res = new List<Team>();
            foreach (var item in teams)
            {
                res.Add(ConvertDtoToDb(item, id));
            }
            return res;
        }

        

       

       

      

        

        public  Team ConvertDtoToDb(TeamDto item, long id)
        {
            var res = new Team
            {
                teamId = item.teamId,
                win = item.win
            };
            var ban  = ConvertDtoToDb(item.bans, id);
            res.banID = ban[0].TeamId;
            var ob = ConvertDtoToDb(item.objectives, id);
            res.objectiveId = ob.TeamId;
            return res;
        }

        public  Objectives ConvertDtoToDb(ObjectivesDto objectives, long id)
        {
            var res = new Objectives
            {
                TeamId = id,
            };
            var ob = ConvertDtoToDb(objectives.baron, res.TeamId);
            res.baron = ob;
            res.baronId = ob.Id;
            ob = ConvertDtoToDb(objectives.champion, res.TeamId);
            res.champion = ConvertDtoToDb(objectives.champion, res.TeamId);
            res.championId = ob.Id;
            ob = ConvertDtoToDb(objectives.dragon, res.TeamId);
            res.dragon = ob;
            res.dragonId = ob.Id;
            ob = ConvertDtoToDb(objectives.inhibitor, res.TeamId);
            res.inhibitor = ob;
            res.inhibitorId = ob.Id;
            ob = ConvertDtoToDb(objectives.riftHerald, res.TeamId);
            res.riftHerald = ob;
            res.riftHeraldId = ob.Id;
            ob = ConvertDtoToDb(objectives.tower, res.TeamId);
            res.tower = ob;
            res.towerId = ob.Id;
            return res;
        }

        public  Objective ConvertDtoToDb(ObjectiveDto baron, long id)
        {
            var res = new Objective
            {

                first = baron.first,
                kills = baron.kills
            };

            return res;
        }

        public  List<Ban> ConvertDtoToDb(List<BanDto> bans, long id)
        {
            var res = new List<Ban>();
            foreach (var item in bans)
            {
                res.Add(ConvertDtoToDb(item, id));
            }
            return res;
        }

        public  Ban ConvertDtoToDb(BanDto item, long id)
        {
            return new Ban
            {
                TeamId = id,
                championId = item.championId,
                pickTurn = item.pickTurn
            };
        }

        public  List<Participant> ConvertDtoToDb(List<ParticipantDto> participants, long id)
        {
            var res = new List<Participant>();
            foreach (var item in participants)
            {
                res.Add(ConvertDtoToDb(item, id));
            }
            return res;
        }

        public  Participant ConvertDtoToDb(ParticipantDto part, long infoId)
        {
            var res = new Participant
            {
               
                assists = part.assists,
                teamId = part.teamId,
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
            res.perks = ConvertDtoToDb(part.perks, res.Id);

            return res;
        }

        public  Perks ConvertDtoToDb(PerksDto perks, long id)
        {
            var res = new Perks
            {
                ParticipantId = id,
            };
            var st = ConvertDtoToDb(perks.styles, id);
            res.PerkstylesID = st[0].Id;


            return res;
        }

        public static List<PerkStyle> ConvertDtoToDb(List<PerkStyleDto> styles, long id)
        {
            var res = new List<PerkStyle>();
            foreach (var item in styles)
            {
                var perk = new PerkStyle
                {
                    PerksId = id,
                    description = item.description,

                    style = item.style
                };
                var sel = ConvertDtoToDb(item.selections, id);
                perk.PerkselectionsID = sel[0].Id;
                res.Add(perk);
            }
            return res;
        }

        public static List<PerkStyleSelection> ConvertDtoToDb(List<PerkStyleSelectionDto> selections, long id)
        {
            var res = new List<PerkStyleSelection>();
            foreach (var item in selections)
            {
                res.Add(new PerkStyleSelection
                {
                    
                    PerkStyleId = id,
                    perk = item.perk,
                    var1 = item.var1,
                    var2 = item.var2,
                    var3 = item.var3
                });
            }
            return res;
        }

        public static PerkStats ConvertDtoToDb(PerkStatsDto myProperty, long id)
        {
            if (myProperty == null)
            {
                return new PerkStats
                {
                    PerksId = id,
                    defense = 0,
                    flex = 0,
                    offense = 0
                };
            }
            return new PerkStats
            {
                PerksId = id,
                defense = myProperty.defense,
                flex = myProperty.flex,
                offense = myProperty.offense
            };
        }           

        public static Summoner ConvertDtoToSummoner(SummonerDto item)
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
        #region DB to DTO
        public static SummonerDto ConvertSummonerToDto(Summoner item)
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
        public static List<SummonerDto> ConvertSummonerListToDto(List<Summoner> sum)
        {
            var res = new List<SummonerDto>();
            foreach (var item in sum)
            {
                res.Add(ConvertSummonerToDto(item));
            }

            return res;
        }

        public MatchDto ConvertDbToDto(Match match)
        {
            var info = db.Infos.Where(x => x.Id == match.InfoId + 1).FirstOrDefault();
            var meta = db.MetaDatas.Where(x => x.Id == match.MetaDataId + 1).FirstOrDefault();
            return new MatchDto
            {

                Info = ConvertDbToDto(info),
                MetaData = ConvertDbToDto(meta),

            };
        }
        public MetaDataDto ConvertDbToDto(MetaData metaData)
        {
            return new MetaDataDto
            {
                dataVersion = metaData.dataVersion,
                matchId = metaData.dataVersion,
                participants = metaData.Participants
            };
        }
        public InfoDto ConvertDbToDto(Info info)
        {
            return new InfoDto
            {
                gameCreation = info.gameCreation,
                gameDuration = info.gameDuration,
                gameEndTimestamp = info.gameEndTimestamp,
                gameId = info.gameId,
                gameMode = info.gameMode,
                gameName = info.gameName,
                gameStartTimestamp = info.gameStartTimestamp,
                gameType = info.gameType,
                gameVersion = info.gameVersion,
                mapId = info.mapId,
                participants = ConvertDbToDto(info.participants),
                platformId = info.platformId,
                queueId = info.queueId,
                teams = ConvertDbToDto(info.teams),
                tournamentCode = info.tournamentCode
            };
        }

        public List<TeamDto> ConvertDbToDto(List<Team> teams)
        {
            var res = new List<TeamDto>();
            foreach (var item in teams)
            {
                res.Add(ConvertDbToDto(item));
            }
            return res;
        }

        public TeamDto ConvertDbToDto(Team item)
        {
            return new TeamDto
            {
                bans = ConvertDbToDto(item.bans),
                objectives = ConvertDbToDto(item.objectives),
                teamId = item.teamId,
                win = item.win
            };
        }

        public ObjectivesDto ConvertDbToDto(Objectives objectives)
        {
            return new ObjectivesDto
            {
                baron = ConvertDbToDto(objectives.baron),
                champion = ConvertDbToDto(objectives.champion),
                dragon = ConvertDbToDto(objectives.dragon),
                inhibitor = ConvertDbToDto(objectives.inhibitor),
                riftHerald = ConvertDbToDto(objectives.riftHerald),
                tower = ConvertDbToDto(objectives.tower),
            };
        }

        public ObjectiveDto ConvertDbToDto(Objective baron)
        {
            return new ObjectiveDto
            {
                first = baron.first,
                kills = baron.kills
            };
        }

        public List<BanDto> ConvertDbToDto(List<Ban> bans)
        {
            var res = new List<BanDto>();
            foreach (var item in bans)
            {
                res.Add(ConvertDbToDto(item));
            }
            return res;
        }

        public BanDto ConvertDbToDto(Ban item)
        {
            return new BanDto
            {
                championId = item.championId,
                pickTurn = item.pickTurn
            };
        }

        public List<ParticipantDto> ConvertDbToDto(List<Participant> participants)
        {
            var res = new List<ParticipantDto>();
            foreach (var item in participants)
            {
                res.Add(ConvertDbToDto(item));
            }
            return res;
        }

        public ParticipantDto ConvertDbToDto(Participant item)
        {
            var part = item;
            return new ParticipantDto
            {
                assists = item.assists,
                baronKills = item.baronKills,
                bountyLevel = item.bountyLevel,
                champExperience = item.champExperience,
                championId = item.championId,
                championName = item.championName,
                championTransform = item.championTransform,
                champLevel = item.champLevel,
                consumablesPurchased = item.consumablesPurchased,
                damageDealtToBuildings = item.damageDealtToBuildings,
                damageDealtToObjectives = item.damageDealtToObjectives,
                damageDealtToTurrets = item.damageDealtToTurrets,
                damageSelfMitigated = item.damageSelfMitigated,
                deaths = item.deaths,
                detectorWardsPlaced = item.detectorWardsPlaced,
                doubleKills = item.doubleKills,
                dragonKills = item.dragonKills,
                firstBloodAssist = item.firstBloodAssist,
                firstBloodKill = item.firstBloodKill,
                firstTowerAssist = item.firstTowerAssist,
                firstTowerKill = item.firstTowerKill,
                gameEndedInEarlySurrender = item.gameEndedInEarlySurrender,
                gameEndedInSurrender = item.gameEndedInSurrender,
                goldEarned = item.goldEarned,
                goldSpent = item.goldSpent,
                individualPosition = item.individualPosition,
                inhibitorKills = item.inhibitorKills,
                inhibitorsLost = item.inhibitorsLost,
                inhibitorTakedowns = item.inhibitorTakedowns,
                item0 = item.item0,
                item1 = item.item1,
                item2 = item.item2,
                item3 = item.item3,
                item4 = item.item4,
                item5 = item.item5,
                item6 = item.item6,
                itemsPurchased = item.itemsPurchased,
                killingSprees = item.killingSprees,
                kills = item.kills,
                lane = item.lane,
                largestCriticalStrike = item.largestCriticalStrike,
                largestKillingSpree = item.largestKillingSpree,
                largestMultiKill = item.largestMultiKill,
                longestTimeSpentLiving = item.longestTimeSpentLiving,
                magicDamageDealt = item.magicDamageDealt,
                magicDamageDealtToChampions = item.magicDamageDealtToChampions,
                magicDamageTaken = item.magicDamageTaken,
                neutralMinionsKilled = item.neutralMinionsKilled,
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

        #endregion
    }
}
