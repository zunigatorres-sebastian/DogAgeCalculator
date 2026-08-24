# DogAgeCalculator

Windows Forms application designed to calculate a dog's equivalent age in human years using conversion rules defined specifically for this project. The application allows users to manage dog information, perform age calculations, and store the generated results.

*Note: The age conversion logic follows specific rules defined for this implementation and is intended for informational purposes only.*

## Architecture Overview
The application was developed using a layered architecture to separate responsibilities and improve code organization and maintainability.

- **UI (User Interface):** Handles user interaction through Windows Forms components and dynamic data visualization.
- **BLL (Business Logic Layer):** Contains business rules, validations, and the logic for converting a dog's age into an equivalent human age.
- **DAL (Data Access Layer):** Manages file operations and data persistence for storing and retrieving records.
- **Entities:** Defines the data models and objects used across the different application layers.

## Key Features
- **Dog Age Calculator:** Converts a dog's age into an equivalent human age using the conversion rules established for the project.
- **Information Management:** Allows users to register, view, and manage the information used by the calculator.
- **Data Persistence:** Stores records using text files to facilitate data storage and retrieval.
- **Document Generation:** Uses the OpenXML SDK to generate .DOCX documents containing calculation results without requiring Microsoft Office or local Interop installations.
- **Layered Architecture:** Implements a four-layer pattern (UI, BLL, DAL, and Entities) to maintain a clear separation of responsibilities.
- **Real-time Data Visualization:** Dynamically updates displayed information through components such as `DataGridView`, synchronized with the persistence layer.

## Technologies
- **Language/Framework:** C# / .NET 8.0
- **UI:** Windows Forms (WinForms)
- **Dependencies:** DocumentFormat.OpenXml (NuGet Package)

## How to Run the Project
### Option 1 - Download Executable
1. Go to **release** section
2. Download **.zip** file and extract its contents
3. Run the **.exe** file to start the application

### Option 2 - Open in Visual Studio 2022
1. Clone the repository
2. Open the **.sln** project
3. Restore and Run 

## Requirements
- [**.NET 8.0 Desktop Runtime:**](https://dotnet.microsoft.com/download/dotnet/8.0) Required to run the application.
- **Infrastructure:** Lightweight and portable. The application is **environment-independent**, meaning it doesn't require Word, Excel, or external database drivers to function (standalone file persistence)

## Author
Sebastián Zúñiga Torres
