using PartyInvites.Enums;

// This CompetitionInvite class contains three properties. Account and TwitterAccount
// are of type string and the interest property is of the TechnicalInterest enum type.

namespace PartyInvites.Models
{
    public class CompetitionInvite
    {
        //Address property
        public string Address { get; set; }

        //TwitterAccount property
        public string TwitterAccount { get; set; }

        //TechnicalInterest property
        public TechnicalInterest Interest { get; set; }
    }
}
