﻿// <auto-generated />
using System;
using InsaragSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsaragSystem.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231209210452_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Disaster.DisasterBase", b =>
                {
                    b.Property<int>("DisasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisasterId"));

                    b.Property<string>("AffectedAreas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateEnded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("DisasterType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EpicenterId")
                        .HasColumnType("int");

                    b.Property<int>("EstimatedAffectedPopulation")
                        .HasColumnType("int");

                    b.Property<int>("EstimatedCasualties")
                        .HasColumnType("int");

                    b.Property<int>("EstimatedDisplacedPersons")
                        .HasColumnType("int");

                    b.Property<decimal>("EstimatedEconomicLoss")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ImmediateNeeds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImpactLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitiatingEvent")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ReliefResources")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Scope")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("DisasterId");

                    b.HasIndex("EpicenterId");

                    b.ToTable("Disasters", (string)null);

                    b.HasDiscriminator<string>("DisasterType").HasValue("DisasterBase");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.GpsCoordinates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("GpsCoordinates");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<int>("DisasterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisasterId");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Subdivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Subdivisions");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Subfield", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<int>("SubdivisionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubdivisionId");

                    b.ToTable("Subfields");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Team.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AssignedSectorId")
                        .HasColumnType("int");

                    b.Property<int>("DisasterId")
                        .HasColumnType("int");

                    b.Property<int?>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignedSectorId");

                    b.HasIndex("DisasterId");

                    b.HasIndex("SectorId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Disaster.Earthquake", b =>
                {
                    b.HasBaseType("InsaragSystem.Domain.Entities.Disaster.DisasterBase");

                    b.Property<double>("Depth")
                        .HasColumnType("float");

                    b.Property<double>("Magnitude")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Earthquake");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Disaster.Flood", b =>
                {
                    b.HasBaseType("InsaragSystem.Domain.Entities.Disaster.DisasterBase");

                    b.Property<double>("FloodedArea")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Flood");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Disaster.Wildfire", b =>
                {
                    b.HasBaseType("InsaragSystem.Domain.Entities.Disaster.DisasterBase");

                    b.Property<decimal>("BurnedArea")
                        .HasColumnType("decimal(18, 2)");

                    b.HasDiscriminator().HasValue("Wildfire");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Disaster.DisasterBase", b =>
                {
                    b.HasOne("InsaragSystem.Domain.Entities.GpsCoordinates", "Epicenter")
                        .WithMany()
                        .HasForeignKey("EpicenterId");

                    b.Navigation("Epicenter");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Sector", b =>
                {
                    b.HasOne("InsaragSystem.Domain.Entities.Disaster.DisasterBase", "Disaster")
                        .WithMany("Sectors")
                        .HasForeignKey("DisasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disaster");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Subdivision", b =>
                {
                    b.HasOne("InsaragSystem.Domain.Entities.Sector.Sector", "Sector")
                        .WithMany("Subdivisions")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Subfield", b =>
                {
                    b.HasOne("InsaragSystem.Domain.Entities.Sector.Subdivision", "Subdivision")
                        .WithMany("Subfields")
                        .HasForeignKey("SubdivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subdivision");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Team.Team", b =>
                {
                    b.HasOne("InsaragSystem.Domain.Entities.Sector.Sector", "AssignedSector")
                        .WithMany()
                        .HasForeignKey("AssignedSectorId");

                    b.HasOne("InsaragSystem.Domain.Entities.Disaster.DisasterBase", "Disaster")
                        .WithMany("Teams")
                        .HasForeignKey("DisasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsaragSystem.Domain.Entities.Sector.Sector", null)
                        .WithMany("AssignedTeams")
                        .HasForeignKey("SectorId");

                    b.OwnsOne("InsaragSystem.Domain.Entities.Team.ContactDetails", "ContactDetails", b1 =>
                        {
                            b1.Property<int>("TeamId")
                                .HasColumnType("int");

                            b1.Property<string>("BaseOperationLocation")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact1Email")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact1MobilePhoneNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact1NameOrTitle")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact1SatellitePhoneNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact2Email")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact2MobilePhoneNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact2NameOrTitle")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Contact2SatellitePhoneNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("RadioFrequencyInMHz")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("WorkSiteGpsCoordinatesId")
                                .HasColumnType("int");

                            b1.HasKey("TeamId");

                            b1.HasIndex("WorkSiteGpsCoordinatesId");

                            b1.ToTable("Teams");

                            b1.WithOwner()
                                .HasForeignKey("TeamId");

                            b1.HasOne("InsaragSystem.Domain.Entities.GpsCoordinates", "WorkSiteGpsCoordinates")
                                .WithMany()
                                .HasForeignKey("WorkSiteGpsCoordinatesId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.Navigation("WorkSiteGpsCoordinates");
                        });

                    b.OwnsOne("InsaragSystem.Domain.Entities.Team.SupportRequirements", "SupportRequirements", b1 =>
                        {
                            b1.Property<int>("TeamId")
                                .HasColumnType("int");

                            b1.Property<int>("DailyCuttingGasCylindersRequired")
                                .HasColumnType("int");

                            b1.Property<double>("DailyDieselRequirementInLiters")
                                .HasColumnType("float");

                            b1.Property<double>("DailyGasolineRequirementInLiters")
                                .HasColumnType("float");

                            b1.Property<int>("DailyMedicalOxygenCylindersRequired")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("OtherLogisticRequirements")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("RequiredBaseOperationSpaceInSquareMeters")
                                .HasColumnType("float");

                            b1.Property<int>("TotalDogsToTransport")
                                .HasColumnType("int");

                            b1.Property<double>("TotalEquipmentVolumeInCubicMeters")
                                .HasColumnType("float");

                            b1.Property<double>("TotalEquipmentWeightInTons")
                                .HasColumnType("float");

                            b1.Property<int>("TotalPeopleToTransport")
                                .HasColumnType("int");

                            b1.HasKey("TeamId");

                            b1.ToTable("Teams");

                            b1.WithOwner()
                                .HasForeignKey("TeamId");
                        });

                    b.OwnsOne("InsaragSystem.Domain.Entities.Team.TeamDetails", "TeamDetails", b1 =>
                        {
                            b1.Property<int>("TeamId")
                                .HasColumnType("int");

                            b1.Property<string>("AircraftType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ArrivalPoint")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<bool>("CanSupportUC")
                                .HasColumnType("bit");

                            b1.Property<string>("CountryOfOrigin")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("DaysOfFoodAutonomy")
                                .HasColumnType("int");

                            b1.Property<int>("DaysOfWaterAutonomy")
                                .HasColumnType("int");

                            b1.Property<DateTime>("EstimatedArrivalDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<bool>("HasCanineSearchCapability")
                                .HasColumnType("bit");

                            b1.Property<bool>("HasHazardousMaterialDetectionCapability")
                                .HasColumnType("bit");

                            b1.Property<bool>("HasMedicalCapability")
                                .HasColumnType("bit");

                            b1.Property<bool>("HasProvisionalOSOCCCapability")
                                .HasColumnType("bit");

                            b1.Property<bool>("HasRescueCapability")
                                .HasColumnType("bit");

                            b1.Property<bool>("HasTechnicalSearchCapability")
                                .HasColumnType("bit");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("InsaragClassification")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("NumberOfStructuralEngineers")
                                .HasColumnType("int");

                            b1.Property<string>("OlympicCountryCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("OtherCapabilities")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ResponseType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("TotalDeployedDogs")
                                .HasColumnType("int");

                            b1.Property<int>("TotalDeployedPeople")
                                .HasColumnType("int");

                            b1.HasKey("TeamId");

                            b1.ToTable("Teams");

                            b1.WithOwner()
                                .HasForeignKey("TeamId");
                        });

                    b.Navigation("AssignedSector");

                    b.Navigation("ContactDetails")
                        .IsRequired();

                    b.Navigation("Disaster");

                    b.Navigation("SupportRequirements")
                        .IsRequired();

                    b.Navigation("TeamDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Disaster.DisasterBase", b =>
                {
                    b.Navigation("Sectors");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Sector", b =>
                {
                    b.Navigation("AssignedTeams");

                    b.Navigation("Subdivisions");
                });

            modelBuilder.Entity("InsaragSystem.Domain.Entities.Sector.Subdivision", b =>
                {
                    b.Navigation("Subfields");
                });
#pragma warning restore 612, 618
        }
    }
}
