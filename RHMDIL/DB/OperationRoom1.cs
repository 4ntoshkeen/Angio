using System;
using System.Collections.Generic;

#nullable disable

namespace RHMDIL.DB
{
    public partial class OperationRoom1
    {
        public int Id { get; set; }
        public DateTime? OperationDate { get; set; }
        public byte? Cito { get; set; }
        public TimeSpan? OperationTimeStart { get; set; }
        public TimeSpan? OperationTimeFinish { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public DateTime? PatientBirthday { get; set; }
        public int? DepartmentId { get; set; }
        public int? HistoryNumber { get; set; }
        public TimeSpan? FluoTime { get; set; }
        public int? Dose { get; set; }
        public int? Stents { get; set; }
        public byte? Elevation { get; set; }
        public int? SurgeonId { get; set; }
        public int? AssistantId { get; set; }
        public int? NurseId { get; set; }
        public int? LaboratorianId { get; set; }
        public int? CleanerId { get; set; }
        public int? AnesthesiologistId { get; set; }
        public int? AnesthesiologistNurseId { get; set; }
        public int? CardiologistId { get; set; }
        public int? OperationTypeId { get; set; }
        public int? ToolingNameId { get; set; }
        public int? ToolingSizeId { get; set; }
        public int? ToolingQuantity { get; set; }

        public virtual Anesthesiologist Anesthesiologist { get; set; }
        public virtual AnesthesiologistNurse AnesthesiologistNurse { get; set; }
        public virtual Surgeon Assistant { get; set; }
        public virtual Cardiologist Cardiologist { get; set; }
        public virtual Cleaner Cleaner { get; set; }
        public virtual Department Department { get; set; }
        public virtual Laboratorian Laboratorian { get; set; }
        public virtual Nurse Nurse { get; set; }
        public virtual Operation OperationType { get; set; }
        public virtual Surgeon Surgeon { get; set; }
    }
}
