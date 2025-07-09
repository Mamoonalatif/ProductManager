# Contributing to Product Manager Application

Thank you for your interest in contributing to the Product Manager Application! This document provides guidelines and information for contributors.

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server or SQL Server Express
- Git
- Visual Studio 2022 or Visual Studio Code

### Setting up the Development Environment

1. Fork the repository on GitHub
2. Clone your fork locally:
   ```bash
   git clone https://github.com/YOUR_USERNAME/ProductManager.git
   cd ProductManager
   ```

3. Set up the upstream remote:
   ```bash
   git remote add upstream https://github.com/mamoonaalatif/ProductManager.git
   ```

4. Configure the database connection in `ProductApi/appsettings.json`
5. Run database migrations:
   ```bash
   cd ProductApi
   dotnet ef database update
   ```

## 🔄 Development Workflow

### 1. Create a Feature Branch
```bash
git checkout -b feature/your-feature-name
```

### 2. Make Your Changes
- Write clean, well-documented code
- Follow the existing code style and conventions
- Add unit tests for new functionality
- Update documentation as needed

### 3. Test Your Changes
- Run the API: `cd ProductApi && dotnet run`
- Run the client: `cd ProductClient && dotnet run`
- Test all functionality works as expected
- Ensure no existing tests are broken

### 4. Commit Your Changes
```bash
git add .
git commit -m "Add: brief description of your changes"
```

Follow conventional commit format:
- `feat:` for new features
- `fix:` for bug fixes
- `docs:` for documentation changes
- `refactor:` for code refactoring
- `test:` for adding tests
- `chore:` for maintenance tasks

### 5. Push and Create Pull Request
```bash
git push origin feature/your-feature-name
```

Then create a pull request on GitHub.

## 📝 Code Style Guidelines

### C# Conventions
- Use PascalCase for public members
- Use camelCase for private fields and local variables
- Use meaningful variable and method names
- Add XML documentation for public APIs
- Follow Microsoft's C# coding conventions

### Project Structure
- Keep controllers lightweight - business logic should be in services
- Use dependency injection for services
- Separate concerns between API and Client projects
- Follow RESTful principles for API endpoints

## 🧪 Testing

### Running Tests
```bash
dotnet test
```

### Writing Tests
- Add unit tests for new services and controllers
- Use meaningful test names that describe the scenario
- Follow AAA pattern (Arrange, Act, Assert)
- Mock external dependencies

## 📚 Documentation

### API Documentation
- All public APIs should have XML documentation
- Update Swagger documentation when adding new endpoints
- Include example requests/responses in documentation

### Code Comments
- Add comments for complex business logic
- Avoid obvious comments
- Keep comments up-to-date with code changes

## 🐛 Bug Reports

When reporting bugs, please include:
- Steps to reproduce
- Expected behavior
- Actual behavior
- Environment details (OS, .NET version, browser)
- Screenshots if applicable

## 💡 Feature Requests

For feature requests:
- Describe the problem you're trying to solve
- Explain why this feature would be beneficial
- Provide examples of how it would be used
- Consider the impact on existing functionality

## 🔍 Code Review Process

All contributions go through code review:
- Ensure code follows project conventions
- Check for security vulnerabilities
- Verify tests are included and passing
- Confirm documentation is updated
- Review for performance implications

## 📦 Dependencies

### Adding New Dependencies
- Ensure the dependency is necessary
- Use stable, well-maintained packages
- Update both API and Client projects if needed
- Document any new configuration requirements

### Updating Dependencies
- Check for breaking changes
- Update documentation if needed
- Test thoroughly after updates

## 🚦 Continuous Integration

Our CI process:
- Builds both projects
- Runs all tests
- Checks code formatting
- Performs security scans

Make sure your changes pass all CI checks.

## 📄 License

By contributing, you agree that your contributions will be licensed under the MIT License.

## 💬 Getting Help

If you need help:
- Check existing issues and documentation
- Ask questions in GitHub discussions
- Contact the maintainers

## 🙏 Recognition

Contributors will be recognized in:
- README.md contributors section
- Release notes for significant contributions
- GitHub contributors page

Thank you for helping make Product Manager Application better!
