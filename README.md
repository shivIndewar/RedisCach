🚀 ASP.NET Web App with Azure Cache & Azure SQL

This project demonstrates a high-performance web application built using .NET that leverages in-memory caching with Azure Cache to reduce database load and improve response times.

📌 Architecture Overview

The application follows a cache-aside pattern:

User sends request to the web application

Application checks if data exists in cache

If cache hit → return data immediately

If cache miss → fetch from database

Store data in cache

Return response to user

🧠 Key Concept

Cache stores key/value pairs in memory

Reduces repeated database calls

Improves performance and scalability

🏗️ Tech Stack

Backend: ASP.NET Core

Caching: Azure Cache for Redis

Database: Azure SQL Database

Language: C#

⚙️ How It Works
Client → Web App → Cache Check
                     ↓
                Cache Hit → Return Data
                     ↓
                Cache Miss → Fetch from DB → Store in Cache → Return Data
📂 Project Structure
/src
  ├── Controllers/
  ├── Views/
  ├── Models/
  ├── appsettings.json
  └── Program.cs
🔧 Configuration

Update your appsettings.json:

{
  "ConnectionStrings": {
    "SqlConnection": "<YOUR_AZURE_SQL_CONNECTION_STRING>",
    "RedisConnection": "<YOUR_AZURE_REDIS_CONNECTION_STRING>"
  }
}
▶️ Getting Started
1. Clone the repo
git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name
2. Restore dependencies
dotnet restore
3. Run the application
dotnet run
🧪 Example Flow

<img width="550" height="215" alt="rediscachearchitecture" src="https://github.com/user-attachments/assets/00d8490e-c291-4958-bfee-081afd7c56e3" />

🤝 Contributing

Feel free to fork this repository and submit pull requests.
