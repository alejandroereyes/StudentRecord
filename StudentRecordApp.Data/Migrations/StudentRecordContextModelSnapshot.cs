using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StudentRecordApp.Data;

namespace StudentRecordApp.Data.Migrations
{
    [DbContext(typeof(StudentRecordContext))]
    partial class StudentRecordContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentRecordApp.Domain.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("Unit");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserId");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("StudentRecordApp.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Grade");

                    b.Property<string>("Name");

                    b.Property<int>("StudentId");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentRecordApp.Domain.Credit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("StudentId");

                    b.Property<string>("Type");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("UserId");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("StudentRecordApp.Domain.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaCode");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Prefix");

                    b.Property<int>("Suffix");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("StudentRecordApp.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Type");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("StudentRecordApp.Domain.Student", b =>
                {
                    b.HasBaseType("StudentRecordApp.Domain.User");


                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("StudentRecordApp.Domain.Address", b =>
                {
                    b.HasOne("StudentRecordApp.Domain.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("StudentRecordApp.Domain.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentRecordApp.Domain.Course", b =>
                {
                    b.HasOne("StudentRecordApp.Domain.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentRecordApp.Domain.Credit", b =>
                {
                    b.HasOne("StudentRecordApp.Domain.Student")
                        .WithMany("Credits")
                        .HasForeignKey("StudentId");

                    b.HasOne("StudentRecordApp.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentRecordApp.Domain.PhoneNumber", b =>
                {
                    b.HasOne("StudentRecordApp.Domain.User", "User")
                        .WithOne("PhoneNumber")
                        .HasForeignKey("StudentRecordApp.Domain.PhoneNumber", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
