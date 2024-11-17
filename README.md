# Dependency Injection Example

This project demonstrates the use of **Dependency Injection** in C# by implementing a simple example with `Teacher` and `ClassRoom` classes. The purpose of this project is to reduce coupling between classes and make the design more flexible.

## Overview

### Classes

#### 1. Teacher Class
- **Properties**:
  - `FirstName` (string): The first name of the teacher.
  - `LastName` (string): The last name of the teacher.

- **Methods**:
  - `GetInfo()`: Returns the full name of the teacher (first name and last name).

#### 2. ClassRoom Class
- **Properties**:
  - `Teacher` (ITeacher): An instance of the `Teacher` class.

- **Methods**:
  - `GetTeacherInfo()`: Calls the `GetInfo()` method of the `Teacher` instance to get the teacher's information.

### Dependency Injection
- The `ClassRoom` class uses **Constructor Injection** to receive an instance of the `Teacher` class through its constructor.
- The `Teacher` class implements an interface `ITeacher` to follow dependency inversion principles.

### Project Structure
- **Services/ITeacher.cs**: Interface for the `Teacher` class.
- **Managers/Teacher.cs**: Implementation of the `ITeacher` interface.
- **Managers/ClassRoom.cs**: The `ClassRoom` class that depends on `ITeacher`.
- **Controllers/ClassRoomsController.cs**: A simple controller to test the dependency injection functionality.

## Example Code

### Teacher Interface
```csharp
public interface ITeacher
{
    string GetInfo();
}
```

### Teacher Class
```csharp
public class Teacher : ITeacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetInfo()
    {
        return $"{FirstName} {LastName}";
    }
}
```

### ClassRoom Class
```csharp
public class ClassRoom
{
    private readonly ITeacher _teacher;

    public ClassRoom(ITeacher teacher)
    {
        _teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}
```

## How It Works

1. **Define Interfaces**:
   - The `Teacher` class implements the `ITeacher` interface to abstract its functionality.
2. **Constructor Injection**:
   - The `ClassRoom` class receives an instance of `ITeacher` through its constructor, adhering to dependency injection principles.
3. **Controller Usage**:
   - The `ClassRoomsController` uses the `ClassRoom` instance to fetch and display teacher information.

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/dependency-injection-example.git
   ```

2. Open the project in Visual Studio.

3. Build and run the project:
   ```bash
   dotnet run
   ```

4. Access the API or debug the project to see the dependency injection in action.

---

## Author

Created by **Batuhan Uzun**
