using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Examination_mangment_System
{
    internal class QuestionList
    {
        public List<TrueOrFalseQuestion> TrueOrFalseList { get; set; } = new List<TrueOrFalseQuestion>();
        public List<ChooseOneQuestion> ChooseOneList { get; set; } = new List<ChooseOneQuestion>();



        public QuestionList()
        {

        }

        public void ListQuestions()
        {
            if (TrueOrFalseList is not null)
            {
                Console.WriteLine();
                Console.WriteLine("True Or False Questions");
                Console.WriteLine();
                foreach (var x in TrueOrFalseList)
                {
                    Console.WriteLine(x);
                }
            }
            if (ChooseOneList is not null)
            {
                Console.WriteLine();
                Console.WriteLine("choose one Questions");
                Console.WriteLine();

                foreach (var x in ChooseOneList)
                {
                    Console.WriteLine(x);
                }
            }
        }
        public void DeleteQuestion<T>(List<T> list, int Qnumber)
        {
            Qnumber--;

            if (list[Qnumber] is not null)
            {
                list.RemoveAt(Qnumber);

                if (list.Equals(TrueOrFalseList))
                {
                    for (; Qnumber < list.Count; Qnumber++)
                    {
                        TrueOrFalseList[Qnumber].QNumber = TrueOrFalseList[Qnumber].QNumber - 1;
                    }
                }
                else
                {
                    for (; Qnumber < list.Count; Qnumber++)
                    {
                        ChooseOneList[Qnumber].QNumber = ChooseOneList[Qnumber].QNumber - 1;
                    }
                }
            }
        }


        public void GetQuestionsDetails<T>(List<T> list)
        {
            int Counter = list.Count + 1;
            int numberOfQ = 0;
            int innerCounter = 1;
            int QuestionMark;
            QLevel QuestionLevel;
            string QuestionBody;
            object obj;
            do
            {
                Console.WriteLine("How many Questions do you want ?");
            } while (!int.TryParse(Console.ReadLine(), out numberOfQ));
            numberOfQ += list.Count;
            while (Counter <= numberOfQ)
            {
                Console.WriteLine();
                Console.WriteLine($"Add The  Question Number {innerCounter} ");
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Enter the Question Level  [1.Easy    2.Medium     3.Hard]");
                } while (!Enum.TryParse(typeof(QLevel), Console.ReadLine(), true, out obj));
                QuestionLevel = (QLevel)obj;

                do
                {
                    Console.WriteLine("Enter the Question Mark");
                } while (!int.TryParse(Console.ReadLine(), out QuestionMark));

                Console.WriteLine("enter the Question");
                QuestionBody = Console.ReadLine();
                if (list.Equals(TrueOrFalseList))
                {
                    TrueOrFalseQuestion trueOrFalseQuestion = new TrueOrFalseQuestion();
                    TrueOrFalseList.Add(trueOrFalseQuestion.Add(QuestionLevel, QuestionBody, QuestionMark, Counter));
                }
                else
                {
                    ChooseOneQuestion chooseOneQuestion = new ChooseOneQuestion();
                    ChooseOneList.Add(chooseOneQuestion.Add(QuestionLevel, QuestionBody, QuestionMark, Counter));
                }
                Counter++;
                innerCounter++;
            }
        }


        public void AddQuestions()
        {
            Qtype QuestionType = 0;
            object obj;

            do
            {
                Console.WriteLine("What is the type of question do you want ?");
                Console.WriteLine("1.True or False");
                Console.WriteLine("2.Choose one");
                Console.WriteLine("Choose between (1,2)");
            } while (!Enum.TryParse(typeof(Qtype), Console.ReadLine(), true, out obj));
            QuestionType = (Qtype)obj;


            if (QuestionType == Qtype.TrueOrFalse)
            {

                GetQuestionsDetails(TrueOrFalseList);
            }

            if (QuestionType == Qtype.ChooseOne)
            {
                GetQuestionsDetails(ChooseOneList);
            }

        }
        public void AddQuestionsForTheFirstTime()
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add True OR False Questions ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            GetQuestionsDetails(TrueOrFalseList);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add Choose One Questions ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            GetQuestionsDetails(ChooseOneList);
            Console.WriteLine();
        }
    }
}