﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? RoleName { get; set; }

        public ICollection<Account>? Account { get; } = new List<Account>();
    }
}
