using System;
namespace Hel.CreatingTypesinC
{
    public class PracticingStructs
    {
        public static void Program()
        {
            Student student = new Student(9,10);
            Console.WriteLine(student.score);
        }

        public class Student
        {
            //field
            public float right, wrong;
            public Score score;

            //constructor
            public Student(float right, float wrong)
            {
                this.right = right;
                this.wrong = wrong;
                score = new Score(this.right, this.wrong);
            }   

            //Structs (like a class, except it's a value type)
            public struct Score
            {
                //fields
                float right, wrong;

                //can I put a property in a struct?
                public float grade
                {
                    get => right / wrong;
                }

                //constructor
                public Score(float right, float wrong) { this.right = right; this.wrong = wrong; }

                //ToString Override
                public override string ToString()
                {
                    return right + " right, " + wrong + " wrong, grade: " + grade * 100 + "%";
                }
            }

        }
    }
}
//Structs and Properties in C#
//Properties: like fields, but contain logic (get and set accessors)
//Structs: like classes, but value type
//does not support inheritance (other than from object)