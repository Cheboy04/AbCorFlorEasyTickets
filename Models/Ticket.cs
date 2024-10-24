namespace ProjectoTicketsAbCorFlo.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string? Evento { get; set; }
        public double precio { get; set; }
        public string? Lugar { get; set; }
        public string? ButacaArea { get; set; }
        public DateTime Fecha { get; set; }
        //1 usuario por ticket
        public int UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }

    }
}
