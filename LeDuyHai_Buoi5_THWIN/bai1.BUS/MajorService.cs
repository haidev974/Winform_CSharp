using bai1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
        }
    }
}
