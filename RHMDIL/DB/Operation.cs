using System;
using System.Collections.Generic;

#nullable disable

namespace RHMDIL.DB
{
    public partial class Operation
    {
        public Operation()
        {
            OperationRoom1s = new HashSet<OperationRoom1>();
        }

        public int Id { get; set; }
        public string OperationName { get; set; }

        public virtual ICollection<OperationRoom1> OperationRoom1s { get; set; }
    }
}
