using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileClinicAPI.Data;
using MobileClinicAPI.Models;

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

        // GET: api/Patients
        [HttpGet]
        public IActionResult Get()
        {
            var patients = context.Patients.ToList();
            return Ok(patients);
        }

        // GET: api/Patients/1
        [HttpGet("{id}", Name = "GetPatient")]
        public IActionResult Get(int id)
        {
            var patient = context.Patients.Find(id);

            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

        // POST: api/Patients
        [HttpPost]
        public IActionResult Post([FromBody] Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();

            return CreatedAtRoute("GetPatient", new { id = patient.ID }, patient);
        }

        // PUT: api/Patients/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Patient updatedPatient)
        {
            var existingPatient = context.Patients.Find(id);

            if (existingPatient == null)
            {
                return NotFound();
            }

            existingPatient.FirstName = updatedPatient.FirstName;
            existingPatient.LastName = updatedPatient.LastName;
            existingPatient.OtherName = updatedPatient.OtherName;
            existingPatient.DateOfBirth = updatedPatient.DateOfBirth;
            existingPatient.Gender = updatedPatient.Gender;
            existingPatient.IDNumber = updatedPatient.IDNumber;
            existingPatient.HomeCounty = updatedPatient.HomeCounty;
            existingPatient.Mobile = updatedPatient.Mobile;
            existingPatient.Email = updatedPatient.Email;
            existingPatient.NameOfAlternative = updatedPatient.NameOfAlternative;
            existingPatient.TelephoneNumber = updatedPatient.TelephoneNumber;
            existingPatient.HasDisability = updatedPatient.HasDisability;

            context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Patients/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var patient = context.Patients.Find(id);

            if (patient == null)
            {
                return NotFound();
            }

            context.Patients.Remove(patient);
            context.SaveChanges();

            return NoContent();
        }
    }
}
