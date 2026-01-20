using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using YetenekTakasiApi.Context;
using YetenekTakasiApi.Models;

namespace YetenekTakasiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertsController : ControllerBase
    {
        private readonly YetenekTakasiDbContext _dbContext;

		public AdvertsController(YetenekTakasiDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpGet("getAllAdverts")]
		public IActionResult GetAllAdverts()
		{
			var adverts = _dbContext.Adverts.ToList();
			return Ok(adverts);
		}

		[HttpPost("createAdvert")]
		public IActionResult CreateAdvert(Advert model)
		{
			if(model.Title==null || model.Title=="" || model.Title.IsNullOrEmpty())
			{
				return BadRequest("Başlık alanı boş bırakılamaz!");
			}
			_dbContext.Adverts.Add(model);
			_dbContext.SaveChanges();
			return Ok(new { message = "İlan başarılı bir şekilde eklendi." });
		}


		[HttpGet("getAdvertsByUser/{userId}")]
		public IActionResult GetAdvertsByUser(string userId)
		{
			var adverts = _dbContext.Adverts.Where(a => a.UserId == userId).ToList();
			if (adverts == null || !adverts.Any())
			{
				return NotFound("Bu kullanıcıya ait ilan bulunamadı.");
			}
			return Ok(adverts);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAdvert(int id)
		{
			var advert = await _dbContext.Adverts.FindAsync(id);
			if (advert == null)
			{
				return NotFound(new { message = "İlan bulunamadı." });
			}

			_dbContext.Adverts.Remove(advert);
			await _dbContext.SaveChangesAsync();

			return Ok(new { message = "İlan başarıyla silindi." });
		}
	}
}
