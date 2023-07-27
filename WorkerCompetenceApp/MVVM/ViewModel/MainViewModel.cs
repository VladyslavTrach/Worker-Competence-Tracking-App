using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerCompetenceApp.Core;

namespace WorkerCompetenceApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand WorkerDataGridCommand { get; set; }
        public RelayCommand ProjectCommand { get; set; }
        public WorkerDataGridViewModel WorkerDataGridVM { get; set; }
        public ProjectViewModel ProjectVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            WorkerDataGridVM = new WorkerDataGridViewModel();
            ProjectVM = new ProjectViewModel();

            CurrentView = WorkerDataGridVM;

            WorkerDataGridCommand = new RelayCommand(o =>
            {
                CurrentView = WorkerDataGridVM;
            }); ;


            ProjectCommand = new RelayCommand(o =>
            {
                CurrentView = ProjectVM;
            }); ;
        }
    }
}
