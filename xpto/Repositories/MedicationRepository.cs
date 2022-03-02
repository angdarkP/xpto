using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using xpto.Context;
using xpto.Entities;

namespace xpto.Repositories
{
    public class MedicationRepository : IMedicationRepository
    {
        protected MyDbContext myContext;

        public MedicationRepository(MyDbContext pContext)
        {
            myContext = pContext;
        }

        public void AddMedication(Medication pMedication)
        {
            myContext.Add(pMedication);
        }

        public void DeleteMedication(string pId)
        {
            myContext.Remove(pId);
        }

        public IEnumerable<Medication> GetAllMedication()
        {
            return myContext.Medication;
        }
    }
}
