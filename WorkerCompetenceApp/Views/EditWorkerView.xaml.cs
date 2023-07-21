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

namespace WorkerCompetenceApp.Views
{
    /// <summary>
    /// Interaction logic for EditWorkerView.xaml
    /// </summary>
    public partial class EditWorkerView : Window
    {
        public EditWorkerView(Point mouseLocation, int Id, string FullName, string Position, string Specialization, string Language)
        {
            InitializeComponent();

            Left= mouseLocation.X;
            Top= mouseLocation.Y + Height + 235;

            IdEditTextBox.Text = Id.ToString();
            FullNameEditTextBox.Text = FullName;
            PositionEditTextBox.Text = Position;
            SpecializationEditTextBox.Text = Specialization;
            LanguageEditTextBox.Text = Language;

            
        }


        private void EditWorker(int id, string newFullName, string newPosition, string newSpecialization, string newLanguage)
        {
            using (WorkerCompetenceContext context = new WorkerCompetenceContext())
            {
                Worker workerToEdit = context.Workers.FirstOrDefault(w => w.Id == id);

                if (workerToEdit != null)
                {
                    workerToEdit.FullName = newFullName;
                    workerToEdit.Position = newPosition;
                    workerToEdit.Specialization = newSpecialization;
                    workerToEdit.Language = newLanguage;
                }

                context.SaveChanges();
            }
        }

        private void DontAddWorkerToDB_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddWorkerToDB_Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(IdEditTextBox.Text, out int ParsedId);
            EditWorker(ParsedId, FullNameEditTextBox.Text, PositionEditTextBox.Text, SpecializationEditTextBox.Text, LanguageEditTextBox.Text);
            this.Close();
        }
    }
}
