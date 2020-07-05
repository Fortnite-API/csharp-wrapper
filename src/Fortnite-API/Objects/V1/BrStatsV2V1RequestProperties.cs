namespace Fortnite_API.Objects.V1
{
	public class BrStatsV2V1RequestProperties
	{
		public Optional<string> Name { get; set; }
		public Optional<BrStatsV2V1AccountType> AccountType { get; set; }
		public Optional<string> AccountId { get; set; }
		public Optional<BrStatsV2V1TimeWindow> TimeWindow { get; set; }
		public Optional<BrStatsV2V1ImagePlatform> ImagePlatform { get; set; }
	}
}