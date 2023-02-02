using System.ComponentModel.DataAnnotations;

namespace AutorApi.Models;

public class Autor{
    public int Id { get; set; }
    
    [MaxLength(200)]
    public string Nome { get; set; }
    [DataType(DataType.Date)]
    public DateTime Dt_nasc { get; set; }


}