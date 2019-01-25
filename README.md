# FSFakeProjectScaffold
Project scaffold for F# with FAKE

Use with
[Visual Studio Code](https://code.visualstudio.com/)
extensions
[.NET Core Test Explorer](https://github.com/formulahendry/vscode-dotnet-test-explorer)
for unit testing explorer and
[Coverage Gutters](https://github.com/ryanluker/vscode-coverage-gutters)
for displaying unit testing coverage.

The
[FAKE](https://fake.build/)
build tool is used to manage project scenarios like running tests, cleaning artefacts, running application and generating code coverage rapport.

- This project requires that you have FAKE installed. It can be installed with dotnet cli globally with command
    ```
    dotnet tool install fake-cli -g
    ```
    or installed locally at a location of your choosing (you may refer to the location in your PATH environment variable)
    ```
    dotnet tool install fake-cli --tool-path c:/path/to/wherever
    ```

## Usage
- Run application with command:
    ```
    fake run
    ```
- Run tests with command:
    ```
    fake run build.fsx -t Test
    ```
    ***Test** is not strictly needed since tests can be run from the test explorer in vs code.*

- Run cleaning process with command:
    ```
    fake run build.fsx -t Clean
    ```
    ***Clean** should not be necessary but could be useful to have.*

- Run cleaning process and a complete project rebuild with command:
    ```
    fake run build.fsx -t CleanBuild
    ```
- Generate unit test code coverage with command:
    ```
    fake run build.fsx -t Coverage
    ```

---
## Run unit tests with .NET Core Test Explorer
![testexplorer](https://user-images.githubusercontent.com/38290734/51555245-81416980-1e77-11e9-88b5-e2fdc609fc54.gif)

---
## Generate unit test code coverage
![codecoverage](https://user-images.githubusercontent.com/38290734/51555726-91a61400-1e78-11e9-8ad4-48dd8116e084.gif)

---
## Property based testing
![propertytesting](https://user-images.githubusercontent.com/38290734/51748035-753ded80-20ab-11e9-995b-cb609f5b8b85.gif)
*The test fails because `x * x` isn't greater than `x` when `x = 0` or when `x = 1`*