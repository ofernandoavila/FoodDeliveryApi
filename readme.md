<h1 align="center">🍔 Food Delivery API </h1>
<div align="center">
 
<a href="">![.NET Core](https://img.shields.io/badge/.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)</a>
<a href="">![PostgreSQL](https://img.shields.io/badge/PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white)</a>
<a href="">![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)</a>

</div>

<br>

<h2 align="center">📌 Project Overview</h2>

<p align="center">
<b>Food Delivery API</b> is a platform designed to manage restaurants efficiently. Restaurant owners can register their businesses, add products, and track payments. Customers can create accounts to place orders, while owners maintain control over their sales and financial transactions. <br>The system also supports managing multiple restaurants under a single account.
</p>

<br>

## 🚀 Technologies Used

- **Backend**: .NET Core
- **Database**: PostgreSQL

---

## 🔥 Features

✔️ Restaurant registration and management  
✔️ Product catalog for each restaurant  
✔️ Customer account creation and order placement  
✔️ Payment tracking and financial management  
✔️ Multi-restaurant support for owners  

---

## 🛠️ Installation & Setup

Clone the repository:
```sh
git clone https://github.com/ofernandoavila/fooddeliveryapi food_delivery_api
cd food_delivery_api
```

Run the application:
```sh
dotnet run
```

Ensure PostgreSQL is running and configured properly.

---

## 📞 Contact

📌 **Developer**: Fernando Avila  
📧 **Email**: [fernandoavilajunior@gmail.com](mailto:fernandoavilajunior@gmail.com)  
🔗 **LinkedIn**: [linkedin.com/in/ofernandoavila](https://linkedin.com/in/ofernandoavila)  

<br>

## 📌 .NET Core Guide

This document provides essential information for setting up and running a .NET Core application using CLI commands.


### 📌 Requirements

Before running the project, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/) (if using a database)
- [Docker](https://www.docker.com/) (optional, if using containers)

To verify the .NET SDK installation, run:

```sh
 dotnet --version
```

### 📌 Running the Application Locally

To run the application using the .NET CLI, execute:

```sh
dotnet run
```
### 📌 Stopping the Application

To stop the running application, press `CTRL + C` in the terminal where it's running.

---

### 📌 Managing Migrations

### Add a Migration

To create a new migration:

```sh
dotnet ef migrations add <MIGRATION NAME> --project ..\Ofernandoavila.FoodDelivery.Data\Ofernandoavila.FoodDelivery.Data.csproj --startup-project . --context AppDbContext
```

### Remove Last Migration

If you need to undo the last migration:

```sh
dotnet ef migrations remove --project ..\Ofernandoavila.FoodDelivery.Data\Ofernandoavila.FoodDelivery.Data.csproj --startup-project . --context AppDbContext
```

### Apply Migrations

To apply migrations and update the database:

```sh
dotnet ef migrations update --project ..\Ofernandoavila.FoodDelivery.Data\Ofernandoavila.FoodDelivery.Data.csproj --startup-project . --context AppDbContext
```
<br>

## 📌 Docker Container Guide

This document provides the main commands for managing Docker containers for **.NET Core + PostgreSQL**.

---

### 📌 Start the Containers
To start the containers (API .NET Core and PostgreSQL):

```sh
docker-compose up -d
```

---

## 📌 Rebuild and Restart Containers
If there are code changes and you need to rebuild the containers:

```sh
docker-compose up -d --build
```

---

## 📌 Stop Containers (without removing them)
To stop container execution without deleting them:

```sh
docker-compose stop
```
---

## 📌 Start Stopped Containers
If you have stopped the containers and want to start them again:

```sh
docker-compose start
```

---

## 📌 Remove Containers and Volumes
If you need to completely remove the containers and volumes (such as stored databases):

```sh
docker-compose down -v
```

---

## 📌 List Running Containers
To check which containers are running:

```sh
docker ps
```

To list all containers, including stopped ones:

```sh
docker ps -a
```

---

## 📌 Check Container Logs
To view logs for the API (.NET Core) or the database (PostgreSQL):

```sh
docker logs -f minha_api
```

```sh
docker logs -f postgres_container
```
---

## 📌 Access a Container's Terminal
To access a container's shell:

```sh
docker exec -it postgres_container bash
```

Or for a .NET Core container:

```sh
docker exec -it minha_api bash
```
---

## 📌 Check Database Status (PostgreSQL)
To verify if the database is running correctly:

```sh
docker exec -it postgres_container psql -U $POSTGRES_USER -d $POSTGRES_DB
```

---

## 📌 Remove a Specific Container
If you want to remove only the API or PostgreSQL container, run:

```sh
docker rm -f minha_api
```

```sh
docker rm -f postgres_container
```
---

## 📌 Remove All Docker Images
If you need to clean up all Docker images on the system:

```sh
docker rmi $(docker images -q) -f
```
