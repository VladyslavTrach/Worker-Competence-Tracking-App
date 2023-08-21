using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using WorkerCompetenceApp.Migrations;
using WorkerCompetenceApp.Models;
using WorkerCompetenceApp.Views;
using SkillSet = WorkerCompetenceApp.Models.SkillSet;

namespace WorkerCompetenceApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for DetailsProjectView.xaml
    /// </summary>
    public partial class DetailsProjectView : Window
    {
        public int ProjectId;
        public bool isTopEditActive = false;
        public bool isMidEditActive = false;
        public DetailsProjectView(int projectId)
        {
            ProjectId = projectId;

            InitializeComponent();
            PopulateDataGrid();
        }

        public void PopulateDataGrid()
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            ObservableCollection<SkillSet> skills = new ObservableCollection<SkillSet>();

            var skillsSQL = from skill in context.SkillSets
                            where skill.ProjectId == ProjectId
                            orderby skill.Id
                            select skill;

            foreach (SkillSet s in skillsSQL)
            {
                skills.Add(new SkillSet()
                {
                    Id = s.Id,
                    Category = s.Category,
                    Name = s.Name,
                    Level = s.Level,
                    DateOfAcquisition = s.DateOfAcquisition,
                    ProjectId = s.ProjectId
                });
            }

            SkillsDataGrid.ItemsSource = skills;






            var project = context.Projects.SingleOrDefault(w => w.Id == ProjectId);
            if (project != null)
            {
                string colorString = project.Collor; // Assuming worker.Color is a string representing the color (e.g., "#FF0000" for red).
                Color color = (Color)ColorConverter.ConvertFromString(colorString);
                RoundBorder.Background = new SolidColorBrush(color);
                CircleTextBlock.Text = project.Letter.ToString();

                TopNameTextBox.Text = project.Name;

                DescriptionTextBox.Text = project.Description;
                CollorTextBox.Text = project.Collor;
                LetterTextBox.Text = project.Letter.ToString();
            }
        }

        private void EditTopRowDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isTopEditActive)
            {
                TopNameTextBox.IsReadOnly = false;
                LetterTextBox.IsReadOnly = false;
                CollorTextBox.IsReadOnly = false;                

                TopNameTextBox.Background = Brushes.Green;
                LetterTextBox.Background = Brushes.Green;
                CollorTextBox.Background = Brushes.Green;

                isTopEditActive = true;
                EditTopTextBlock.Text = "Save";
            }
            else
            {
                switch (IsTopRowDetailsCorrect())
                {
                    case "Correct":
                        TopNameTextBox.IsReadOnly = true;
                        LetterTextBox.IsReadOnly = true;
                        CollorTextBox.IsReadOnly = true;


                        ClearAllTextBoxCollor();
                        isTopEditActive = false;
                        EditTopTextBlock.Text = "Edit";

                        EditProject(ProjectId, TopNameTextBox.Text, DescriptionTextBox.Text, LetterTextBox.Text, CollorTextBox.Text);
                        PopulateDataGrid();
                        break;

                    case "Name":
                        ClearAllTextBoxCollor();
                        TopNameTextBox.Background = Brushes.Red;
                        break;

                    case "Letter":
                        ClearAllTextBoxCollor();
                        LetterTextBox.Background = Brushes.Red;
                        break;

                    case "Collor":
                        ClearAllTextBoxCollor();
                        CollorTextBox.Background = Brushes.Red;
                        break;
                }
            }
        }

        private string IsTopRowDetailsCorrect()
        {
            if (TopNameTextBox.Text == null || TopNameTextBox.Text.Length < 5 || TopNameTextBox.Text.Length > 30 || Regex.IsMatch(TopNameTextBox.Text, @"\d"))
                return "Name";
            if (LetterTextBox.Text == null || LetterTextBox.Text.Length != 1)
                return "Letter";
            if (CollorTextBox.Text == null || CollorTextBox.Text.Length != 7 || Regex.IsMatch(CollorTextBox.Text, @"[a-zA-Z]"))
                return "Collor";

            return "Correct";
        }

        private void EditMiddleRowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (!isMidEditActive)
            {
                DescriptionTextBox.IsReadOnly = false;

                DescriptionTextBox.Background = Brushes.Green;

                isMidEditActive = true;
                EditBottomTextBlock.Text = "Save";
            }
            else
            {
                switch (IsMiddleRowDetailsCorrect())
                {
                    case "Correct":
                        DescriptionTextBox.IsReadOnly = true;

                        isMidEditActive = false;

                        ClearAllTextBoxCollor();

                        EditBottomTextBlock.Text = "Edit";

                        EditProject(ProjectId, TopNameTextBox.Text, DescriptionTextBox.Text, LetterTextBox.Text, CollorTextBox.Text); 
                        PopulateDataGrid();
                        break;


                    case "Description":
                        ClearAllTextBoxCollor();
                        DescriptionTextBox.Background = Brushes.Red;
                        break;
                }

            }
        }

        private string IsMiddleRowDetailsCorrect()
        {
            if (DescriptionTextBox.Text == null || DescriptionTextBox.Text.Length > 30)
                return "Description";

            return "Correct";
        }

        private void EditProject(int id, string newName, string newDescription, string newLetter, string newCollor)
        {
            using (WorkerCompetenceContext context = new WorkerCompetenceContext())
            {
                Project projectToEdit = context.Projects.FirstOrDefault(p => p.Id == id);

                if (projectToEdit != null)
                {
                    projectToEdit.Name = newName;
                    projectToEdit.Description = newDescription;
                    projectToEdit.Letter = newLetter[0];
                    projectToEdit.Collor = newCollor;
                }

                context.SaveChanges();
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EditSkillButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void DeleteSkillButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewSkillButton_Click(object sender, RoutedEventArgs e)
        {
            AddSkillView addSkillView = new AddSkillView(63, ProjectId);
            addSkillView.Show();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateDataGrid();
        }

        public void ClearAllTextBoxCollor()
        {
            TopNameTextBox.Background = Brushes.Transparent;
            LetterTextBox.Background = Brushes.Transparent;
            CollorTextBox.Background = Brushes.Transparent;

            DescriptionTextBox.Background = Brushes.Transparent;
        }
    }
}
