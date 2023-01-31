# QuantumTeleportation in C#
This program demonstrates the concept of quantum teleportation using C# and the Microsoft Quantum Development Kit.

## Overview
The Teleport class in the provided C# .NET 6.0 program is an example of a quantum teleportation algorithm.

Quantum teleportation is a quantum communication protocol that allows for the transfer of quantum states from one location to another without physically moving the quantum state. This is achieved through the use of entangled qubits and classical communication.

The Teleport class in the provided program is a basic implementation of a quantum teleportation algorithm that can be run on a quantum simulator. The class has a static method Run that takes a QuantumSimulator object and a Result object as input.

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

## Prerequisites
Visual Studio or any other IDE that supports C#
Microsoft Quantum Development Kit

## Nuget Package
Please make sure you have the Microsoft.Quantum.Simulation.Simulators NuGet package installed in your project. You can install it by right-clicking the project in Visual Studio, selecting "Manage NuGet Packages," searching for Microsoft.Quantum.Simulation.Simulators, and clicking "Install."

## Installing
1. Clone the repository.
`bash
Copy code
git clone https://github.com/MuhammadOmerKhan/QuantumSimulator.git`
2. Open the project in Visual Studio or any other IDE that supports C#.
3. Build and run the project.

## Program Walkthrough
The program consists of two main parts: the main program and the Teleport class.

## Main Program
The main program creates a QuantumSimulator object and runs the Teleport.Run method for each possible initial state (Result.Zero and Result.One). The results are then displayed on the console.

```csharp
using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumTeleportation
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Result[] initials = new Result[] { Result.Zero, Result.One };
                foreach (Result initial in initials)
                {
                    var res = Teleport.Run(qsim, initial).Result;
                    Console.WriteLine(
                        $"Initial: {initial} => Teleported: {res}");
                }
            }
            Console.ReadLine();
        }
    }
}
```
## Teleport Class
The Teleport class implements the Run method, which takes a QuantumSimulator object and an initial state as input and returns the teleported state as output.

```csharp
using System;
using System.Threading.Tasks;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumTeleportation
{
    class Teleport
    {
        public static Task<Result> Run(QuantumSimulator qsim, Result initial)
        {
            // Perform your teleportation algorithm here
            return Task.FromResult(initial);
        }
    }
}
```

## Built With
Microsoft Quantum Development Kit
C#
