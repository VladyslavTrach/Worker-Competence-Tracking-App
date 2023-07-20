using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerCompetenceApp.Models
{
    internal class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public DateTime DateOfAcquisition { get; set; }
    }
}
