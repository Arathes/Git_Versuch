using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Versuch
{
    using System;

    class MotivationalDeveloper
    {
        private string name;
        private int yearsOfExperience;

        public MotivationalDeveloper(string name, int yearsOfExperience)
        {
            this.name = name;
            this.yearsOfExperience = yearsOfExperience;
        }

        public void Motivate()
        {
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("You have " + yearsOfExperience + " years of experience as a developer.");

            if (yearsOfExperience < 1)
            {
                Console.WriteLine("Don't worry if you're just starting out. Everyone has to start somewhere!");
            }
            else if (yearsOfExperience < 5)
            {
                Console.WriteLine("You're making great progress! Keep learning and growing as a developer.");
            }
            else if (yearsOfExperience < 10)
            {
                Console.WriteLine("You're a seasoned developer! Keep challenging yourself and pushing your limits.");
            }
            else
            {
                Console.WriteLine("You're a true expert in your field! Keep sharing your knowledge and helping others grow.");
            }

            Console.WriteLine("Remember to take breaks and practice self-care to avoid burnout. Keep up the great work!");
        }
    }
}
