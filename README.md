Contract Monthly Claim System
📌 Overview

The Contract Monthly Claim System is a prototype WPF application designed to simplify and digitize the process of managing lecturer claims. The system allows lecturers to submit their monthly claims, attach supporting documents, and track claim statuses. Programme Coordinators and Academic Managers can verify and approve claims with transparency.

This prototype is not fully functional but demonstrates the navigation, layout, and potential workflow of the final application.

✨ Features

Dashboard: Central hub for navigation across the app.

Add Claim: Lecturers can enter claim details such as title, amount, date, description, and upload supporting files.

Track Claims: Displays claim history with fake statuses (Pending, Approved, Rejected) for prototype purposes.

Approve Claims: Managers can view submitted claims and approve or reject them.

Profile: Displays lecturer information.

Settings: Inspired by WhatsApp layout with sections for Notifications, Security, and Change Password.

🏗️ Design Choices

WPF (C#) was chosen for its ability to create interactive desktop prototypes with clean GUI layouts.

A modular navigation system was implemented so each page (UserControl) can be loaded dynamically into the main window.

Consistency: Dark header sections and light content backgrounds were chosen for a professional look.


ClaimDesk/
│
├── MainWindow.xaml          # Main container
├── Dashboard.xaml           # Dashboard navigation
├── AddClaim.xaml            # Submit claim form
├── TrackClaims.xaml         # Claim history with fake statuses
├── ApproveClaims.xaml       # Approve/Reject claim interface
├── Profile.xaml             # User profile page
├── Settings.xaml            # System settings
└── /Assets                  # Images, icons, and resources

Database Design (Conceptual)

User: Stores lecturers, coordinators, and managers.

Claim: Stores submitted claims (title, amount, date, description).

Approval: Stores approval/rejection details of each claim.

Policy (optional): Stores rules for claims.

See the UML class diagram for relationships.

🚀 How to Run

Clone or download the project.

Open the solution in Visual Studio.

Build and run the project.

Navigate through the app to explore the prototype.

⚠️ Limitations

No actual database connection (static data is used).

Upload functionality is simulated.

Approval and statuses are non-functional placeholders.

📅 Future Improvements

Connect to a real database (SQL Server).

Implement authentication and role-based access (Lecturer, Coordinator, Manager).

Add real file upload and storage.

Enable dynamic approval workflows.
