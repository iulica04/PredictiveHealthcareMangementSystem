﻿// <auto-generated />
using System;
using Identity.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Identity.Migrations
{
    [DbContext(typeof(UsersDbContext))]
    partial class UsersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Domain.Entities.MedicalCondition", b =>
                {
                    b.Property<Guid>("MedicalConditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsGenetic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommendation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MedicalConditionId");

                    b.ToTable("MedicalCondition");
                });

            modelBuilder.Entity("Domain.Entities.Medication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AdverseEffects")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PrescriptionId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("Domain.Entities.PatientRecord", b =>
                {
                    b.Property<Guid>("PatientRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MedicalConditionId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TreatmentId")
                        .HasColumnType("TEXT");

                    b.HasKey("PatientRecordId");

                    b.HasIndex("MedicalConditionId");

                    b.HasIndex("PatientId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("PatientRecord");
                });

            modelBuilder.Entity("Domain.Entities.Prescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("Domain.Entities.Treatment", b =>
                {
                    b.Property<Guid>("TreatmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MedicalConditionId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PrescriptionId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("TreatmentId");

                    b.HasIndex("MedicalConditionId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("Treatment");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<int>("Type");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Entities.Admin", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.HasDiscriminator().HasValue(0);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3839f91c-c2d7-4fca-987d-9ba155aafb28"),
                            Address = "Piata Unirii nr.3, Iasi",
                            BirthDate = new DateTime(2004, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "admin1@gmail.com",
                            FirstName = "Admin1",
                            Gender = "Female",
                            LastName = "User",
                            PasswordHash = "$2a$11$0HgjUGGoGnvGt0pwyhB8BOKLD83PuB27yU35NUPCz34gEM1A8x/jy",
                            PhoneNumber = "0757732675",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("9e470494-50fc-4361-9b8b-7c8a172fa474"),
                            Address = "Strada Libertatii nr.10, Iasi",
                            BirthDate = new DateTime(2003, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "admin2@gmail.com",
                            FirstName = "Admin2",
                            Gender = "Male",
                            LastName = "User",
                            PasswordHash = "$2a$11$0VJj.0p.cyW3KERp1WjWF.Jk5BGcF77z.CNpcavQIH6KNxbp0/LU.",
                            PhoneNumber = "0751234567",
                            Type = 0
                        });
                });

            modelBuilder.Entity("Domain.Entities.Medic", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.Property<string>("Hospital")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Domain.Entities.Patient", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Domain.Entities.Medication", b =>
                {
                    b.HasOne("Domain.Entities.Prescription", null)
                        .WithMany("Medications")
                        .HasForeignKey("PrescriptionId");
                });

            modelBuilder.Entity("Domain.Entities.PatientRecord", b =>
                {
                    b.HasOne("Domain.Entities.MedicalCondition", "MedicalCondition")
                        .WithMany()
                        .HasForeignKey("MedicalConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Patient", null)
                        .WithMany("PatientRecords")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Treatment", "Treatment")
                        .WithMany()
                        .HasForeignKey("TreatmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalCondition");

                    b.Navigation("Treatment");
                });

            modelBuilder.Entity("Domain.Entities.Treatment", b =>
                {
                    b.HasOne("Domain.Entities.MedicalCondition", null)
                        .WithMany("Treatments")
                        .HasForeignKey("MedicalConditionId");

                    b.HasOne("Domain.Entities.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Domain.Entities.MedicalCondition", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("Domain.Entities.Prescription", b =>
                {
                    b.Navigation("Medications");
                });

            modelBuilder.Entity("Domain.Entities.Patient", b =>
                {
                    b.Navigation("PatientRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
