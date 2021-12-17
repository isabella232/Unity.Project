# Unity Analyzer

After some futher investigation, we could generate a JSON from `Microsoft.Unity.Analyzers`

If you want to see how to reproduce locally, check `Dockerfile`

## How does it work

- Was created a dummy C# project (Unity.Project) with Unity.SDK as dependency (see Unity.Project.csproj)
- [Microsoft.Unity.Analyzers](https://github.com/microsoft/Microsoft.Unity.Analyzers) was added to this dummy project.
- `Default.ruleset` was added. This file defines the rules that will be analyzed and its severity. Check `Unity.Project` to see this file linked to project. 
- There is a [dotnet global tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools) called [dotnet format](https://github.com/dotnet/format) that generate the JSON file based on analyzers of project.

## How to run

```sh
docker build -t "unity-analyzer" .
docker run -v $PWD/:/src/report "unity-analyzer"
```

After runing this, you will see a filed named `format-report.json` which is the result of analysis.

## Useful resources
https://docs.unity3d.com/Manual/roslyn-analyzers.html

https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/index.md

