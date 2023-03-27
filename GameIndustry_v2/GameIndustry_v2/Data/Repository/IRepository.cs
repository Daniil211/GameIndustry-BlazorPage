using GameIndustry_v2.Models;

namespace GameIndustry_v2.Data.Repository
{
    public interface IRepository
    {
        List<GameModel> GetAllGames();
        List<Genre> GetAllGenres();
        Genre GetGenreByID(int id);
        bool EditGenre(Genre editedGenre);
    }
}
