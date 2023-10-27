using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.model
{
    [Serializable]
    public class Feedback
    {
        public string FeedbackText { get; set; }
        public DateTime Date { get; set; }
        public String FeedbackGiver { get; set; }
        public Feedback(string feedbackText, DateTime date, String feedbackGiver)
        {
            FeedbackText = feedbackText;
            Date = date;
            FeedbackGiver = feedbackGiver;
        }
        public Feedback() { }
    }
}
