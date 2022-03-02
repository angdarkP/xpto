using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using xpto.Entities;
using xpto.Services;

namespace xpto.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MedicationsController : ControllerBase
    {
        private readonly IMedicationService myMedicationService;

        public MedicationsController(IMedicationService pService)
        {
            myMedicationService = pService ?? throw new ArgumentNullException(nameof(pService));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Medication>), StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Medication>> GetMedicineList()
        {
            return Ok(myMedicationService.GetMedicationsList());
        }

        [HttpPost]
        public ActionResult AddMedicine(MedicationRequestDto pMedicationRequest)
        {
            myMedicationService.AddMedication(pMedicationRequest);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteMedicine(string pId)
        {
            myMedicationService.DeleteMedicationById(pId);
            return Ok();
        }
    }
}
