FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SimpleCode/SimpleCode.csproj", "SimpleCode/"]
RUN dotnet restore "SimpleCode/SimpleCode.csproj"
COPY . .
WORKDIR "/src/SimpleCode"
RUN dotnet build "SimpleCode.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleCode.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleCode.dll"]
