# ASP.NET MVC State Management Example

This project demonstrates the use of various state management techniques in an ASP.NET MVC application, 
including cookies and TempData.

## Project Overview
The project consists of :
1. Program.cs : Configures the ASP.NET Core application pipeline and sets up the default controller route.
2. StateManagementController1.cs : Contains actions demonstrating how to set and retrieve data using cookies and TempData.

# Key Features
- Cookies : 
  - Persistent cookies with expiration.
  - Session cookies.
- TempData :
  - Server-side (session) data persistence using `Peek` and `Keep`.
  - Client-side (Cookies) data persistence.
 
# Notes
 - HTTPS: The application uses HTTPS by default. You may need to configure the development certificate in your environment.
 - TempData Behavior:
  Default behavior removes data after the first read unless explicitly retained.
  Use Peek or Keep to preserve TempData across multiple reads.
