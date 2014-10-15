namespace Task01Cooker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Refactor the following class using best practices for organizing straight-line code:
    class Chef
    {
        public void Cook()
        {
            // This is how I see things. Actualy we first get bowl and peel and cut stuffs and add them to it after that we
            // take the other vegetable and do the same. This increase life span.
            // In programming point of view best is to get vegetables peel and cut them then get the bowl and add the stuffs there.

            Bowl bowl;
            bowl = GetBowl();

            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }

        private void Cut(Vegetable potato)
        {
            throw new NotImplementedException();
        }
    }
}