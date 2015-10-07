# Prerequisites

- ASP.NET 5 beta7 -> https://www.microsoft.com/en-us/download/details.aspx?id=48738
- Visual Studio 2015

# Install the correct .NET Execution Environment

http://blogs.msdn.com/b/sujitdmello/archive/2015/04/23/step-by-step-installation-instructions-for-getting-dnx-on-your-laptop.aspx

- De code is geschreven op CLR (dus niet Core!) beta7
- Deze moet geinstalleerd en geselecteerd zijn als default

# Builden

- dnx restore
- msbuild

# Starten

- dnx restore
- dnx -p src\TestWebapp.Tests test

# Draaien

- dnx restore
- dnx -p src\TestWebapp web
- surf naar http://localhost:5000
