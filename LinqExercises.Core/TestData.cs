using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqExercises.Core
{
    public static class TestData
    {
        public static List<User> GetTestUsers()
        {
            return new List<User>
       {
           // Sweden (25)
           new User { FirstName = "Anders", LastName = "Söderberg", Country = "Sweden", Email = "anders.s@email.com", DataStored = 7800, DateOfBirth = new DateTime(1982, 8, 5), LastLogin = DateTime.Now.AddDays(-12) },
           new User { FirstName = "Karin", LastName = "Sjöberg", Country = "Sweden", Email = "karin.s@email.com", DataStored = 5900, DateOfBirth = new DateTime(1991, 11, 28), LastLogin = DateTime.Now.AddDays(-15) },
           new User { FirstName = "Johan", LastName = "Stark", Country = "Sweden", Email = "johan.s@email.com", DataStored = 12500, DateOfBirth = new DateTime(1987, 6, 14), LastLogin = DateTime.Now.AddDays(-20) },
           new User { FirstName = "Lisa", LastName = "Swenson", Country = "Sweden", Email = "lisa.s@email.com", DataStored = 9100, DateOfBirth = new DateTime(1994, 2, 9), LastLogin = DateTime.Now.AddDays(-25) },
           new User { FirstName = "Magnus", LastName = "Sjöström", Country = "Sweden", Email = "magnus.s@email.com", DataStored = 6800, DateOfBirth = new DateTime(1986, 9, 30), LastLogin = DateTime.Now.AddDays(-30) },
           new User { FirstName = "Emma", LastName = "Sundström", Country = "Sweden", Email = "emma.s@email.com", DataStored = 8300, DateOfBirth = new DateTime(1989, 12, 3), LastLogin = DateTime.Now.AddDays(-35) },
           new User { FirstName = "Peter", LastName = "Sandström", Country = "Sweden", Email = "peter.s@email.com", DataStored = 7200, DateOfBirth = new DateTime(1984, 4, 22), LastLogin = DateTime.Now.AddDays(-40) },
           new User { FirstName = "Anna", LastName = "Smith", Country = "Sweden", Email = "anna.smith@email.com", DataStored = 5500, DateOfBirth = new DateTime(1990, 1, 1), LastLogin = DateTime.Now.AddDays(-1) },
           new User { FirstName = "Erik", LastName = "Svensson", Country = "Sweden", Email = "erik.s@email.com", DataStored = 15000, DateOfBirth = new DateTime(1985, 5, 15), LastLogin = DateTime.Now.AddDays(-2) },
           new User { FirstName = "Maria", LastName = "Samuelsson", Country = "Sweden", Email = "maria.s@email.com", DataStored = 7500, DateOfBirth = new DateTime(1992, 3, 20), LastLogin = DateTime.Now.AddDays(-3) },
           new User { FirstName = "Lars", LastName = "Strömberg", Country = "Sweden", Email = "lars.s@email.com", DataStored = 9999999, DateOfBirth = new DateTime(1980, 12, 24), LastLogin = DateTime.Now.AddDays(-4) },
           new User { FirstName = "Eva", LastName = "Sundberg", Country = "Sweden", Email = "eva.s@email.com", DataStored = 4500, DateOfBirth = new DateTime(1995, 7, 8), LastLogin = DateTime.Now.AddDays(-5) },
           new User { FirstName = "Karl", LastName = "Sandberg", Country = "Sweden", Email = "karl.s@email.com", DataStored = 8500, DateOfBirth = new DateTime(1988, 9, 12), LastLogin = DateTime.Now.AddDays(-8) },
           new User { FirstName = "Sofia", LastName = "Lindström", Country = "Sweden", Email = "sofia.l@email.com", DataStored = 6200, DateOfBirth = new DateTime(1993, 4, 18), LastLogin = DateTime.Now.AddDays(-10) },
           new User { FirstName = "Linda", LastName = "Stenberg", Country = "Sweden", Email = "linda.s@email.com", DataStored = 5400, DateOfBirth = new DateTime(1993, 7, 17), LastLogin = DateTime.Now.AddDays(-45) },
           new User { FirstName = "Mikael", LastName = "Sundqvist", Country = "Sweden", Email = "mikael.s@email.com", DataStored = 11000, DateOfBirth = new DateTime(1981, 10, 8), LastLogin = DateTime.Now.AddDays(-50) },
           new User { FirstName = "Sara", LastName = "Silverman", Country = "Sweden", Email = "sara.s@email.com", DataStored = 6500, DateOfBirth = new DateTime(1996, 1, 25), LastLogin = DateTime.Now.AddDays(-55) },
           new User { FirstName = "Gustav", LastName = "Ström", Country = "Sweden", Email = "gustav.s@email.com", DataStored = 8900, DateOfBirth = new DateTime(1983, 5, 11), LastLogin = DateTime.Now.AddDays(-60) },
           new User { FirstName = "Hanna", LastName = "Svärd", Country = "Sweden", Email = "hanna.s@email.com", DataStored = 7600, DateOfBirth = new DateTime(1992, 8, 19), LastLogin = DateTime.Now.AddDays(-65) },
           new User { FirstName = "Oscar", LastName = "Strandberg", Country = "Sweden", Email = "oscar.s@email.com", DataStored = 9300, DateOfBirth = new DateTime(1988, 3, 7), LastLogin = DateTime.Now.AddDays(-70) },
           new User { FirstName = "Julia", LastName = "Stenmark", Country = "Sweden", Email = "julia.s@email.com", DataStored = 6100, DateOfBirth = new DateTime(1995, 6, 28), LastLogin = DateTime.Now.AddDays(-75) },
           new User { FirstName = "David", LastName = "Sandgren", Country = "Sweden", Email = "david.s@email.com", DataStored = 8700, DateOfBirth = new DateTime(1986, 11, 13), LastLogin = DateTime.Now.AddDays(-80) },
           new User { FirstName = "Elin", LastName = "Sjödin", Country = "Sweden", Email = "elin.s@email.com", DataStored = 7400, DateOfBirth = new DateTime(1990, 2, 4), LastLogin = DateTime.Now.AddDays(-85) },
           new User { FirstName = "Daniel", LastName = "Strömqvist", Country = "Sweden", Email = "daniel.s@email.com", DataStored = 10200, DateOfBirth = new DateTime(1987, 7, 21), LastLogin = DateTime.Now.AddDays(-90) },
           new User { FirstName = "Alice", LastName = "Söderqvist", Country = "Sweden", Email = "alice.s@email.com", DataStored = 5800, DateOfBirth = new DateTime(1994, 10, 16), LastLogin = DateTime.Now.AddDays(-95) },

           // USA (20)
           new User { FirstName = "John", LastName = "Smith", Country = "USA", Email = "john.s@email.com", DataStored = 8500, DateOfBirth = new DateTime(1988, 7, 10), LastLogin = DateTime.Now.AddDays(-5) },
           new User { FirstName = "Sarah", LastName = "Johnson", Country = "USA", Email = "sarah.j@email.com", DataStored = 12000, DateOfBirth = new DateTime(1995, 9, 25), LastLogin = DateTime.Now.AddDays(-8) },
           new User { FirstName = "Michael", LastName = "Williams", Country = "USA", Email = "michael.w@email.com", DataStored = 9500, DateOfBirth = new DateTime(1987, 11, 15), LastLogin = DateTime.Now.AddDays(-6) },
           new User { FirstName = "Emily", LastName = "Brown", Country = "USA", Email = "emily.b@email.com", DataStored = 7000, DateOfBirth = new DateTime(1992, 4, 30), LastLogin = DateTime.Now.AddDays(-9) },
           new User { FirstName = "James", LastName = "Davis", Country = "USA", Email = "james.d@email.com", DataStored = 11500, DateOfBirth = new DateTime(1985, 8, 20), LastLogin = DateTime.Now.AddDays(-7) },
           new User { FirstName = "Jessica", LastName = "Miller", Country = "USA", Email = "jessica.m@email.com", DataStored = 6500, DateOfBirth = new DateTime(1993, 2, 12), LastLogin = DateTime.Now.AddDays(-10) },
           new User { FirstName = "William", LastName = "Wilson", Country = "USA", Email = "william.w@email.com", DataStored = 8800, DateOfBirth = new DateTime(1989, 6, 5), LastLogin = DateTime.Now.AddDays(-12) },
           new User { FirstName = "Jennifer", LastName = "Anderson", Country = "USA", Email = "jennifer.a@email.com", DataStored = 10200, DateOfBirth = new DateTime(1991, 10, 8), LastLogin = DateTime.Now.AddDays(-15) },
           new User { FirstName = "David", LastName = "Taylor", Country = "USA", Email = "david.t@email.com", DataStored = 7500, DateOfBirth = new DateTime(1986, 12, 18), LastLogin = DateTime.Now.AddDays(-18) },
           new User { FirstName = "Lisa", LastName = "Thomas", Country = "USA", Email = "lisa.t@email.com", DataStored = 9800, DateOfBirth = new DateTime(1994, 3, 22), LastLogin = DateTime.Now.AddDays(-20) },
           new User { FirstName = "Robert", LastName = "Moore", Country = "USA", Email = "robert.m@email.com", DataStored = 6800, DateOfBirth = new DateTime(1990, 5, 15), LastLogin = DateTime.Now.AddDays(-25) },
           new User { FirstName = "Michelle", LastName = "Jackson", Country = "USA", Email = "michelle.j@email.com", DataStored = 11800, DateOfBirth = new DateTime(1988, 9, 28), LastLogin = DateTime.Now.AddDays(-30) },
           new User { FirstName = "Daniel", LastName = "White", Country = "USA", Email = "daniel.w@email.com", DataStored = 8200, DateOfBirth = new DateTime(1993, 7, 3), LastLogin = DateTime.Now.AddDays(-35) },
           new User { FirstName = "Amanda", LastName = "Harris", Country = "USA", Email = "amanda.h@email.com", DataStored = 7200, DateOfBirth = new DateTime(1987, 1, 9), LastLogin = DateTime.Now.AddDays(-40) },
           new User { FirstName = "Joseph", LastName = "Martin", Country = "USA", Email = "joseph.m@email.com", DataStored = 10500, DateOfBirth = new DateTime(1992, 11, 14), LastLogin = DateTime.Now.AddDays(-45) },
           new User { FirstName = "Ashley", LastName = "Thompson", Country = "USA", Email = "ashley.t@email.com", DataStored = 6900, DateOfBirth = new DateTime(1995, 4, 7), LastLogin = DateTime.Now.AddDays(-50) },
           new User { FirstName = "Christopher", LastName = "Garcia", Country = "USA", Email = "chris.g@email.com", DataStored = 9200, DateOfBirth = new DateTime(1989, 8, 25), LastLogin = DateTime.Now.AddDays(-55) },
           new User { FirstName = "Elizabeth", LastName = "Martinez", Country = "USA", Email = "elizabeth.m@email.com", DataStored = 7800, DateOfBirth = new DateTime(1991, 2, 19), LastLogin = DateTime.Now.AddDays(-60) },
           new User { FirstName = "Kevin", LastName = "Robinson", Country = "USA", Email = "kevin.r@email.com", DataStored = 11200, DateOfBirth = new DateTime(1986, 6, 30), LastLogin = DateTime.Now.AddDays(-65) },
           new User { FirstName = "Melissa", LastName = "Clark", Country = "USA", Email = "melissa.c@email.com", DataStored = 8600, DateOfBirth = new DateTime(1994, 12, 11), LastLogin = DateTime.Now.AddDays(-70) },

           // Norway (14)
           new User { FirstName = "Ole", LastName = "Hansen", Country = "Norway", Email = "ole.h@email.com", DataStored = 9500, DateOfBirth = new DateTime(1987, 11, 30), LastLogin = DateTime.Now.AddDays(-4) },
           new User { FirstName = "Nina", LastName = "Larsen", Country = "Norway", Email = "nina.l@email.com", DataStored = 7200, DateOfBirth = new DateTime(1991, 6, 5), LastLogin = DateTime.Now.AddDays(-7) },
           new User { FirstName = "Erik", LastName = "Olsen", Country = "Norway", Email = "erik.o@email.com", DataStored = 10800, DateOfBirth = new DateTime(1989, 3, 15), LastLogin = DateTime.Now.AddDays(-10) },
           new User { FirstName = "Kristin", LastName = "Andersen", Country = "Norway", Email = "kristin.a@email.com", DataStored = 6500, DateOfBirth = new DateTime(1993, 9, 22), LastLogin = DateTime.Now.AddDays(-15) },
           new User { FirstName = "Anders", LastName = "Pedersen", Country = "Norway", Email = "anders.p@email.com", DataStored = 8900, DateOfBirth = new DateTime(1986, 12, 8), LastLogin = DateTime.Now.AddDays(-20) },
           new User { FirstName = "Ingrid", LastName = "Johansen", Country = "Norway", Email = "ingrid.j@email.com", DataStored = 7800, DateOfBirth = new DateTime(1992, 4, 17), LastLogin = DateTime.Now.AddDays(-25) },
           new User { FirstName = "Magnus", LastName = "Nilsen", Country = "Norway", Email = "magnus.n@email.com", DataStored = 11200, DateOfBirth = new DateTime(1988, 7, 29), LastLogin = DateTime.Now.AddDays(-30) },
           new User { FirstName = "Hilde", LastName = "Berg", Country = "Norway", Email = "hilde.b@email.com", DataStored = 6900, DateOfBirth = new DateTime(1994, 1, 12), LastLogin = DateTime.Now.AddDays(-35) },
           new User { FirstName = "Thomas", LastName = "Haugen", Country = "Norway", Email = "thomas.h@email.com", DataStored = 9700, DateOfBirth = new DateTime(1985, 10, 3), LastLogin = DateTime.Now.AddDays(-40) },
            new User { FirstName = "Kari", LastName = "Moen", Country = "Norway", Email = "kari.m@email.com", DataStored = 8300, DateOfBirth = new DateTime(1990, 5, 25), LastLogin = DateTime.Now.AddDays(-45) },
            new User { FirstName = "Lars", LastName = "Bakken", Country = "Norway", Email = "lars.b@email.com", DataStored = 10100, DateOfBirth = new DateTime(1987, 8, 14), LastLogin = DateTime.Now.AddDays(-50) },
            new User { FirstName = "Marit", LastName = "Solberg", Country = "Norway", Email = "marit.s@email.com", DataStored = 7100, DateOfBirth = new DateTime(1993, 3, 8), LastLogin = DateTime.Now.AddDays(-55) },
            new User { FirstName = "Petter", LastName = "Kristiansen", Country = "Norway", Email = "petter.k@email.com", DataStored = 9300, DateOfBirth = new DateTime(1986, 11, 19), LastLogin = DateTime.Now.AddDays(-60) },
            new User { FirstName = "Astrid", LastName = "Jacobsen", Country = "Norway", Email = "astrid.j@email.com", DataStored = 6700, DateOfBirth = new DateTime(1992, 7, 30), LastLogin = DateTime.Now.AddDays(-65) },

            // UK (20)
            new User { FirstName = "James", LastName = "Stewart", Country = "UK", Email = "james.s@email.com", DataStored = 11000, DateOfBirth = new DateTime(1989, 4, 15), LastLogin = DateTime.Now.AddDays(-7) },
            new User { FirstName = "Emma", LastName = "Brown", Country = "UK", Email = "emma.b@email.com", DataStored = 8800, DateOfBirth = new DateTime(1994, 8, 22), LastLogin = DateTime.Now.AddDays(-9) },
            new User { FirstName = "William", LastName = "Taylor", Country = "UK", Email = "william.t@email.com", DataStored = 10200, DateOfBirth = new DateTime(1986, 2, 10), LastLogin = DateTime.Now.AddDays(-12) },
            new User { FirstName = "Sophie", LastName = "Wilson", Country = "UK", Email = "sophie.w@email.com", DataStored = 7500, DateOfBirth = new DateTime(1992, 6, 18), LastLogin = DateTime.Now.AddDays(-15) },
            new User { FirstName = "Oliver", LastName = "Davies", Country = "UK", Email = "oliver.d@email.com", DataStored = 9300, DateOfBirth = new DateTime(1988, 11, 5), LastLogin = DateTime.Now.AddDays(-18) },
            new User { FirstName = "Emily", LastName = "Evans", Country = "UK", Email = "emily.e@email.com", DataStored = 6900, DateOfBirth = new DateTime(1995, 3, 28), LastLogin = DateTime.Now.AddDays(-21) },
            new User { FirstName = "Harry", LastName = "Roberts", Country = "UK", Email = "harry.r@email.com", DataStored = 12500, DateOfBirth = new DateTime(1987, 9, 14), LastLogin = DateTime.Now.AddDays(-24) },
            new User { FirstName = "Lucy", LastName = "Walker", Country = "UK", Email = "lucy.w@email.com", DataStored = 8100, DateOfBirth = new DateTime(1993, 1, 7), LastLogin = DateTime.Now.AddDays(-27) },
            new User { FirstName = "George", LastName = "Thompson", Country = "UK", Email = "george.t@email.com", DataStored = 11800, DateOfBirth = new DateTime(1985, 7, 25), LastLogin = DateTime.Now.AddDays(-30) },
            new User { FirstName = "Olivia", LastName = "White", Country = "UK", Email = "olivia.w@email.com", DataStored = 7200, DateOfBirth = new DateTime(1991, 12, 3), LastLogin = DateTime.Now.AddDays(-33) },
            new User { FirstName = "Jack", LastName = "Hughes", Country = "UK", Email = "jack.h@email.com", DataStored = 9700, DateOfBirth = new DateTime(1990, 4, 19), LastLogin = DateTime.Now.AddDays(-36) },
            new User { FirstName = "Isabella", LastName = "Green", Country = "UK", Email = "isabella.g@email.com", DataStored = 6500, DateOfBirth = new DateTime(1994, 10, 8), LastLogin = DateTime.Now.AddDays(-39) },
            new User { FirstName = "Thomas", LastName = "Hall", Country = "UK", Email = "thomas.h@email.com", DataStored = 10900, DateOfBirth = new DateTime(1986, 5, 30), LastLogin = DateTime.Now.AddDays(-42) },
            new User { FirstName = "Mia", LastName = "Martin", Country = "UK", Email = "mia.m@email.com", DataStored = 7800, DateOfBirth = new DateTime(1992, 8, 12), LastLogin = DateTime.Now.AddDays(-45) },
            new User { FirstName = "Charlie", LastName = "Clarke", Country = "UK", Email = "charlie.c@email.com", DataStored = 11200, DateOfBirth = new DateTime(1989, 2, 27), LastLogin = DateTime.Now.AddDays(-48) },
            new User { FirstName = "Ava", LastName = "Jackson", Country = "UK", Email = "ava.j@email.com", DataStored = 8400, DateOfBirth = new DateTime(1993, 11, 15), LastLogin = DateTime.Now.AddDays(-51) },
            new User { FirstName = "Oscar", LastName = "Wood", Country = "UK", Email = "oscar.w@email.com", DataStored = 10100, DateOfBirth = new DateTime(1987, 6, 9), LastLogin = DateTime.Now.AddDays(-54) },
            new User { FirstName = "Lily", LastName = "Edwards", Country = "UK", Email = "lily.e@email.com", DataStored = 7100, DateOfBirth = new DateTime(1991, 9, 22), LastLogin = DateTime.Now.AddDays(-57) },
            new User { FirstName = "Jacob", LastName = "Turner", Country = "UK", Email = "jacob.t@email.com", DataStored = 9900, DateOfBirth = new DateTime(1988, 3, 4), LastLogin = DateTime.Now.AddDays(-60) },
            new User { FirstName = "Sophia", LastName = "Cooper", Country = "UK", Email = "sophia.c@email.com", DataStored = 6800, DateOfBirth = new DateTime(1995, 1, 17), LastLogin = DateTime.Now.AddDays(-63) },


            // Germany (20)
            new User { FirstName = "Hans", LastName = "Schmidt", Country = "Germany", Email = "hans.s@email.com", DataStored = 13000, DateOfBirth = new DateTime(1991, 8, 20), LastLogin = DateTime.Now.AddDays(-6) },
            new User { FirstName = "Anna", LastName = "Weber", Country = "Germany", Email = "anna.w@email.com", DataStored = 9800, DateOfBirth = new DateTime(1993, 2, 28), LastLogin = DateTime.Now.AddDays(-8) },
            new User { FirstName = "Thomas", LastName = "Meyer", Country = "Germany", Email = "thomas.m@email.com", DataStored = 11500, DateOfBirth = new DateTime(1987, 5, 15), LastLogin = DateTime.Now.AddDays(-10) },
            new User { FirstName = "Lisa", LastName = "Wagner", Country = "Germany", Email = "lisa.w@email.com", DataStored = 8200, DateOfBirth = new DateTime(1995, 9, 7), LastLogin = DateTime.Now.AddDays(-12) },
            new User { FirstName = "Michael", LastName = "Becker", Country = "Germany", Email = "michael.b@email.com", DataStored = 10700, DateOfBirth = new DateTime(1989, 11, 30), LastLogin = DateTime.Now.AddDays(-14) },
            new User { FirstName = "Julia", LastName = "Koch", Country = "Germany", Email = "julia.k@email.com", DataStored = 7400, DateOfBirth = new DateTime(1992, 4, 12), LastLogin = DateTime.Now.AddDays(-16) },
            new User { FirstName = "Andreas", LastName = "Wolf", Country = "Germany", Email = "andreas.w@email.com", DataStored = 12200, DateOfBirth = new DateTime(1986, 7, 25), LastLogin = DateTime.Now.AddDays(-18) },
            new User { FirstName = "Sarah", LastName = "Fischer", Country = "Germany", Email = "sarah.f@email.com", DataStored = 8900, DateOfBirth = new DateTime(1994, 1, 8), LastLogin = DateTime.Now.AddDays(-20) },
            new User { FirstName = "Peter", LastName = "Schäfer", Country = "Germany", Email = "peter.s@email.com", DataStored = 11100, DateOfBirth = new DateTime(1988, 3, 21), LastLogin = DateTime.Now.AddDays(-22) },
            new User { FirstName = "Laura", LastName = "Hoffmann", Country = "Germany", Email = "laura.h@email.com", DataStored = 7800, DateOfBirth = new DateTime(1991, 6, 4), LastLogin = DateTime.Now.AddDays(-24) },
            new User { FirstName = "Martin", LastName = "Schulz", Country = "Germany", Email = "martin.s@email.com", DataStored = 10300, DateOfBirth = new DateTime(1990, 10, 17), LastLogin = DateTime.Now.AddDays(-26) },
            new User { FirstName = "Christina", LastName = "Krüger", Country = "Germany", Email = "christina.k@email.com", DataStored = 6900, DateOfBirth = new DateTime(1993, 12, 29), LastLogin = DateTime.Now.AddDays(-28) },
            new User { FirstName = "Stefan", LastName = "Richter", Country = "Germany", Email = "stefan.r@email.com", DataStored = 11900, DateOfBirth = new DateTime(1985, 8, 11), LastLogin = DateTime.Now.AddDays(-30) },
            new User { FirstName = "Melanie", LastName = "Klein", Country = "Germany", Email = "melanie.k@email.com", DataStored = 8500, DateOfBirth = new DateTime(1992, 2, 23), LastLogin = DateTime.Now.AddDays(-32) },
            new User { FirstName = "Alexander", LastName = "Schneider", Country = "Germany", Email = "alexander.s@email.com", DataStored = 10800, DateOfBirth = new DateTime(1987, 5, 6), LastLogin = DateTime.Now.AddDays(-34) },
            new User { FirstName = "Nicole", LastName = "Zimmermann", Country = "Germany", Email = "nicole.z@email.com", DataStored = 7600, DateOfBirth = new DateTime(1994, 7, 19), LastLogin = DateTime.Now.AddDays(-36) },
            new User { FirstName = "Markus", LastName = "König", Country = "Germany", Email = "markus.k@email.com", DataStored = 12500, DateOfBirth = new DateTime(1986, 11, 1), LastLogin = DateTime.Now.AddDays(-38) },
            new User { FirstName = "Claudia", LastName = "Werner", Country = "Germany", Email = "claudia.w@email.com", DataStored = 8700, DateOfBirth = new DateTime(1991, 3, 14), LastLogin = DateTime.Now.AddDays(-40) },
            new User { FirstName = "Daniel", LastName = "Schwarz", Country = "Germany", Email = "daniel.s@email.com", DataStored = 11300, DateOfBirth = new DateTime(1989, 9, 27), LastLogin = DateTime.Now.AddDays(-42) },
            new User { FirstName = "Sandra", LastName = "Lange", Country = "Germany", Email = "sandra.l@email.com", DataStored = 7200, DateOfBirth = new DateTime(1995, 4, 9), LastLogin = DateTime.Now.AddDays(-44) }
};
        }
    }
}
