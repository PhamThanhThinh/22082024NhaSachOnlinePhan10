using NhaSachOnline.Models;

namespace NhaSachOnline.Repositories
{
  public interface IHomeRepository
  {
    Task<IEnumerable<Book>> GetBooks(string keySearch = "", int genreId = 0);
    Task<IEnumerable<Genre>> Genres();
  }
}
