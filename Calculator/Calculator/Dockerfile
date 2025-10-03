# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project files and restore dependencies
COPY ./Calculator/Calculator/*.csproj ./
RUN dotnet restore

# Copy the rest of the source code and build the app
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Use the ASP.NET runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Expose the default port
EXPOSE 8080

# Start the application
ENTRYPOINT ["dotnet", "Calculator.dll"]