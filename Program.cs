using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;

return new CommandLineBuilder()
    .UseResources(new MyResources())
    .UseDefaults()
    .Build()
    .Invoke("--help");

class MyResources : Resources
{
    public override string HelpUsageTile()
    {
        throw new Exception("Never called :(");
    }
}