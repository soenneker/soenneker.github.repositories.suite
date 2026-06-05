using Microsoft.Extensions.DependencyInjection;
using Soenneker.GitHub.Repositories.Discussions.Registrars;
using Soenneker.GitHub.Repositories.Issues.Registrars;
using Soenneker.GitHub.Repositories.Pages.Registrars;
using Soenneker.GitHub.Repositories.PullRequests.Registrars;
using Soenneker.GitHub.Repositories.Readmes.Registrars;
using Soenneker.GitHub.Repositories.Releases.Registrars;
using Soenneker.GitHub.Repositories.Rulesets.Registrars;
using Soenneker.GitHub.Repositories.Secrets.Registrars;
using Soenneker.GitHub.Repositories.Security.Registrars;
using Soenneker.GitHub.Repositories.Subscriptions.Registrars;

namespace Soenneker.GitHub.Repositories.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for GitHub's Repository related operations
/// </summary>
public static class GitHubRepositorySuiteRegistrar
{
    /// <summary>
    /// Adds git hub repositories suite as singleton.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddGitHubRepositoriesSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddGitHubRepositoriesReleasesUtilAsSingleton()
                .AddGitHubRepositoriesReadmesUtilAsSingleton()
                .AddGitHubRepositoriesPullRequestsUtilAsSingleton()
                .AddGitHubRepositoriesSecretsUtilAsSingleton()
                .AddGitHubRepositoriesIssuesUtilAsSingleton()
                .AddGitHubRepositoriesRulesetsUtilAsSingleton()
                .AddGitHubRepositoriesDiscussionsUtilAsSingleton()
                .AddGitHubRepositoriesPagesUtilAsSingleton()
                .AddGitHubRepositoriesSubscriptionsUtilAsSingleton()
                .AddGitHubRepositoriesSecurityUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds git hub repositories suite as scoped.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddGitHubRepositoriesSuiteAsScoped(this IServiceCollection services)
    {
        services.AddGitHubRepositoriesReleasesUtilAsScoped()
                .AddGitHubRepositoriesReadmesUtilAsScoped()
                .AddGitHubRepositoriesPullRequestsUtilAsScoped()
                .AddGitHubRepositoriesSecretsUtilAsScoped()
                .AddGitHubRepositoriesIssuesUtilAsScoped()
                .AddGitHubRepositoriesRulesetsUtilAsScoped()
                .AddGitHubRepositoriesDiscussionsUtilAsScoped()
                .AddGitHubRepositoriesPagesUtilAsScoped()
                .AddGitHubRepositoriesSubscriptionsUtilAsScoped()
                .AddGitHubRepositoriesSecurityUtilAsScoped();

        return services;
    }
}