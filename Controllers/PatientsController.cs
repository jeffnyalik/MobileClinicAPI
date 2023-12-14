using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileClinicAPI.Data;

namespace MobileClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly DataContext context;
        public PatientsController(DataContext context)
        {
            this.context = context;
        }


    }
}
