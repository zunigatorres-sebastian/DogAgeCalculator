# DogAgeCalculator

High-performance Windows Forms application designed for veterinary data management, age conversion to human age, and automated generation of clinical reports.

*Note: The biological conversion logic follows specific business rules designed for this implementation.*

## Architecture Overview
The application was developed using a layered architecture to separate responsibilities and improve code organization and maintainability.

- **UI (User Interface):** Handles user interaction through Windows Forms components and dynamic data visualization.
- **BLL (Business Logic Layer):** Contains the business rules, validations, and fictional dog age conversion logic.
- **DAL (Data Access Layer):** Manages file operations and data persistence for record storage and retrieval.
- **Entities:** Defines the data models and objects used across the application layers.

## Key Features
- **Dual Export System:** Automatically generates **.DOCX** clinical reports for clients and maintains technical **.TXT** logs for data persistence.
- **Clean Architecture:** Built using a 4-layer pattern (UI, BLL, DAL, Entities) to ensure scalability and maintainability.
- **Age Calculator:** Converts biological age into human-equivalent stages to assist in the categorization and prioritization of medical treatments for different canine life cycles.
- **Office-less Integration:** Leverages **OpenXML SDK** to create structured Word documents, eliminating the need for local Interop or Office licenses.
- **Real-time Data Visualization:** Dynamic UI updates via DataGridView, synchronized with the persistence layer.

## Technologies
- **IDE:** Visual Studio 2022
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
