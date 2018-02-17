using System;
using System.Collections.Generic;
using System.Linq;

namespace TstGenetic.WorldCup
{
    public static class Distances
    {
        private static List<List<double>> Matrix { get; set; }

        private static void InsertEntry(City from, City to, double distance)
        {
            Matrix[Convert.ToInt32(from)][Convert.ToInt32(to)] = distance;
            Matrix[Convert.ToInt32(to)][Convert.ToInt32(from)] = distance;
        }

        public static void Initialize()
        {
            // 12 cities
            Matrix = new List<List<double>>();
            for (int i = 0; i < 12; i++)
                Matrix.Add((new double[12]).ToList());             
   
            // Distances       
            InsertEntry(City.SaoPaulo, City.Natal, 2320);
            InsertEntry(City.SaoPaulo, City.Salvador, 1453);
            InsertEntry(City.SaoPaulo, City.Cuiaba, 1326);
            InsertEntry(City.SaoPaulo, City.BeloHorizonte, 489);
            InsertEntry(City.SaoPaulo, City.Recife, 2128);
            InsertEntry(City.SaoPaulo, City.Fortaleza, 2368);
            InsertEntry(City.SaoPaulo, City.Manaus, 2689);
            InsertEntry(City.SaoPaulo, City.Brasilia, 873);
            InsertEntry(City.SaoPaulo, City.PortoAlegre, 852);
            InsertEntry(City.SaoPaulo, City.RioDeJaneiro, 357);
            InsertEntry(City.SaoPaulo, City.Curitiba, 338);
           
            InsertEntry(City.Natal, City.Salvador, 1126);
            InsertEntry(City.Natal, City.Cuiaba, 2524);
            InsertEntry(City.Natal, City.BeloHorizonte, 1831);
            InsertEntry(City.Natal, City.Recife, 297);
            InsertEntry(City.Natal, City.Fortaleza, 435);
            InsertEntry(City.Natal, City.Manaus, 2765);
            InsertEntry(City.Natal, City.Brasilia, 1775);
            InsertEntry(City.Natal, City.PortoAlegre, 4998);
            InsertEntry(City.Natal, City.RioDeJaneiro, 2625);
            InsertEntry(City.Natal, City.Curitiba, 2645);

            InsertEntry(City.Salvador, City.Cuiaba, 1915);
            InsertEntry(City.Salvador, City.BeloHorizonte, 964);
            InsertEntry(City.Salvador, City.Recife, 675);
            InsertEntry(City.Salvador, City.Fortaleza, 1028);
            InsertEntry(City.Salvador, City.Manaus, 2605);
            InsertEntry(City.Salvador, City.Brasilia, 1060);
            InsertEntry(City.Salvador, City.PortoAlegre, 2303);
            InsertEntry(City.Salvador, City.RioDeJaneiro, 1209);
            InsertEntry(City.Salvador, City.Curitiba, 1784);

            InsertEntry(City.Cuiaba, City.BeloHorizonte, 1372);
            InsertEntry(City.Cuiaba, City.Recife, 3255);
            InsertEntry(City.Cuiaba, City.Fortaleza, 3406);
            InsertEntry(City.Cuiaba, City.Manaus, 2357);
            InsertEntry(City.Cuiaba, City.Brasilia, 873);
            InsertEntry(City.Cuiaba, City.PortoAlegre, 2206);
            InsertEntry(City.Cuiaba, City.RioDeJaneiro, 2017);
            InsertEntry(City.Cuiaba, City.Curitiba, 1679);

            InsertEntry(City.BeloHorizonte, City.Recife, 2061);
            InsertEntry(City.BeloHorizonte, City.Fortaleza, 2528);
            InsertEntry(City.BeloHorizonte, City.Manaus, 3951);
            InsertEntry(City.BeloHorizonte, City.Brasilia, 716);
            InsertEntry(City.BeloHorizonte, City.PortoAlegre, 1712);
            InsertEntry(City.BeloHorizonte, City.RioDeJaneiro, 434);
            InsertEntry(City.BeloHorizonte, City.Curitiba, 1004);
       
            InsertEntry(City.Recife, City.Fortaleza, 629);
            InsertEntry(City.Recife, City.Manaus, 2833);
            InsertEntry(City.Recife, City.Brasilia, 1657);
            InsertEntry(City.Recife, City.PortoAlegre, 2977);
            InsertEntry(City.Recife, City.RioDeJaneiro, 2338);
            InsertEntry(City.Recife, City.Curitiba, 2459);

            InsertEntry(City.Fortaleza, City.Manaus, 5763);
            InsertEntry(City.Fortaleza, City.Brasilia, 1687);
            InsertEntry(City.Fortaleza, City.PortoAlegre, 4242);
            InsertEntry(City.Fortaleza, City.RioDeJaneiro, 2805);
            InsertEntry(City.Fortaleza, City.Curitiba, 2670);

            InsertEntry(City.Manaus, City.Brasilia, 1932);
            InsertEntry(City.Manaus, City.PortoAlegre, 4563);
            InsertEntry(City.Manaus, City.RioDeJaneiro, 4374);
            InsertEntry(City.Manaus, City.Curitiba, 2734);

            InsertEntry(City.Brasilia, City.PortoAlegre, 2027);
            InsertEntry(City.Brasilia, City.RioDeJaneiro, 1148);
            InsertEntry(City.Brasilia, City.Curitiba, 1366);

            InsertEntry(City.PortoAlegre, City.RioDeJaneiro, 1553);
            InsertEntry(City.PortoAlegre, City.Curitiba, 546);

            InsertEntry(City.RioDeJaneiro, City.Curitiba, 675);
       }

        public static double GetDistance(City from, City to)
        {
            if (from == to)
                return 0;

            return Matrix[Convert.ToInt32(from)][Convert.ToInt32(to)];
        }
    }
}
