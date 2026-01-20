using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YetenekTakasiApi.Context;
using YetenekTakasiApi.Models;

namespace YetenekTakasiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly YetenekTakasiDbContext _dbContext;

		public UsersController(YetenekTakasiDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		[HttpGet("getAllUsers")]
		public IActionResult GetAllUsers()
		{
			var users = _dbContext.Users.ToList();  //veri tabanına bağlan users tablosuna git verilerin tümünü getir
			return Ok(users);
		}

		[HttpGet("getByIdUser/{id}")]
		public IActionResult GetByIdUser(string id)
		{
			var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
			if (user == null)
			{
				return NotFound("Kullanıcı bulunamadı.");
			}
			return Ok(user);
		}

		[HttpPost("AddInformationUser")]
		public IActionResult AddInformationUser(User model)
		{
			// Başlık ve Soyad alanları kontrol ediliyor
			if (string.IsNullOrEmpty(model.Name))
			{
				return BadRequest("İsim alanı boş bırakılamaz!");
			}
			if (string.IsNullOrEmpty(model.Surname))
			{
				return BadRequest("Soyisim alanı boş bırakılamaz!");
			}

			// Kullanıcıyı veritabanından bulalım
			var user = _dbContext.Users.FirstOrDefault(u => u.Id == model.Id);

			if (user == null)
			{
				// Eğer kullanıcı bulunamadıysa, yeni kullanıcı ekleyelim
				user = new User
				{
					Id = model.Id,
					Name = model.Name,
					Surname = model.Surname
				};

				_dbContext.Users.Add(user); // Yeni kullanıcıyı ekle
				_dbContext.SaveChanges();

				return Ok(new { message = "Yeni kullanıcı başarıyla eklendi." });
			}
			else
			{
				// Kullanıcıyı bulduysak, bilgileri güncelleyelim
				user.Name = model.Name;
				user.Surname = model.Surname;

				_dbContext.SaveChanges(); // Değişiklikleri kaydet

				return Ok(new { message = "Kullanıcı başarıyla güncellendi." });
			}
		}

	}
}
