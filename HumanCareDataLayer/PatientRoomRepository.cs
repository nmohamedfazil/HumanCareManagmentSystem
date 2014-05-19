using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using HumanCareModelLayer.Models;

namespace HumanCareDataLayer
{
    public class PatientRoomRepository
    {
        PatientRoomcontext dbobject = new PatientRoomcontext();

        public IEnumerable<PatientRoom> GetallRoom()
        {
            return dbobject.PatientRoomcontextgs;
        }
    }
}