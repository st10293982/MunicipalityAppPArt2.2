MunicipalityApp

Cebolenkosi Lindelwa Nyawo
ST10293982
PROG7312 (Part 2)

MunicipalityApp is a comprehensive Windows Forms application developed to streamline municipal issue reporting and management. Built with .NET 8.0 and SQLite, it provides citizens with an intuitive interface to report local issues, attach media, and track their resolution status.

Table of Contents

Features

Technologies Used

Prerequisites

Installation

Usage

Architecture

Database Schema

Contributing

Changelog

Support

Features
Core Functionality

Report Issues: Submit detailed reports with location, category, description, and optional file attachments.

Categories: Updated categories include Community, Sports, Government, Culture, Education, Health, Environment, Arts, Business, Recreation.

Unique Report Numbers: Automatically generates unique identifiers for tracking.

Media Attachments: Upload images or videos to support your reports.

Local Events & Announcements: Browse upcoming events with search and recommended categories.

Service Request Status: Track the progress of submitted reports in real-time.

User Interface

Main Menu: Organized MenuStrip for easy navigation between features.

Intuitive Forms: Clean, native Windows Forms design.

Input Validation: Ensures accurate and complete user submissions with clear prompts.

Status Feedback: Immediate confirmation and status messages.

Form Reset: Clears forms after successful submissions.

Event Search & Filtering: Filter events by category and date range.

Recommendations: Suggests relevant categories based on search patterns.

Data Management

SQLite Database: Local storage for offline support.

Data Integrity: Proper indexing and unique constraints ensure reliable data.

Backup-Friendly: Database stored in user AppData folder.

Efficient Structures: Uses Dictionary, SortedDictionary, HashSet, Queue, Stack, PriorityQueue for optimized event handling.

Screenshots
Main Application Window


Displays the issue reporting form with updated categories and input fields.

Technologies Used

Framework: .NET 8.0 Windows Forms

Database: SQLite via Microsoft.Data.Sqlite

Language: C# 12.0

UI Framework: Windows Forms with modern styling

Build Tools: MSBuild / dotnet CLI

Prerequisites

Windows 10 or later

.NET 8.0 Runtime or SDK

100 MB free disk space

Installation

Ensure .NET 8.0 Runtime or SDK is installed on your system.

Open the project in Visual Studio or your preferred IDE.

Restore dependencies if required.

Build the project in Release configuration.

Run the application directly from the IDE or the compiled executable.

Usage
Reporting an Issue

Open MunicipalityApp.

Navigate to Report Issue from the main menu.

Fill in the required fields:

Location: Address or area description

Category: Select from Community, Sports, Government, Culture, Education, Health, Environment, Arts, Business, Recreation

Description: Provide detailed information

Attachment: Optional image/video

Click Submit.

Note the unique Report Number for tracking.

Viewing Submitted Issues

Access Service Request Status to view reports.

Filter, search, and track resolution status.

Browsing Local Events

Open Local Events and Announcements.

Browse or filter by category and date.

Recommendations are displayed based on previous search patterns.

Events include title, description, date, category, and priority.

Architecture
Project Structure
MunicipalityApp/
├── DataStorage.cs          # SQLite database management for issues
├── EventsDataStorage.cs    # SQLite management for events
├── MainForm.cs             # Main window with MenuStrip
├── ReportIssueForm.cs      # Issue reporting form
├── ViewIssuesForm.cs       # Status tracking form
├── LocalEventsForm.cs      # Events and announcements interface
├── Event.cs                # Event data model
├── Program.cs              # Application entry point
├── MunicipalityApp.csproj  # Project config
└── assets/                 # Images and icons

Database Design

Local Storage: SQLite database in AppData

Automatic Initialization: Database created on first run

Schema Updates: Supports future changes

Connection Handling: Proper disposal and management

Database Schema
Issues Table
CREATE TABLE Issues (
    Id TEXT PRIMARY KEY,
    Location TEXT NOT NULL,
    Category TEXT NOT NULL,
    Description TEXT NOT NULL,
    FilePath TEXT,
    SubmittedAt TEXT NOT NULL,
    ReportNumber TEXT NOT NULL UNIQUE
);


Id: GUID

Location: Issue location

Category: Selected category

Description: Issue details

FilePath: Optional file attachment

SubmittedAt: ISO timestamp

ReportNumber: Unique identifier

Events Table
CREATE TABLE Events (
    Id TEXT PRIMARY KEY,
    Title TEXT NOT NULL,
    Description TEXT NOT NULL,
    Date TEXT NOT NULL,
    Category TEXT NOT NULL,
    Priority INTEGER NOT NULL,
    ImagePath TEXT
);


Id: GUID

Title: Event title

Description: Event details

Date: ISO date

Category: Event category (updated set of categories)

Priority: 1=Low, 2=Medium, 3=High

ImagePath: Optional image