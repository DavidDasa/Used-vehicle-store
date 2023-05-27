# Yad2_Cars Application

Yad2_Cars is a Windows Forms application that allows users to browse and buy electric cars, petrol cars, and motorcycles. The application provides functionality for both users and administrators.

## Features

### User Features

- View and browse electric cars, petrol cars, and motorcycles.
- View detailed information about each vehicle, including model, year, mileage, price, and specifications.
- Add vehicles to the shopping list.
- View the shopping list with the total price.
- Exit the application.

### Administrator Features

- Add new electric cars, petrol cars, and motorcycles to the inventory.
- Edit existing vehicles in the inventory.
- Delete vehicles from the inventory.
- Access the application's administrative panel with a password.
- Exit the administrative panel.

## Getting Started

To run the Yad2_Cars application, follow these steps:

1. Clone the repository or download the source code.
2. Open the project in Visual Studio.
3. Build the solution to restore the NuGet packages and compile the application.
4. Run the application in the Visual Studio debugger or compile it and run the executable file.

## Usage

When you launch the Yad2_Cars application, you will see a welcome screen with options to browse cars, motorcycles, or exit the application. Select the desired option to proceed.

### User Mode

#### Browsing Vehicles

- Click on the "Cars" button to browse electric and petrol cars.
- Click on the "Motorcycle" button to browse motorcycles.
- The available vehicles will be displayed in a list.
- Select a vehicle from the list to view detailed information.
- Use the scroll bar to navigate through the list if it exceeds the visible area.

#### Adding Vehicles to Shopping List

- To add a vehicle to the shopping list, click the "Add to Shopping List" button on the vehicle's information page.
- The vehicle will be added to the shopping list.
- You can view the shopping list by clicking the "Shopping List" button.
- The shopping list will display the selected vehicles and their total price.

### Administrator Mode

#### Accessing the Administrative Panel

- Click on the "Add Vehicle" button on the welcome screen to access the administrative panel.
- Enter the correct password in the password input field and click the "Enter" button.
- If the password is correct, the administrative panel will be displayed.

#### Adding Vehicles to Inventory

- In the administrative panel, click on the "Add Electric Car," "Add Petrol Car," or "Add Motorcycle" button to add a new vehicle to the inventory.
- Enter the required information for the vehicle, such as model, year, mileage, price, and specifications.
- Click the "Add" button to add the vehicle to the inventory.

#### Editing Vehicles in Inventory

- In the administrative panel, click on the "Edit Electric Car," "Edit Petrol Car," or "Edit Motorcycle" button to edit an existing vehicle in the inventory.
- Select the vehicle from the drop-down list.
- Update the desired fields for the vehicle.
- Click the "Save" button to save the changes.

#### Deleting Vehicles from Inventory

- In the administrative panel, click on the "Delete Electric Car," "Delete Petrol Car," or "Delete Motorcycle" button to delete a vehicle from the inventory.
- Select the vehicle from the drop-down list.
- Click the "Delete" button to remove the vehicle from the inventory.

#### Exiting the Administrative Panel

- To exit the administrative panel, click the "Exit" button.
- You will be returned to the welcome screen.

## Development Environment

- Language: C#
- Framework: .NET Framework
- IDE: Visual Studio

## Dependencies

The Yad2_Cars application relies on the following dependencies:

- .NET Framework
