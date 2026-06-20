# ARFMS — Inter-University Facilities Management System

A desktop application that brings sport and recreation facility bookings for multiple participating universities into one shared system. The focus was on making bookings and facility management straightforward across universities, with clear role-based access so each type of user only sees what's relevant to them.

## Tech Stack

- **IDE:** Microsoft Visual Studio
- **Language:** C# (.NET, Windows Forms)
- **Database:** SQL Server LocalDB (ADO.NET — `SqlConnection`, `SqlCommand`)
- **Architecture:** Object-Oriented Programming

## User Roles

**Manager**
- Add, view, and delete participating universities
- Manage user accounts and roles
- Add, edit, and delete facilities
- Assign maintenance tasks to technicians
- Approve or decline equipment requests

**Receptionist**
- View, add, and delete student accounts
- Search and manage bookings
- Approve or reject facility bookings, generate receipts
- View overall facility ratings

**Student**
- Check facility availability across all participating universities
- Book facilities by date and time
- Submit and view facility reviews/ratings
- Update personal profile

**Maintenance Staff**
- View assigned maintenance schedules
- Update task status (Pending / In Progress / Completed)
- Raise equipment and replacement requests
- Edit personal profile

## Setup

1. Clone the repo:
   ```
   git clone https://github.com/yourusername/ARFMS.git
   ```
2. Open the `.sln` file in Visual Studio.
3. Make sure SQL Server LocalDB is installed and running.
4. Update the connection string in `App.config` (e.g. `myCS` / `myARFMS`) if your local setup differs.
5. Build and run.

## Team

- **Hafiy Ziyad Zikry** — Team lead, Manager module
- **Iddin Irfan Mikhail** — Login & Receptionist module
- **Mohd Afif Ammarhazim** — Student & Maintenance module
