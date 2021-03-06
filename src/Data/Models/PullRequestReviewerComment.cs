﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RelationalGit
{
    public class PullRequestReviewerComment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string CommitId { get; internal set; }
        public int? InReplyTo { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAtDateTime { get; set; }
        public int? PullRequestReviewId { get; set; }
        public string Body { get; set; }
        public string PullRequestUrl { get; set; }
        public string Url { get; set; }
        public int PullRequestNumber { get; set; }
        //public string AuthorAssociation { get; set; }
    }
}
