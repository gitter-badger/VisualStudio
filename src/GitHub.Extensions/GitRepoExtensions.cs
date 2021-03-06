﻿using Microsoft.VisualStudio.TeamFoundation.Git.Extensibility;
using NullGuard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Extensions
{
    public static class GitRepoExtensions
    {
        public static bool Compare([AllowNull] this IGitRepositoryInfo lhs, [AllowNull]IGitRepositoryInfo rhs)
        {
            if (lhs == null && rhs == null)
                return true;
            if (lhs != null && rhs != null)
                return lhs.RepositoryPath == rhs.RepositoryPath;
            return false;
        }
    }
}
