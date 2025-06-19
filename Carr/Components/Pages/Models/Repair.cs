namespace Carr;

public class Repair
{
    public string Title { get; set; }          // Название услуги
    public string Description { get; set; }    // Описание услуги
    public int? Cost { get; set; }             // Стоимость 
    public int Id { get; set; }                // Уникальный идентификатор

    public DateTime ServiceDate { get; set; } = DateTime.Today; // Дата оказания услуги
    public string ServiceName { get; set; } = string.Empty;
        
    
}