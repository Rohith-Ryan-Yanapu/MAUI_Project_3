using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class QuizItem
    {
        public string ID { get; set; }

        public string Expression { get; set; }

        public List<String> Options { get; set; } = new List<string>();

        public int AnswerIndex { get; set; }
    }
}
