using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HumanCareModelLayer.Models
{
    public class PatientRoom
    {
        public int patientid { get; set; }
        public string roomid { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public string treatmentid { get; set; }
    }
}