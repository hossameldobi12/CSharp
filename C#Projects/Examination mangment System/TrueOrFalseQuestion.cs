using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_mangment_System
{
    enum QTFAnswer
    {
        True = 1,
        T = 1,
        F = 2,
        False = 2
    }

    internal class TrueOrFalseQuestion : Questions<TrueOrFalseQuestion>
    {

        public QTFAnswer Answer { get; set; }
        public TrueOrFalseQuestion(QLevel Qlevel, Qtype Qheader, string Qbody, int Qmark, QTFAnswer Qanswer, int Qnumber) : base(Qlevel, Qheader, Qbody, Qmark, Qnumber)
        {
            Answer = Qanswer;
        }
        public TrueOrFalseQuestion()
        {

        }

        public override TrueOrFalseQuestion Add(QLevel Qlevel, string Qbody, int Qmark, int Qnumber)
        {
            QTFAnswer QTFAnswer;
            do
            {
                Console.WriteLine("Enter the Answer [1.True     2.False]");
            } while (!Enum.TryParse(typeof(QTFAnswer), Console.ReadLine(), true, out OBJECT));
            QTFAnswer = (QTFAnswer)OBJECT;

            return new TrueOrFalseQuestion(Qlevel, Qtype.TrueOrFalse, Qbody, Qmark, QTFAnswer, Qnumber);

        }

        public override string ToString()
        {
            return $"{base.ToString()} , Question Answer {Answer}  ";
        }

        public override string ToQuestion()
        {
            return $"Question Number {QNumber}\nType of Question [True , False]\n Question Level {QLevel}\n Question Mark {QMark}\n The Question is : {QBody}\n Choose[True,False]\n";
        }


    }
}
