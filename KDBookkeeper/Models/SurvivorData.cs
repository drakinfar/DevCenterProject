namespace KDBookkeeper.Models
{
	public class SurvivorData
	{
		public string Name { get; set; }
		public bool Survived { get; internal set; }
		public int SurvivorId { get; internal set; }
	}
}