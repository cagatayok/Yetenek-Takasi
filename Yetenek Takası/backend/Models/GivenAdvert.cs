namespace YetenekTakasiApi.Models
{
	public class GivenAdvert
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public User? User { get; set; }
		public int AdvertId { get; set; }
		public Advert Advert { get; set; }
	}
}
