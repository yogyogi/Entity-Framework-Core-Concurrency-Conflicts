﻿using System.ComponentModel.DataAnnotations;

namespace CT.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
