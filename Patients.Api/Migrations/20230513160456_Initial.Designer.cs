﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patients.Api.Data;

#nullable disable

namespace Patients.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230513160456_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Patients.Api.Models.DataMaster", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nmdato");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("feregistro");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("febaja");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("dsdato");

                    b.Property<string>("MasterId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nmmaestro");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2")
                        .HasColumnName("feactulizacion");

                    b.HasKey("Id");

                    b.HasIndex("MasterId");

                    b.ToTable("DataMaestra");
                });

            modelBuilder.Entity("Patients.Api.Models.Master", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nmmaestro");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("feregistro");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("febaja");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("dsmaestro");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2")
                        .HasColumnName("feactulizacion");

                    b.HasKey("Id");

                    b.ToTable("Maestras");
                });

            modelBuilder.Entity("Patients.Api.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("nmid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Condition")
                        .HasMaxLength(20)
                        .HasColumnType("text")
                        .HasColumnName("condicion");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("feregistro");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("febaja");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("nmid_medicotra");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("nmid_persona");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2")
                        .HasColumnName("feactulizacion");

                    b.Property<string>("User")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("cdusuario");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PersonId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Patients.Api.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("nmid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("dsdireccion");

                    b.Property<DateTime>("Born")
                        .HasColumnType("date")
                        .HasColumnName("fenacimiento");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cdtelefono_movil");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("feregistro");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("febaja");

                    b.Property<string>("Document")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cddocument");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("dsemail");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("cdgenero");

                    b.Property<string>("LastNames")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("dsapellidos");

                    b.Property<string>("Names")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("dsnombres");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cdtelefono_fijo");

                    b.Property<string>("Photo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("dsphoto");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2")
                        .HasColumnName("feactulizacion");

                    b.Property<string>("User")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("cdusuario");

                    b.Property<string>("UserType")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("cdtipo");

                    b.HasKey("Id");

                    b.HasIndex("Born");

                    b.HasIndex("Document");

                    b.HasIndex("Names");

                    b.HasIndex("UserType");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Patients.Api.Models.DataMaster", b =>
                {
                    b.HasOne("Patients.Api.Models.Master", "Master")
                        .WithMany("DataMasters")
                        .HasForeignKey("MasterId");

                    b.Navigation("Master");
                });

            modelBuilder.Entity("Patients.Api.Models.Patient", b =>
                {
                    b.HasOne("Patients.Api.Models.Person", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Patients.Api.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Patients.Api.Models.Master", b =>
                {
                    b.Navigation("DataMasters");
                });
#pragma warning restore 612, 618
        }
    }
}
