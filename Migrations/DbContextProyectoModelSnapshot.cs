﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerTresModEmpleados.Models.DAL;

namespace TallerTresModEmpleados.Migrations
{
    [DbContext(typeof(DbContextProyecto))]
    partial class DbContextProyectoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TallerTresModEmpleados.Models.Entities.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CambioEstado")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InternoExterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoId");

                    b.ToTable("CargosPrivTours");
                });

            modelBuilder.Entity("TallerTresModEmpleados.Models.Entities.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CambioEstado")
                        .HasColumnType("bit");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.ToTable("EmpleadosPrivTours");
                });
#pragma warning restore 612, 618
        }
    }
}
