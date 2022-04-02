namespace Management.WebApp.Data
{
    //Is partial because I don´t want anyone to instantiate this class bay itself. It muss have an inheritance working with it 
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
