using PartyInvites.Enums;

namespace PartyInvites.Models
{
    public class CompetitionInvite
    {
        public string Address { get; set; }

        public string TwitterAccount { get; set; }

        public TechnicalInterest Interest { get; set; }
    }
}
