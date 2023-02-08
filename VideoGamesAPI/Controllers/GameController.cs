using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGamesAPI.Data;
using VideoGamesAPI.Models;

namespace VideoGamesAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class GameController : Controller
    {
        [HttpGet("GetGames")]
        public IActionResult Get()
        {
            return Ok(GameData.GetAll());
        }
        [HttpGet("FindGame")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(GameData.GetById(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] GameModel value)
        {
            try
            {
                GameData.Add(value);
                return Ok("Success!");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] GameModel value)
        {
            try
            {
                GameData.Update(value);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            GameData.Remove(id);
            return Ok("Product Removed");
        }
    }
}
