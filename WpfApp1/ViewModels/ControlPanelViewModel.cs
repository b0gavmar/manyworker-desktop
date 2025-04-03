using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.Repos;

namespace WpfApp1.ViewModels
{
    public partial class ControlPanelViewModel: ObservableObject
    {
        private readonly WorkerRepo _workerRepo;

        [ObservableProperty]
        private string _numberOfWorkers = string.Empty;

        [ObservableProperty]
        private Manyworker _currentWorker;

        [ObservableProperty]
        private int _addedPay = 0;

        [ObservableProperty]
        private ObservableCollection<Manyworker> _workers = new ObservableCollection<Manyworker>();

        public ControlPanelViewModel(WorkerRepo repo)
        {
            _workerRepo = repo;
            
            UpdateData();
        }

        [RelayCommand]
        public void RemoveWorker()
        {
            if (CurrentWorker is null) return;
            _workerRepo.RemoveWorker(CurrentWorker.Email);
            UpdateData();
        }

        [RelayCommand]
        public void PayWorker()
        {
            if (CurrentWorker is null) return;
            _workerRepo.PayWorker(CurrentWorker,AddedPay);
            UpdateData();
        }

        private void UpdateData()
        {
            NumberOfWorkers = _workerRepo.GetNumberOfWorkers().ToString();
            Workers = new ObservableCollection<Manyworker>(_workerRepo.GetAllWorkers());

        }
    }
}
