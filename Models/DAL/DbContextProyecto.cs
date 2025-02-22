﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerTresModEmpleados.Models.Entities;

namespace TallerTresModEmpleados.Models.DAL
{
    public class DbContextProyecto: DbContext
    {

        public DbContextProyecto(DbContextOptions<DbContextProyecto> options) : base(options)
        {

        }

        public DbSet<Empleado> EmpleadosPrivTours { get; set; }
        public DbSet<Cargo> CargosPrivTours { get; set; }


    }
}
