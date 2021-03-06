// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFWAPIFixed.Models;

#nullable disable

namespace TFWAPIFixed.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TFWAPIFixed.Models.Admin", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FBLInk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("IGLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuperAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("PostedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("SCLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.Property<string>("YTLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Bio", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FBLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IGLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SnapLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoutubeLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Bio");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Blog", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Blurb", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BioID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BlogID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<string>("OwnerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("PostedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BioID");

                    b.HasIndex("BlogID");

                    b.ToTable("Blurb");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Guest", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestItemOrdered", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestOrderID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ItemID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GuestOrderID");

                    b.ToTable("GuestItemOrdered");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestOrder", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isPaid")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("GuestID");

                    b.ToTable("GuestOrder");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestSchedule", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GuestSchedule");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestTrainingOrdered", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestScheduleID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("TrainingID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GuestID");

                    b.HasIndex("GuestScheduleID");

                    b.ToTable("GuestTrainingOrdered");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Item", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Merchant", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("PostedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Merchant");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Product", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<string>("MerchantID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("PostedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MerchantID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Schedule", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("OwnerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("TrainingID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("TrainingID");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Trainer", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("PostedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Training", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PostedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TrainerID");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.TrainingVideo", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Abs")
                        .HasColumnType("bit");

                    b.Property<bool>("Back")
                        .HasColumnType("bit");

                    b.Property<bool>("Biceps")
                        .HasColumnType("bit");

                    b.Property<bool>("Buttocks")
                        .HasColumnType("bit");

                    b.Property<bool>("Calves")
                        .HasColumnType("bit");

                    b.Property<bool>("Chest")
                        .HasColumnType("bit");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<bool>("ForeArms")
                        .HasColumnType("bit");

                    b.Property<bool>("Hamstrings")
                        .HasColumnType("bit");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("Image")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaBottom")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaLeft")
                        .HasColumnType("bit");

                    b.Property<string>("MediaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MediaRight")
                        .HasColumnType("bit");

                    b.Property<bool>("MediaTop")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PostedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Quadriceps")
                        .HasColumnType("bit");

                    b.Property<bool>("Shoulders")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Triceps")
                        .HasColumnType("bit");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TrainingID");

                    b.ToTable("TrainingVideo");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Blurb", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Bio", null)
                        .WithMany("blurbs")
                        .HasForeignKey("BioID");

                    b.HasOne("TFWAPIFixed.Models.Blog", null)
                        .WithMany("Blurbs")
                        .HasForeignKey("BlogID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestItemOrdered", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.GuestOrder", null)
                        .WithMany("ItemsOrdered")
                        .HasForeignKey("GuestOrderID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestOrder", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Guest", null)
                        .WithMany("Orders")
                        .HasForeignKey("GuestID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestTrainingOrdered", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Guest", null)
                        .WithMany("Trainings")
                        .HasForeignKey("GuestID");

                    b.HasOne("TFWAPIFixed.Models.GuestSchedule", null)
                        .WithMany("Schedule")
                        .HasForeignKey("GuestScheduleID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Item", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Product", null)
                        .WithMany("Items")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Product", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Merchant", null)
                        .WithMany("ProductPages")
                        .HasForeignKey("MerchantID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Schedule", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Training", null)
                        .WithMany("TrainingSchedule")
                        .HasForeignKey("TrainingID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Training", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Trainer", null)
                        .WithMany("TrainingPages")
                        .HasForeignKey("TrainerID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.TrainingVideo", b =>
                {
                    b.HasOne("TFWAPIFixed.Models.Training", null)
                        .WithMany("TrainingVideos")
                        .HasForeignKey("TrainingID");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Bio", b =>
                {
                    b.Navigation("blurbs");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Blog", b =>
                {
                    b.Navigation("Blurbs");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Guest", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Trainings");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestOrder", b =>
                {
                    b.Navigation("ItemsOrdered");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.GuestSchedule", b =>
                {
                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Merchant", b =>
                {
                    b.Navigation("ProductPages");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Product", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Trainer", b =>
                {
                    b.Navigation("TrainingPages");
                });

            modelBuilder.Entity("TFWAPIFixed.Models.Training", b =>
                {
                    b.Navigation("TrainingSchedule");

                    b.Navigation("TrainingVideos");
                });
#pragma warning restore 612, 618
        }
    }
}
