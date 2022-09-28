using System;
using System.Collections;
using System.Runtime.Serialization;


namespace ЛР2
{ 
    public abstract class Prototype
    {
        [DataMember]
        public string Name;
        [DataMember]
        public int Semestr;
        [DataMember]
        public int Course;
        [DataMember]
        public string Specialization;
        [DataMember]
        public string NumberOfLectures;
        [DataMember]
        public string NumberOfLabs;
        [DataMember]
        public string TypeOfControl;
        [DataMember]
        public string Result;
        [DataMember]
        public Lector Lector;

        public override string ToString()
        {
            return "Название дисциплины: " + Name + " Курс: " + Course + " Семестр:  " + Semestr + " Специальность: " + Specialization + " Кол-во лекций: " + NumberOfLectures + " Кол-во лабораторных: " + NumberOfLabs;

        }

        public abstract Prototype Clone();
    }

    [DataContract]
    public class Discipline : Prototype
    {
        public Discipline(string Name, int Semestr, int Course, string Specialization, string NumberOfLectures, string NumberOfLabs, string TypeOfControl, string Result, Lector Lector)
        {
            name = Name;
            semestr = Semestr;
            course = Course;
            specialization = Specialization;
            numberoflectures = NumberOfLectures;
            numberoflabs = NumberOfLabs;
            typeofcontrol = TypeOfControl;
            result = Result;
            lector = Lector;
        }


        public Discipline()
        {
        }

        public Discipline(string Name, int Semestr, int Course)
        {
            name = Name;
            semestr = Semestr;
            course = Course;
        }
        public override Prototype Clone()
        {
            return new Discipline(Name, Semestr, Course, Specialization, NumberOfLectures, NumberOfLabs, TypeOfControl, Result, Lector);
        }

        public string name
        {
            get => Name;
            set
            {
                if (value.Length < 1)
                    throw new Exception("name");
                else
                    Name = value;
            }
        }

        public int semestr
        {
            get => Semestr;
            set
            {
                if (value < 1)
                    throw new Exception("semestr");
                else
                    Semestr = value;
            }
        }

        public int course
        {
            get => Course;
            set
            {
                if (value < 1)
                    throw new Exception("course");
                else
                    Course = value;
            }
        }

        public string specialization
        {
            get => Specialization;
            set
            {
                if (value.Length < 4)
                    throw new Exception("spec");
                else
                    Specialization = value;
            }
        }

        public string numberoflectures
        {
            get => NumberOfLectures;
            set
            {
                if (value.Length < 1)
                    throw new Exception("lect");
                else
                    NumberOfLectures = value;
            }
        }

        public string numberoflabs
        {
            get => NumberOfLabs;
            set
            {
                if (value.Length < 1)
                    throw new Exception("lab");
                else
                    NumberOfLabs = value;
            }
        }
        
        public string typeofcontrol
        {
            get => TypeOfControl;
            set
            {
                if (value.Length < 5)
                    throw new Exception("toc");
                else
                    TypeOfControl = value;
            }
        }

        public string result
        {
            get => Result;
            set
            {
                if (value.Length < 0)
                    throw new Exception("result");
                else
                    Result = value;
            }
        }
        public Lector lector
        {
            get => Lector;
            set => Lector = value;
        }
    }
}
