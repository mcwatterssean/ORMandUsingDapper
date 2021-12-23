using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyDapperExercise
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        public void InsertDepartment(string newDepartmentName);


    }
}
