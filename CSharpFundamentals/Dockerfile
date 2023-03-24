FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CSharpFundamentals/CSharpFundamentals.csproj", "CSharpFundamentals/"]
RUN dotnet restore "CSharpFundamentals/CSharpFundamentals.csproj"
COPY . .
WORKDIR "/src/CSharpFundamentals"
RUN dotnet build "CSharpFundamentals.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CSharpFundamentals.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CSharpFundamentals.dll"]
