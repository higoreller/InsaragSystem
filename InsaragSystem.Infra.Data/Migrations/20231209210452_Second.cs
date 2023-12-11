using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsaragSystem.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisasterBase_GpsCoordinates_EpicenterId",
                table: "DisasterBase");

            migrationBuilder.DropForeignKey(
                name: "FK_Sectors_DisasterBase_DisasterId",
                table: "Sectors");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_ContactDetails_ContactDetailsId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_DisasterBase_DisasterId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_SupportRequirements_SupportRequirementsId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_TeamDetails_TeamDetailsId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "SupportRequirements");

            migrationBuilder.DropTable(
                name: "TeamDetails");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ContactDetailsId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SupportRequirementsId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamDetailsId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisasterBase",
                table: "DisasterBase");

            migrationBuilder.RenameTable(
                name: "DisasterBase",
                newName: "Disasters");

            migrationBuilder.RenameColumn(
                name: "TeamDetailsId",
                table: "Teams",
                newName: "TeamDetails_TotalDeployedPeople");

            migrationBuilder.RenameColumn(
                name: "SupportRequirementsId",
                table: "Teams",
                newName: "TeamDetails_TotalDeployedDogs");

            migrationBuilder.RenameColumn(
                name: "ContactDetailsId",
                table: "Teams",
                newName: "TeamDetails_NumberOfStructuralEngineers");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Disasters",
                newName: "DisasterType");

            migrationBuilder.RenameIndex(
                name: "IX_DisasterBase_EpicenterId",
                table: "Disasters",
                newName: "IX_Disasters_EpicenterId");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_BaseOperationLocation",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact1Email",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact1MobilePhoneNumber",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact1NameOrTitle",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact1SatellitePhoneNumber",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact2Email",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact2MobilePhoneNumber",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact2NameOrTitle",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_Contact2SatellitePhoneNumber",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ContactDetails_Id",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_RadioFrequencyInMHz",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ContactDetails_WorkSiteGpsCoordinatesId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupportRequirements_DailyCuttingGasCylindersRequired",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SupportRequirements_DailyDieselRequirementInLiters",
                table: "Teams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SupportRequirements_DailyGasolineRequirementInLiters",
                table: "Teams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SupportRequirements_DailyMedicalOxygenCylindersRequired",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupportRequirements_Id",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SupportRequirements_OtherLogisticRequirements",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "SupportRequirements_RequiredBaseOperationSpaceInSquareMeters",
                table: "Teams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SupportRequirements_TotalDogsToTransport",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SupportRequirements_TotalEquipmentVolumeInCubicMeters",
                table: "Teams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SupportRequirements_TotalEquipmentWeightInTons",
                table: "Teams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SupportRequirements_TotalPeopleToTransport",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_AircraftType",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_ArrivalPoint",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "TeamDetails_CanSupportUC",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_CountryOfOrigin",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TeamDetails_DaysOfFoodAutonomy",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamDetails_DaysOfWaterAutonomy",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TeamDetails_EstimatedArrivalDateTime",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "TeamDetails_HasCanineSearchCapability",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TeamDetails_HasHazardousMaterialDetectionCapability",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TeamDetails_HasMedicalCapability",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TeamDetails_HasProvisionalOSOCCCapability",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TeamDetails_HasRescueCapability",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TeamDetails_HasTechnicalSearchCapability",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeamDetails_Id",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_InsaragClassification",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_OlympicCountryCode",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_OtherCapabilities",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamDetails_ResponseType",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disasters",
                table: "Disasters",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ContactDetails_WorkSiteGpsCoordinatesId",
                table: "Teams",
                column: "ContactDetails_WorkSiteGpsCoordinatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disasters_GpsCoordinates_EpicenterId",
                table: "Disasters",
                column: "EpicenterId",
                principalTable: "GpsCoordinates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sectors_Disasters_DisasterId",
                table: "Sectors",
                column: "DisasterId",
                principalTable: "Disasters",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Disasters_DisasterId",
                table: "Teams",
                column: "DisasterId",
                principalTable: "Disasters",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_GpsCoordinates_ContactDetails_WorkSiteGpsCoordinatesId",
                table: "Teams",
                column: "ContactDetails_WorkSiteGpsCoordinatesId",
                principalTable: "GpsCoordinates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disasters_GpsCoordinates_EpicenterId",
                table: "Disasters");

            migrationBuilder.DropForeignKey(
                name: "FK_Sectors_Disasters_DisasterId",
                table: "Sectors");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Disasters_DisasterId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_GpsCoordinates_ContactDetails_WorkSiteGpsCoordinatesId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ContactDetails_WorkSiteGpsCoordinatesId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Disasters",
                table: "Disasters");

            migrationBuilder.DropColumn(
                name: "ContactDetails_BaseOperationLocation",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact1Email",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact1MobilePhoneNumber",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact1NameOrTitle",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact1SatellitePhoneNumber",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact2Email",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact2MobilePhoneNumber",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact2NameOrTitle",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Contact2SatellitePhoneNumber",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_RadioFrequencyInMHz",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ContactDetails_WorkSiteGpsCoordinatesId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_DailyCuttingGasCylindersRequired",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_DailyDieselRequirementInLiters",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_DailyGasolineRequirementInLiters",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_DailyMedicalOxygenCylindersRequired",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_OtherLogisticRequirements",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_RequiredBaseOperationSpaceInSquareMeters",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_TotalDogsToTransport",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_TotalEquipmentVolumeInCubicMeters",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_TotalEquipmentWeightInTons",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SupportRequirements_TotalPeopleToTransport",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_AircraftType",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_ArrivalPoint",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_CanSupportUC",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_CountryOfOrigin",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_DaysOfFoodAutonomy",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_DaysOfWaterAutonomy",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_EstimatedArrivalDateTime",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_HasCanineSearchCapability",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_HasHazardousMaterialDetectionCapability",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_HasMedicalCapability",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_HasProvisionalOSOCCCapability",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_HasRescueCapability",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_HasTechnicalSearchCapability",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_InsaragClassification",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_Name",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_OlympicCountryCode",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_OtherCapabilities",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamDetails_ResponseType",
                table: "Teams");

            migrationBuilder.RenameTable(
                name: "Disasters",
                newName: "DisasterBase");

            migrationBuilder.RenameColumn(
                name: "TeamDetails_TotalDeployedPeople",
                table: "Teams",
                newName: "TeamDetailsId");

            migrationBuilder.RenameColumn(
                name: "TeamDetails_TotalDeployedDogs",
                table: "Teams",
                newName: "SupportRequirementsId");

            migrationBuilder.RenameColumn(
                name: "TeamDetails_NumberOfStructuralEngineers",
                table: "Teams",
                newName: "ContactDetailsId");

            migrationBuilder.RenameColumn(
                name: "DisasterType",
                table: "DisasterBase",
                newName: "Discriminator");

            migrationBuilder.RenameIndex(
                name: "IX_Disasters_EpicenterId",
                table: "DisasterBase",
                newName: "IX_DisasterBase_EpicenterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisasterBase",
                table: "DisasterBase",
                column: "DisasterId");

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkSiteGpsCoordinatesId = table.Column<int>(type: "int", nullable: false),
                    BaseOperationLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact1Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact1MobilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact1NameOrTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact1SatellitePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2MobilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2NameOrTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact2SatellitePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadioFrequencyInMHz = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "SupportRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCuttingGasCylindersRequired = table.Column<int>(type: "int", nullable: false),
                    DailyDieselRequirementInLiters = table.Column<double>(type: "float", nullable: false),
                    DailyGasolineRequirementInLiters = table.Column<double>(type: "float", nullable: false),
                    DailyMedicalOxygenCylindersRequired = table.Column<int>(type: "int", nullable: false),
                    OtherLogisticRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredBaseOperationSpaceInSquareMeters = table.Column<double>(type: "float", nullable: false),
                    TotalDogsToTransport = table.Column<int>(type: "int", nullable: false),
                    TotalEquipmentVolumeInCubicMeters = table.Column<double>(type: "float", nullable: false),
                    TotalEquipmentWeightInTons = table.Column<double>(type: "float", nullable: false),
                    TotalPeopleToTransport = table.Column<int>(type: "int", nullable: false)
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
                    AircraftType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanSupportUC = table.Column<bool>(type: "bit", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysOfFoodAutonomy = table.Column<int>(type: "int", nullable: false),
                    DaysOfWaterAutonomy = table.Column<int>(type: "int", nullable: false),
                    EstimatedArrivalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasCanineSearchCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasHazardousMaterialDetectionCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasMedicalCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasProvisionalOSOCCCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasRescueCapability = table.Column<bool>(type: "bit", nullable: false),
                    HasTechnicalSearchCapability = table.Column<bool>(type: "bit", nullable: false),
                    InsaragClassification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfStructuralEngineers = table.Column<int>(type: "int", nullable: false),
                    OlympicCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherCapabilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDeployedDogs = table.Column<int>(type: "int", nullable: false),
                    TotalDeployedPeople = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ContactDetailsId",
                table: "Teams",
                column: "ContactDetailsId",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_WorkSiteGpsCoordinatesId",
                table: "ContactDetails",
                column: "WorkSiteGpsCoordinatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DisasterBase_GpsCoordinates_EpicenterId",
                table: "DisasterBase",
                column: "EpicenterId",
                principalTable: "GpsCoordinates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sectors_DisasterBase_DisasterId",
                table: "Sectors",
                column: "DisasterId",
                principalTable: "DisasterBase",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_ContactDetails_ContactDetailsId",
                table: "Teams",
                column: "ContactDetailsId",
                principalTable: "ContactDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_DisasterBase_DisasterId",
                table: "Teams",
                column: "DisasterId",
                principalTable: "DisasterBase",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_SupportRequirements_SupportRequirementsId",
                table: "Teams",
                column: "SupportRequirementsId",
                principalTable: "SupportRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_TeamDetails_TeamDetailsId",
                table: "Teams",
                column: "TeamDetailsId",
                principalTable: "TeamDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
