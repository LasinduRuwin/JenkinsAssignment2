using Microsoft.AspNetCore.Mvc.RazorPages;
using VideoGamesAPI.Models;

namespace VideoGamesAPI.Data
{
    public class GameData
    {
        private static GameModel _dummyData1 = new GameModel() { Id = 1, Name = "God of War Ragnarok", Genre = "Action/Adventure", Developer = "Sony Santa Monica", Publisher = "Sony", Price = 59.99 };
        private static GameModel _dummyData2 = new GameModel() { Id = 2, Name = "Batman Arkham Asylum", Genre = "Action/Adventure", Developer = "Eidos & Rocksteady", Publisher = "WB", Price = 59.99 };
        private static GameModel _dummyData3 = new GameModel() { Id = 3, Name = "Mortal Kombat X", Genre = "Arcade Fighting", Developer = "Netherrealm Studios", Publisher = "WB", Price = 59.99 };
        private static GameModel _dummyData4 = new GameModel() { Id = 4, Name = "Need For Speed Unbound", Genre = "Arcade Racing", Developer = "Critireon Games", Publisher = "EA", Price = 59.99 };
        private static GameModel _dummyData5 = new GameModel() { Id = 5, Name = "Call of Duty Modern Warfare", Genre = "Action/FPS/Shooter", Developer = "Activision", Publisher = "Blizzard", Price = 59.99 };
        private static GameModel _dummyData6 = new GameModel() { Id = 6, Name = "Forza Motorsports 7", Genre = "Simulation/Racing", Developer = "Microsoft Studios", Publisher = "Microsoft Xbox", Price = 59.99 };

        private static Dictionary<int, GameModel> Games = new Dictionary<int, GameModel>() 
        { {1,_dummyData1 },{ 2,_dummyData2},{ 3,_dummyData3},{ 4,_dummyData4},{ 5,_dummyData5},{ 6,_dummyData6} };

        // add product
        public static void Add(GameModel product)
        {
            Games.Add(product.Id, product);
        }

        // retreive the products
        public static IEnumerable<GameModel> GetAll()
        {
            return Games.Values;
        }

        // retrive a single product
        public static GameModel GetById(int id)
        {
            return Games[id];
        }

        //update a product
        public static void Update(GameModel product)
        {
            Games[product.Id] = product;
        }

        //remove an event
        public static void Remove(int id)
        {
            Games.Remove(id);
        }
    }
}
