using System;
using System.Collections.Generic;
using xpto.Entities;

namespace xpto.Repositories
{
    public interface IMedicationRepository
    {
        void AddMedication(Medication pMedication);

        IEnumerable<Medication> GetAllMedication();

        void DeleteMedication(string pId);
    }
}
