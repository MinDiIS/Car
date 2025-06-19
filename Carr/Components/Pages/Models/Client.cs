namespace Carr; 


public class Client
{
    public string Name { get; set; }          
    public string Description { get; set; }   
    public DateTime AppointmentDate { get; set; } = DateTime.Now;
    public TimeOnly AppointmentTime { get; set; } = new TimeOnly(10, 0); 
    public int Id { get; set; }              
    public int ServiceId { get; set; }  

}
