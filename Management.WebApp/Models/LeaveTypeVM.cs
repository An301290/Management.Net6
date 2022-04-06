using System.ComponentModel.DataAnnotations;

namespace Management.WebApp.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        [Display(Name = "Default Number of Days")]
        public int DefaultDays { get; set; }   
    }
}


//How to retunr View Models instead of Data Models