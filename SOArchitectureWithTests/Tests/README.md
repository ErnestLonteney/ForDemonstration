# Test Project Documentation

## Overview
The **Tests** project is a NUnit-based test suite for testing the **Services** layer with an **in-memory database** context.

## Project Structure

```
Tests/
├── Tests.csproj                          # Test project file with NUnit dependencies
├── Fixtures/
│   └── TestFixtureBase.cs               # Base class for all tests with in-memory DB setup
└── Services/
    └── ContactServiceTests.cs            # Unit tests for ContactService
```

## Key Features

### 1. **In-Memory Database**
- Uses `Microsoft.EntityFrameworkCore.InMemory` for isolated test execution
- Each test gets a unique in-memory database instance
- No external dependencies or side effects between tests

### 2. **Test Fixture Base Class**
The `TestFixtureBase` class provides:
- `GetInMemoryContext()` - Creates isolated in-memory database contexts
- `GetMockLogger<T>()` - Provides a mock logger implementation

### 3. **ContactServiceTests**
Contains 14 comprehensive tests organized into sections:

#### **CreateContactAsync Tests** (5 tests)
- ✅ Valid data creation returns true
- ✅ Contacts are persisted to database
- ✅ Unique IDs are generated
- ✅ Multiple contacts can be created
- ✅ Edge cases (empty first name) are handled

#### **GetAllContactsAsync Tests** (4 tests)
- ✅ Empty database returns empty list
- ✅ Multiple contacts are retrieved
- ✅ Returns ContactDto objects
- ✅ FullName mapping is correct

#### **GetContactByIdAsync Tests** (5 tests)
- ✅ Valid ID returns contact
- ✅ Invalid ID returns null
- ✅ Returns ContactDto objects
- ✅ FullName mapping is correct
- ✅ Empty Guid returns null

## Running Tests

### Via Command Line
```powershell
cd C:\Users\vnesterchuk\source\repos\SOArchitecture\
dotnet test Tests/Tests.csproj
```

### Via Visual Studio
1. Open Test Explorer (Test > Test Explorer)
2. Build the solution
3. Click "Run All Tests"

### Run Specific Test Class
```powershell
dotnet test Tests/Tests.csproj --filter ClassName=Tests.Services.ContactServiceTests
```

### Run Specific Test Method
```powershell
dotnet test Tests/Tests.csproj --filter Name~CreateContactAsync_WithValidData_ShouldReturnTrue
```

## Test Results

```
Test summary: total: 14, failed: 0, succeeded: 14, skipped: 0, duration: 5.5s
```

## Best Practices Used

### 1. **AAA Pattern (Arrange-Act-Assert)**
```csharp
[Test]
public async Task TestMethod()
{
    // Arrange - Set up test data
    var input = "test";

    // Act - Execute the method
    var result = await service.MethodAsync(input);

    // Assert - Verify the result
    Assert.That(result, Is.Not.Null);
}
```

### 2. **Descriptive Test Names**
Tests follow the pattern: `MethodName_Scenario_ExpectedResult`
- Example: `CreateContactAsync_WithValidData_ShouldReturnTrue`

### 3. **Test Isolation**
- Each test gets its own database instance (unique Guid)
- `SetUp()` initializes fresh service and context
- `TearDown()` disposes resources properly

### 4. **Comprehensive Coverage**
- Happy path scenarios
- Edge cases
- Error conditions
- Data mapping verification

## Dependencies

| Package | Version | Purpose |
|---------|---------|---------|
| NUnit | 4.1.0 | Testing framework |
| NUnit3TestAdapter | 4.5.0 | Visual Studio integration |
| Microsoft.NET.Test.Sdk | 17.10.0 | Test infrastructure |
| Microsoft.EntityFrameworkCore.InMemory | 10.0.7 | In-memory database |
| Microsoft.Extensions.Logging | 10.0.7 | Logging support |

## Adding New Tests

1. Create a new test class in `Tests/Services/`
2. Inherit from `TestFixtureBase`
3. Use `GetInMemoryContext()` and `GetMockLogger<T>()`
4. Follow the AAA pattern and naming conventions

Example:
```csharp
[TestFixture]
public class NewServiceTests : TestFixtureBase
{
    private NewService _service = null!;
    private MyCRMContext _context = null!;

    [SetUp]
    public void Setup()
    {
        _context = GetInMemoryContext();
        _service = new NewService(_context, GetMockLogger<NewService>());
    }

    [Test]
    public async Task MethodName_Scenario_ExpectedResult()
    {
        // Arrange

        // Act

        // Assert
    }
}
```

## Continuous Integration

These tests can be integrated into CI/CD pipelines:

```yaml
# Example GitHub Actions
- name: Run Tests
  run: dotnet test Tests/Tests.csproj --logger "console;verbosity=detailed"
```

## Troubleshooting

### Tests Not Found
- Ensure test class inherits from `TestFixtureBase`
- Check test methods have `[Test]` attribute
- Verify project builds successfully

### Database Errors
- In-memory database doesn't support migrations
- The `MyCRMContext` checks provider name and uses `EnsureCreated()` for in-memory

### Assertion Failures
- Use detailed assertion messages for debugging
- Check test data in `[SetUp]` method
- Verify service dependencies are properly mocked/injected
