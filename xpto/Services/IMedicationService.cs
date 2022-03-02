using System.Collections.Generic;
using xpto.Entities;

namespace xpto.Services
{
    public interface IMedicationService
    {        
        void AddMedication(MedicationRequestDto pMedication);

        IEnumerable<Medication> GetMedicationsList();

        void DeleteMedicationById(string pId);
    }
}
