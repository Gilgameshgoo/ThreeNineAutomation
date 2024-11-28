# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the solution file and all the project files
COPY ./TestProject1 /app

# Restore the solution's dependencies
#RUN dotnet restore

# Build the solution and publish the output (specify the path to your solution file)
RUN dotnet publish /app/TestProject1.sln -c QA

# Expose the application port (assuming your app uses port 80)
EXPOSE 80

# Define the entry point to run the application
ENTRYPOINT ["dotnet", "test", "-c", "QA"]
