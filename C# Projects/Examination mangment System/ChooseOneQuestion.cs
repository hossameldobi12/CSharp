using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_mangment_System
{
    internal class ChooseOneQuestion : Questions<ChooseOneQuestion>
    {

        public int QAnswer { get; set; }
        public string[] Choices { get; set; }
        public ChooseOneQuestion(QLevel Qlevel, Qtype Qheader, string Qbody, int Qmark, int qAnswer, string[] choices, int Qnumber) : base(Qlevel, Qheader, Qbody, Qmark, Qnumber)
        {
            QAnswer = qAnswer;
            Choices = choices;
        }
        public ChooseOneQuestion()
        {

        }

        public override ChooseOneQuestion Add(QLevel Qlevel, string Qbody, int Qmark, int Qnumber)
        {

            int ChooseOneQuestionAnswer;
            string[] Choices = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Please enter the  choice {i + 1}");
                Choices[i] = Console.ReadLine();
            }
            do
            {
                Console.WriteLine("Enter the Answer");
            } while (!int.TryParse(Console.ReadLine(), out ChooseOneQuestionAnswer));

            return new ChooseOneQuestion(Qlevel, Qtype.ChooseOne, Qbody, Qmark, ChooseOneQuestionAnswer, Choices, Qnumber);
        }
        public override string ToString()
        {
            return $"{base.ToString()} , Question Answer {QAnswer}  ";
        }


        public override string ToQuestion()
        {
            return $"Question Number {QNumber}\nType of Question [Choose one Q]]\n Question Level {QLevel}\n Question Mark {QMark}\n The Question is : {QBody}\n 1.{Choices[0]}\n 2.{Choices[1]}\n 3.{Choices[2]}\n 4.{Choices[3]}\n";
        }
    }
}
