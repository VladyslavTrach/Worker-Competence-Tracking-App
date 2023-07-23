using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorkerCompetenceApp.Data;
using WorkerCompetenceApp.Models;

namespace WorkerCompetenceApp.Views
{
    /// <summary>
    /// Interaction logic for AddSkillView.xaml
    /// </summary>
    public partial class AddSkillView : Window
    {
        private int workerId;

        public AddSkillView(int WorkerId)
        {
            InitializeComponent();
            PopulateListBoxes();

            this.workerId = WorkerId;

            CategoryComboBox.SelectionChanged += CategoryComboBox_SelectionChanged;
        }

        private void PopulateListBoxes()
        {
            CategoryComboBox.Items.Clear();

            foreach (string category in CategoriesHelper.Categories)
            {
                CategoryComboBox.Items.Add(category);
            }

            OptionComboBox.Items.Add("Select category");
            LevelComboBox.Items.Add("Select category");

            OptionComboBox.SelectedIndex = 0;
            LevelComboBox.SelectedIndex = 0;

            DatePicker.SelectedDate = DateTime.Today;
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {         
            string selectedCategory = CategoryComboBox.SelectedItem as string;

            LevelComboBox.Items.Clear();
            foreach (string level in CategoriesHelper.Levels)
            {
                LevelComboBox.Items.Add(level);
            }
            LevelComboBox.SelectedIndex = 0;

            switch (selectedCategory)
            {
                case "Programming Language":
                    OptionComboBox.Items.Clear();
                    foreach (string pLang in CategoriesHelper.ProggramingLanguages)
                    {                        
                        OptionComboBox.Items.Add(pLang);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Framework":
                    OptionComboBox.Items.Clear();
                    foreach (string framework in CategoriesHelper.Frameworks)
                    {
                        OptionComboBox.Items.Add(framework);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Markup Language":
                    OptionComboBox.Items.Clear();
                    foreach (string markupLang in CategoriesHelper.MarkupLanguage)
                    {
                        OptionComboBox.Items.Add(markupLang);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "DataBase":
                    OptionComboBox.Items.Clear();
                    foreach (string dataBase in CategoriesHelper.DataBase)
                    {
                        OptionComboBox.Items.Add(dataBase);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Version Control":
                    OptionComboBox.Items.Clear();
                    foreach (string versionControl in CategoriesHelper.VersionControl)
                    {
                        OptionComboBox.Items.Add(versionControl);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Cloud Services and Deployment":
                    OptionComboBox.Items.Clear();
                    foreach (string cloudServicesAndDeployment in CategoriesHelper.CloudServicesAndDeployment)
                    {
                        OptionComboBox.Items.Add(cloudServicesAndDeployment);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Software Development Methodologies":
                    OptionComboBox.Items.Clear();
                    foreach (string softwareDevelopmentMethodologies in CategoriesHelper.SoftwareDevelopmentMethodologies)
                    {
                        OptionComboBox.Items.Add(softwareDevelopmentMethodologies);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Game Development":
                    OptionComboBox.Items.Clear();
                    foreach (string gameDevelopment in CategoriesHelper.GameDevelopment)
                    {
                        OptionComboBox.Items.Add(gameDevelopment);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Operating Systems":
                    OptionComboBox.Items.Clear();
                    foreach (string operatingSystems in CategoriesHelper.OperatingSystems)
                    {
                        OptionComboBox.Items.Add(operatingSystems);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

                case "Software Design Patterns":
                    OptionComboBox.Items.Clear();
                    foreach (string designPatterns in CategoriesHelper.DesignPatterns)
                    {
                        OptionComboBox.Items.Add(designPatterns);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

            }
        }

        private void AddSkill(string Category, string Name, string Level, DateTime DateOfAcquisition, int workerId)
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            SkillSet skill = new SkillSet()
            {
                Category = Category,
                Name = Name,
                Level = Level,
                DateOfAcquisition = DateOfAcquisition,
                WorkerId = workerId
            };

            context.SkillSets.Add(skill);
            context.SaveChanges();
        }

        private void AddSkillToDB_ButtonClick(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDateTime = DatePicker.SelectedDate;
            if (selectedDateTime.HasValue)
            {
                DateTime extractedDate = selectedDateTime.Value;
                AddSkill(CategoryComboBox.Text, OptionComboBox.Text, LevelComboBox.Text, extractedDate, this.workerId); // Use the stored WorkerId
                this.Close();
            }
            else
            {
                // Handle the case where no date is selected in the DatePicker
                MessageBox.Show("Please select a date.");
            }
        }

    }
}
