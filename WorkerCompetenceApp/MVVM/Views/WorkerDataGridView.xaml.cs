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
    /// Interaction logic for WorkerDataGridView.xaml
    /// </summary>
    public partial class WorkerDataGridView : UserControl
    {
        public WorkerDataGridView()
        {
            InitializeComponent();
            PopulateDataGrid();
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
                workers.Add(new Worker() { FullName = w.FullName, Id = w.Id, Position = w.Position, Specialization = w.Specialization, Language = w.Language, Collor = w.Collor, Letter = w.Letter });
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


        private void ViewDetailWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MembersDataGrid.SelectedItem != null)
            {
                var selectedMember = MembersDataGrid.SelectedItem as Worker;

                if (selectedMember != null)
                {
                    DetailsWorkerView detailsWorkerView = new DetailsWorkerView(selectedMember.Id);
                    detailsWorkerView.Show();
                }
            }


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

        private void CogButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateDataGrid();
        }
    }
}
