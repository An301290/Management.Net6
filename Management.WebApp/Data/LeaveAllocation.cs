using System.ComponentModel.DataAnnotations.Schema;

namespace Management.WebApp.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        //This represent that I´m connected to the LeaveType Table
        public LeaveType LeaveType { get; set; }  
        //Need a column that represent this foreign key
        public int LeaveTypeId { get; set; }   
        public string EmployeeId { get; set; }  
    }
}
