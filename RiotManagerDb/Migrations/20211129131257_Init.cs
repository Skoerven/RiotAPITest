using Microsoft.EntityFrameworkCore.Migrations;

namespace RiotManagerDb.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    matchid = table.Column<string>(nullable: false),
                    puuid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.matchid);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    matchid = table.Column<string>(nullable: false),
                    puuid = table.Column<string>(nullable: false),
                    assists = table.Column<int>(nullable: false),
                    baronKills = table.Column<int>(nullable: false),
                    bountyLevel = table.Column<int>(nullable: false),
                    champExperience = table.Column<int>(nullable: false),
                    champLevel = table.Column<int>(nullable: false),
                    championId = table.Column<int>(nullable: false),
                    championName = table.Column<string>(nullable: true),
                    championTransform = table.Column<int>(nullable: false),
                    consumablesPurchased = table.Column<int>(nullable: false),
                    damageDealtToBuildings = table.Column<int>(nullable: false),
                    damageDealtToObjectives = table.Column<int>(nullable: false),
                    damageDealtToTurrets = table.Column<int>(nullable: false),
                    damageSelfMitigated = table.Column<int>(nullable: false),
                    deaths = table.Column<int>(nullable: false),
                    detectorWardsPlaced = table.Column<int>(nullable: false),
                    doubleKills = table.Column<int>(nullable: false),
                    dragonKills = table.Column<int>(nullable: false),
                    firstBloodAssist = table.Column<bool>(nullable: false),
                    firstBloodKill = table.Column<bool>(nullable: false),
                    firstTowerAssist = table.Column<bool>(nullable: false),
                    firstTowerKill = table.Column<bool>(nullable: false),
                    gameEndedInEarlySurrender = table.Column<bool>(nullable: false),
                    gameEndedInSurrender = table.Column<bool>(nullable: false),
                    goldEarned = table.Column<int>(nullable: false),
                    goldSpent = table.Column<int>(nullable: false),
                    individualPosition = table.Column<string>(nullable: true),
                    inhibitorKills = table.Column<int>(nullable: false),
                    inhibitorTakedowns = table.Column<int>(nullable: false),
                    inhibitorsLost = table.Column<int>(nullable: false),
                    item0 = table.Column<int>(nullable: false),
                    item1 = table.Column<int>(nullable: false),
                    item2 = table.Column<int>(nullable: false),
                    item3 = table.Column<int>(nullable: false),
                    item4 = table.Column<int>(nullable: false),
                    item5 = table.Column<int>(nullable: false),
                    item6 = table.Column<int>(nullable: false),
                    itemsPurchased = table.Column<int>(nullable: false),
                    killingSprees = table.Column<int>(nullable: false),
                    kills = table.Column<int>(nullable: false),
                    lane = table.Column<string>(nullable: true),
                    largestCriticalStrike = table.Column<int>(nullable: false),
                    largestKillingSpree = table.Column<int>(nullable: false),
                    largestMultiKill = table.Column<int>(nullable: false),
                    longestTimeSpentLiving = table.Column<int>(nullable: false),
                    magicDamageDealt = table.Column<int>(nullable: false),
                    magicDamageDealtToChampions = table.Column<int>(nullable: false),
                    magicDamageTaken = table.Column<int>(nullable: false),
                    neutralMinionsKilled = table.Column<int>(nullable: false),
                    nexusKills = table.Column<int>(nullable: false),
                    nexusTakedowns = table.Column<int>(nullable: false),
                    nexusLost = table.Column<int>(nullable: false),
                    objectivesStolen = table.Column<int>(nullable: false),
                    objectivesStolenAssists = table.Column<int>(nullable: false),
                    participantId = table.Column<int>(nullable: false),
                    pentaKills = table.Column<int>(nullable: false),
                    physicalDamageDealt = table.Column<int>(nullable: false),
                    physicalDamageDealtToChampions = table.Column<int>(nullable: false),
                    physicalDamageTaken = table.Column<int>(nullable: false),
                    profileIcon = table.Column<int>(nullable: false),
                    quadraKills = table.Column<int>(nullable: false),
                    riotIdName = table.Column<string>(nullable: true),
                    riotIdTagline = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true),
                    sightWardsBoughtInGame = table.Column<int>(nullable: false),
                    spell1Casts = table.Column<int>(nullable: false),
                    spell2Casts = table.Column<int>(nullable: false),
                    spell3Casts = table.Column<int>(nullable: false),
                    spell4Casts = table.Column<int>(nullable: false),
                    summoner1Casts = table.Column<int>(nullable: false),
                    summoner1Id = table.Column<int>(nullable: false),
                    summoner2Casts = table.Column<int>(nullable: false),
                    summoner2Id = table.Column<int>(nullable: false),
                    summonerId = table.Column<string>(nullable: true),
                    summonerLevel = table.Column<int>(nullable: false),
                    summonerName = table.Column<string>(nullable: true),
                    teamEarlySurrendered = table.Column<bool>(nullable: false),
                    teamId = table.Column<int>(nullable: false),
                    teamPosition = table.Column<string>(nullable: true),
                    timeCCingOthers = table.Column<int>(nullable: false),
                    timePlayed = table.Column<int>(nullable: false),
                    totalDamageDealt = table.Column<int>(nullable: false),
                    totalDamageDealtToChampions = table.Column<int>(nullable: false),
                    totalDamageShieldedOnTeammates = table.Column<int>(nullable: false),
                    totalDamageTaken = table.Column<int>(nullable: false),
                    totalHeal = table.Column<int>(nullable: false),
                    totalHealsOnTeammates = table.Column<int>(nullable: false),
                    totalMinionsKilled = table.Column<int>(nullable: false),
                    totalTimeCCDealt = table.Column<int>(nullable: false),
                    totalTimeSpentDead = table.Column<int>(nullable: false),
                    totalUnitsHealed = table.Column<int>(nullable: false),
                    tripleKills = table.Column<int>(nullable: false),
                    trueDamageDealt = table.Column<int>(nullable: false),
                    trueDamageDealtToChampions = table.Column<int>(nullable: false),
                    trueDamageTaken = table.Column<int>(nullable: false),
                    turretKills = table.Column<int>(nullable: false),
                    turretTakedowns = table.Column<int>(nullable: false),
                    turretsLost = table.Column<int>(nullable: false),
                    unrealKills = table.Column<int>(nullable: false),
                    visionScore = table.Column<int>(nullable: false),
                    visionWardsBoughtInGame = table.Column<int>(nullable: false),
                    wardsKilled = table.Column<int>(nullable: false),
                    wardsPlaced = table.Column<int>(nullable: false),
                    win = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => new { x.matchid, x.puuid });
                });

            migrationBuilder.CreateTable(
                name: "Summoners",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: true),
                    ProfileIconId = table.Column<int>(nullable: false),
                    RevisionDate = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    puuid = table.Column<string>(nullable: true),
                    SummonerLevel = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summoners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Summoners");
        }
    }
}
