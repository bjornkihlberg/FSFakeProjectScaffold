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
- Run cleaning process with command:
    ```
    fake run build.fsx -t Clean
    ```
- Run cleaning process and a complete project rebuild with command:
    ```
    fake run build.fsx -t CleanBuild
    ```
- Generate unit test code coverage with command:
    ```
    fake run build.fsx -t Coverage
    ```
