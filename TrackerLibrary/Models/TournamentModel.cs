using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezinta un campionat cu toate rundele, meciurile, premile si venitul pe care il ofera.
    /// </summary>
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// Idenficatorul unic pentru campionat.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Numele acestui campionat.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Suma de bani pe care trebuie sa o introduca fiecare echipa pentru a intra.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Setul de echipa care au intrat
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Lista de premii pentru fiecare loc.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Meciurile din fiecare runda.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
