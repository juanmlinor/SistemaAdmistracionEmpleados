using BaseLibrary.Entities;
using Microsoft.AspNetCore.Mvc;
using ServerLibrary.Repositories.Contracts;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController(IGenericRepositoryInterface<Doctor> genericRepositoryInterface) : GenericController<Doctor>(genericRepositoryInterface)
    {
    }
}
