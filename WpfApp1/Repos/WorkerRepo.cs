using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Repos
{
    public class WorkerRepo
    {
        private readonly ManyworkerContext _context = new ManyworkerContext();

        public int GetNumberOfWorkers()
        {
            return _context.Manyworkers.Count();
        }

        public List<Manyworker> GetAllWorkers()
        {
            return _context.Manyworkers.ToList();
        }

        public void RemoveWorker(string email)
        {
            var worker = _context.Manyworkers.FirstOrDefault(w => w.Email == email);
            if (worker != null)
            {
                _context.Manyworkers.Remove(worker);
                _context.SaveChanges();
            }
            
        }

        public void PayWorker(Manyworker worker, int p)
        {
            var workerToPay = _context.Manyworkers.FirstOrDefault(w => w.Email == worker.Email);
            if (workerToPay != null)
            {
                workerToPay.Salary += p;
                _context.SaveChanges();
            }
        }
    }
}
