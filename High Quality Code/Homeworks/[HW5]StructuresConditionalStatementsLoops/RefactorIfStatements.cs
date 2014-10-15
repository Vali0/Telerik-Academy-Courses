namespace Task02RefactorIfStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Refactor the following if statements: 
    class RefactorIfStatements
    {
        public static void RefactorIfStatements()
        {
            Potato potato;

            if (potato != null)
            {
                if (potato.isPeeled && !potato.isRotten)
                {
                    Cook(potato);
                }
            }

            if (!isVisitedCell && (x >= MIN_X && x <= MAX_X) && (y >= MIN_Y && y <= MAX_Y))
            {
                VisitCell();
            }
        }
    }
}