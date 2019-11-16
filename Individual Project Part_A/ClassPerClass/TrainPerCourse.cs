using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class TrainPerCourse
    {
        List<Course> Mathima = ListProvider.CreateListCourses();
        List<Trainer> Trainers = ListProvider.CreateListsTrainers();

        public TrainPerCourse(List<Course> mathima, List<Trainer> kathigites)
        {
            Trainers = kathigites;
            Mathima = mathima;
        }

        public static List<TrainPerCourse> CreateListsTrainersPerCourse() // CREATE LIST, TRAINERS per COURSE______________________________________
        {
            List<Trainer> Trainers = ListProvider.CreateListsTrainers();
            List<Course> Mathima = ListProvider.CreateListCourses();

            TrainPerCourse TPC001 = new TrainPerCourse(Mathima, Trainers);

            List<TrainPerCourse> trainerspercourse = new List<TrainPerCourse>();
            trainerspercourse.Add(TPC001);

            return trainerspercourse;
        }

        public static void PrintListsTrainersPerCourse() // PRINT TRAINERS per COURSE______________________________________
        {
            List<TrainPerCourse> TpC = new List<TrainPerCourse>();
            TpC = TrainPerCourse.CreateListsTrainersPerCourse();


            foreach (var item in TpC[0].Mathima)
            {
                item.Output();

                foreach (var ass in TpC[0].Trainers)
                {
                    if (ass.Subject == item.Type)
                    {
                        ass.Output();
                    }
                }
            }
        }

    }
}
