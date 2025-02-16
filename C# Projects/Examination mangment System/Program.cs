using System.Diagnostics.CodeAnalysis;

namespace Examination_mangment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            string InputMode;
            string InputOperation;
            string InputType;
            string input;
            int Qnumber;
            QuestionList QuestionList = new QuestionList();
            if (flag == false)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("login for first time , Welcome in Questions Bank");
                Console.ForegroundColor = ConsoleColor.White;
                QuestionList.AddQuestionsForTheFirstTime();
                flag = true;


            }
            while (flag)
            {
                try
                {

                    Console.WriteLine();

                    Console.WriteLine("Select Mode [1.Teacher    2.Student]");
                    Console.WriteLine();
                    InputMode = Console.ReadLine();
                    while (InputMode == "1")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Select Operations [1.Add Questions    2.List All Questions    3.Delete Question  4.Exit From Teacher Mode]");
                        InputOperation = Console.ReadLine();
                        if (InputOperation == "1")
                        {
                            QuestionList.AddQuestions();
                        }
                        else if (InputOperation == "2")
                        {
                            QuestionList.ListQuestions();
                        }
                        else if (InputOperation == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Select Type Of Question [1.True Or False       2.Choose One]");
                            InputType = Console.ReadLine();

                            Console.WriteLine("Enter the Question Number");
                            int.TryParse(Console.ReadLine(), out Qnumber);

                            if (InputType == "1")
                            {
                                QuestionList.DeleteQuestion(QuestionList.TrueOrFalseList, Qnumber);
                            }
                            else if (InputType == "2")
                            {
                                QuestionList.DeleteQuestion(QuestionList.ChooseOneList, Qnumber);
                            }
                            else
                            {
                                throw new Exception("Invalid number please select from this  [1.True Or False       2.Choose One] ");
                            }
                        }
                        else if (InputOperation == "4")
                        {
                            break;
                        }
                        else
                        {
                            throw new Exception("Invalied number please select from this [1.Add Questions    2.List All Questions    3.Delete Question  4.Exit From Teacher Mode]");

                        }
                    }
                    while (InputMode == "2")
                    {
                        Console.WriteLine("Select Exam   [1.Final   2.MidTerm   3.Exit From Student Mode]");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("***************START FINAL EXAM*******************");
                            Console.WriteLine();
                            FinalExam final = new FinalExam();

                            final.ShowExam(QuestionList, final.finalquestionsNumber);

                        }
                        else if (input == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine("***************START MIDTERM EXAM*******************");
                            Console.WriteLine();
                            MidTermExam mid = new MidTermExam();
                            mid.ShowExam(QuestionList, mid.midquestionsNumber);

                        }
                        else if (input == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            throw new Exception("Invalied number please select from this [1.Final   2.MidTerm     3.Exit From Student Mode]");


                        }
                    }






                }

                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                }
            }
        }
    }
}
