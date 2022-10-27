FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /src
RUN dotnet tool install -g dotnet-format --version "7.*" --add-source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet7/nuget/v3/index.json
COPY . .
RUN dotnet restore
ENTRYPOINT [ "dotnet", "format", "analyzers", "--verify-no-changes", "--report", "report", "-v", "diag" ]