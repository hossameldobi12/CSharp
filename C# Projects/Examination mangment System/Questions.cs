using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_mangment_System
{
    enum Qtype
    {
        TrueOrFalse = 1,
        ChooseOne = 2,

    }
    enum QLevel
    {
        Easy = 1,
        Medium = 2,
        Hard = 3
    }

    internal abstract class Questions<T>
    {
        public QLevel QLevel { get; set; }
        public Qtype QHeader { get; set; }
        public string QBody { get; set; }
        public int QMark { get; set; }
        public int QNumber { get; set; }


        public object OBJECT;
        public Questions(QLevel Qlevel, Qtype Qheader, string Qbody, int Qmark, int Qnumber)
        {
            QLevel = Qlevel; QHeader = Qheader; QBody = Qbody; QMark = Qmark; QNumber = Qnumber;
        }
        public override string ToString()
        {
            return $"Question Number  {QNumber} , Question Level {QLevel} , Question Header {QHeader} , Question Body {QBody} , Question Mark {QMark} ";
        }
        public abstract string ToQuestion();
        public abstract T Add(QLevel Qlevel, string Qbody, int Qmark, int Qnumber);


        public Questions()
        {

        }
    }
}
