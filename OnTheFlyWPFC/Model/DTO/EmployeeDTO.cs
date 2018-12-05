﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTheFlyWPFC.Model.DTO
{
    public class EmployeeDTO
    {
        public int employeeID { get; set; }
        public string name { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string address { get; set; }
        public bool active { get; set; }
        public int jobID { get; set; }
        public string jobName { get; set; }
        public string cityID { get; set; }
        public string cityName { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }
        public int? branchID { get; set; }
        public string branchName { get; set; }
    }
}
