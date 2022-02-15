using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFWAPIFixed.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsValidated = table.Column<bool>(type: "bit", nullable: false),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    FBLInk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YTLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FBLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SnapLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TitleHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GuestSchedule",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuestID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestSchedule", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Merchant",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsValidated = table.Column<bool>(type: "bit", nullable: false),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    GuestID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsValidated = table.Column<bool>(type: "bit", nullable: false),
                    GuestID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Blurb",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    OwnerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BioID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blurb", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Blurb_Bio_BioID",
                        column: x => x.BioID,
                        principalTable: "Bio",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Blurb_Blog_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blog",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "GuestOrder",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuestID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    isPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestOrder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GuestOrder_Guest_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "GuestTrainingOrdered",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainingID = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    GuestID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GuestScheduleID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestTrainingOrdered", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GuestTrainingOrdered_Guest_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_GuestTrainingOrdered_GuestSchedule_GuestScheduleID",
                        column: x => x.GuestScheduleID,
                        principalTable: "GuestSchedule",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    MerchantID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Merchant_MerchantID",
                        column: x => x.MerchantID,
                        principalTable: "Merchant",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainerID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Training_Trainer_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "GuestItemOrdered",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItemID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    GuestOrderID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestItemOrdered", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GuestItemOrdered_GuestOrder_GuestOrderID",
                        column: x => x.GuestOrderID,
                        principalTable: "GuestOrder",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Item_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    OwnerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Schedule_Training_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Training",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TrainingVideo",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainingID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Back = table.Column<bool>(type: "bit", nullable: false),
                    Chest = table.Column<bool>(type: "bit", nullable: false),
                    Biceps = table.Column<bool>(type: "bit", nullable: false),
                    Triceps = table.Column<bool>(type: "bit", nullable: false),
                    Shoulders = table.Column<bool>(type: "bit", nullable: false),
                    ForeArms = table.Column<bool>(type: "bit", nullable: false),
                    Abs = table.Column<bool>(type: "bit", nullable: false),
                    Buttocks = table.Column<bool>(type: "bit", nullable: false),
                    Quadriceps = table.Column<bool>(type: "bit", nullable: false),
                    Hamstrings = table.Column<bool>(type: "bit", nullable: false),
                    Calves = table.Column<bool>(type: "bit", nullable: false),
                    MediaTop = table.Column<bool>(type: "bit", nullable: false),
                    MediaBottom = table.Column<bool>(type: "bit", nullable: false),
                    MediaLeft = table.Column<bool>(type: "bit", nullable: false),
                    MediaRight = table.Column<bool>(type: "bit", nullable: false),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    PostedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingVideo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrainingVideo_Training_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Training",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blurb_BioID",
                table: "Blurb",
                column: "BioID");

            migrationBuilder.CreateIndex(
                name: "IX_Blurb_BlogID",
                table: "Blurb",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_GuestItemOrdered_GuestOrderID",
                table: "GuestItemOrdered",
                column: "GuestOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_GuestOrder_GuestID",
                table: "GuestOrder",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_GuestTrainingOrdered_GuestID",
                table: "GuestTrainingOrdered",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_GuestTrainingOrdered_GuestScheduleID",
                table: "GuestTrainingOrdered",
                column: "GuestScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ProductID",
                table: "Item",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MerchantID",
                table: "Product",
                column: "MerchantID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_TrainingID",
                table: "Schedule",
                column: "TrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainerID",
                table: "Training",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingVideo_TrainingID",
                table: "TrainingVideo",
                column: "TrainingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Blurb");

            migrationBuilder.DropTable(
                name: "GuestItemOrdered");

            migrationBuilder.DropTable(
                name: "GuestTrainingOrdered");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "TrainingVideo");

            migrationBuilder.DropTable(
                name: "Bio");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "GuestOrder");

            migrationBuilder.DropTable(
                name: "GuestSchedule");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Merchant");

            migrationBuilder.DropTable(
                name: "Trainer");
        }
    }
}
