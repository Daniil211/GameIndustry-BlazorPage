using GameIndustry_v2.Models;

namespace GameIndustry_v2.Data.Repository
{
    public interface IRepository
    {
        List<GameModel> GetAllGames();
        bool CreateNewGame(GameModel newGame);
        GameModel GetGameById(int id);
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        bool EditGenre(Genre editedGenre);
        List<GameDeveloper> GetAllDevelopers();
    }
}
