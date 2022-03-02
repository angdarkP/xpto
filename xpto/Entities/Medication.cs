using System;

namespace xpto.Entities
{
    public class Medication
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public DateTime CreationDate { get; private set; }

        public Medication(string pName, int pQuantity)
        {
            Id = Guid.NewGuid().ToString();
            Name = string.IsNullOrEmpty(pName) ? throw new ArgumentNullException(nameof(pName)) : pName;
            Quantity = pQuantity < 1 ? throw new ArgumentNullException(nameof(pQuantity)) : pQuantity;
            CreationDate = DateTime.Now;
        }
    }
}
