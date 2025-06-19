namespace Carr; 


public class Client
{
    public string Name { get; set; }          // Имя клиента
    public string Description { get; set; }   // Описание проблемы
    public DateTime AppointmentDate { get; set; } // Дата назначения
    
    public TimeOnly AppointmentTime { get; set; } = new TimeOnly(10, 0); // Время 
    public int Id { get; set; }               // Уникальный идентификатор
    public int ServiceId { get; set; }  // Связь с услугой

    
}