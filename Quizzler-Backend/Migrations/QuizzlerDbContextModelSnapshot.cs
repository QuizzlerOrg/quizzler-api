﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quizzler_Backend.Data;

#nullable disable

namespace Quizzler_Backend.Migrations
{
    [DbContext(typeof(QuizzlerDbContext))]
    partial class QuizzlerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Quizzler_Backend.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Flashcard", b =>
                {
                    b.Property<int>("FlashcardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnswerText")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("FlashcardId");

                    b.HasIndex("LessonId");

                    b.ToTable("Flashcard");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.FlashcardLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FlashcardId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("WasCorrect")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("FlashcardId");

                    b.HasIndex("UserId");

                    b.ToTable("FlashcardLog");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("LessonId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.LessonTag", b =>
                {
                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("LessonId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("LessonTag");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.LoginInfo", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("UserId");

                    b.ToTable("LoginInfo");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Media", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<int?>("FlashcardAnswerId")
                        .HasColumnType("int");

                    b.Property<int?>("FlashcardQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.Property<int>("UploaderId")
                        .HasColumnType("int");

                    b.HasKey("MediaId");

                    b.HasIndex("AnswerId")
                        .IsUnique();

                    b.HasIndex("FlashcardAnswerId")
                        .IsUnique();

                    b.HasIndex("FlashcardQuestionId")
                        .IsUnique();

                    b.HasIndex("LessonId")
                        .IsUnique();

                    b.HasIndex("MediaTypeId");

                    b.HasIndex("QuestionId")
                        .IsUnique();

                    b.HasIndex("QuizId")
                        .IsUnique();

                    b.HasIndex("UploaderId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.MediaType", b =>
                {
                    b.Property<int>("MediaTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<long>("MaxSize")
                        .HasColumnType("bigint");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MediaTypeId");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuizOwner")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("QuizId");

                    b.HasIndex("QuizOwner");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Avatar")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("LastSeen")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Answer", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Flashcard", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.Lesson", "Lesson")
                        .WithMany("Flashcards")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.FlashcardLog", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.Flashcard", "Flashcard")
                        .WithMany("FlashcardLog")
                        .HasForeignKey("FlashcardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.User", "User")
                        .WithMany("FlashcardLog")
                        .HasForeignKey("UserId");

                    b.Navigation("Flashcard");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Lesson", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.User", "Owner")
                        .WithMany("Lesson")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.LessonTag", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.Lesson", "Lesson")
                        .WithMany("LessonTags")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.Tag", "Tag")
                        .WithMany("LessonTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.LoginInfo", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.User", "User")
                        .WithOne("LoginInfo")
                        .HasForeignKey("Quizzler_Backend.Models.LoginInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Media", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.Answer", "Answer")
                        .WithOne("AnswerMedia")
                        .HasForeignKey("Quizzler_Backend.Models.Media", "AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.Flashcard", "FlashcardAnswer")
                        .WithOne("AnswerMedia")
                        .HasForeignKey("Quizzler_Backend.Models.Media", "FlashcardAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.Flashcard", "FlashcardQuestion")
                        .WithOne("QuestionMedia")
                        .HasForeignKey("Quizzler_Backend.Models.Media", "FlashcardQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.Lesson", "Lesson")
                        .WithOne("LessonMedia")
                        .HasForeignKey("Quizzler_Backend.Models.Media", "LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.MediaType", "MediaType")
                        .WithMany()
                        .HasForeignKey("MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.Question", "Question")
                        .WithOne("QuestionMedia")
                        .HasForeignKey("Quizzler_Backend.Models.Media", "QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.Quiz", "Quiz")
                        .WithOne("QuizMedia")
                        .HasForeignKey("Quizzler_Backend.Models.Media", "QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizzler_Backend.Models.User", "Uploader")
                        .WithMany("UserMedia")
                        .HasForeignKey("UploaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("FlashcardAnswer");

                    b.Navigation("FlashcardQuestion");

                    b.Navigation("Lesson");

                    b.Navigation("MediaType");

                    b.Navigation("Question");

                    b.Navigation("Quiz");

                    b.Navigation("Uploader");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Question", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Quiz", b =>
                {
                    b.HasOne("Quizzler_Backend.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("QuizOwner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Answer", b =>
                {
                    b.Navigation("AnswerMedia");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Flashcard", b =>
                {
                    b.Navigation("AnswerMedia");

                    b.Navigation("FlashcardLog");

                    b.Navigation("QuestionMedia");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Lesson", b =>
                {
                    b.Navigation("Flashcards");

                    b.Navigation("LessonMedia");

                    b.Navigation("LessonTags");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("QuestionMedia");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Quiz", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("QuizMedia");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.Tag", b =>
                {
                    b.Navigation("LessonTags");
                });

            modelBuilder.Entity("Quizzler_Backend.Models.User", b =>
                {
                    b.Navigation("FlashcardLog");

                    b.Navigation("Lesson");

                    b.Navigation("LoginInfo")
                        .IsRequired();

                    b.Navigation("UserMedia");
                });
#pragma warning restore 612, 618
        }
    }
}
