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

            modelBuilder.Entity("SICAU.App.Dominio.EncuestaCovid", b =>
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

                    b.ToTable("encuestaCovids");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Facultad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facultad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("facultades");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Facultad");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Grupo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("horarioid")
                        .HasColumnType("int");

                    b.Property<int?>("materiaid")
                        .HasColumnType("int");

                    b.Property<string>("numeroGrupo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("profesorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("horarioid");

                    b.HasIndex("materiaid");

                    b.HasIndex("profesorid");

                    b.ToTable("grupos");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Horario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("diaSemana")
                        .HasColumnType("int");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<DateTime>("horaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int?>("salonid")
                        .HasColumnType("int");

                    b.HasKey("id");

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

                    b.Property<int?>("programaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("programaid");

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

            modelBuilder.Entity("SICAU.App.Dominio.Sede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sede")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("universidadid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("universidadid");

                    b.ToTable("sedes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Sede");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Sintoma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EncuestaCovidid")
                        .HasColumnType("int");

                    b.Property<string>("sintoma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("EncuestaCovidid");

                    b.ToTable("sintomas");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Universidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("universidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("universidades");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Programa", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Facultad");

                    b.Property<string>("programa")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Programa");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Directivo", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<int?>("sedeid")
                        .HasColumnType("int");

                    b.Property<string>("unidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("sedeid");

                    b.HasDiscriminator().HasValue("Directivo");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<int?>("Grupoid")
                        .HasColumnType("int");

                    b.Property<int?>("programaid")
                        .HasColumnType("int");

                    b.Property<int>("semestre")
                        .HasColumnType("int");

                    b.HasIndex("Grupoid");

                    b.HasIndex("programaid");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("SICAU.App.Dominio.PersonalAseo", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<int?>("sedeid")
                        .HasColumnType("int")
                        .HasColumnName("PersonalAseo_sedeid");

                    b.Property<int>("turno")
                        .HasColumnType("int");

                    b.HasIndex("sedeid");

                    b.HasDiscriminator().HasValue("PersonalAseo");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Persona");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Salon", b =>
                {
                    b.HasBaseType("SICAU.App.Dominio.Sede");

                    b.Property<int>("capacidad")
                        .HasColumnType("int");

                    b.Property<string>("numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Salon");
                });

            modelBuilder.Entity("SICAU.App.Dominio.EncuestaCovid", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Grupo", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Horario", "horario")
                        .WithMany()
                        .HasForeignKey("horarioid");

                    b.HasOne("SICAU.App.Dominio.Materia", "materia")
                        .WithMany()
                        .HasForeignKey("materiaid");

                    b.HasOne("SICAU.App.Dominio.Profesor", "profesor")
                        .WithMany()
                        .HasForeignKey("profesorid");

                    b.Navigation("horario");

                    b.Navigation("materia");

                    b.Navigation("profesor");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Horario", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Salon", "salon")
                        .WithMany()
                        .HasForeignKey("salonid");

                    b.Navigation("salon");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Materia", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Programa", "programa")
                        .WithMany()
                        .HasForeignKey("programaid");

                    b.Navigation("programa");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Sede", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Universidad", "universidad")
                        .WithMany()
                        .HasForeignKey("universidadid");

                    b.Navigation("universidad");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Sintoma", b =>
                {
                    b.HasOne("SICAU.App.Dominio.EncuestaCovid", null)
                        .WithMany("sintoma")
                        .HasForeignKey("EncuestaCovidid");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Directivo", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Sede", "sede")
                        .WithMany()
                        .HasForeignKey("sedeid");

                    b.Navigation("sede");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Grupo", null)
                        .WithMany("estudiantes")
                        .HasForeignKey("Grupoid");

                    b.HasOne("SICAU.App.Dominio.Programa", "programa")
                        .WithMany()
                        .HasForeignKey("programaid");

                    b.Navigation("programa");
                });

            modelBuilder.Entity("SICAU.App.Dominio.PersonalAseo", b =>
                {
                    b.HasOne("SICAU.App.Dominio.Sede", "sede")
                        .WithMany()
                        .HasForeignKey("sedeid");

                    b.Navigation("sede");
                });

            modelBuilder.Entity("SICAU.App.Dominio.EncuestaCovid", b =>
                {
                    b.Navigation("sintoma");
                });

            modelBuilder.Entity("SICAU.App.Dominio.Grupo", b =>
                {
                    b.Navigation("estudiantes");
                });
#pragma warning restore 612, 618
        }
    }
}
