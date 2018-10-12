using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class FourInARow
    {
        char[,] twoDimensionalArray = new char[6,6];

        /// <summary>
        /// get a singel value from our two dimensional array
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        /// <returns></returns>
        public char getSingleValue(int x, int y)
        {
            return twoDimensionalArray[x, y];
        }

        /// <summary>
        /// Set a single value our two dimensional array
        /// </summary>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="value">the char you want to set</param>
        /// <returns></returns>
        //TODO - gameClass og playerClass oprettes
        //TODO - Eventuel minusliste tæller ned og visuelt går op.
        //TODO - Liste skal kunne anerkende at en given plads er optaget. 
        //TODO - Producere 'if' sætninger der kan udelukke specifikke pladser.
        //TODO - Spillet består af to spiller, hvor parameterne for at vinde er på ligelinjer (vandret og lodret)
        public char setSingleValue(int x, int y, char value)
        {
             twoDimensionalArray[x, y] = value;
        }
    }

    
}
