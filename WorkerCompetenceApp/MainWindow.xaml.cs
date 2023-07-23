using System;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkerCompetenceApp.Data;
using WorkerCompetenceApp.Models;
using WorkerCompetenceApp.Views;


namespace WorkerCompetenceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PopulateDataGrid();
        }



        private bool IsMaximized = false;  
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount== 2) 
            {
                if(IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height= 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    //CornerRadius = 0;

                    IsMaximized = true;
                }
            }
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        public void PopulateDataGrid()
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            var converter = new BrushConverter();

            ObservableCollection<Worker> workers = new ObservableCollection<Worker>();

            var workersSQL = from worker in context.Workers
                             where worker.FullName != "1"
                             orderby worker.Id
                             select worker;

            foreach (Worker w in workersSQL)
            {
                workers.Add(new Worker() { FullName = w.FullName, Id = w.Id, Position = w.Position, Specialization = w.Specialization, Language = w.Language});
            }

            MembersDataGrid.ItemsSource = workers;
        }

        private void RemoveWorker(int Id)
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            // Find the worker by their FullName
            Worker workerToRemove = context.Workers.FirstOrDefault(w => w.Id == Id);

            if (workerToRemove != null)
            {
                context.Workers.Remove(workerToRemove);
                context.SaveChanges();
            }
        }


        private void AddNewWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            AddWorkerView addWorkerView = new AddWorkerView();

            addWorkerView.Show();
        }

        private void DeleteWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MembersDataGrid.SelectedItem != null)
            {
                var selectedMember = MembersDataGrid.SelectedItem as Worker;

                if (selectedMember != null)
                {
                    RemoveWorker(selectedMember.Id);
                    PopulateDataGrid();
                }
            }
        }

        private void EditWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MembersDataGrid.SelectedItem != null)
            {
                Point mouseLocation = Mouse.GetPosition(MembersDataGrid);

                Worker workerToEdit = MembersDataGrid.SelectedItem as Worker;

                EditWorkerView editWorkerView = new EditWorkerView(mouseLocation, workerToEdit.Id, workerToEdit.FullName, workerToEdit.Position, workerToEdit.Specialization, workerToEdit.Language);

                editWorkerView.Show();
               
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PopulateDataGrid();
        }

        private void ViewDetailWorkerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddSkillButton_Click(object sender, RoutedEventArgs e)
        {
            if (MembersDataGrid.SelectedItem != null)
            {
                var selectedMember = MembersDataGrid.SelectedItem as Worker;

                if (selectedMember != null)
                {
                    AddSkillView addSkillView = new AddSkillView(selectedMember.Id);
                    addSkillView.Show();
                }
            }

           

        }
    }

}