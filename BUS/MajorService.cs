using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFacylty(int facultyID)
        {
            StudentContextDB context = new StudentContextDB(); 
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
        }
    }
}
