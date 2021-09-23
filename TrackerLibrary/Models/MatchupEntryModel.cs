using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Idenficatorul unic pentru intrarea meciului.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificatorului unic pentru fiecare echipa
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Reprezinta o echipa in meci.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Reprezinta scorul pentru aceasta echipa.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Identificatorul unic pentru meciurile parinte (sau echipa)
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Reprezinta meciul din care aceasta echipa 
        /// a venit.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
