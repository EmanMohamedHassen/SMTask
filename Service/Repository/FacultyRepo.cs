using Service.IRepository;
using System.Collections.Generic;
using Model.Entities;
using System.Linq;

namespace Service.Repository
{
    public class FacultyRepo : IFaculty
    {
        public AppDBContext Context { get; }
        public FacultyRepo (AppDBContext context)
        {
            Context = context;
        }

        public List<Faculty> GetFaculties()
        {
            return Context.faculties.ToList();
        }
    }
}
