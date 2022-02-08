# Use Red Hat UBI 8 for 
FROM registry.access.redhat.com/ubi8/dotnet-60-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#FROM registry.access.redhat.com/ubi8/dotnet-60 AS build
#NOTE - Having build output folder permission issues with UBI, so build on ms
WORKDIR /src
COPY ["OsDemoApi/OsDemoApi.csproj", "OsDemoApi/"]
RUN dotnet restore "OsDemoApi/OsDemoApi.csproj"
COPY . .
WORKDIR "/src/OsDemoApi"
RUN dotnet build "OsDemoApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OsDemoApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OsDemoApi.dll"]