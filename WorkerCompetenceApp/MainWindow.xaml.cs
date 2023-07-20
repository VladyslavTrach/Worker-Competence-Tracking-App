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

            //AddWorker("Volodymur Pigarev", "Boss", "Mechanic");
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

        private void PopulateDataGrid()
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
    }

}





//Skill Dota = new Skill()
//{
//    Id = 8,
//};

//Worker Vlad = new Worker()
//{
//    Name = "Max",
//    SurName = "Chaba",
//    Age = 20,
//    SkillId = Dota.Id
//};

//context.Workers.Add(Vlad);
//context.SaveChanges();

//var workers = from worker in context.Workers
//              where worker.SurName == "Chaba"
//              orderby worker.Id
//              select worker;


//foreach(Worker w in workers)
//{
//    textBox.Text += $"id:     {w.Id}\n";
//    textBox.Text += $"Name:     {w.Name}\n";
//    textBox.Text += $"Surname:     {w.SurName}\n";
//    textBox.Text += $"Skill Id:     {w.SkillId}\n";
//    textBox.Text += "----------------\n\n";

//}