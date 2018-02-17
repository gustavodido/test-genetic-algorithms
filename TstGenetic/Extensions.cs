using GAF;
using System;
using TstGenetic.WorldCup;

namespace TstGenetic
{
    public static class Extensions
    {
        public static string ToChromosomeString(this Chromosome thiz)
        {
            var res = string.Empty;
            foreach (var gen in thiz.Genes)
                res = string.Concat(res, gen.RealValue.ToString());

            return res;
        }

        public static string ToRoute(this Chromosome thiz)
        {
            var res = string.Empty;
            for (int i = 0; i < thiz.Genes.Count; i++)
			{
			    var currentGene = thiz.Genes[i];
                var currentGeneMatch = WorldCupChronogram.Days[i].Matches[Convert.ToInt32(currentGene.RealValue)];

                res = string.Concat(res,"\n", Convert.ToString(currentGeneMatch.City));
			}

            return res;
        }

        public static double TotalDistance(this Chromosome thiz)
        {
            double distanceSum = 0;
            for (int i = 1; i < thiz.Genes.Count; i++)
            {
                var currentGene = thiz.Genes[i];
                var previousGene = thiz.Genes[i - 1];

                var currentGeneMatch = WorldCupChronogram.Days[i].Matches[Convert.ToInt32(currentGene.RealValue)];
                var previousGeneMatch = WorldCupChronogram.Days[i - 1].Matches[Convert.ToInt32(previousGene.RealValue)];

                distanceSum += Distances.GetDistance(previousGeneMatch.City, currentGeneMatch.City);
            }

            return distanceSum;
        }

        public static double TotalDistanceWithRoute(this Chromosome thiz)
        {
            double distanceSum = 0;
            for (int i = 1; i < thiz.Genes.Count; i++)
            {
                var currentGene = thiz.Genes[i];
                var previousGene = thiz.Genes[i - 1];

                var currentGeneMatch = WorldCupChronogram.Days[i].Matches[Convert.ToInt32(currentGene.RealValue)];
                var previousGeneMatch = WorldCupChronogram.Days[i - 1].Matches[Convert.ToInt32(previousGene.RealValue)];

                distanceSum += Distances.GetDistance(previousGeneMatch.City, currentGeneMatch.City);
                Console.WriteLine(string.Format("From {0} to {1} with {2}", previousGeneMatch.City, currentGeneMatch.City, distanceSum));
            }

            return distanceSum;
        }
    }
}
