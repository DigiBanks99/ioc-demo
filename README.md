# .NET Core IoC container demos

This repo is intended to show some features of the IoC in .NET Core 3.0.

## Unresolved dependencies

To show how unregistered dependencies are handled in .NET Core 3.0, you can run the solution with the `IISExpress` or `ioc_demo_break` launch settings.
The point is to show that the class that references the dependency will never get created if the dependency does not exist.
