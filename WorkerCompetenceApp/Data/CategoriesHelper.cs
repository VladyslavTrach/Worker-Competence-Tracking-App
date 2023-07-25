using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerCompetenceApp.Data
{
    public static class CategoriesHelper
    {
        public static List<string> Categories = new List<string>
            {
                "Programming Language",
                "Framework",
                "Front-end",
                "DataBase",
                "Version Control",
                "Cloud Services",
                "Development Methodologies",
                "Game Development",
                "Operating Systems",
                "Design Patterns"
            };

        public static List<string> ProggramingLanguages = new List<string>
            {
                "C#",
                "C++",
                "Java",
                "Python"
            };
        public static List<string> Frameworks = new List<string>
            {
                ".Net",
            };
        public static List<string> MarkupLanguage = new List<string> 
        { 
            "CSS", "HTML", 
        };
        public static List<string> DataBase = new List<string> 
        { 
            "SQL", "RabbitMQ", 
        };
        public static List<string> VersionControl = new List<string> { 
            "Git", "SVN", "Mercurial", "Perforce" 
        };
        public static List<string> CloudServicesAndDeployment = new List<string> 
        { 
            "Amazon Web Services (AWS)", "Microsoft Azure", "Google Cloud Platform (GCP)", "Heroku", "DigitalOcean", "Firebase" 
        };
        public static List<string> SoftwareDevelopmentMethodologies = new List<string>
        { 
            "Agile", "Scrum", "Kanban", "Waterfall", "Extreme Programming (XP)", "Lean Software Development", 
            "Feature-Driven Development (FDD)", "Rapid Application Development (RAD)", "Spiral", 
            "Crystal", "Dynamic Systems Development Method (DSDM)", "Joint Application Development (JAD)", 
            "Incremental", "V-Model", "DevOps", "Continuous Integration (CI)", "Continuous Delivery (CD)" 
        };
        public static List<string> GameDevelopment = new List<string>
        { 
            "Unity", "Unreal Engine", "Godot", "Cocos2d", "Phaser" 
        };
        public static List<string> OperatingSystems = new List<string> { 
            "Windows", "macOS", "Linux", "iOS", "Android" 
        };
        public static List<string> DesignPatterns = new List<string> { 
            "Singleton", "Factory Method", "Observer", "Decorator", 
            "Strategy", "Adapter", "Facade", "Command", "Prototype" 
        };
        public static List<string> FrontEndLanguages = new List<string>
{
    "HTML",
    "CSS",
    "JavaScript",
    "TypeScript",
    "React",
    "Angular",
    "Vue.js"
};


        public static List<string> Levels = new List<string> 
        {
            "Novice", "Intermediate", "Advanced", "Expert", "Master"
        };
    }
}
