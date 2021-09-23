using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezinta un meci din campionat
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Idenficatorul unic pentru meci.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Numarul de echipe care sunt implicate in acest meci.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Id-ul din baza de date care va fi utilizat pentru a gasi castigatorul
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Castigatoarea meciului.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Din care runda face parte acest meci.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName }";
                        } 
                    }
                    else
                    {
                        output = "Meciul nu a fost inca determinat";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
