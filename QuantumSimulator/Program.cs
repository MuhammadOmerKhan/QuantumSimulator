using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumTeleportation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var qsim = new QuantumSimulator();
            var initialStates = new[] { Result.Zero, Result.One };

            foreach (var initialState in initialStates)
            {
                var result = await Teleport.Run(qsim, initialState);
                Console.WriteLine($"Initial state: {initialState} => Teleported state: {result}");
            }
        }
    }
}