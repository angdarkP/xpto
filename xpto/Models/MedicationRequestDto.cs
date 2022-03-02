using System;

namespace xpto.Entities
{
    public struct MedicationRequestDto
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
    }
}
