namespace PosPizza.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string? Nombres { get; set; }
        public string? Dni { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? Usuario { get; set; }
        public string? Clave { get; set; }
        public bool Estado { get; set; }
        public string? RolDescripcion { get; set; }
    }
}