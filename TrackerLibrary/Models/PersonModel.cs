using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezinta o persoana
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Idenficatorul unic pentru persoana.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Prenumele persoanei.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Numele persoanei.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email-ul persoanei.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Numarul de telefon al persoanei.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get 
            { 
                return $"{ FirstName } { LastName }"; 
            }
        }


    }
}
