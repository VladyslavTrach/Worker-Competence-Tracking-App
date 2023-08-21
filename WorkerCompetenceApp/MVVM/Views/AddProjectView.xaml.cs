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

namespace WorkerCompetenceApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for AddProjectView.xaml
    /// </summary>
    public partial class AddProjectView : Window
    {
        public AddProjectView()
        {
            InitializeComponent();
        }

        private void AddNewProjectButton_Click(object sender, RoutedEventArgs e)
        {
            AddProject(NameTextBox.Text, DescriptionTextBox.Text);
            this.Close();
        }


        //private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.ChangedButton == MouseButton.Left)
        //    {
        //        this.DragMove();
        //    }
        //}

        private void AddProject(string Title, string Decription)
        {
            Random random = new Random();
            int randomColor = random.Next(100000, 1000000);

            char Letter = Title[0];

            using WorkerCompetenceContext context = new WorkerCompetenceContext();


            Project project = new Project()
            {
                Name = Title,
                Description = Decription,
                Collor = ("#" + randomColor.ToString()),
                Letter = Letter
            };

            context.Projects.Add(project);
            context.SaveChanges();
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //private void AddNewWorkerButton_Click(object sender, RoutedEventArgs e)
        //{
        //    AddWorker(NameTextBox.Text, PositionTextBox.Text, SpecializationTextBox.Text, LangTextBox.Text, PhoneTextBox.Text, EmailNameTextBox.Text);

        //    this.Close();

        //}
    }
}
