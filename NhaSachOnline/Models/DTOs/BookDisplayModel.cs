namespace NhaSachOnline.Models.DTOs
{
  public class BookDisplayModel
  {
    public IEnumerable<Book> Books { get; set; }
    public IEnumerable<Genre> Genres { get; set; }
    public string KeySearch { get; set; } = "";
    public int GenreId { get; set; } = 0;
  }
}
