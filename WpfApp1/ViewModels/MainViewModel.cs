using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Repos;

namespace WpfApp1.ViewModels
{
    public class MainViewModel
    {
        public WorkerRepo _workerRepo = new WorkerRepo();
        public ControlPanelViewModel ControlPanelsViewModel { get; set; }

        public MainViewModel()
        {
            ControlPanelsViewModel = new ControlPanelViewModel(_workerRepo);
        }
    }
}
