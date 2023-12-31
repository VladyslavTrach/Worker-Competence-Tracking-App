﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WorkerCompetenceApp.Models
{
    internal class Worker
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string? Position { get; set; }
        public string? Language { get; set; }
        public string? Specialization { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public char? Letter { get; set; }
        public string? Collor { get; set; }
        public List<Project> Projects{ get; set; }
    }
}
