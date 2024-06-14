# Kanban Tracker


## Overview

Kanban Tracker is a C# Windows Forms application designed to manage projects using the Kanban methodology. This application allows you to add users and admins, create and manage issues, epics, stories, and tasks, and move tasks across different stages on a Kanban board.

## Features

- **User and Admin Management:** Add and manage users and administrators.
- **Issue Management:** Create and track issues, epics, stories, and tasks.
- **Kanban Board:** Drag and drop tasks between Backlog, To Do, Doing, and Done lists.
- **Database:** Includes a `.bak` file for easy database restoration in MS SQL Server.

## Screenshots

### Add Project
![Add Project](Kanban%20Tracker/images/add_project.jpg) <!-- Make sure to update the path -->

### Add Person
![Add Person](Kanban%20Tracker/images/add_person.jpg) <!-- Make sure to update the path -->

### Kanban Board
![Kanban Board](Kanban%20Tracker/images/kanban_board.jpg) <!-- Make sure to update the path -->

### Projects
![Projects](Kanban%20Tracker/images/projects.jpg) <!-- Make sure to update the path -->

### Create Issue
![Create Issue](Kanban%20Tracker/images/create_issue.jpg) <!-- Make sure to update the path -->

### Create Account
![Create Account](Kanban%20Tracker/images/create_account.jpg) <!-- Make sure to update the path -->

### Login
![Login](Kanban%20Tracker/images/login.jpg) <!-- Make sure to update the path -->

### List
![List](Kanban%20Tracker/images/list.jpg) <!-- Make sure to update the path -->

## Getting Started

### Prerequisites

- Visual Studio
- MS SQL Server
- .NET Framework

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/kanban-tracker.git
    ```

2. Open the solution in Visual Studio.

3. Restore the database:
    - Open MS SQL Server Management Studio.
    - Restore the database using the provided `.bak` file.

4. Update the database connection string in the application configuration file to match your setup:
    ```csharp
    string connectionStr = "Data Source = YOUR_SERVER_NAME; Initial Catalog=KanbanTracker; Integrated Security=true";
    ```
    Replace `YOUR_SERVER_NAME` with the name of your MS SQL Server instance.

### Usage

1. Run the application from Visual Studio.
2. Log in as an admin to manage users and projects.
3. Create issues, epics, stories, and tasks.
4. Use the Kanban board to move tasks between different stages.

## Importance of Kanban Tracker

Kanban Tracker simplifies project management by providing a visual and interactive way to track tasks and progress. It enhances team productivity and collaboration by clearly defining project stages and task statuses, ensuring that everyone is on the same page and can easily see what needs to be done next.

