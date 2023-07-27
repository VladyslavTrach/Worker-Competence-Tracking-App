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
using WorkerCompetenceApp.Models;
using System.Drawing;
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;

namespace WorkerCompetenceApp.Views
{
    /// <summary>
    /// Interaction logic for DetailsWorkerView.xaml
    /// </summary>
    public partial class DetailsWorkerView : Window
    {
        public int WorkerId;
        public bool isTopEditActive = false;
        public bool isMidEditActive = false;
        public DetailsWorkerView(int workerId)
        {
            WorkerId = workerId;

            InitializeComponent();
            PopulateDataGrid();
        }

        public void PopulateDataGrid()
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            ObservableCollection<SkillSet> skills = new ObservableCollection<SkillSet>();

            var skillsSQL = from skill in context.SkillSets
                            where skill.WorkerId == WorkerId
                            orderby skill.Id
                            select skill;

            foreach (SkillSet s in skillsSQL)
            {
                skills.Add(new SkillSet()
                {
                    Id= s.Id,
                    Category = s.Category,
                    Name = s.Name,
                    Level = s.Level,
                    DateOfAcquisition = s.DateOfAcquisition,
                    WorkerId = s.WorkerId
                });
            }

            SkillsDataGrid.ItemsSource = skills;



            var worker = context.Workers.SingleOrDefault(w => w.Id == WorkerId);
            if (worker != null)
            {
                string colorString = worker.Collor; // Assuming worker.Color is a string representing the color (e.g., "#FF0000" for red).
                Color color = (Color)ColorConverter.ConvertFromString(colorString);
                RoundBorder.Background = new SolidColorBrush(color);
                CircleTextBlock.Text = worker.Letter.ToString();

                TopNameTextBox.Text = worker.FullName;
                TopPositionTextBox.Text = worker.Position;
                TopLangTextBox.Text = worker.Language;

                NameTextBox.Text = worker.FullName;
                PositionTextBox.Text = worker.Position;
                SpecializationTextBox.Text = worker.Specialization;
                PhoneTextBox.Text = worker.Phone;
                EmailNameTextBox.Text = worker.Email;
                CollorTextBox.Text = worker.Collor;
                LetterTextBox.Text = worker.Letter.ToString();
            }
        }

        private void EditTopRowDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if(!isTopEditActive)
            {
                TopNameTextBox.IsReadOnly = false;
                TopPositionTextBox.IsReadOnly = false;
                TopLangTextBox.IsReadOnly = false;

                isTopEditActive = true;

                TopNameTextBox.Background = Brushes.Green;
                TopPositionTextBox.Background = Brushes.Green;
                TopLangTextBox.Background = Brushes.Green;
            }
            else
            {
                TopNameTextBox.IsReadOnly = true;
                TopPositionTextBox.IsReadOnly = true;
                TopLangTextBox.IsReadOnly = true;

                isTopEditActive = false;

                TopNameTextBox.Background = Brushes.Transparent;
                TopPositionTextBox.Background = Brushes.Transparent;
                TopLangTextBox.Background = Brushes.Transparent;

                EditWorker(WorkerId, TopNameTextBox.Text, TopPositionTextBox.Text, SpecializationTextBox.Text, TopLangTextBox.Text, PhoneTextBox.Text, EmailNameTextBox.Text, LetterTextBox.Text, CollorTextBox.Text);
                PopulateDataGrid();

            }
        }

        private void EditMiddleRowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (!isMidEditActive)
            {
                NameTextBox.IsReadOnly = false;
                PositionTextBox.IsReadOnly = false;
                SpecializationTextBox.IsReadOnly = false;
                PhoneTextBox.IsReadOnly = false;
                EmailNameTextBox.IsReadOnly = false;
                LetterTextBox.IsReadOnly = false;
                CollorTextBox.IsReadOnly = false;

                isMidEditActive = true;

                NameTextBox.Background = Brushes.Green;
                PositionTextBox.Background = Brushes.Green;
                SpecializationTextBox.Background = Brushes.Green;
                PhoneTextBox.Background = Brushes.Green;
                EmailNameTextBox.Background = Brushes.Green;
                LetterTextBox.Background = Brushes.Green;
                CollorTextBox.Background = Brushes.Green;
            }
            else
            {
                NameTextBox.IsReadOnly = true;
                PositionTextBox.IsReadOnly = true;
                SpecializationTextBox.IsReadOnly = true;
                PhoneTextBox.IsReadOnly = true;
                EmailNameTextBox.IsReadOnly = true;
                LetterTextBox.IsReadOnly = true;
                CollorTextBox.IsReadOnly = true;


                isMidEditActive = false;

                NameTextBox.Background = Brushes.Transparent;
                PositionTextBox.Background = Brushes.Transparent;
                SpecializationTextBox.Background = Brushes.Transparent;
                PhoneTextBox.Background = Brushes.Transparent;
                EmailNameTextBox.Background = Brushes.Transparent;
                LetterTextBox.Background = Brushes.Transparent;
                CollorTextBox.Background = Brushes.Transparent;

                EditWorker(WorkerId, NameTextBox.Text, PositionTextBox.Text, SpecializationTextBox.Text, TopLangTextBox.Text, PhoneTextBox.Text, EmailNameTextBox.Text, LetterTextBox.Text, CollorTextBox.Text);
                PopulateDataGrid();
            }
        }

        private void EditSkillButton_Click(object sender, RoutedEventArgs e)
        {
            if (SkillsDataGrid.SelectedItem != null)
            {
                var selectedSkill = SkillsDataGrid.SelectedItem as SkillSet;

                if (selectedSkill != null)
                {
                    EditSkillView editSkillView = new EditSkillView(selectedSkill.Id, selectedSkill.Category, selectedSkill.Name, selectedSkill.Level, selectedSkill.DateOfAcquisition);
                    editSkillView.Show();
                }
            }
        }

        private void DeleteSkillButton_Click(object sender, RoutedEventArgs e)
        {
            if (SkillsDataGrid.SelectedItem != null)
            {
                var selectedSkill = SkillsDataGrid.SelectedItem as SkillSet;

                if (selectedSkill != null)
                {
                    RemoveSkill(selectedSkill.Id);
                    PopulateDataGrid();
                }
            }
        }

        private void RemoveSkill(int skillId)
        {
            using WorkerCompetenceContext context = new WorkerCompetenceContext();

            SkillSet SkillToRemove = context.SkillSets.FirstOrDefault(s => s.Id == skillId);

            if (SkillToRemove != null)
            {
                context.SkillSets.Remove(SkillToRemove);
                context.SaveChanges();
            }
        }


        private void EditWorker(int id, string newFullName, string newPosition, string newSpecialization, string newLanguage, string newPhone, string newEmail, string newLetter, string newCollor)
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
                    workerToEdit.Phone = newPhone; 
                    workerToEdit.Email = newEmail;
                    workerToEdit.Letter = newLetter[0];
                    workerToEdit.Collor = newCollor;
                }

                context.SaveChanges();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            EditWorker(WorkerId, NameTextBox.Text, PositionTextBox.Text, SpecializationTextBox.Text, TopLangTextBox.Text, PhoneTextBox.Text, EmailNameTextBox.Text, LetterTextBox.Text, CollorTextBox.Text);
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
