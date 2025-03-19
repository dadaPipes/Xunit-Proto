---
_layout: landing
---

# Welcome to xUnit

xUnit is a widely used unit testing framework for .NET applications. It provides a modern, flexible, 
and extensible approach to writing tests, making it a preferred choice over older frameworks 
like **MSTest** and **NUnit**.

## Key Features of xUnit

- Attribute-Based Testing: Uses ```[Fact]``` for single tests and ```[Theory]``` for parameterized tests.

- Built-In Dependency Injection: Supports constructor injection for test class dependencies.

- Isolation & Parallelization: Runs tests in isolation and supports parallel execution for better performance.

- Extensibility: Allows custom test behaviors using fixtures and collections.

## Basic Example:

```csharp
public class SampleTests
{
    [Fact]
    public void Addition_ShouldReturnCorrectSum()
    {
        int result = 2 + 3;
        Assert.Equal(5, result);
    }
}
```

xUnit is well-integrated with .NET CLI, Visual Studio, and CI/CD pipelines, 
making it an excellent choice for test automation in modern .NET applications.