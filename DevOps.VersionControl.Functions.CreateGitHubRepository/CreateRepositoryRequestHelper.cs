using Common.Structures.HttpJsonRequest;

namespace DevOps.VersionControl.Functions.CreateGitHubRepository
{
    internal static class CreateRepositoryRequestHelper
    {
        private const string BaseAddress = "https://api.github.com";
        private const string Path = "/user/repos";

        public static ApiRequest CreateRepository(string name, string description)
            => new PostRequest(BaseAddress, Path, GetJson(name, description));

        private static string GetJson(string name, string description)
            => $"{{ \"name\": \"{name}\", \"description\": \"{description}\" }}";
    }
}
