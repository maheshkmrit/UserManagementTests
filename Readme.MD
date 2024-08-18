# User Management Testing

This document outlines the test methods for the `UserManagement` class. It includes details about the test methods, the libraries used, and the required NuGet packages.

## Test Methods

### `Add_CreateUser`

**Description**:  
This test method verifies that a new user can be added successfully to the `UserManagement` system. It checks that the user is saved with the correct first name, last name, and that the email verification status is set to `false`.

**Test Steps**:

1. **Arrange**: Initialize an instance of `UserManagement`.
2. **Act**: Add a new user with the name "Mahesh Kumar" to the `UserManagement` instance.
3. **Assert**:
   - Ensure that there is exactly one user in the `AllUsers` collection.
   - Verify that the saved user's first name is "Mahesh".
   - Verify that the saved user's last name is "Kumar".
   - Check that the user's email verification status is `false`.

### `Update_UpdateMobileNumber`

**Description**:  
This test method checks that a user's phone number can be updated correctly in the `UserManagement` system. It ensures that the updated phone number is saved properly.

**Test Steps**:

1. **Arrange**: Initialize an instance of `UserManagement` and add a new user.
2. **Act**:
   - Retrieve the added user.
   - Update the user's phone number to "7250833924".
   - Update the user in the `UserManagement` instance.
3. **Assert**:
   - Ensure that there is exactly one user in the `AllUsers` collection.
   - Verify that the user's phone number has been updated to "7250833924".

## Libraries and NuGet Packages

The tests are written using the xUnit testing framework. To run these tests, you need to include the xUnit library in your project.

### Required NuGet Packages

- **xUnit**:  
  The xUnit library is required for writing and executing unit tests.  
  [NuGet Package](https://www.nuget.org/packages/xunit)  
  **Command to install**: `dotnet add package xunit`

- **xUnit.runner.visualstudio** (optional):  
  This package is useful for running tests within Visual Studio.  
  [NuGet Package](https://www.nuget.org/packages/xunit.runner.visualstudio)  
  **Command to install**: `dotnet add package xunit.runner.visualstudio`

## Running Tests

To execute the tests, you can use the following methods:

1. **Using .NET CLI**:
   ```sh
   dotnet test
   ```
