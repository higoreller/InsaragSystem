using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsaragSystem.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GpsCoordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpsCoordinates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPeopleToTransport = table.Column<int>(type: "int", nullable: false),
                    TotalDogsToTransport = table.Column<int>(type: "int", nullable: false),
                    TotalEquipmentWeightInTons = table.Column<double>(type: "float", nullable: false),
                    TotalEquipmentVolumeInCubicMeters = table.Column<double>(type: "float", nullable: false),
                    DailyGasolineRequirementInLiters = table.Column<double>(type: "float", nullable: false),
                    DailyDieselRequirementInLiters = table.Column<double>(type: "float", nullable: false),
                    DailyCuttingGasCylindersRequired = table.Column<int>(type: "int", nullable: false),
                    DailyMedicalOxygenCylindersRequired = table.Column<int>(type: "int", nullable: false),
                    RequiredBaseOperationSpaceInSquareMeters = table.Column<double>(type: "float", nullable: false),
                    OtherLogisticRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OlympicCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDeployedPeople = table.Column<int>(type: "int", nullable: false),
                    TotalDeployedDogs = table.Column<int>(type: "int", nullable: false),
                    ResponseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsaragClassification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasTechnicalSearchCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasCanineSearchCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasRescueCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasMedicalCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasHazardousMaterialDetectionCapability = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfStructuralEngineers = table.Column<int>(type: "int", nullable: false),
                    HasProvisionalOSOCCCapability = table.Column<bool>(type: "bit", nullable: false),
                    CanSupportUC = table.Column<bool>(type: "bit", nullable: false),
                    OtherCapabilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysOfWaterAutonomy = table.Column<int>(type: "int", nullable: false),
                    DaysOfFoodAutonomy = table.Column<int>(type: "int", nullable: false),
                    EstimatedArrivalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AircraftType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact1NameOrTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact1MobilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact1SatellitePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact1Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2NameOrTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2MobilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2SatellitePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseOperationLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadioFrequencyInMHz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkSiteGpsCoordinatesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactDetails_GpsCoordinates_WorkSiteGpsCoordinatesId",
                        column: x => x.WorkSiteGpsCoordinatesId,
                        principalTable: "GpsCoordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisasterBase",
                columns: table => new
                {
                    DisasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    DateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EpicenterId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AffectedAreas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImpactLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitiatingEvent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ReliefResources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImmediateNeeds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedAffectedPopulation = table.Column<int>(type: "int", nullable: false),
                    EstimatedCasualties = table.Column<int>(type: "int", nullable: false),
                    EstimatedDisplacedPersons = table.Column<int>(type: "int", nullable: false),
                    EstimatedEconomicLoss = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Magnitude = table.Column<double>(type: "float", nullable: true),
                    Depth = table.Column<double>(type: "float", nullable: true),
                    FloodedArea = table.Column<double>(type: "float", nullable: true),
                    BurnedArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisasterBase", x => x.DisasterId);
                    table.ForeignKey(
                        name: "FK_DisasterBase_GpsCoordinates_EpicenterId",
                        column: x => x.EpicenterId,
                        principalTable: "GpsCoordinates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    DisasterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sectors_DisasterBase_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "DisasterBase",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subdivisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subdivisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subdivisions_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactDetailsId = table.Column<int>(type: "int", nullable: false),
                    SupportRequirementsId = table.Column<int>(type: "int", nullable: false),
                    TeamDetailsId = table.Column<int>(type: "int", nullable: false),
                    DisasterId = table.Column<int>(type: "int", nullable: false),
                    AssignedSectorId = table.Column<int>(type: "int", nullable: true),
                    SectorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_ContactDetails_ContactDetailsId",
                        column: x => x.ContactDetailsId,
                        principalTable: "ContactDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_DisasterBase_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "DisasterBase",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Sectors_AssignedSectorId",
                        column: x => x.AssignedSectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_SupportRequirements_SupportRequirementsId",
                        column: x => x.SupportRequirementsId,
                        principalTable: "SupportRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_TeamDetails_TeamDetailsId",
                        column: x => x.TeamDetailsId,
                        principalTable: "TeamDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subfields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "char(1)", nullable: false),
                    SubdivisionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subfields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subfields_Subdivisions_SubdivisionId",
                        column: x => x.SubdivisionId,
                        principalTable: "Subdivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_WorkSiteGpsCoordinatesId",
                table: "ContactDetails",
                column: "WorkSiteGpsCoordinatesId");

            migrationBuilder.CreateIndex(
                name: "IX_DisasterBase_EpicenterId",
                table: "DisasterBase",
                column: "EpicenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_DisasterId",
                table: "Sectors",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Subdivisions_SectorId",
                table: "Subdivisions",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Subfields_SubdivisionId",
                table: "Subfields",
                column: "SubdivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_AssignedSectorId",
                table: "Teams",
                column: "AssignedSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ContactDetailsId",
                table: "Teams",
                column: "ContactDetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_DisasterId",
                table: "Teams",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SectorId",
                table: "Teams",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SupportRequirementsId",
                table: "Teams",
                column: "SupportRequirementsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamDetailsId",
                table: "Teams",
                column: "TeamDetailsId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subfields");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Subdivisions");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "SupportRequirements");

            migrationBuilder.DropTable(
                name: "TeamDetails");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "DisasterBase");

            migrationBuilder.DropTable(
                name: "GpsCoordinates");
        }
    }
}
