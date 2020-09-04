using System;
using System.Collections.Generic;

namespace Bank_Heist_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            var Drew = new Hacker()
            {
                Name = "Drew",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var Fred = new Hacker()
            {
                Name = "Fred",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var Wilson = new Muscle()
            {
                Name = "Wilson",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var Van = new LockSpecialist()
            {
                Name = "Van",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var Sylvian = new Muscle()
            {
                Name = "Sylvian",
                SkillLevel = 40,
                PercentageCut = 20
            };
        }

    }
}
