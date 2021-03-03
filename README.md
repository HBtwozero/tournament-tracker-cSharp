# tournament-tracker-cSharp

### Team
	- TeamMembers(list<Person>)

### Person
	- FirstName (string)
	- LastName (string)
	- EmaiAdress (string)
	- CellPhoneNumber (string)
### Tournament
	- TournmentName (string)
	- EntryFee(decimal)
	- EnteredTeams (list<Team>)
	- Prizes (List<Prize>)
	- Rounds (List<list<Matchup>>)

### Prize
	- PlaceNumber (int)
	- PlaceName (string)
	- PrizeAmount (decimal)
	- PrizePercentage (double)

### Matchup 
	- Entries (List<MatchupEntry)
	- Winner (Team)
	- MatchRound (int)

### MatchupEntry 
	- TeamCompeting (Team)
	- Score (double)
	- ParentMatchup (Matchup)