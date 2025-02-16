using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examination_mangment_System
{
    internal class MidTermExam : Exam
    {
        public QuestionsNumber midquestionsNumber = new QuestionsNumber { MaxNumberOfAllQuestions = 6, MaxNumberOfEachQuestion = 3 };

        public MidTermExam() 
        {
        }




    }
}
