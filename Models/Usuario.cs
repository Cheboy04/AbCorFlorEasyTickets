namespace ProjectoTicketsAbCorFlo.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        //1 USUARIO VARIOS TICKETS
        public List<Ticket> tickets { get; set; }
        

    }
}
