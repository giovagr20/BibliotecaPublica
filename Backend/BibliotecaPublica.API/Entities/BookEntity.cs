namespace BibliotecaPublica.API.Entities
{
    /*
    * author: Giovanni Gomez
    * description: Clase Entity de Book
    */
    public class BookEntity
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime anio { get; set; }
        public string genero { get; set; }
        public int numeroPaginas { get; set; }
    }
}
