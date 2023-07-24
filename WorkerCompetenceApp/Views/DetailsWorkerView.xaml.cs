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
                TopNameTextBox.Text = worker.FullName;
                TopPositionTextBox.Text = worker.Position;
                TopSpecializationTextBox.Text = worker.Specialization;

                NameTextBox.Text = worker.FullName;
                PositionTextBox.Text = worker.Position;
                SpecializationTextBox.Text = worker.Specialization;
                PhoneTextBox.Text = worker.Phone;
                EmailNameTextBox.Text = worker.Email;

                string character = worker.FullName;
                CircleTextBlock.Text = character[0].ToString();
            }
        }

        private void EditTopRowDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if(!isTopEditActive)
            {
                TopNameTextBox.IsReadOnly = false;
                TopPositionTextBox.IsReadOnly = false;
                TopSpecializationTextBox.IsReadOnly = false;

                isTopEditActive = true;

                TopNameTextBox.Background = Brushes.Green;
                TopPositionTextBox.Background = Brushes.Green;
                TopSpecializationTextBox.Background = Brushes.Green;
            }
            else
            {
                TopNameTextBox.IsReadOnly = true;
                TopPositionTextBox.IsReadOnly = true;
                TopSpecializationTextBox.IsReadOnly = true;

                isTopEditActive = false;

                TopNameTextBox.Background = Brushes.Transparent;
                TopPositionTextBox.Background = Brushes.Transparent;
                TopSpecializationTextBox.Background = Brushes.Transparent;
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

                isMidEditActive = true;

                NameTextBox.Background = Brushes.Green;
                PositionTextBox.Background = Brushes.Green;
                SpecializationTextBox.Background = Brushes.Green;
                PhoneTextBox.Background = Brushes.Green;
                EmailNameTextBox.Background = Brushes.Green;
            }
            else
            {
                NameTextBox.IsReadOnly = true;
                PositionTextBox.IsReadOnly = true;
                SpecializationTextBox.IsReadOnly = true;
                PhoneTextBox.IsReadOnly = true;
                EmailNameTextBox.IsReadOnly = true;

                isMidEditActive = false;

                NameTextBox.Background = Brushes.Transparent;
                PositionTextBox.Background = Brushes.Transparent;
                SpecializationTextBox.Background = Brushes.Transparent;
                PhoneTextBox.Background = Brushes.Transparent;
                EmailNameTextBox.Background = Brushes.Transparent;
            }
        }

        private void EditSkillButton_Click(object sender, RoutedEventArgs e)
        {
           
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



        //private void RemoveWorker(int Id)
        //{
        //    using WorkerCompetenceContext context = new WorkerCompetenceContext();

        //    // Find the worker by their FullName
        //    Worker workerToRemove = context.Workers.FirstOrDefault(w => w.Id == Id);

        //    if (workerToRemove != null)
        //    {
        //        context.Workers.Remove(workerToRemove);
        //        context.SaveChanges();
        //    }
        //}
    }
}
