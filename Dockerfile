FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ControlPoint/ControlPoint.csproj", "ControlPoint/"]
RUN dotnet restore "ControlPoint/ControlPoint.csproj"
COPY . .
WORKDIR "/src/ControlPoint"
RUN dotnet build "ControlPoint.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ControlPoint.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ControlPoint.dll"]
