using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AddWorkerView.xaml
    /// </summary>
    public partial class AddWorkerView : Window
    {
        public AddWorkerView()
        {
            InitializeComponent();
        }



        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void AddWorker(string FullName, string Position, string Specialization, string Language)
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            Worker worker = new Worker()
            {
                FullName = FullName,
                Position = Position,
                Specialization = Specialization,
                Language = Language
            };

            context.Workers.Add(worker);
            context.SaveChanges();
        }

        private void AddWorkerToDB_Button_Click(object sender, RoutedEventArgs e)
        {
            AddWorker(FullNameTextBox.Text, PositionTextBox.Text, SpecializationTextBox.Text, LanguageTextBox.Text);

            this.Close();
        }


    }
}
