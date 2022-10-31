namespace NZWalks.API.Modules.Domain
{
    public class Walk
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Lenght { get; set; }

        public int RegionId { get; set; }

        public int WalkDifficultyId { get; set; }

        //Navigation Property

        public Region Region { get; set; }

        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
