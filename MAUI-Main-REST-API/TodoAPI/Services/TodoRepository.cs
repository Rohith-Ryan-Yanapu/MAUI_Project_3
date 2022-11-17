using System.Diagnostics;
using TodoAPI.Interfaces;
using TodoAPI.Models;

namespace TodoAPI.Services
{
    public class TodoRepository : ITodoRepository
    {
        private List<TodoItem> _todoList;
        public GenerateQuestion question;
        int numberOfQuestions;

        public TodoRepository()
        {
            numberOfQuestions = 10;
            InitializeData();
        }

        public IEnumerable<TodoItem> All
        {
            get { return _todoList; }
        }

        public bool DoesItemExist(string id)
        {
            return _todoList.Any(item => item.ID == id);
        }

        public TodoItem Find(string id)
        {
            return _todoList.FirstOrDefault(item => item.ID == id);
        }

        public void Insert(TodoItem item)
        {
            _todoList.Add(item);
        }

        public void Update(TodoItem item)
        {
            var todoItem = this.Find(item.ID);
            var index = _todoList.IndexOf(todoItem);
            _todoList.RemoveAt(index);
            _todoList.Insert(index, item);
        }

        public void Delete(string id)
        {
            _todoList.Remove(this.Find(id));
        }

        private void InitializeData()
        {
            _todoList = new List<TodoItem>();
            string[] V = { "Hi", "Hello" };
            _todoList = new List<TodoItem>();
            Debug.WriteLine("Hey");
            for (int i = 0; i < this.numberOfQuestions; i++)
            {
                question = new GenerateQuestion();
                Debug.WriteLine("Hey");
                Debug.WriteLine(question.expression);
                _todoList.Add(new TodoItem
                {
                    ID = (i + 1).ToString(),
                    Expression = question.expression,
                    Options = { question.opt1.ToString(), question.opt2.ToString(), question.opt3.ToString() },
                    AnswerIndex = question.opt
                });
            }
            /*var todoItem1 = new TodoItem
            {
                ID = "1",
                Expression = "2+3",
                Options = { "7", "5", "9" },
                AnswerIndex = 2
            };

            var todoItem2 = new TodoItem
            {
                ID = "2",
                Expression = "5-3",
                Options = { "2", "10", "7" },
                AnswerIndex = 1
            };

            var todoItem3 = new TodoItem
            {
                ID = "3",
                Expression = "3*3",
                Options = { "3", "6", "9" },
                AnswerIndex = 3,
            };

            _todoList.Add(todoItem1);
            _todoList.Add(todoItem2);
            _todoList.Add(todoItem3);*/
        }
    }
}
