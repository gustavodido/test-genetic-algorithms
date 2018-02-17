using System;
using GAF;
using GAF.Operators;
using TstGenetic.WorldCup;
using System.Collections.Generic;

namespace TstGenetic
{
    class Program
    {
        public const int MAX_GENERATIONS = 100;

        public const int INITIAL_POPULATION_SIZE = 1000;
        public const int CHROMOSOME_SIZE = 20;

        static void Main(string[] args)
        {
            // Initialize the game table, matches and distances
            WorldCupChronogram.Initialize();
            Distances.Initialize();

            // Population, with a chromossome length
            var population = new Population(CHROMOSOME_SIZE);
            
            // Random seed
            var random = new Random();

            // Initialize the population
            for (int i = 0; i < INITIAL_POPULATION_SIZE; i++)
            {
                var chromossome = new Chromosome();
                for (int j = 0; j < CHROMOSOME_SIZE; j++)
                {
                    //  Somedays have more or less games
                    var maxGamesInDays = WorldCupChronogram.Days[j].NumberOfGames;

                    var gene = new Gene(random.Next(maxGamesInDays));

                    chromossome.Add(gene);
                }

                population.Solutions.Add(chromossome);
            }
        {
    }
}
