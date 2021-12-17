﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    class DashboardModel
    {
        public string SendMessages { get; set; }
        public string FailedMessages { get; set; }
        public string SuccessMessages { get; set; }
        public string Balance { get; set; }
        public string Users { get; set; }
        public string Groups { get; set; }
        public string Templates { get; set; }
        public User User { get; set; }
    }
}
