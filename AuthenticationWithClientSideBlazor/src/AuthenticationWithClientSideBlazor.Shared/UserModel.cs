namespace AuthenticationWithClientSideBlazor.Shared
{
    public class UserModel
    {
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }

        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int ShotsHit { get; set; }
        public int ShotsFired { get; set; }
    }
}
