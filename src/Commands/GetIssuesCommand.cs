﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RelationalGit.Commands
{
    public class GetIssuesCommand
    {
        private ILogger _logger;

        public GetIssuesCommand(ILogger logger)
        {
            _logger = logger;
        }

        public async Task Execute(string token, string agenName, string owner, string repo, string[] labels,string state="All")
        {
            using (var dbContext = new GitRepositoryDbContext())
            {
                dbContext.Database.ExecuteSqlCommand($"TRUNCATE TABLE Issue");
                var githubExtractor = new GithubDataFetcher(token, agenName,_logger);
                var issues = await githubExtractor.GetIssues(owner, repo, labels,state);
                dbContext.AddRange(issues);
                dbContext.SaveChanges();
            }
        }
    }
}
