using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;
namespace GithubIC
{
    public class GitHubIssue
    {
        [LoadColumn(0)]
        public string? ID { get; set;  }
        [LoadColumn(1)]
        public string? Area { get; set; }
        [LoadColumn(2)]
        public string? Title { get; set; }
        [LoadColumn (3)]
        public required string Description { get; set; }
    }

    public class IssuePrediction
    {
        [ColumnName("predictedLabel")]
        public string? Area;
    }
}
