using System;
using System.Diagnostics;
using System.Globalization;

namespace Scout24.Statistic
{
    [ExcludeFromCtorWithAllPropertiesConventionTest(nameof(Type))]
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Organization : Account
    {
        public Organization() { }

        public Organization(string avatarUrl, string bio, string blog, int collaborators, string company, DateTimeOffset createdAt, int diskUsage, string email, int followers, int following, bool? hireable, string htmlUrl, int totalPrivateRepos, int id, string nodeId, string location, string login, string name, int ownedPrivateRepos, Plan plan, int privateGists, int publicGists, int publicRepos, string url, string billingAddress, string reposUrl, string eventsUrl, string hooksUrl, string issuesUrl, string membersUrl, string publicMembersUrl, string description, bool isVerified, bool hasOrganizationProjects, bool hasRepositoryProjects, DateTimeOffset updatedAt)
            : base(avatarUrl, bio, blog, collaborators, company, createdAt, diskUsage, email, followers, following, hireable, htmlUrl, totalPrivateRepos, id, location, login, name, nodeId, ownedPrivateRepos, plan, privateGists, publicGists, publicRepos, AccountType.Organization, url)
        {
            BillingAddress = billingAddress;
            ReposUrl = reposUrl;
            EventsUrl = eventsUrl;
            HooksUrl = hooksUrl;
            IssuesUrl = issuesUrl;
            MembersUrl = membersUrl;
            PublicMembersUrl = publicMembersUrl;
            Description = description;
            IsVerified = isVerified;
            HasOrganizationProjects = hasOrganizationProjects;
            HasRepositoryProjects = hasRepositoryProjects;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The billing address for an organization. This is only returned when updating 
        /// an organization.
        /// </summary>
        public string BillingAddress { get; protected set; }
        public string ReposUrl { get; protected set; }
        public string EventsUrl { get; protected set; }
        public string HooksUrl { get; protected set; }
        public string IssuesUrl { get; protected set; }
        public string MembersUrl { get; protected set; }
        public string PublicMembersUrl { get; protected set; }
        public string Description { get; protected set; }
        public bool IsVerified { get; protected set; }
        public bool HasOrganizationProjects { get; protected set; }
        public bool HasRepositoryProjects { get; protected set; }
        public DateTimeOffset UpdatedAt { get; protected set; }


        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture,
                    "Organization: Id: {0} Login: {1}", Id, Login);
            }
        }
    }
}