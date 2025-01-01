# ECommerce Application

An **ECommerce application** built with **microservices**, **Kafka**, and **.NET Core 8**. The frontend uses **Razor Pages** to provide an interactive shopping experience.

## Technologies Used

- **.NET Core 8**: Backend API and Razor Pages
- **Kafka**: For communication between microservices
- **Aspire**: For process automation like order processing
- **SQL Server/PostgreSQL/MongoDB**: Databases for services

## Features

- **Microservices**: Scalable, independent services for product, order, and user management.
- **Kafka**: Event-driven architecture for real-time data synchronization.
- **Aspire**: Automates workflows like order fulfillment.

## Running the Application

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/ECommerce_Application.git
    cd ECommerce_Application
    ```

2. Run the microservices and frontend:

    ```bash
    dotnet build
    dotnet run
    ```
