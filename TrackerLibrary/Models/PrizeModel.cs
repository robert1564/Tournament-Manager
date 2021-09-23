using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezinta premiul pentru fiecare loc.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Idenficatorul unic pentru premiu.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificatorul numeric pentru fiecare loc.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Numele pentru fiecare loc.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Suma fixa pe care o premeste un loc anume sau zero daca.
        /// nu este folosita
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Numarul care reprezinta procentajul per total primit sau
        /// zero daca nu este folosit. Procentajul este o fratie de 1
        /// deci 0.5 reprezinta 50%.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }

    }
}
