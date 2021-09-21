﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SICAU.App.Persistencia;

namespace SICAU.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SICAU.App.Dominio.Encuesta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("estadoCovid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaDiagnostico")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaEncuesta")
                        .HasColumnType("datetime2");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("encuestas");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Horario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("diasemana")
                        .HasColumnType("int");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<DateTime>("horaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int?>("materiaid")
                        .HasColumnType("int");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<int?>("salonid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("materiaid");

                    b.HasIndex("personaid");

                    b.HasIndex("salonid");

                    b.ToTable("horarios");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Materia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("materia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("materias");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estadoCovid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Salon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("capacidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("salones");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Sede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("sedes");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Sintoma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Encuestaid")
                        .HasColumnType("int");

                    b.Property<string>("sintoma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Encuestaid");

                    b.ToTable("sintomas");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Directivo", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<string>("unidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Directivo");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<string>("carrera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("semestre")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("SICAU.App.Dominio.PersonalAseo", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<int>("turno")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("PersonalAseo");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("materia")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Encuesta", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Horario", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Materia", "materia")
                        .WithMany()
                        .HasForeignKey("materiaid");

                    b.HasOne("SICAU.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.HasOne("SICAU.App.Dominio.Salon", "salon")
                        .WithMany()
                        .HasForeignKey("salonid");

                    b.Navigation("materia");

                    b.Navigation("persona");

                    b.Navigation("salon");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Sintoma", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Encuesta", null)
                        .WithMany("sintoma")
                        .HasForeignKey("Encuestaid");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Encuesta", b =>
                {
                    b.Navigation("sintoma");
                });
#pragma warning restore 612, 618
        }
    }
}
