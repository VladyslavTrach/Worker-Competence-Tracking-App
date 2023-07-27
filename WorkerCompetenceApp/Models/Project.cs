using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerCompetenceApp.Models
{
    internal class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public char? Letter { get; set; }
        public string? Collor { get; set; }
        public List<Worker> Workers { get; set; }
        public List<SkillSet> Skills { get; set; }
    }
}
