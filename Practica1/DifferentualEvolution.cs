using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    internal class DifferentualEvolution
    {
        public static double[] OptimizeAckley(int populationSize, int dimension, double minRange, double maxRange, int maxGenerations)
        {
            Random random = new Random();
            List<double[]> population = new List<double[]>();

            // Inicializa la población aleatoriamente
            for (int i = 0; i < populationSize; i++)
            {
                double[] individual = new double[dimension];
                for (int j = 0; j < dimension; j++)
                {
                    individual[j] = random.NextDouble() * (maxRange - minRange) + minRange;
                }
                population.Add(individual);
            }

            for (int generation = 0; generation < maxGenerations; generation++)
            {
                List<double[]> newPopulation = new List<double[]>();

                // Implementa la lógica DE para evolucionar la población
                foreach (double[] targetIndividual in population)
                {
                    // Selecciona tres individuos diferentes de la población actual
                    double[] individualA, individualB, individualC;
                    do
                    {
                        individualA = population[random.Next(populationSize)];
                        individualB = population[random.Next(populationSize)];
                        individualC = population[random.Next(populationSize)];
                    } while (individualA == individualB || individualA == individualC || individualB == individualC);

                    // Realiza la operación de mutación y recombinación
                    double[] newIndividual = new double[dimension];
                    for (int j = 0; j < dimension; j++)
                    {
                        double mutationFactor = random.NextDouble();
                        double crossoverFactor = random.NextDouble();
                        if (crossoverFactor <= 0.8)
                        {
                            newIndividual[j] = individualA[j] + mutationFactor * (individualB[j] - individualC[j]);
                        }
                        else
                        {
                            newIndividual[j] = targetIndividual[j];
                        }
                    }

                    // Aplica límites a los valores generados
                    for (int j = 0; j < dimension; j++)
                    {
                        if (newIndividual[j] < minRange)
                        {
                            newIndividual[j] = minRange;
                        }
                        else if (newIndividual[j] > maxRange)
                        {
                            newIndividual[j] = maxRange;
                        }
                    }

                    // Evalúa si el nuevo individuo es mejor que el objetivo actual
                    if (AckleyFuncion.Calculate(newIndividual) < AckleyFuncion.Calculate(targetIndividual))
                    {
                        newPopulation.Add(newIndividual);
                    }
                    else
                    {
                        newPopulation.Add(targetIndividual);
                    }
                }

                // Actualiza la población con los nuevos individuos generados
                population = newPopulation;
            }

            // Encuentra el mejor individuo
            double[] bestIndividual = population.OrderBy(ind => AckleyFuncion.Calculate(ind)).First();
            return bestIndividual;
        }
    }
}
