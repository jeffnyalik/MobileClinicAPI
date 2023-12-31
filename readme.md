﻿# Clinic Appointment management Restful API.

The Restful API has been developed using C#/ASpNetCore webAPI.
The functionality of the API includes:

 -Adding patient records to the database
 -Getting the patients Details.
 -Getting A single patient details.
 -Updating the patients records
 -Deleting the patient record

 ### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/jeffnyalik/MobileClinicAPI.git
    ```

2. Restore dependencies:

    ```bash
    dotnet restore
    ```

3. Update the database with migrations:

    ```bash
    dotnet ef database update
    ```

4. Run the application:

    ```bash
    dotnet run
    ```
## Tools used include:
  -Aspnetcore.
  -C#
  -SqlServer Database.
  -SqlServer Management Studio
  -Visual Studio 2022

Here is a sneak preview of the app project endpoints

## Endpoints

### Patients

- `GET /api/patients`: Get all patients.
- `GET /api/patients/{id}`: Get a specific patient by ID.
- `POST /api/patients`: Create a new patient.
- `PUT /api/patients/{id}`: Update a patient by ID.
- `DELETE /api/patients/{id}`: Delete a patient by ID.

![](images/rest_api.png)


Happy Coding!!
