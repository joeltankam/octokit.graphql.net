namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of RerequestCheckSuite
    /// </summary>
    public class RerequestCheckSuiteInput
    {
        public ID RepositoryId { get; set; }

        public ID CheckSuiteId { get; set; }

        public string ClientMutationId { get; set; }
    }
}