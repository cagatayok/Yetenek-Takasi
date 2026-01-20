using Microsoft.EntityFrameworkCore;
using YetenekTakasiApi.Models;

namespace YetenekTakasiApi.Context
{
	public class YetenekTakasiDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-3U9KI3T\\SQLEXPRESS; database=YetenekTakasiApi; User ID=sa; Password=1; TrustServerCertificate=True");
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Advert> Adverts { get; set; }
		public DbSet<GivenAdvert> GivenAdverts { get; set; }



	}
}
