using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        public string ID { get; set; }
        public string Expression { get; set; }
        public List<String> Options { get; set; } = new List<string>();
        public int AnswerIndex { get; set; }
    }
}
