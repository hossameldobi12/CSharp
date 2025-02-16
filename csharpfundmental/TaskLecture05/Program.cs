namespace TaskLecture05
{
    enum WeekDayes : byte
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    enum season : byte
    {
        spring,
        summer,
        Autumn,
        winter
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            *****************************************************************************************************
            *                                                                                                   *
            * 1- create an enum called weekdayes and print all the dayes                                        *
            *                                                                                                   *  
            *****************************************************************************************************
            

            foreach (WeekDayes day in Enum.GetValues(typeof(WeekDayes)))
            {
                Console.WriteLine($"the day name :{day} and the number is {(byte)day }");
            }


              ************************************** THE END OF TASK ******************************** 
            */



            /*
             
            *****************************************************************************************************
            *                                                                                                   *
            * 2- create an enum of season and take the season as input from user and print the range of month   *
            *                                                                                                   *  
            *****************************************************************************************************
            

            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            try
            {
                Console.WriteLine("enter the season name");
                season SeasonUser = (season)Enum.Parse(typeof(season), Console.ReadLine(), true);
                if ((int)SeasonUser > 3)
                {
                    throw new Exception("the number out of range");
                }
                else
                {
                    if (SeasonUser == season.winter)
                    {
                        Console.WriteLine($"the season is {SeasonUser}, the monthes is {month[11]} , {month[0]}, {month[1]} ");
                    }
                    else if (SeasonUser == season.spring)
                    {
                        Console.WriteLine($"the season is {SeasonUser}, the monthes is {month[2]} , {month[3]} , {month[4]} ");

                    }
                    else if (SeasonUser == season.summer)
                    {
                        Console.WriteLine($"the season is {SeasonUser}, the monthes is {month[5]} , {month[6]}, {month[7]} ");

                    }
                    else if (SeasonUser == season.Autumn)
                    {
                        Console.WriteLine($"the season is {SeasonUser}, the monthes is {month[8]} , {month[9]} , {month[10]} ");

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

              ************************************** THE END OF TASK ******************************** 
              
            */
            
        }

    }
}
