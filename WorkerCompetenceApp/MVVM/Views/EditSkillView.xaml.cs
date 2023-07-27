using Azure.Core.GeoJson;
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
    /// Interaction logic for EditSkillView.xaml
    /// </summary>
    public partial class EditSkillView : Window
    {
        private int skillId;
        public EditSkillView(int skillId, string skillCategory, string skillOption, string skillLevel,  DateTime dateOfAcq)
        {
            InitializeComponent();
            PopulateListBoxes(skillCategory, skillOption, skillLevel, dateOfAcq);

            this.skillId = skillId;
        }

        private void PopulateListBoxes(string skillCategory, string skillOption, string skillLevel, DateTime dateOfAcq)
        {
            int cnt = 0;
            CategoryComboBox.Items.Clear();

            foreach (string category in CategoriesHelper.Categories)
            {
                CategoryComboBox.Items.Add(category);
            }


            int categoryIndex = CategoriesHelper.Categories.IndexOf(skillCategory);
            int levelIndex = CategoriesHelper.Levels.IndexOf(skillLevel);


            if (categoryIndex >= 0 && categoryIndex < CategoryComboBox.Items.Count)
            {
                CategoryComboBox.SelectedIndex = categoryIndex;
            }

            if (levelIndex >= 0 && levelIndex < CategoryComboBox.Items.Count)
            {
                LevelComboBox.SelectedIndex = levelIndex;
            }


            foreach (string a in OptionComboBox.Items)
            {
                if (a == skillOption)
                {
                    OptionComboBox.SelectedIndex = cnt;
                }
                cnt++;
            }

            DatePicker.SelectedDate = dateOfAcq;
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

                case "Front-end":
                    OptionComboBox.Items.Clear();
                    foreach (string frontEndLang in CategoriesHelper.FrontEndLanguages)
                    {
                        OptionComboBox.Items.Add(frontEndLang);
                    }
                    OptionComboBox.SelectedIndex = 0;
                    break;

            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EditSkilButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDateTime = DatePicker.SelectedDate;
            if (selectedDateTime.HasValue)
            {
                DateTime extractedDate = selectedDateTime.Value;
                EditSkill(CategoryComboBox.Text, OptionComboBox.Text, LevelComboBox.Text, extractedDate.Date); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a date.");
            }
        }

        private void EditSkill(string Category, string Name, string Level, DateTime DateOfAcquisition)
        {
            using (WorkerCompetenceContext context = new WorkerCompetenceContext())
            {
                SkillSet skillToEdit = context.SkillSets.FirstOrDefault(s => s.Id == skillId);

                if (skillToEdit != null)
                {
                    skillToEdit.Category = Category;
                    skillToEdit.Name = Name;
                    skillToEdit.Level = Level;
                    skillToEdit.DateOfAcquisition = DateOfAcquisition;
                }

                context.SaveChanges();
            }
        }

    }
}
