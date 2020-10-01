using System;


namespace SQLLib
{
    public class ProblemModel
    {
        public string Tester { get; set; }

        public string Start { get; set; }

        public string Stop { get; set; }

        public string InterventionStart { get; set; }

        public string RootCause { get; set; }

        public string TypeOfIssue { get; set; }

        public string technicianID { get; set; }

        public TimeSpan Downtime { get; set; }

        public string LoggedOperator { get; set; }

    }
}
