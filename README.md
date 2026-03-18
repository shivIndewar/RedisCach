🚀 ASP.NET Web App with Azure Cache & Azure SQL

A high-performance web application built with ASP.NET Core that utilizes Azure Cache for Redis and Azure SQL Database to optimize data access, reduce latency, and improve scalability.

📌 Overview

This project demonstrates how to implement a cache-aside pattern in a modern .NET application. By integrating in-memory caching, the application minimizes database load and significantly improves response times.

🧠 Key Concepts

🔹 Cache-aside pattern for efficient data retrieval

🔹 In-memory key/value storage using Redis

🔹 Reduced database round-trips

🔹 Improved application performance and scalability

🏗️ Architecture

The application workflow:

Client → Web App → Cache Check
                     ↓
                Cache Hit → Return Data
                     ↓
                Cache Miss → Fetch from DB → Store in Cache → Return Data
🔄 Request Flow

Client sends a request to the application

Application checks Redis cache

If cache hit → data is returned instantly

If cache miss:

Fetch data from Azure SQL Database

Store data in Redis cache

Return response to client

🛠️ Tech Stack
Layer	Technology
Backend	ASP.NET Core
Language	C#
Caching	Azure Cache for Redis
Database	Azure SQL Database
📂 Project Structure
/src
  ├── Controllers/   # Handles HTTP requests
  ├── Models/        # Data models
  ├── Views/         # UI components
  ├── appsettings.json
  └── Program.cs     # Entry point
⚙️ Configuration

Update your appsettings.json with your Azure credentials:

{
  "ConnectionStrings": {
    "SqlConnection": "<YOUR_AZURE_SQL_CONNECTION_STRING>",
    "RedisConnection": "<YOUR_AZURE_REDIS_CONNECTION_STRING>"
  }
}
▶️ Getting Started
1️⃣ Clone the Repository
git clone https://github.com/shivIndewar/RedisCach.git
cd RedisCach
2️⃣ Restore Dependencies
dotnet restore
3️⃣ Run the Application
dotnet run
🧪 Example Flow

🚀 Features

⚡ Fast data retrieval using Redis caching

📉 Reduced database load

🔄 Scalable and production-ready architecture

🧩 Clean and maintainable project structure

🤝 Contributing

Contributions are welcome!


<img width="550" height="215" alt="rediscachearchitecture" src="https://github.com/user-attachments/assets/019c9182-e6b8-4ebd-8a35-66efa5c8ad93" />
