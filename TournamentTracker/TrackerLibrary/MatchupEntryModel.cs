namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the Match
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Score for particular team
        /// </summary>
        public double Score { get; set; }
        
        /// <summary>
        /// Represents Match up this team come from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}