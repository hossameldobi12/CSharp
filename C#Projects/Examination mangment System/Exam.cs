using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_mangment_System
{
    struct QuestionsNumber
    {
        public int MaxNumberOfAllQuestions;
        public int MaxNumberOfEachQuestion;
    }
    internal abstract class Exam
    {
        

        protected Exam()
        {
            
        }
        public void ShowExam(QuestionList questionList, QuestionsNumber questionsNumber)
        {
            {
                int MaxNumberOfQuestions = questionsNumber.MaxNumberOfAllQuestions;
                int MaxNumberOfTrueOrFalse = questionList.TrueOrFalseList.Count;
                int MaxNumberOfChooseOne = questionList.ChooseOneList.Count;
                int MaxNumberOfEachQuestion = questionsNumber.MaxNumberOfEachQuestion;
                int CurrentQuestion = 0;
                int CurrentQuestionOfOneQuestion = 0;
                int RandomIndex;
                int UserAnswerChooseOne = 0;
                int StudentScore = 0;
                int FullScore = 0;
                object obj;
                QTFAnswer UserAnswer;
                while ((CurrentQuestion < MaxNumberOfQuestions))
                {

                    while ((CurrentQuestionOfOneQuestion < MaxNumberOfTrueOrFalse) && (CurrentQuestionOfOneQuestion < MaxNumberOfEachQuestion))
                    {
                        Helper.GetUniqueValue(questionList.TrueOrFalseList.Count, out RandomIndex);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(questionList.TrueOrFalseList[RandomIndex].ToQuestion());
                        Console.ForegroundColor = ConsoleColor.White;
                        do
                        {
                            Console.WriteLine("Please enter the answer");
                        } while (!Enum.TryParse(typeof(QTFAnswer), Console.ReadLine(), true, out obj));
                        UserAnswer = (QTFAnswer)obj;
                        if (UserAnswer == questionList.TrueOrFalseList[RandomIndex].Answer)
                        {
                            StudentScore += questionList.TrueOrFalseList[RandomIndex].QMark;
                        }
                        FullScore += questionList.TrueOrFalseList[RandomIndex].QMark;
                        CurrentQuestionOfOneQuestion++;
                        CurrentQuestion++;
                    }

                    Helper.UniqueValue.Clear();
                    CurrentQuestionOfOneQuestion = 0;

                    while ((CurrentQuestionOfOneQuestion < MaxNumberOfChooseOne) && (CurrentQuestionOfOneQuestion < MaxNumberOfEachQuestion))
                    {
                        Helper.GetUniqueValue(questionList.ChooseOneList.Count, out RandomIndex);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(questionList.ChooseOneList[RandomIndex].ToQuestion());
                        Console.ForegroundColor = ConsoleColor.White;
                        do
                        {
                            Console.WriteLine("Please enter the answer");
                        } while (!int.TryParse(Console.ReadLine(), out UserAnswerChooseOne));
                        if (UserAnswerChooseOne == questionList.ChooseOneList[RandomIndex].QAnswer)
                        {
                            StudentScore += questionList.ChooseOneList[RandomIndex].QMark;
                        }
                        FullScore += questionList.ChooseOneList[RandomIndex].QMark;
                        CurrentQuestionOfOneQuestion++;
                        CurrentQuestion++;
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"StudentScore is {StudentScore} From {FullScore}");
                Console.ForegroundColor = ConsoleColor.White;
                Helper.UniqueValue.Clear();
                Console.WriteLine();

            }
        }
    }
}
