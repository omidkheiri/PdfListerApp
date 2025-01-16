# PdfListerApp

## Overview
PdfListerApp is a .NET Core console application that lists all PDF files in a specified directory and creates a text file for each PDF. Each text file contains the name of the PDF and its byte array representation as a string.

## Features
- Lists all PDF files in a given directory.
- Creates a text file for each PDF with its name and byte array value.

## Project Structure
```
PdfListerApp
├── PdfListerApp
│   ├── Program.cs
│   └── PdfProcessor.cs
├── PdfListerApp.sln
└── PdfListerApp.csproj
```

## Getting Started

### Prerequisites
- .NET Core SDK installed on your machine.

### Building the Application
1. Open a terminal and navigate to the project directory.
2. Run the following command to build the application:
   ```
   dotnet build
   ```

### Running the Application
1. Navigate to the directory containing the compiled application.
2. Run the application using the following command:
   ```
   dotnet run
   ```

### Usage
- Specify the directory containing the PDF files in the `Program.cs` file.
- The application will create text files in the same directory with the PDF names and their byte array values.

## Contributing
Feel free to submit issues or pull requests for improvements or bug fixes.

## License
This project is licensed under the MIT License.