using Microsoft.EntityFrameworkCore.Migrations;

namespace RiotManagerDb.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    gameCreation = table.Column<long>(nullable: false),
                    gameDuration = table.Column<long>(nullable: false),
                    gameEndTimestamp = table.Column<long>(nullable: false),
                    gameId = table.Column<long>(nullable: false),
                    gameMode = table.Column<string>(nullable: true),
                    gameName = table.Column<string>(nullable: true),
                    gameStartTimestamp = table.Column<long>(nullable: false),
                    gameType = table.Column<string>(nullable: true),
                    gameVersion = table.Column<string>(nullable: true),
                    mapId = table.Column<int>(nullable: false),
                    platformId = table.Column<string>(nullable: true),
                    queueId = table.Column<int>(nullable: false),
                    tournamentCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MatchId = table.Column<string>(nullable: true),
                    MetaDataId = table.Column<long>(nullable: false),
                    InfoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchesInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    matchid = table.Column<string>(nullable: true),
                    puuid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchesInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetaDatas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    dataVersion = table.Column<string>(nullable: true),
                    partici = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objective",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first = table.Column<bool>(nullable: false),
                    kills = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objective", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InfoId = table.Column<long>(nullable: false),
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
                    puuid = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Participant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participant_Infos_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Infos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParticipantId = table.Column<long>(nullable: false),
                    teamId = table.Column<int>(nullable: false),
                    win = table.Column<bool>(nullable: false),
                    InfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Infos_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Infos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Perks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParticipantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perks_Participant_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ban",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<long>(nullable: false),
                    championId = table.Column<int>(nullable: false),
                    pickTurn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ban", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ban_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<long>(nullable: false),
                    baronId = table.Column<long>(nullable: false),
                    championId = table.Column<long>(nullable: false),
                    dragonId = table.Column<long>(nullable: false),
                    inhibitorId = table.Column<long>(nullable: false),
                    riftHeraldId = table.Column<long>(nullable: false),
                    towerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objectives_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Objectives_Objective_baronId",
                        column: x => x.baronId,
                        principalTable: "Objective",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Objectives_Objective_championId",
                        column: x => x.championId,
                        principalTable: "Objective",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Objectives_Objective_dragonId",
                        column: x => x.dragonId,
                        principalTable: "Objective",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Objectives_Objective_inhibitorId",
                        column: x => x.inhibitorId,
                        principalTable: "Objective",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Objectives_Objective_riftHeraldId",
                        column: x => x.riftHeraldId,
                        principalTable: "Objective",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Objectives_Objective_towerId",
                        column: x => x.towerId,
                        principalTable: "Objective",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerkStats",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PerksId = table.Column<long>(nullable: false),
                    defense = table.Column<int>(nullable: false),
                    flex = table.Column<int>(nullable: false),
                    offense = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerkStats_Perks_PerksId",
                        column: x => x.PerksId,
                        principalTable: "Perks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerkStyle",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PerksId = table.Column<long>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    style = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkStyle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerkStyle_Perks_PerksId",
                        column: x => x.PerksId,
                        principalTable: "Perks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerkStyleSelection",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PerkStyleId = table.Column<long>(nullable: false),
                    perk = table.Column<int>(nullable: false),
                    var1 = table.Column<int>(nullable: false),
                    var2 = table.Column<int>(nullable: false),
                    var3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkStyleSelection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerkStyleSelection_PerkStyle_PerkStyleId",
                        column: x => x.PerkStyleId,
                        principalTable: "PerkStyle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ban_TeamId",
                table: "Ban",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_TeamId",
                table: "Objectives",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_baronId",
                table: "Objectives",
                column: "baronId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_championId",
                table: "Objectives",
                column: "championId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_dragonId",
                table: "Objectives",
                column: "dragonId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_inhibitorId",
                table: "Objectives",
                column: "inhibitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_riftHeraldId",
                table: "Objectives",
                column: "riftHeraldId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_towerId",
                table: "Objectives",
                column: "towerId");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_InfoId",
                table: "Participant",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perks_ParticipantId",
                table: "Perks",
                column: "ParticipantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerkStats_PerksId",
                table: "PerkStats",
                column: "PerksId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerkStyle_PerksId",
                table: "PerkStyle",
                column: "PerksId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkStyleSelection_PerkStyleId",
                table: "PerkStyleSelection",
                column: "PerkStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_InfoId",
                table: "Team",
                column: "InfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ban");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "MatchesInfo");

            migrationBuilder.DropTable(
                name: "MetaDatas");

            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "PerkStats");

            migrationBuilder.DropTable(
                name: "PerkStyleSelection");

            migrationBuilder.DropTable(
                name: "Summoners");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Objective");

            migrationBuilder.DropTable(
                name: "PerkStyle");

            migrationBuilder.DropTable(
                name: "Perks");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "Infos");
        }
    }
}
