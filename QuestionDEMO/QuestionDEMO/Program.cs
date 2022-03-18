using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("Asagidakilerden hangisi betik bir dildir ?", new string[] { "c#", "Java", "C","Javascript" }, "javascript");
            var q2 = new Question("Hanigisi UNIX tabanlı bir işletim sistemidir ?", new string[] { "Linux", "Windows", "MSDOS", "MACOS" }, "Linux");
            var q3 = new Question("Hanigisi UNIX tabanlı bir işletim sistemidir ?", new string[] { "Linux", "Windows", "MSDOS", "MACOS" }, "Linux");
            var questions = new Question[] {q1,q2,q3};
            /*foreach(var q in questions)
            {
                Console.WriteLine($"Soru: {q.Text}");
                foreach(var c in q.Choices)
                {
                    Console.WriteLine(c);
                }
                string _answer = Console.ReadLine();
                Console.WriteLine("\n"+q.checkanswer(_answer)+"\n");
        
            }*/

            var _qs = new Quiz(questions);
            _qs.play();
            Console.WriteLine(_qs.Score);


            




         }
           
    }
    
    public class Question
    {

        public Question(string text,string[] choices,string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.answer = answer;
            

        }
         public bool checkanswer(string answer)
        {
            
            return this.answer.ToLower() == answer.ToLower();

        }
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string answer { get; set; }

    }

    public class Quiz
    {
        public Quiz(Question[] questions)
        {
            this._question = questions;
        }
      
        public Question[] _question { get; set; }
        public int questindex { get; set;}
        public int Score = 0;
        
        public Question getquest()
        {

            return this._question[this.questindex];
            
        }
        public void play()
        {
            var getquest = this.getquest();
            Console.WriteLine(getquest.Text);
            foreach (var c in getquest.Choices)
            {
                Console.WriteLine(c);
            }
            this.guess();

        }
        public void guess()
        {
            var question = this.getquest();
            string ans = Console.ReadLine();
            if(getquest().answer.ToLower() == ans.ToLower())
            {
                Score++;
            }
            if(_question.Length-1>questindex)
            {
                questindex++;
                this.play();
            }
            
        }
            

    }

}
