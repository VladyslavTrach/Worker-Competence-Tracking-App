using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WorkerCompetenceApp.Migrations;
using WorkerCompetenceApp.Models;

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

       //     List<int> skillSetIds = context.ProjectToSkillSets
       //.Where(pts => pts.ProjectId == projectId)
       //.Select(pts => pts.SkillSetId)
       //.ToList();








            //var skillsSQL = from skill in context.SkillSets
            //                where skill.ProjectId == ProjectId
            //                orderby skill.Id
            //                select skill;

            //foreach (SkillSet s in skillsSQL)
            //{
            //    skills.Add(new SkillSet()
            //    {
            //        Id = s.Id,
            //        Category = s.Category,
            //        Name = s.Name,
            //        Level = s.Level,
            //        DateOfAcquisition = s.DateOfAcquisition,
            //        ProjectId = s.ProjectId
            //    });
            //}

            //SkillsDataGrid.ItemsSource = skills;






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

                isTopEditActive = true;

                TopNameTextBox.Background = Brushes.Green;
                LetterTextBox.Background = Brushes.Green;
                CollorTextBox.Background = Brushes.Green;
            }
            else
            {
                TopNameTextBox.IsReadOnly = true;
                LetterTextBox.IsReadOnly = true;
                CollorTextBox.IsReadOnly = true;

                isTopEditActive = false;

                TopNameTextBox.Background = Brushes.Transparent;
                LetterTextBox.Background = Brushes.Transparent;
                CollorTextBox.Background = Brushes.Transparent;

                EditProject(ProjectId, TopNameTextBox.Text, DescriptionTextBox.Text, LetterTextBox.Text, CollorTextBox.Text);
                PopulateDataGrid();

            }
        }

        private void EditMiddleRowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (!isMidEditActive)
            {
                DescriptionTextBox.IsReadOnly = false;

                isMidEditActive = true;

                DescriptionTextBox.Background = Brushes.Green;
            }
            else
            {
                DescriptionTextBox.IsReadOnly = true;

                isMidEditActive = false;

                DescriptionTextBox.Background = Brushes.Transparent;

                EditProject(ProjectId, TopNameTextBox.Text, DescriptionTextBox.Text, LetterTextBox.Text, CollorTextBox.Text); 
                PopulateDataGrid();
            }
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

        }

        private void EditSkillButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteSkillButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
