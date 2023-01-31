global using BenchmarkDotNet.Attributes;
global using BenchmarkDotNet.Running;
global using BenchmarkDotNet.Order;
global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.Runtime.CompilerServices;
global using Bogus;
global using BenchmarkDotNet.Jobs;

BenchmarkRunner.Run<Add_vs_AddRange>();
BenchmarkRunner.Run<Aggregate_vs_StringJoin>();
BenchmarkRunner.Run<CheckIfAddUpdateRemove_vs_RemoveRangeAddRangeAsync>();
BenchmarkRunner.Run<DatabaseLinqWhereCount_vs_DatabaseLinqCount>();
BenchmarkRunner.Run<Equals_vs_EqualEqual>();
BenchmarkRunner.Run<Find_vs_SingleFirst>();
BenchmarkRunner.Run<Foreach_vs_ForEachLinq>();
BenchmarkRunner.Run<IAsyncEnumerable_vs_TaskList>();
BenchmarkRunner.Run<LinqWhereCount_vs_LinqCount>();
BenchmarkRunner.Run<Loop_vs_Recursion>();
BenchmarkRunner.Run<Program>();
BenchmarkRunner.Run<StringEquals_vs_ToLower_vs_ToUpper>();
BenchmarkRunner.Run<SystemDiagnosticsStackTrace_vs_CallerMemberName>();
BenchmarkRunner.Run<SystemTextJson_vs_NewtonsoftJson>();
BenchmarkRunner.Run<Update_vs_RemoveAdd>();
