﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Individual_project.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupLocation { get; set; }
        public IList<User> Users { get; set; }
    }
}