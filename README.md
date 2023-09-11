
# CMPG323-Project-2-34385479
Welcome to API Development
###
![image](https://github.com/kayleeyana/CMPG323-Project-2-34385479/assets/112712495/d2034945-ea62-497b-9b21-2c6bd0c10fcc)

## About the Project:
This is a Web API project that works with a database called ecocloudhub. This database is a SQL Server database that is hosted on Azure. 

# The database has three tables namely:
        #Customer
        #Order
        #Product
        #OderDetails

# Microsoft Azure Integration

![image](https://github.com/kayleeyana/CMPG323-Project-2-34385479/assets/112712495/21febda2-f330-4e85-a637-3054ec6ff3de)

# Microsoft Azure database
1. Started off by creating an account on Microsft Azure.
2. Created a Monthly budget to avoid running out of credits.
3. Created a resource group called rgEcoPowerSolutions.
4. Created a SQL server and database under the resource group rgEcoPowerSolutions.

# API Creation
I used Visual Studio to create the web API. Added controllers that will support the manipulation of tables in the database that is hosted on the Azure server. Thereafter, I implemented security on the API so that no unauthorized user could get access to the API functionality.

# Hosting the API
I published the API via Visual Studio and pulled it from the Azure side.

 ![image](https://github.com/kayleeyana/CMPG323-Project-2-34385479/assets/112712495/65d93720-ede6-4766-ba88-07d4a982b214)

## Security:
The API is secured in the sense that not everyone has access to it right away. You must register an account in order to use the API to access and manipulate database data. This is a token-based, secure system. The server on which the database is hosted is also secured, and those details are not accessible to everyone. I also used the git ignore file for all passwords in the appsettings.json file. (For protection purposes)

# API Usage Guide

Welcome to the API Usage Guide for the Project Name API. This guide will help you understand how to interact with the API to access and manipulate data from the ecocloudhub database.

# Getting Started
Once you have access to the API link, 
You should: Register an Account:

Visit the API registration page to create an admin user account.
This account is required to access and manipulate database tables.

# Log In:
Use the login credentials from the registration to log in.
After successful login, you'll receive an authentication token.

# Using the API
Endpoints
Customer Data
# GET /api/customers: Retrieve a list of all customers.
# GET /api/customers/{id}: Retrieve details of a specific customer.##
# POST /api/customers: Create a new customer entry.
# PUT /api/customers/{id}: Update customer details.
# DELETE /api/customers/{id}: Delete a customer.

Order Data
# GET /api/orders: Retrieve a list of all orders.
# GET /api/orders/{id}: Retrieve details of a specific order.
# POST /api/orders: Create a new order.
# PUT /api/orders/{id}: Update order details.
# DELETE /api/orders/{id}: Delete an order.

Product Data
# GET /api/products: Retrieve a list of all products.
# GET /api/products/{id}: Retrieve details of a specific product.
# POST /api/products: Create a new product.
# PUT /api/products/{id}: Update product details.
# DELETE /api/products/{id}: Delete a product.


# Authentication
Include the authentication token received upon login in the Authorization header for each request.

Example: Authorization: Bearer <your-token-here>
Example Workflow

# Register an admin account.
Log in to receive the authentication token.
Use the token in the Authorization header for subsequent requests.
Access customer, order, and product data using the provided endpoints.
Make GET, POST, PUT, or DELETE requests as needed.
Security Notes
The API is secured using token-based authentication.
Only admin users have access to the API endpoints.
The server hosting the database is also secure.

# Resource Group
https://portal.azure.com/#@nwuac.onmicrosoft.com/resource/subscriptions/ba8bb3d0-bd11-4b50-bb78-9cbb21ab2b3c/resourceGroups/rgEcoPowerSolutions/overview

# Link to API (Error 404)
creatingapi20230831134207.azurewebsites.net



