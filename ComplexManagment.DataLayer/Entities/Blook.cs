﻿namespace ComplexManagment.DataLayer.Entities
{
    public class Blook
    {
        public Blook()
        {
            Units = new HashSet<Unit>(); 
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitCount { get; set; }
        public int ComplexId { get; set; }
        public Complex Complex { get; set; }

        public HashSet<Unit> Units { get; set; }
    }
}
