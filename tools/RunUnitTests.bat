@rem VS 2010 Express spits out Release builds when you choose to Build the solution, but
@rem makes Debug builds when you run (F5) it. So we'll try to run tests on both, instead of only Debug.

@ECHO OFF
SET runner=..\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe

SET debug=..\UnitConverter.Tests\bin\Debug\UnitConverter.Tests.dll
SET release=..\UnitConverter.Tests\bin\Release\UnitConverter.Tests.dll

@IF EXIST %debug% echo Running tests in %debug%
@IF EXIST %debug% %runner% %debug%

@IF EXIST %release% echo Running tests in %release%
@IF EXIST %release% %runner% %release%

SET debugx86=..\UnitConverter.Tests\bin\x86\Debug\UnitConverter.Tests.dll
SET releasex86=..\UnitConverter.Tests\bin\x86\Release\UnitConverter.Tests.dll

@IF EXIST %debugx86% echo Running tests in %debugx86%
@IF EXIST %debugx86% %runner% %debugx86%

@IF EXIST %releasex86% echo Running tests in %releasex86%
@IF EXIST %releasex86% %runner% %releasex86%

@pause