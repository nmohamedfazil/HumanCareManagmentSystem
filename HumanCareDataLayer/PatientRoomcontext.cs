using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HumanCareModelLayer.Models;

namespace HumanCareDataLayer
{
    public class PatientRoomcontext : DbContext
    {
        public PatientRoomcontext()
            : base("name=HumanCareEntities")
        {
        }
        public DbSet<PatientRoom> PatientRoomcontextgs { get; set; } 
    }
}