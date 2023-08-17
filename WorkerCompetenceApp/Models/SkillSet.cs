using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerCompetenceApp.Models
{
    class SkillSet
    {
        public int Id { get; set; }
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Level { get; set; }
        public DateTime DateOfAcquisition { get; set; }
        public int WorkerId { get; set; }
        public int ProjectId { get; set; }
        public Worker worker { get; set; } = null!;
        public List<Project> Projects { get; set; }
    }
}
