using System.Collections.Generic;
using Model.Entities;

namespace Service.IRepository
{
    public interface IFaculty
    {
        List<Faculty> GetFaculties();
    }
}
