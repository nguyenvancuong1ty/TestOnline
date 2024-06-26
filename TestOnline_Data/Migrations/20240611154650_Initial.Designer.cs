﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestOnline_Data.EF;

#nullable disable

namespace TestOnline_Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240611154650_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("TestOnline_Data.Models.Answer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsCorrect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Chapter", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Classes", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("JoinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SchoolYear")
                        .HasColumnType("Date");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalStudent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId")
                        .IsUnique()
                        .HasFilter("[SubjectId] IS NOT NULL");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = "00000000-0000-0000-0000-0000000000001",
                            JoinCode = "TCC01",
                            Name = "Toán cao cấp",
                            Note = "ssds",
                            SchoolYear = new DateTime(2024, 6, 11, 22, 46, 49, 911, DateTimeKind.Local).AddTicks(1171),
                            TotalStudent = 20
                        },
                        new
                        {
                            Id = "00000000-0000-0000-0000-0000000000002",
                            JoinCode = "TTHCM",
                            Name = "Tư tưởng HCM",
                            Note = "aadsdsd",
                            SchoolYear = new DateTime(2024, 6, 11, 22, 46, 49, 911, DateTimeKind.Local).AddTicks(1185),
                            TotalStudent = 12
                        });
                });

            modelBuilder.Entity("TestOnline_Data.Models.Exam", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSeePoint")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWrapQuestion")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberQuestionBasic")
                        .HasColumnType("int");

                    b.Property<int>("NumberQuestionDifficult")
                        .HasColumnType("int");

                    b.Property<int>("NumberQuestionEz")
                        .HasColumnType("int");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("TotalNumberQuestion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("TestOnline_Data.Models.ExamDetail", b =>
                {
                    b.Property<string>("ExamId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("QuestionId")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("ExamId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExamDetails");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Notification", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TestOnline_Data.Models.NotificationToClass", b =>
                {
                    b.Property<string>("NotifyId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("NotifyId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("NotificationToClass");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Question", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ChapterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Result", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("UserId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("TestOnline_Data.Models.ResultDetail", b =>
                {
                    b.Property<string>("ResultId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("QuestionId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("AnswerId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.HasKey("ResultId", "QuestionId", "AnswerId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ResultDetails");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("TestOnline_Data.Models.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("NumberCredits")
                        .HasColumnType("int");

                    b.Property<int>("NumberLapSessions")
                        .HasColumnType("int");

                    b.Property<int>("NumberLectureSessions")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TestOnline_Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("TestOnline_Data.Models.UserClasses", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ClassesId")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("UserId", "ClassesId");

                    b.HasIndex("ClassesId");

                    b.ToTable("UserClass", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TestOnline_Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TestOnline_Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TestOnline_Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestOnline_Data.Models.Answer", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Chapter", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Subject", "Subject")
                        .WithMany("Chapters")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Classes", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Subject", "Subject")
                        .WithOne("Classes")
                        .HasForeignKey("TestOnline_Data.Models.Classes", "SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Exam", b =>
                {
                    b.HasOne("TestOnline_Data.Models.User", "User")
                        .WithMany("Exams")
                        .HasForeignKey("CreatedUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Subject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestOnline_Data.Models.ExamDetail", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Exam", "Exam")
                        .WithMany("ExamDetails")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.Question", "Question")
                        .WithMany("ExamDetails")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("TestOnline_Data.Models.NotificationToClass", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Classes", "Class")
                        .WithMany("NotificationToClass")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.Notification", "Notification")
                        .WithMany("NotificationToClass")
                        .HasForeignKey("NotifyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Notification");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Question", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Chapter", "Chapter")
                        .WithMany("Questions")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Result", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Exam", "Exam")
                        .WithMany("Results")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.User", "User")
                        .WithMany("Results")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestOnline_Data.Models.ResultDetail", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Answer", "Answer")
                        .WithMany("ResultDetails")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.Question", "Question")
                        .WithMany("ResultDetails")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.Result", "Result")
                        .WithMany("ResultDetails")
                        .HasForeignKey("ResultId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("TestOnline_Data.Models.UserClasses", b =>
                {
                    b.HasOne("TestOnline_Data.Models.Classes", "Class")
                        .WithMany("UserClasses")
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestOnline_Data.Models.User", "User")
                        .WithMany("UserClasses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Answer", b =>
                {
                    b.Navigation("ResultDetails");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Chapter", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Classes", b =>
                {
                    b.Navigation("NotificationToClass");

                    b.Navigation("UserClasses");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Exam", b =>
                {
                    b.Navigation("ExamDetails");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Notification", b =>
                {
                    b.Navigation("NotificationToClass");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("ExamDetails");

                    b.Navigation("ResultDetails");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Result", b =>
                {
                    b.Navigation("ResultDetails");
                });

            modelBuilder.Entity("TestOnline_Data.Models.Subject", b =>
                {
                    b.Navigation("Chapters");

                    b.Navigation("Classes");

                    b.Navigation("Exams");
                });

            modelBuilder.Entity("TestOnline_Data.Models.User", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Results");

                    b.Navigation("UserClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
