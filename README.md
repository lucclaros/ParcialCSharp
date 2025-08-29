Second Partial - Employee and Vehicle Management System
Overview

This project is a C# console application developed as part of a second partial exam. It simulates a management system for employees and vehicles, including functionalities for registering employees, vehicles, and assignments (dotations), as well as listing and sorting data.

The system is organized with object-oriented principles, using inheritance, polymorphism, and collections to manage the data.

Features

Employee Management

Register different types of employees: CChofer (Driver) and CProfesional (Professional Staff).

List and sort all employees by last name.

Display employee data with details such as ID, name, registration number, and category.

Vehicle Management

Register different types of vehicles: CAuto (Car) and CAmbulancia (Ambulance).

List and sort all vehicles by license plate.

Display vehicle details including license plate, brand, model, and type (for ambulances).

Dotation Management

Assign employees to vehicles (currently partially implemented).

User Interface

Interactive console menu for performing all operations.

Input validation for required fields.

Clear display of options and results.

Project Structure

Entities

CEmpleado (abstract) – base class for all employees.

CChofer – inherits from CEmpleado.

CProfesional – inherits from CEmpleado.

CVehiculo (base class) – represents vehicles.

CAuto – inherits from CVehiculo.

CAmbulancia – inherits from CVehiculo, adds ambulance type.

Controllers

CControladora – main entry point and program logic.

CEmpleados – manages the employee collection.

CVehiculos – manages the vehicle collection.

CDotacion / CDotaciones – manage vehicle assignments (dotations).

Utilities

CInterfaz – handles console input and menu display.

Usage

Clone the repository or download the files.

Open the project in Visual Studio or Visual Studio Code with the C# extension installed.

Build the solution.

Run the application.

Follow the console menu to register employees, vehicles, and perform queries.

Notes

The dotation feature (CDotacion / CDotaciones) is not fully implemented.

The application demonstrates object-oriented programming concepts such as inheritance, polymorphism, and collections in C#.

Input validation is included for key fields in the console interface.
