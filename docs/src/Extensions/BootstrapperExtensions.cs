﻿using Statiq.App;
using Statiq.Common;

namespace Docs.Extensions
{
    public static class BootstrapperExtensions
    {
        public static Bootstrapper ConfigureSite(this Bootstrapper bootstrapper, string owner, string repo, string branch)
        {
            if (bootstrapper != null)
            {
                bootstrapper.AddSetting(Constants.Site.Owner, owner);
                bootstrapper.AddSetting(Constants.Site.Repository, repo);
                bootstrapper.AddSetting(Constants.Site.Branch, branch);
            }
            return bootstrapper;
        }

        public static Bootstrapper ConfigureDeployment(this Bootstrapper bootstrapper, string deployBranch)
        {
            bootstrapper?.AddSetting(Constants.Deployment.TargetBranch, deployBranch);
            return bootstrapper;
        }
    }
}
