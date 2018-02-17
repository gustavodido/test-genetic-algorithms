using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TstGenetic.WorldCup
{
    public class WorldCupMatch
    {
        public City City { get; set; }
    }

    public class WorldCupDay 
    {
        public string Date { get; set;}
        public int NumberOfGames { get; set;}
        public List<WorldCupMatch> Matches {get; set;}
    }

    public class WorldCupChronogram
    {
        private static IEnumerable<WorldCupMatch> CreateMatches(params City[] cities)
        {
            foreach(var c in cities)
                yield return new WorldCupMatch { City = c };
        }

        public static List<WorldCupDay> Days { get; set; }

        public static void Initialize()
        {
            Days = new List<WorldCupDay>();

            // Group phase
            //Days.Add(new WorldCupDay { Date = "12/6", NumberOfGames = 1, Matches = CreateMatches(City.SaoPaulo).ToList() });

            Days.Add(new WorldCupDay { Date = "13/6", NumberOfGames = 3, Matches = CreateMatches(City.Natal, City.Salvador, City.Cuiaba).ToList() });          
            Days.Add(new WorldCupDay { Date = "14/6", NumberOfGames = 4, Matches = CreateMatches(City.BeloHorizonte, City.Recife, City.Fortaleza, City.Manaus).ToList() });            
            Days.Add(new WorldCupDay { Date = "15/6", NumberOfGames = 3, Matches = CreateMatches(City.Brasilia, City.PortoAlegre, City.RioDeJaneiro).ToList() });
            Days.Add(new WorldCupDay { Date = "16/6", NumberOfGames = 3, Matches = CreateMatches(City.Curitiba, City.Natal, City.Salvador).ToList() });
            Days.Add(new WorldCupDay { Date = "17/6", NumberOfGames = 3, Matches = CreateMatches(City.Cuiaba, City.BeloHorizonte, City.Fortaleza).ToList() });

            Days.Add(new WorldCupDay { Date = "18/6", NumberOfGames = 3, Matches = CreateMatches(City.Manaus, City.PortoAlegre, City.RioDeJaneiro).ToList() });
            Days.Add(new WorldCupDay { Date = "19/6", NumberOfGames = 3, Matches = CreateMatches(City.SaoPaulo, City.Natal, City.Brasilia).ToList() });
            Days.Add(new WorldCupDay { Date = "20/6", NumberOfGames = 3, Matches = CreateMatches(City.Salvador, City.Recife, City.Curitiba).ToList() });
            Days.Add(new WorldCupDay { Date = "21/6", NumberOfGames = 3, Matches = CreateMatches(City.Cuiaba, City.BeloHorizonte, City.Fortaleza).ToList() });
            Days.Add(new WorldCupDay { Date = "22/6", NumberOfGames = 3, Matches = CreateMatches(City.Manaus, City.PortoAlegre, City.RioDeJaneiro).ToList() });
            Days.Add(new WorldCupDay { Date = "23/6", NumberOfGames = 4, Matches = CreateMatches(City.SaoPaulo, City.Recife, City.Brasilia, City.Curitiba).ToList() });
            Days.Add(new WorldCupDay { Date = "24/6", NumberOfGames = 4, Matches = CreateMatches(City.Natal, City.Cuiaba, City.BeloHorizonte, City.Fortaleza).ToList() });
            Days.Add(new WorldCupDay { Date = "25/6", NumberOfGames = 4, Matches = CreateMatches(City.Salvador, City.Manaus, City.PortoAlegre, City.RioDeJaneiro).ToList() });
            Days.Add(new WorldCupDay { Date = "26/6", NumberOfGames = 4, Matches = CreateMatches(City.SaoPaulo, City.Recife, City.Brasilia, City.Curitiba).ToList() });

            // Best of 16
            Days.Add(new WorldCupDay { Date = "28/6", NumberOfGames = 2, Matches = CreateMatches(City.BeloHorizonte, City.RioDeJaneiro).ToList() });
            Days.Add(new WorldCupDay { Date = "29/6", NumberOfGames = 2, Matches = CreateMatches(City.Fortaleza, City.Recife).ToList() }); 
            Days.Add(new WorldCupDay { Date = "30/6", NumberOfGames = 2, Matches = CreateMatches(City.PortoAlegre, City.Brasilia).ToList() });
            Days.Add(new WorldCupDay { Date = "01/7", NumberOfGames = 2, Matches = CreateMatches(City.SaoPaulo, City.Salvador).ToList() });

            // Quarters
            Days.Add(new WorldCupDay { Date = "04/7", NumberOfGames = 2, Matches = CreateMatches(City.Fortaleza, City.RioDeJaneiro).ToList() });
            Days.Add(new WorldCupDay { Date = "05/7", NumberOfGames = 2, Matches = CreateMatches(City.Salvador, City.Brasilia).ToList() });

            // Seminfinals
            Days.Add(new WorldCupDay { Date = "08/7", NumberOfGames = 1, Matches = CreateMatches(City.BeloHorizonte).ToList() });
            Days.Add(new WorldCupDay { Date = "09/7", NumberOfGames = 1, Matches = CreateMatches(City.SaoPaulo).ToList() });

            // Finals
            Days.Add(new WorldCupDay { Date = "12/7", NumberOfGames = 1, Matches = CreateMatches(City.Brasilia).ToList() });
            Days.Add(new WorldCupDay { Date = "13/7", NumberOfGames = 1, Matches = CreateMatches(City.RioDeJaneiro).ToList() });

 
        }
    }
}
