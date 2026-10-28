# Setting Up an NUnit Test Project

I am learning how to write NUnit tests using C# and .NET.
These are the steps I followed to create an NUnit test project using the .NET CLI (Command Line Interface).

## Step 1: Create a Solution

```bash
dotnet new sln --name TestingWithNUnit
```
This command creates a new .NET solution named `TestingWithNUnit`.
A solution is used to organise and manage one or more projects.

## Step 2: Create an NUnit Test Project

```bash
dotnet new nunit -n TestingWithNUnit.Tests
```
This command creates a new NUnit test project named `TestingWithNUnit.Tests`.

- `dotnet new` creates a new project from a template.
- `nunit` specifies the NUnit test project template.
- `-n` specifies the name of the project.
- `TestingWithNUnit.Tests` is the project name.

The project contains a `.csproj` file, which defines the project configuration and dependencies.

## Step 3: Add the NUnit Project to the Solution

```bash
dotnet sln add TestingWithNUnit.Tests/TestingWithNUnit.Tests.csproj
```

This command links the NUnit test project to the solution.
The solution can now recognise and manage the test project.

## Step 4: Run the Tests

```bash
dotnet test
```
This command builds the test project and runs the tests.
It also displays the results, showing which tests passed, failed or were skipped.
