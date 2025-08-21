# MyTime

## Description

**MyTime** is an object-oriented C# program designed to model and manipulate time values. It provides a `MyTime` class that encapsulates hours, minutes, and seconds, and supports various operations for incrementing, decrementing, setting, and validating time values.

### Applied Techniques & Design Concepts

- **Object-Oriented Design:**  
  - The `MyTime` class encapsulates all time-related data and operations, following principles of encapsulation and abstraction.
  - All fields are private and accessible only through public methods, maintaining class invariants.

- **Constructor Overloading & Validation:**  
  - Includes both a default constructor (initializes to 00:00:00) and a parameterized constructor with input validation.
  - Throws exceptions on invalid time values, ensuring only valid times are represented.

- **Validation Methods:**  
  - Robust input validation for hours, minutes, and seconds, with helper methods for each field.

- **Time Manipulation Methods:**  
  - Methods to set individual components (`SetHour`, `SetMinute`, `SetSecond`) and the whole time (`SetTime`).
  - Methods to get each component (`GetHour`, `GetMinute`, `GetSecond`).
  - Provides `NextHour`, `NextMinute`, `NextSecond` and their `Previous` counterparts, with proper rollover and boundary logic (e.g., incrementing past 23 hours wraps to 0).

- **String Representation:**  
  - The `ToString()` method outputs the time in `HH:mm:ss` format, with leading zeroes.

- **Exception Handling:**  
  - Throws descriptive `ArgumentException`s for invalid operations, aiding debugging and robust usage.

- **Demonstration:**  
  - The `TestMyTime.cs` file shows usage and tests all major features, including setting, getting, incrementing, decrementing, and displaying time.

---

## Instructions

To run the **MyTime** program in **Microsoft Visual Studio 2022**, follow these steps:

1. **Clone or Download the Repository**
   - Download as ZIP or use Git:
     ```
     git clone https://github.com/rainool/MyTime.git
     ```

2. **Open in Visual Studio 2022**
   - Launch Visual Studio.
   - Go to `File` > `Open` > `Project/Solution`.
   - Navigate to the folder containing `MyTime.cs` and `TestMyTime.cs`.
   - Open the folder as a project, or create a new C# Console Application and add both files to the project.

3. **Add Source Files to Project**
   - Ensure both files are included in the `MyTime` namespace.

4. **Set Startup Object**
   - Confirm `TestMyTime.cs` includes the `Main` method and is set as the startup file.

5. **Build and Run**
   - Press `Ctrl + F5` (or click `Start Without Debugging`) to compile and run.
   - The console will display results from various time operations as demonstrated in `TestMyTime.cs`.

### Requirements

- **Microsoft Visual Studio 2022**
- **.NET 6.0 or later** (recommended)

---

## License

This project is open source and available under the MIT License.

---

Feel free to extend the `MyTime` class to support additional features like time arithmetic, comparison, or formatting!
