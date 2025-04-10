# DataNova Dashboard

DataNova Dashboard is a web application designed to provide interactive business intelligence reports using Power BI. It enables users to access and analyze key business data, including sales, projects, finances, and office locations, all in one place.

## Features

- **📦 Sales Report**: View detailed sales data and trends.
- **🗺️ Office Locations Map**: Visualize office locations on an interactive map.
- **💻 Project Report**: Track project progress and performance.
- **💸 Finance Report**: Analyze financial data and insights.
- **Dynamic Report Loading**: Reports are dynamically loaded into the dashboard for a seamless user experience.

## Technologies Used

- **ASP.NET Core Razor Pages** (.NET 8)
- **Power BI Embedded** for interactive reporting
- **Bootstrap 5** for responsive design
- **jQuery** for dynamic content loading

## Installation

1. Clone the repository:
   git clone https://github.com/jaycm18/DataNovaDashboard.git
2. Navigate to the project directory:
   cd DataNovaDashboard
3. Restore dependencies:
   dotnet restore
4. Build the project:
   dotnet build
5. Run the application:
   dotnet run

6. Open your browser and navigate to `http://localhost:5000`.

## Usage

1. Navigate to the homepage to view the dashboard.
2. Use the sidebar to select a report:
   - **Sales Report**
   - **Office Locations Map**
   - **Project Report**
   - **Finance Report**
3. Reports are dynamically loaded into the main content area.

## File Structure

- **Views/Home**: Contains Razor views for the dashboard and individual reports.
- **Views/Shared**: Includes the shared layout for consistent styling.
- **Controllers/HomeController.cs**: Handles routing and dynamic report loading.


## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
