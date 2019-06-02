using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voluncheer.Models;

/// <summary>
/// Define an interface which contains the methods for the Volunteer repository.
/// All CRUDi aspects
/// </summary>
namespace Voluncheer.Backend
{
    interface IVolunteerRepository
    {
        VolunteerModel Create(VolunteerModel data);
        VolunteerModel Read(String id);
        VolunteerModel Update(VolunteerModel data);
        Boolean Delete(String id);
        List<VolunteerModel> Index();
    }
}
