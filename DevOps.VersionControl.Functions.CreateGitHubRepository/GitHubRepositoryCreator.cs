using Common.Structures.HttpBasicAuthentication;
using System.Threading.Tasks;
using static Common.Functions.SendJsonApiRequest.JsonApiRequestSender;
using static DevOps.VersionControl.Functions.CreateGitHubRepository.CreateRepositoryRequestHelper;
using static Metaproject.Users.CDorst.GitHubAccessToken.GitHubCredentials;

namespace DevOps.VersionControl.Functions.CreateGitHubRepository
{
    public static class GitHubRepositoryCreator
    {
        public static async Task Create(string name, string description, BasicAuthenticationCredentials credentials = null)
            => await ApiRequest(
                CreateRepository(name, description),
                credentials ?? CDorst);
    }
}
