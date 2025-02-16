using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_mangment_System
{
    internal class FinalExam : Exam
    {
        public QuestionsNumber finalquestionsNumber = new QuestionsNumber { MaxNumberOfAllQuestions = 12, MaxNumberOfEachQuestion = 6 };

        public FinalExam() 
        {
        }
    }
}
