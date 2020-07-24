# Runly .NET Core Job App Template

Use this template to bootstrap the creation of a Runly job. :rocket:

This template includes tests and versioning guidance. The tests are built with [xUnit.net](https://xunit.net/) and versioning is done seamlessly with [MinVer](https://github.com/adamralph/minver).

If you don't want to create an entirely new repository, you can use the [dotnet project template](https://www.runly.io/docs/net/start/#dotnet-template) instead to add a Runly Job App to an existing solution.

## Create a Job App from this Template

Click *Use this Template* and provide the new repo details for your job.

## Running Locally

This project builds as a .NET Core console application. For a full list of available commands, run:

```
cd src
dotnet run -- help
```

> Note! The "--" argument shown in the samples here is only a construct of using the "dotnet run" command to separate arguments that should apply to the dotnet tool on the left from arguments that should be passed into the example application. If you run the compiled application itself, you will not need the "--" separator.

Read more about [how to run jobs in your app](https://www.runly.io/docs/net/start/job/#list-the-job).

### Running Tests

Open terminal in the project root:

```
dotnet test
```
