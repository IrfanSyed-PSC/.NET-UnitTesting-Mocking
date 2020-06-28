using NUnit.Framework;

// If we create a .cs file with the following parameters then .NET reads these assembly properties and set parallelism
[assembly: Parallelizable(ParallelScope.All)]
[assembly: LevelOfParallelism(20)]
