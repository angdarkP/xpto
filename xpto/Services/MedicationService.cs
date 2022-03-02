using System.Collections.Generic;
using xpto.Entities;
using xpto.Repositories;

namespace xpto.Services
{
    public class MedicationService : IMedicationService
    {
        private readonly IUnitOfWork myUnitOfWork;
        private readonly IMedicationRepository myMedicationRepository;

        public void AddMedication(MedicationRequestDto pMedication)
        {
            var newMedication = new Medication(pMedication.Name, pMedication.Quantity);

            myMedicationRepository.AddMedication(newMedication);
            myUnitOfWork.Commit();
        }

        public IEnumerable<Medication> GetMedicationsList()
        {
            return myMedicationRepository.GetAllMedication();
        }

        public void DeleteMedicationById(string pId)
        {
            myMedicationRepository.DeleteMedication(pId);
            myUnitOfWork.Commit();
        }
    }
}
