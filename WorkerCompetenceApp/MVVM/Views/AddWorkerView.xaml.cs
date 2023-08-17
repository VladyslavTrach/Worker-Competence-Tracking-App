using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WorkerCompetenceApp.Models;
using WorkerCompetenceApp.MVVM.Views;

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

        private void AddWorker(string FullName, string Position, string Specialization, string Language, string Phone, string Email)
        {
            Random random = new Random();
            int randomColor = random.Next(100000, 1000000);

            char Letter = FullName[0];

            using WorkerCompetenceContext context = new WorkerCompetenceContext();


            Worker worker = new Worker()
            {
                FullName = FullName,
                Position = Position,
                Specialization = Specialization,
                Language = Language,
                Phone = Phone,
                Email = Email,
                Collor = ("#" + randomColor.ToString()),
                Letter = Letter
            };

            context.Workers.Add(worker);
            context.SaveChanges();
        }

        private string IsInputCorrect(string FullName, string Position, string Specialization, string Language, string Phone, string Email)
        {            
            if (NameTextBox.Text == null || NameTextBox.Text.Length < 5 || NameTextBox.Text.Length > 30 || Regex.IsMatch(NameTextBox.Text, @"\d"))
                return "Name";
            if (PositionTextBox.Text == null || PositionTextBox.Text.Length < 5 || PositionTextBox.Text.Length > 30 || Regex.IsMatch(PositionTextBox.Text, @"\d"))
                return "Position";
            if (SpecializationTextBox.Text == null || SpecializationTextBox.Text.Length < 5 || SpecializationTextBox.Text.Length > 30 || Regex.IsMatch(SpecializationTextBox.Text, @"\d"))
                return "Specialization";
            if (LangTextBox.Text == null || LangTextBox.Text.Length > 15 )
                return "Language";
            if (PhoneTextBox.Text == null || PhoneTextBox.Text.Length != 10 || Regex.IsMatch(PhoneTextBox.Text, @"[a-zA-Z]"))
                return "Phone";
            if (EmailNameTextBox.Text == null || EmailNameTextBox.Text.Length < 5 || !EmailNameTextBox.Text.Contains("@") || !EmailNameTextBox.Text.Contains(".") )
                return "Email";

            return "Correct";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void AddNewWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            switch (IsInputCorrect(NameTextBox.Text, PositionTextBox.Text, SpecializationTextBox.Text, LangTextBox.Text, PhoneTextBox.Text, EmailNameTextBox.Text))
            {
                case "Correct":
                    AddWorker(NameTextBox.Text, PositionTextBox.Text, SpecializationTextBox.Text, LangTextBox.Text, PhoneTextBox.Text, EmailNameTextBox.Text);
                    this.Close();
                    break;

                case "Name":
                    ClearAllTextBoxCollor();
                    NameTextBox.Background = Brushes.Red;
                    break;

                case "Position":
                    ClearAllTextBoxCollor();
                    PositionTextBox.Background = Brushes.Red;
                    break;

                case "Specialization":
                    ClearAllTextBoxCollor();
                    SpecializationTextBox.Background = Brushes.Red;
                    break;

                case "Language":
                    ClearAllTextBoxCollor();
                    LangTextBox.Background = Brushes.Red;
                    break;

                case "Phone":
                    ClearAllTextBoxCollor();
                    PhoneTextBox.Background = Brushes.Red;
                    break;

                case "Email":
                    ClearAllTextBoxCollor();
                    EmailNameTextBox.Background = Brushes.Red;
                    break;
            }
        }

        private void ClearAllTextBoxCollor()
        {
            NameTextBox.Background = Brushes.Transparent;
            PositionTextBox.Background = Brushes.Transparent;
            SpecializationTextBox.Background = Brushes.Transparent;
            LangTextBox.Background = Brushes.Transparent;
            PhoneTextBox.Background = Brushes.Transparent;
            EmailNameTextBox.Background = Brushes.Transparent;
        }
    }
}
