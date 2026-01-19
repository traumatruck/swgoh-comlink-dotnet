# Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy only what we need (entire src is fine for now)
COPY ./src ./src

RUN dotnet restore ./src/SwgohComlink.Api/SwgohComlink.Api.csproj
RUN dotnet publish ./src/SwgohComlink.Api/SwgohComlink.Api.csproj -c Release -o /out

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /out ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "SwgohComlink.Api.dll"]