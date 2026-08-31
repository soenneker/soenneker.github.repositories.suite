[![](https://img.shields.io/nuget/v/soenneker.github.repositories.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.repositories.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.repositories.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.github.repositories.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.github.repositories.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.repositories.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.repositories.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.github.repositories.suite/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.GitHub.Repositories.Suite

Install and register the commonly used Soenneker GitHub repository services through one package.

## Installation

```bash
dotnet add package Soenneker.GitHub.Repositories.Suite
```

## Configuration

```json
{
  "GH": {
    "Token": "github-token"
  }
}
```

The token's required permissions depend on which registered services you call.

## Registration

Register every included service as a singleton:

```csharp
services.AddGitHubRepositoriesSuiteAsSingleton();
```

Or register the repository-facing services as scoped:

```csharp
services.AddGitHubRepositoriesSuiteAsScoped();
```

The scoped registration keeps the underlying GitHub client providers shared where their individual packages require that lifetime.

## Included services

The suite registers services for:

- releases and release assets
- repository README files
- pull requests and workflow-run checks
- Actions repository secrets
- issues
- repository rulesets
- discussions
- GitHub Pages
- repository watch subscriptions
- Dependabot, code-scanning, and secret-scanning alerts

Each service remains injectable through its own interface, such as `IGitHubRepositoriesPullRequestsUtil` or `IGitHubRepositoriesSecretsUtil`.

This package does not automatically include every `Soenneker.GitHub.*` package. Install separate packages when you need capabilities outside the list above, such as artifacts, branch policies, packages, or the GitHub-backed file store.
