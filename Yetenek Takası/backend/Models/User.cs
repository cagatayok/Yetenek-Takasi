namespace YetenekTakasiApi.Models
{
	public class User
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
	
		public List<GivenAdvert>? GivenAdverts { get; set; }  //soru işareti null olabilir anlamına geliyor
	}	
}
