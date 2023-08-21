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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkerCompetenceApp.Data;
using WorkerCompetenceApp.Models;
using WorkerCompetenceApp.Views;

namespace WorkerCompetenceApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for ProjectView.xaml
    /// </summary>
    public partial class ProjectView : UserControl
    {
        public ProjectView()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        public void PopulateDataGrid()
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            var converter = new BrushConverter();

            ObservableCollection<Project> projects = new ObservableCollection<Project>();

            var projectsSQL = from project in context.Projects
                             where project.Name != "1"
                             orderby project.Id
                             select project;

            foreach (Project p in projectsSQL)
            {
                projects.Add(new Project() { Name = p.Name, Id = p.Id, Collor = p.Collor, Description = p.Description, Letter = p.Letter});
            }

            ProjectsDataGrid.ItemsSource = projects;
        }

        private void RemoveProject(int Id)
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            // Find the worker by their FullName
            Project projectToRemove = context.Projects.FirstOrDefault(p => p.Id == Id);

            if (projectToRemove != null)
            {
                context.Projects.Remove(projectToRemove);
                context.SaveChanges();
            }
        }
        private void DeleteProjectButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProjectsDataGrid.SelectedItem != null)
            {
                var selectedProject = ProjectsDataGrid.SelectedItem as Project;

                if (selectedProject != null)
                {
                    RemoveProject(selectedProject.Id);
                    PopulateDataGrid();
                }
            }
        }

        private void AddNewProjectButton_Click(object sender, RoutedEventArgs e)
        {
            AddProjectView addProjectView = new AddProjectView();
            addProjectView.Show();
        }

        private void ViewDetailProjectButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProjectsDataGrid.SelectedItem != null)
            {
                var selectedProject = ProjectsDataGrid.SelectedItem as Project;

                if (selectedProject != null)
                {
                    DetailsProjectView detailsProjectView = new DetailsProjectView(selectedProject.Id);
                    detailsProjectView.Show();
                }
            }


        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateDataGrid();
        }
    }
}
