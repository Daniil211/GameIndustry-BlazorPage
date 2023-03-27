﻿using GameIndustry_v2.Data.Repository;
using GameIndustry_v2.Models;

namespace GameIndustry.Repository
{
    public class MockGamesRepository : IRepository
    {
        readonly List<GameModel> _GameModels;
        private readonly List<Genre> _genres;


        public MockGamesRepository()
        {
            _GameModels = new List<GameModel>()
            {
            new GameModel()
            {
                Name = "Farming Simulator 2019",
                GenreId = 4,
                ReleaseDate = new DateTime(2018, 11, 19),
                Image = "https://cdn1.epicgames.com/epic/offer/Diesel_productv2_farming-simulator-19_home_EGS-GIANTS-FS19-860x1148_Standard-860x1148-a464360aa738f506399aff4c95d0a9c7021dee5f-860x1148-71df4a510f82c42cebe1b1861d2f77a3.jpg"
            },
            new GameModel()
            {
                Name = "The Witcher 3",
                GenreId = 0,
                ReleaseDate = new DateTime(2015, 05, 18),
                Image = "https://upload.wikimedia.org/wikipedia/ru/a/a2/The_Witcher_3-_Wild_Hunt_Cover.jpg"
            },
            new GameModel()
            {
                Name = "Destroy All Humans!",
                GenreId = 1,
                ReleaseDate = new DateTime(2020, 07, 28),
                Image = "https://cdn1.epicgames.com/c12a5687fb024192999b2d22c555d4c6/offer/DAH_Portrait-1200x1600-2e2b6bca291228e4df252c4857664408.jpg"
            }
            };
            _genres = new List<Genre>()
            {
                new Genre()
                {
                    Id=0,
                    Name="RPG"
                },
                new Genre()
                {
                    Id=1,
                    Name="Action"
                },
                new Genre()
                {
                    Id=2,
                    Name="Horror"
                },
                new Genre()
                {
                    Id=3,
                    Name="Platformer"
                },
                new Genre()
                {
                    Id=4,
                    Name="Simulator"
                }
            };
        }

        public List<GameModel> GetAllGames()
        {
            return _GameModels;
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }

        public Genre GetGenreByID(int id)
        {
            return _genres.FirstOrDefault(X=>X.Id.Equals(id));
        }

        public bool EditGenre(Genre editedGenre)
        {
            var oldGenre = _genres.FirstOrDefault(x => x.Id.Equals(editedGenre.Id));
            if (oldGenre is not null)
            {
                oldGenre = editedGenre;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
