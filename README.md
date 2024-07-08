# Hangfire Template for Recurrent and Immediate Jobs

This solution provides a robust template for managing recurrent (daily, weekly, monthly) and immediate jobs using Hangfire in .NET 8. It is designed to be highly modular and extensible, facilitating easy job management and scheduling.

## Key Features

- **Modular Structure**: The solution is structured into three projects:
  - **HF.Server**: Hosts the Hangfire server using an OWIN-based Windows Service application.
  - **HF.Jobs**: Contains job definitions segregated into folders for different types of jobs (daily, weekly, monthly, immediate).
  - **HF.API**: Provides a minimal API with an example endpoint for triggering immediate job executions.

- **Dynamic Job Scheduling**: Jobs are dynamically scheduled using Hangfire's capabilities, allowing for easy addition, removal, and management of recurrent and immediate tasks.

- **Middleware and Service Registrars**: Utilizes middleware and service registrars for clean and organized configuration:
  - **BuilderExtensions.cs** in **HF.Server** automates service registration based on interfaces, ensuring a scalable and maintainable dependency injection setup.
  - **EndpointsMapping.cs** in **HF.API** defines API endpoints for immediate job execution, encapsulating job triggering logic with error handling and response formatting.

- **Error Handling and Logging**: Integrated logging with Microsoft.Extensions.Logging ensures comprehensive error handling and job execution monitoring.

- **Swagger Integration**: Includes Swagger UI via Swashbuckle.AspNetCore for easy API exploration and testing.

## Installation

1. **Clone the repository**:
    ```sh
    git clone https://github.com/lucasmnxavierrj/HangfireServiceTemplate.git
    cd HangfireServiceTemplate
    ```

2. **Restore NuGet packages**:
    ```sh
    dotnet restore
    ```

## Configuration

1. **Update Connection Strings**: Configure the connection string in `appsettings.json` for both **HF.Server** and **HF.API** projects to point to your database.

2. **Run Hangfire Server**: Build and run the **HF.Server** project to start the Hangfire server. This automatically sets up Hangfire with SQL Server storage.

## Usage

### Adding and Managing Jobs

- **Recurrent Jobs**: Define your recurrent jobs by implementing the `MyBackgroundJob` abstract class in the appropriate folders under **HF.Jobs** (e.g., Daily, Weekly, Monthly).
  
- **Immediate Jobs**: Implement immediate jobs within the **ImmediateJobs** folder under **HF.Jobs**, leveraging the `IBackgroundJobClient` in **HF.API** to enqueue jobs via HTTP POST requests.

### Triggering Immediate Jobs via API

1. **Start the API**: Build and run the **HF.API** project to expose the API endpoints.

2. **Trigger a Job**: Use the provided endpoint to trigger immediate job execution:
    ```sh
    curl -X POST "https://localhost:<port>/immediate-jobs/example1"
    ```
