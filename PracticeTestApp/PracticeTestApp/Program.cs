using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTestApp
{
    public class MathUtils
    {
        public static double Average(double a, double b)
        {
            return (a + b) / 2;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine(abc.b);
            Console.WriteLine(Average(2.0, 1.0));
        }
    }

    public class DriverExam
    {
        public static void ExecuteExercise(IExercise exercise)
        {
            try
            {

                exercise.Start();
                exercise.Execute();
            }
            catch (Exception)
            {
                exercise.MarkNegativePoints();
            }
            finally
            {
                exercise.End();
            }

            //throw new InvalidOperationException("Waiting to be implemented.");
        }
    }

    public interface IExercise
    {
        void Start();
        void Execute();
        void MarkNegativePoints();
        void End();
    }

    public class Exercise : IExercise
    {
        public void Start() { Console.WriteLine("Start"); }
        public void Execute() { Console.WriteLine("Execute"); }
        public void MarkNegativePoints() { Console.WriteLine("MarkNegativePoints"); }
        public void End() { Console.WriteLine("End"); }
    }
    enum abc
    {
        a,
        b,
        c,
        d
    }
}
