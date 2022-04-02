namespace Management.WebApp.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }  
        //each type will have some type of default days
        public string DefaultDays { get; set; } 
      
    }
}
