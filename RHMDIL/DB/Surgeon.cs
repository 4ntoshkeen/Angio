using System;
using System.Collections.Generic;

#nullable disable

namespace RHMDIL.DB
{
    public partial class Surgeon
    {
        public Surgeon()
        {
            OperationRoom1Assistants = new HashSet<OperationRoom1>();
            OperationRoom1Surgeons = new HashSet<OperationRoom1>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public int? TabNumber { get; set; }
        public string PositionType { get; set; }

        public virtual ICollection<OperationRoom1> OperationRoom1Assistants { get; set; }
        public virtual ICollection<OperationRoom1> OperationRoom1Surgeons { get; set; }
    }
}
