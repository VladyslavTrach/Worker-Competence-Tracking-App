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

        //private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.ChangedButton == MouseButton.Left)
        //    {
        //        this.DragMove();
        //    }
        //}

        //private void AddWorker(string FullName, string Position, string Specialization, string Language, string Phone, string Email)
        //{
        //    Random random = new Random();
        //    int randomColor = random.Next(100000, 1000000);

        //    char Letter = FullName[0];

        //    using WorkerCompetenceContext context = new WorkerCompetenceContext();


        //    Worker worker = new Worker()
        //    {
        //        FullName = FullName,
        //        Position = Position,
        //        Specialization = Specialization,
        //        Language = Language,
        //        Phone = Phone,
        //        Email = Email,
        //        Collor = ("#" + randomColor.ToString()),
        //        Letter = Letter
        //    };

        //    context.Workers.Add(worker);
        //    context.SaveChanges();
        //}


        //private void CloseButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}

        //private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void AddNewWorkerButton_Click(object sender, RoutedEventArgs e)
        //{
        //    AddWorker(NameTextBox.Text, PositionTextBox.Text, SpecializationTextBox.Text, LangTextBox.Text, PhoneTextBox.Text, EmailNameTextBox.Text);

        //    this.Close();

        //}
    }
}
