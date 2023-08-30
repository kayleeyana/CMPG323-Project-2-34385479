# CMPG-323-OVERVIEW - 34385479

###
###

PROJECT 1: Overview
### Welcome to the CMPG-323 semester projects overview.
###
This overview provides an outline of the structure and strategies for the CMPG-323 semester projects.

###

# PROJECT SUBMISSIONS AND REPOSITORIES
Each project submission will consist of separate repositories, each with a specific focus:
###
Project 2:
Repository Name: Creating_API 
###

Project 3:
Repository Name: Patterns and Standards
###

Project 4:
Repository Name: Testing and RPA
###

Project 5:
Repository Name: Reporting and Monitoring
###

Portfolio of Evidence:
Repository Name: EXAM_POE

###
###

# PROJECT STRUCTURE
The diagram below provides a visual representation of the structure of each project submission and its corresponding repository name.

![image](https://github.com/kayleeyana/CMPG-323-Overview---34385479/assets/112712495/af584eb0-dc52-445c-af77-85fc3d671fa0)

###
###

# BRANCHING STRATEGY:
The chosen approach for the branching strategy in each project will involve primarily working within the main branch. However, in the event of a bug occurrence, a dedicated development branch will be created specifically to address and resolve the issue. Therefore, all code-related activities are connected to my development branch and the main activities on my main branch.

###
# .gitignore USAGE:
To maintain a clean repository, each project submission will include a .gitignore file. This file will exclude sensitive data from being tracked and committed, ensuring that only relevant and non-sensitive information is shared. I created a gitignore file for my appsettings.json as it included credentials.

###
###

# SECURITY:
To ensure security, sensitive credentials, and confidential information will be stored within files explicitly excluded from public visibility. This method guarantees that private data remains safeguarded and inaccessible when the repository is accessible to the public.

###
# CHARTS

###
###

# Burndown Chart

![image](https://github.com/kayleeyana/CMPG-323-Overview---34385479/assets/112712495/262cba79-7025-45ed-9841-96d861b435d9)



###
###

## Status Chart
![image](https://github.com/kayleeyana/CMPG-323-Overview---34385479/assets/112712495/1687481e-843b-4515-bf0b-043fb64065f3)

###
###

## Sprint Chart
![image](https://github.com/kayleeyana/CMPG-323-Overview---34385479/assets/112712495/91fda10a-7ccc-4b38-8d96-74bab72db6b6)

###
###

## Label Chart
![image](https://github.com/kayleeyana/CMPG-323-Overview---34385479/assets/112712495/a7cf7169-d342-4d74-961d-c9735b483e10)

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

# Microsoft Azure Integration###

![image](https://github.com/kayleeyana/CMPG323-Project-2-34385479/assets/112712495/21febda2-f330-4e85-a637-3054ec6ff3de)

# Microsoft Azure database
1. Started off by creating an account on Microsft Azure.
2. Created a Monthly budget to avoid running out of credits.
3. Created a resource group called rgEcoPowerSolutions.
4. Created a SQL server and database under the resource group rgEcoPowerSolutions.

# API Creation
I used Visual Studio to create the web API. Added controllers that will support the manipulation of tables in the database that is hosted on the Azure server. Thereafter, I implemented security on the API so that no unauthorized user can get access to the API functionality.

# Hosting the API
I published the API via Visual Studio and pulled it from the Azure side.##

 ![image](https://github.com/kayleeyana/CMPG323-Project-2-34385479/assets/112712495/65d93720-ede6-4766-ba88-07d4a982b214)

## Security:
The API is secured in the sense that not everyone has access to it right away. You must register an account in order to use the API to access and manipulate database data. This is a token-based, secure system. The server on which the database is hosted is also secured, and those details are not accessible to everyone.

## How the API should be used by users:
Upon accessing the API, the user must register an account. Then the user may proceed to login. The user should request a token when accessing tables and manipulating data contained in those tables. The account that should be registered is the admin one because it is the only one that is authorized to access the tables.

## Registering an account:
The user must register as an admin user because it is the only role that is authorized to access the tables and table manipulation.

## Logging in:
The user must click on the login button and insert the newly registered credentials. After logging in the user will receive the token. That token must be saved as it will be used to access the tables since this system uses a token based security.

Ensure that the Readme.md file in the GitHub repository explains how the user would use the API. List all endpoints and additional aspects implemented. 


