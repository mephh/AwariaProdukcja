using System;

namespace SQLiteLib
{
    public class ProblemModel
    {
        public string Tester { get; set; }

        public DateTime Start { get; set; }

        public DateTime Stop { get; set; }

        public int DownTime { get; set; }

        public string RootCause { get; set; }

        public string TesterIssue
        {
            get
            {
                return $"{ Tester } { RootCause }";
            }
        }

    }
}
