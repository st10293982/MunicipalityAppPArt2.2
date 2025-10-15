# MunicipalityApp

**Student Name:** Okuhle Nyawo  
**Student Number:** ST10299658  
**Course:** PROG7312 - Practical Assessment (Part 1)

A comprehensive Windows Forms application developed over 4 years for efficient municipal issue reporting and management. Built with .NET and SQLite, it provides a user-friendly interface for citizens to report local issues and track their resolution.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Architecture](#architecture)
- [Database Schema](#database-schema)
- [Contributing](#contributing)
- [Changelog](#changelog)
- [Support](#support)

## Features

### Core Functionality
- **Issue Reporting**: Submit detailed reports with location, category, description, and file attachments
- **Category Support**: Predefined categories including Water, Electricity, Roads, and Sanitation
- **Unique Report Numbers**: Automatic generation of unique identifiers for tracking
- **File Attachments**: Support for image and video attachments to issues
- **Data Persistence**: Robust SQLite database storage with automatic initialization
- **Local Events and Announcements**: Browse upcoming events and announcements with search and recommendations
- **Service Request Status**: View and track the status of submitted issues

### User Interface
- **Organized Main Menu**: MenuStrip with options for Report Issues, Local Events and Announcements, Service Request Status
- **Intuitive Forms**: Clean, Windows-native interface using Windows Forms
- **Input Validation**: Comprehensive validation with user-friendly error messages
- **Status Updates**: Real-time feedback on submission status
- **Form Reset**: Automatic form clearing after successful submissions
- **Event Search and Filtering**: Filter events by category and date range
- **Recommendations**: AI-like suggestions based on search patterns

### Data Management
- **SQLite Integration**: Local database storage for offline functionality
- **Data Integrity**: Unique constraints and proper indexing
- **Backup Ready**: Database stored in user AppData for easy backup
- **Advanced Data Structures**: Uses SortedDictionary, Dictionary, HashSet, PriorityQueue, Queue, Stack for efficient event management

## Screenshots

### Main Application Window
![Municipality App Main Window](assets/muncipality%20app.png)

*The main interface showing the issue reporting form with category selection and input fields.*

## Technologies Used
- **Framework**: .NET 8.0 Windows Forms
- **Database**: SQLite with Microsoft.Data.Sqlite
- **Language**: C# 12.0
- **UI Framework**: Windows Forms with modern styling
- **Build Tool**: MSBuild / dotnet CLI

## Prerequisites
- Windows 10 or later
- .NET 8.0 Runtime or SDK
- 100 MB free disk space

## Installation

### From Source
1. **Clone the repository**
   ```bash
   git clone [(https://github.com/VCDN-2025/prog7312-poe-part-1-ST10299658.git)]
   cd MunicipalityApp
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the application**
   ```bash
   dotnet build --configuration Release
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

### Alternative: Download Release
Download the latest release from the [Releases][(https://github.com/VCDN-2025/prog7312-poe-part-1-ST10299658.git/release)] page and run the installer.

## Usage

### Reporting an Issue
1. Launch the MunicipalityApp
2. Click "Report Issue" from the main menu
3. Fill in the required fields:
   - **Location**: Address or area description
   - **Category**: Select from Water, Electricity, Roads, Sanitation
   - **Description**: Detailed description of the issue
   - **Attachment**: Optional file attachment (images/videos)
4. Click "Submit" to save the report
5. Note the unique Report Number for future reference

### Viewing Issues
- Access the Service Request Status feature from the main menu
- Filter and search through submitted reports
- Track resolution status

### Browsing Local Events and Announcements
1. Launch the MunicipalityApp
2. Click "Local Events and Announcements" from the main menu
3. Browse all events or filter by category and date range
4. View recommendations based on search patterns
5. Events are displayed with title, description, date, category, and priority

## Architecture

### Project Structure
```
MunicipalityApp/
├── DataStorage.cs          # Database operations and SQLite management for issues
├── EventsDataStorage.cs    # Database operations for events and announcements
├── MainForm.cs             # Main application window with MenuStrip
├── ReportIssueForm.cs      # Issue reporting interface
├── ViewIssuesForm.cs       # Issue viewing interface with status display
├── LocalEventsForm.cs      # Local events and announcements interface
├── Event.cs                # Event data model
├── Program.cs              # Application entry point
├── MunicipalityApp.csproj  # Project configuration
└── assets/                 # Static assets (images, icons)
```

### Database Design
- **Local Storage**: SQLite database in user AppData
- **Automatic Initialization**: Database created on first run
- **Schema Evolution**: Support for future database updates
- **Connection Management**: Proper connection handling and disposal

## Database Schema

The application uses two SQLite tables:

### Issues Table
```sql
CREATE TABLE Issues (
    Id TEXT PRIMARY KEY,
    Location TEXT NOT NULL,
    Category TEXT NOT NULL,
    Description TEXT NOT NULL,
    FilePath TEXT,
    SubmittedAt TEXT NOT NULL,
    ReportNumber TEXT NOT NULL UNIQUE
);
```

### Field Descriptions
- **Id**: GUID primary key
- **Location**: Issue location description
- **Category**: Issue category (Water/Electricity/Roads/Sanitation)
- **Description**: Detailed issue description
- **FilePath**: Path to attached file (optional)
- **SubmittedAt**: ISO 8601 timestamp
- **ReportNumber**: Unique human-readable identifier

### Events Table
```sql
CREATE TABLE Events (
    Id TEXT PRIMARY KEY,
    Title TEXT NOT NULL,
    Description TEXT NOT NULL,
    Date TEXT NOT NULL,
    Category TEXT NOT NULL,
    Priority INTEGER NOT NULL,
    ImagePath TEXT
);
```

### Field Descriptions
- **Id**: GUID primary key
- **Title**: Event title
- **Description**: Event description
- **Date**: Event date (ISO 8601)
- **Category**: Event category (Sports/Culture/Education/etc.)
- **Priority**: Event priority (1=Low, 2=Medium, 3=High)
- **ImagePath**: Path to event image (optional)

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Development Guidelines
- Follow C# coding standards
- Add unit tests for new features
- Update documentation for API changes
- Ensure compatibility with .NET 8.0



## Changelog

### Version 2.0.1 (Latest)
- Fixed SQLite schema issue: Modified `EventsDataStorage.cs` to drop and recreate the Events table, ensuring the Tags column is properly included in the schema to prevent "table Events has no column named Tags" error during event insertion.
- Updated Service Status message: Changed the popup message in `MainForm.cs` from operational status to "This feature will come in the next update."
- Updated documentation: Refreshed README.md and TODO.md to reflect completed tasks and recent changes.

### Version 2.0.0
- Added Local Events and Announcements feature with search and recommendations
- Implemented advanced data structures (SortedDictionary, Dictionary, HashSet, PriorityQueue, Queue, Stack)
- Enhanced main menu with organized MenuStrip
- Added EventsDataStorage for event management
- Varied sample events across categories for better testing
- Updated README with comprehensive documentation

### Version 1.0.0
- Initial release with core issue reporting functionality
- SQLite database integration
- File attachment support
- Input validation and error handling

### Version 0.9.0 (Beta)
- Basic Windows Forms interface
- Issue submission without database
- Form validation

### Version 0.5.0 (Alpha)
- Initial prototype
- Basic UI mockups
- Proof of concept

## Support

For support and questions:
- Create an issue on GitHub
- Check the [Wiki]([(https://github.com/VCDN-2025/prog7312-poe-part-1-ST10299658.git/wiki)] for documentation
- Email: support@municipalityapp.com

---



