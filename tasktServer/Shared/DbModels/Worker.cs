﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tasktServer.Shared.DbModels
{
    public class Worker
    {
        [Key]
        public Guid WorkerID { get; set; }
        public string MachineName { get; set; }
        public string UserName { get; set; }
        public DateTime LastCheckIn { get; set; }
        public WorkerStatus Status { get; set; }
    }

    public enum WorkerStatus
    {
        Pending = 0,
        Authorized = 1,
        Revoked = 2,
        AutoPending = 3
    }


}
