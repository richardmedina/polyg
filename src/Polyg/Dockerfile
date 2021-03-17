#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Polyg/Polyg.csproj", "Polyg/"]
COPY ["Polyg.Contract/Polyg.Contract.csproj", "Polyg.Contract/"]
COPY ["Polyg.Domain/Polyg.Domain.csproj", "Polyg.Domain/"]
COPY ["Polyg.Infrastructure/Polyg.Infrastructure.csproj", "Polyg.Infrastructure/"]
COPY ["Polyg.Common/Polyg.Common.csproj", "Polyg.Common/"]
COPY ["Polyg.Services/Polyg.Services.csproj", "Polyg.Services/"]
RUN dotnet restore "Polyg/Polyg.csproj"
COPY . .
WORKDIR "/src/Polyg"
RUN dotnet build "Polyg.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Polyg.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Polyg.dll"]