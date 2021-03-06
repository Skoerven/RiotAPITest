// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiotManagerDb;

namespace RiotManagerDb.Migrations
{
    [DbContext(typeof(RiotManagerContext))]
    [Migration("20220110100222_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("RiotManagerDb.Ban", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("TeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("championId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("pickTurn")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Ban");
                });

            modelBuilder.Entity("RiotManagerDb.Info", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("gameCreation")
                        .HasColumnType("INTEGER");

                    b.Property<long>("gameDuration")
                        .HasColumnType("INTEGER");

                    b.Property<long>("gameEndTimestamp")
                        .HasColumnType("INTEGER");

                    b.Property<long>("gameId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("gameMode")
                        .HasColumnType("TEXT");

                    b.Property<string>("gameName")
                        .HasColumnType("TEXT");

                    b.Property<long>("gameStartTimestamp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("gameType")
                        .HasColumnType("TEXT");

                    b.Property<string>("gameVersion")
                        .HasColumnType("TEXT");

                    b.Property<int>("mapId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("platformId")
                        .HasColumnType("TEXT");

                    b.Property<int>("queueId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tournamentCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Infos");
                });

            modelBuilder.Entity("RiotManagerDb.Match", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("InfoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MatchId")
                        .HasColumnType("TEXT");

                    b.Property<long>("MetaDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("RiotManagerDb.MatchIdStorage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("matchid")
                        .HasColumnType("TEXT");

                    b.Property<string>("puuid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MatchesInfo");
                });

            modelBuilder.Entity("RiotManagerDb.MetaData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataVersion")
                        .HasColumnType("TEXT");

                    b.Property<string>("partici")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MetaDatas");
                });

            modelBuilder.Entity("RiotManagerDb.Objective", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("first")
                        .HasColumnType("INTEGER");

                    b.Property<int>("kills")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Objective");
                });

            modelBuilder.Entity("RiotManagerDb.Objectives", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("TeamId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("baronId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("championId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("dragonId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("inhibitorId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("riftHeraldId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("towerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.HasIndex("baronId");

                    b.HasIndex("championId");

                    b.HasIndex("dragonId");

                    b.HasIndex("inhibitorId");

                    b.HasIndex("riftHeraldId");

                    b.HasIndex("towerId");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("RiotManagerDb.Participant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("InfoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("assists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("baronKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("bountyLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("champExperience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("champLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("championId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("championName")
                        .HasColumnType("TEXT");

                    b.Property<int>("championTransform")
                        .HasColumnType("INTEGER");

                    b.Property<int>("consumablesPurchased")
                        .HasColumnType("INTEGER");

                    b.Property<int>("damageDealtToBuildings")
                        .HasColumnType("INTEGER");

                    b.Property<int>("damageDealtToObjectives")
                        .HasColumnType("INTEGER");

                    b.Property<int>("damageDealtToTurrets")
                        .HasColumnType("INTEGER");

                    b.Property<int>("damageSelfMitigated")
                        .HasColumnType("INTEGER");

                    b.Property<int>("deaths")
                        .HasColumnType("INTEGER");

                    b.Property<int>("detectorWardsPlaced")
                        .HasColumnType("INTEGER");

                    b.Property<int>("doubleKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("dragonKills")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("firstBloodAssist")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("firstBloodKill")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("firstTowerAssist")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("firstTowerKill")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("gameEndedInEarlySurrender")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("gameEndedInSurrender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("goldEarned")
                        .HasColumnType("INTEGER");

                    b.Property<int>("goldSpent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("individualPosition")
                        .HasColumnType("TEXT");

                    b.Property<int>("inhibitorKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("inhibitorTakedowns")
                        .HasColumnType("INTEGER");

                    b.Property<int>("inhibitorsLost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("item0")
                        .HasColumnType("INTEGER");

                    b.Property<int>("item1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("item2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("item3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("item4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("item5")
                        .HasColumnType("INTEGER");

                    b.Property<int>("item6")
                        .HasColumnType("INTEGER");

                    b.Property<int>("itemsPurchased")
                        .HasColumnType("INTEGER");

                    b.Property<int>("killingSprees")
                        .HasColumnType("INTEGER");

                    b.Property<int>("kills")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lane")
                        .HasColumnType("TEXT");

                    b.Property<int>("largestCriticalStrike")
                        .HasColumnType("INTEGER");

                    b.Property<int>("largestKillingSpree")
                        .HasColumnType("INTEGER");

                    b.Property<int>("largestMultiKill")
                        .HasColumnType("INTEGER");

                    b.Property<int>("longestTimeSpentLiving")
                        .HasColumnType("INTEGER");

                    b.Property<int>("magicDamageDealt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("magicDamageDealtToChampions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("magicDamageTaken")
                        .HasColumnType("INTEGER");

                    b.Property<int>("neutralMinionsKilled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("nexusKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("nexusLost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("nexusTakedowns")
                        .HasColumnType("INTEGER");

                    b.Property<int>("objectivesStolen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("objectivesStolenAssists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("participantId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("pentaKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("physicalDamageDealt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("physicalDamageDealtToChampions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("physicalDamageTaken")
                        .HasColumnType("INTEGER");

                    b.Property<int>("profileIcon")
                        .HasColumnType("INTEGER");

                    b.Property<string>("puuid")
                        .HasColumnType("TEXT");

                    b.Property<int>("quadraKills")
                        .HasColumnType("INTEGER");

                    b.Property<string>("riotIdName")
                        .HasColumnType("TEXT");

                    b.Property<string>("riotIdTagline")
                        .HasColumnType("TEXT");

                    b.Property<string>("role")
                        .HasColumnType("TEXT");

                    b.Property<int>("sightWardsBoughtInGame")
                        .HasColumnType("INTEGER");

                    b.Property<int>("spell1Casts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("spell2Casts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("spell3Casts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("spell4Casts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("summoner1Casts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("summoner1Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("summoner2Casts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("summoner2Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("summonerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("summonerLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("summonerName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("teamEarlySurrendered")
                        .HasColumnType("INTEGER");

                    b.Property<int>("teamId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("teamPosition")
                        .HasColumnType("TEXT");

                    b.Property<int>("timeCCingOthers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("timePlayed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalDamageDealt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalDamageDealtToChampions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalDamageShieldedOnTeammates")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalDamageTaken")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalHeal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalHealsOnTeammates")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalMinionsKilled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalTimeCCDealt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalTimeSpentDead")
                        .HasColumnType("INTEGER");

                    b.Property<int>("totalUnitsHealed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("tripleKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("trueDamageDealt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("trueDamageDealtToChampions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("trueDamageTaken")
                        .HasColumnType("INTEGER");

                    b.Property<int>("turretKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("turretTakedowns")
                        .HasColumnType("INTEGER");

                    b.Property<int>("turretsLost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("unrealKills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("visionScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("visionWardsBoughtInGame")
                        .HasColumnType("INTEGER");

                    b.Property<int>("wardsKilled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("wardsPlaced")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("win")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InfoId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("RiotManagerDb.PerkStats", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("PerksId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("flex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("offense")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PerksId")
                        .IsUnique();

                    b.ToTable("PerkStats");
                });

            modelBuilder.Entity("RiotManagerDb.PerkStyle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("PerksId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<int>("style")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PerksId");

                    b.ToTable("PerkStyle");
                });

            modelBuilder.Entity("RiotManagerDb.PerkStyleSelection", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("PerkStyleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("perk")
                        .HasColumnType("INTEGER");

                    b.Property<int>("var1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("var2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("var3")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PerkStyleId");

                    b.ToTable("PerkStyleSelection");
                });

            modelBuilder.Entity("RiotManagerDb.Perks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ParticipantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantId")
                        .IsUnique();

                    b.ToTable("Perks");
                });

            modelBuilder.Entity("RiotManagerDb.Summoner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileIconId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RevisionDate")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SummonerLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("puuid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Summoners");
                });

            modelBuilder.Entity("RiotManagerDb.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("InfoId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ParticipantId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("teamId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("win")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InfoId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("RiotManagerDb.Ban", b =>
                {
                    b.HasOne("RiotManagerDb.Team", null)
                        .WithMany("bans")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RiotManagerDb.Objectives", b =>
                {
                    b.HasOne("RiotManagerDb.Team", null)
                        .WithOne("objectives")
                        .HasForeignKey("RiotManagerDb.Objectives", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiotManagerDb.Objective", "baron")
                        .WithMany()
                        .HasForeignKey("baronId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiotManagerDb.Objective", "champion")
                        .WithMany()
                        .HasForeignKey("championId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiotManagerDb.Objective", "dragon")
                        .WithMany()
                        .HasForeignKey("dragonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiotManagerDb.Objective", "inhibitor")
                        .WithMany()
                        .HasForeignKey("inhibitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiotManagerDb.Objective", "riftHerald")
                        .WithMany()
                        .HasForeignKey("riftHeraldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiotManagerDb.Objective", "tower")
                        .WithMany()
                        .HasForeignKey("towerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RiotManagerDb.Participant", b =>
                {
                    b.HasOne("RiotManagerDb.Info", null)
                        .WithMany("participants")
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RiotManagerDb.PerkStats", b =>
                {
                    b.HasOne("RiotManagerDb.Perks", null)
                        .WithOne("MyProperty")
                        .HasForeignKey("RiotManagerDb.PerkStats", "PerksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RiotManagerDb.PerkStyle", b =>
                {
                    b.HasOne("RiotManagerDb.Perks", null)
                        .WithMany("styles")
                        .HasForeignKey("PerksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RiotManagerDb.PerkStyleSelection", b =>
                {
                    b.HasOne("RiotManagerDb.PerkStyle", null)
                        .WithMany("selections")
                        .HasForeignKey("PerkStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RiotManagerDb.Perks", b =>
                {
                    b.HasOne("RiotManagerDb.Participant", null)
                        .WithOne("perks")
                        .HasForeignKey("RiotManagerDb.Perks", "ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RiotManagerDb.Team", b =>
                {
                    b.HasOne("RiotManagerDb.Info", null)
                        .WithMany("teams")
                        .HasForeignKey("InfoId");
                });
#pragma warning restore 612, 618
        }
    }
}
