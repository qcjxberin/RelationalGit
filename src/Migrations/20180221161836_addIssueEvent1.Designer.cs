﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RelationalGit;
using System;

namespace RelationalGit.Migrations
{
    [DbContext(typeof(GitRepositoryDbContext))]
    [Migration("20180221161836_addIssueEvent1")]
    partial class addIssueEvent1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RelationalGit.Commit", b =>
                {
                    b.Property<string>("Sha")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AuthorDateTime");

                    b.Property<string>("AuthorEmail");

                    b.Property<DateTime>("CommitterDateTime");

                    b.Property<string>("CommitterEmail");

                    b.Property<bool>("IsMergeCommit");

                    b.Property<string>("Message");

                    b.Property<string>("MessageShort");

                    b.Property<string>("TreeSha");

                    b.HasKey("Sha");

                    b.HasIndex("AuthorEmail");

                    b.HasIndex("CommitterEmail");

                    b.HasIndex("Sha");

                    b.ToTable("Commits");
                });

            modelBuilder.Entity("RelationalGit.CommitBlobBlame", b =>
                {
                    b.Property<string>("DeveloperIdentity");

                    b.Property<string>("CommitSha");

                    b.Property<string>("CanonicalPath");

                    b.Property<int>("AuditedLines");

                    b.Property<double>("AuditedPercentage");

                    b.HasKey("DeveloperIdentity", "CommitSha", "CanonicalPath");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("CommitSha");

                    b.HasIndex("DeveloperIdentity");

                    b.ToTable("CommitBlobBlames");
                });

            modelBuilder.Entity("RelationalGit.CommitPeriod", b =>
                {
                    b.Property<string>("CommitSha")
                        .HasMaxLength(40);

                    b.Property<Guid>("PeriodId");

                    b.HasKey("CommitSha", "PeriodId");

                    b.HasIndex("CommitSha");

                    b.HasIndex("PeriodId");

                    b.ToTable("CommitPeriods");
                });

            modelBuilder.Entity("RelationalGit.CommitRelationship", b =>
                {
                    b.Property<string>("Parent");

                    b.Property<string>("Child");

                    b.HasKey("Parent", "Child");

                    b.ToTable("CommitRelationships");
                });

            modelBuilder.Entity("RelationalGit.CommittedBlob", b =>
                {
                    b.Property<string>("CommitSha");

                    b.Property<string>("CanonicalPath");

                    b.Property<int>("NumberOfLines");

                    b.Property<string>("Path");

                    b.HasKey("CommitSha", "CanonicalPath");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("CommitSha");

                    b.ToTable("CommittedBlob");
                });

            modelBuilder.Entity("RelationalGit.CommittedChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CanonicalPath");

                    b.Property<string>("CommitSha");

                    b.Property<string>("Oid");

                    b.Property<string>("OldOid");

                    b.Property<string>("OldPath");

                    b.Property<string>("Path");

                    b.Property<short>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("CommitSha");

                    b.HasIndex("Oid");

                    b.HasIndex("OldOid");

                    b.HasIndex("Path");

                    b.HasIndex("Status");

                    b.ToTable("CommittedChanges");
                });

            modelBuilder.Entity("RelationalGit.Issue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime?>("ClosedAtDateTime");

                    b.Property<DateTime?>("CreatedAtDateTime");

                    b.Property<string>("HtmlUrl");

                    b.Property<string>("Label");

                    b.Property<int>("Number");

                    b.Property<string>("PullRequestNumber");

                    b.Property<string>("PullRequestUrl");

                    b.Property<string>("State");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.HasIndex("Number");

                    b.ToTable("Issue");
                });

            modelBuilder.Entity("RelationalGit.IssueEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActorLogin");

                    b.Property<string>("CommitId");

                    b.Property<DateTime>("CreatedAtDateTime");

                    b.Property<string>("Event");

                    b.Property<int>("IssueNumber");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CommitId");

                    b.HasIndex("Event");

                    b.HasIndex("IssueNumber");

                    b.ToTable("IssueEvents");
                });

            modelBuilder.Entity("RelationalGit.Period", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstCommit");

                    b.Property<DateTime>("FromDateTime");

                    b.Property<string>("LastCommitSha");

                    b.Property<DateTime>("ToDateTime");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("RelationalGit.PullRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BaseSha");

                    b.Property<DateTime?>("ClosedAtDateTime");

                    b.Property<DateTime?>("CreatedAtDateTime");

                    b.Property<string>("HtmlUrl");

                    b.Property<long>("IssueId");

                    b.Property<string>("IssueUrl");

                    b.Property<string>("MergeCommitSha");

                    b.Property<bool>("Merged");

                    b.Property<DateTime?>("MergedAtDateTime");

                    b.Property<int>("Number");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.HasIndex("BaseSha");

                    b.HasIndex("MergeCommitSha");

                    b.HasIndex("Number");

                    b.ToTable("PullRequests");
                });

            modelBuilder.Entity("RelationalGit.PullRequestFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Additions");

                    b.Property<int?>("Changes");

                    b.Property<int?>("Deletions");

                    b.Property<string>("FileName");

                    b.Property<int>("PullRequestNumber");

                    b.Property<string>("Sha");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("FileName");

                    b.HasIndex("PullRequestNumber");

                    b.ToTable("PullRequestFiles");
                });

            modelBuilder.Entity("RelationalGit.PullRequestReviewer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommitId");

                    b.Property<long>("PullRequestNumber");

                    b.Property<string>("State");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.ToTable("PullRequestReviewers");
                });

            modelBuilder.Entity("RelationalGit.PullRequestReviewerComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("CommitId");

                    b.Property<DateTime>("CreatedAtDateTime");

                    b.Property<int?>("InReplyTo");

                    b.Property<string>("Path");

                    b.Property<int?>("PullRequestReviewId");

                    b.Property<string>("PullRequestUrl");

                    b.Property<string>("Url");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.HasIndex("CommitId");

                    b.HasIndex("Path");

                    b.HasIndex("PullRequestReviewId");

                    b.HasIndex("UserLogin");

                    b.ToTable("PullRequestReviewerComments");
                });

            modelBuilder.Entity("RelationalGit.User", b =>
                {
                    b.Property<string>("UserLogin")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("UserLogin");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
