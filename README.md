The purpose of the project
is to design a backend for a service similar to the websites Hitta.se or Eniro.se.
The project is split into 3 parts where the program code is sequentially upgraded with features according to
the specifications detailed in each part. A GUI is not listed as part of the requirements and is currently not fully implemented.
The language used for the project is C#, with the programming being done using either Visual Studio 2017 or Visual Studio Code.

Design Patterns Used 
1. Factory Design Pattern for getting CSV Data
2. Strategy Design Patter for Data Validation
3. Singleton Design Pattern for Parsing CSV 
4. Builder Design Pattern is used to build them all together
5. Iterator Design Pattern for Printing Added Person


***Project Dependencies***
*****
-.NET framework version 4.6.1
***Project Installation***
*****
1.Import included files into a desired folder.
2.Open files as a project using a C# IDE(E.g. Visual studio)
3.Run project.

***Test suite instructions***
*****
The test suite is found in the CSDLabTests projects and the FinderTest.cs file.
It holds tests for the Finder, PersonList and OrganizationList classes.

The test suite can be run through visual studio(Tested in 2013 professional and 2017 versions).

-Usage:
1. Import the tests project along with the regular project in visual studio.
2. Open up the test window through the top menu  TEST -> WINDOWS -> TEST EXPLORER.
3. Run the tests through the newly opened explorer by selecting "Run all" for all tests or simply "Run..." for individual tests.

-Test coverage:
Test coverage can be seen through TEST -> ANALYZE CODE COVERAGE -> ALL TESTS option.

Note: Test coverage does not include the program.cs class at this moment.


***Usage instructions***
*****
After successful installation interactions are managed via the Finder class.

***Notes***
*****
Exception handling is minimal at the time of this writing.
