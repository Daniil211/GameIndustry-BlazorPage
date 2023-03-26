using GameIndustry_v2.Data.Repository;
using GameIndustry_v2.Models;

namespace GameIndustry.Repository
{
    public class MockGamesRepository : IRepository
    {
        List<GameModel> _GameModels;

        public MockGamesRepository()
        {
            _GameModels = new List<GameModel>()
            {
            new GameModel()
            {
                Name = "Farming Simulator 2019",
                Genre = "Simulator",
                ReleaseDate = new DateTime(2018, 11, 19),
                Image = "https://cdn1.epicgames.com/epic/offer/Diesel_productv2_farming-simulator-19_home_EGS-GIANTS-FS19-860x1148_Standard-860x1148-a464360aa738f506399aff4c95d0a9c7021dee5f-860x1148-71df4a510f82c42cebe1b1861d2f77a3.jpg"
            },
            new GameModel()
            {
                Name = "The Witcher 3",
                Genre = "Action/RPG",
                ReleaseDate = new DateTime(2015, 05, 18),
                Image = "https://upload.wikimedia.org/wikipedia/ru/a/a2/The_Witcher_3-_Wild_Hunt_Cover.jpg"
            },
            new GameModel()
            {
                Name = "Destroy All Humans!",
                Genre = "Action-Adventure",
                ReleaseDate = new DateTime(2020, 07, 28),
                Image = "https://cdn1.epicgames.com/c12a5687fb024192999b2d22c555d4c6/offer/DAH_Portrait-1200x1600-2e2b6bca291228e4df252c4857664408.jpg"
            }
            };
        }

        public List<GameModel> GetAllGames()
        {
            return _GameModels;
        }
    }
}
