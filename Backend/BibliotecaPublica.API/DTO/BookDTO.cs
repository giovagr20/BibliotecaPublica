namespace BibliotecaPublica.API.DTO
{
    /*
     * author: Giovanni Gomez
     * description: Clase DTO de Book
     */
    public class BookDTO
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime anio { get; set; }
        public string genero { get; set; }
        public int numeroPaginas { get; set; }
    }
}
