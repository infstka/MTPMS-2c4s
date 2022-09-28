using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    internal interface IBuilder
    {
        void BuildPartA(string Name, int Semestr, int Course, string NumberOfLectures, string NumberOfLabs);
        void BuildPartB(string Specialization, string TypeOfControl);
        void BuildPartC(Lector Lector);
    }
    
    internal class Builder : IBuilder
    {
        private Discipline discipline = new Discipline();
        public Builder()
        {
            Reset();
        }
        public void Reset()
        {
            discipline = new Discipline();
        }

        public void BuildPartA(string Name, int Semestr, int Course, string NumberOfLectures, string NumberOfLabs)
        {
            discipline.name = Name;
            discipline.semestr = Semestr;
            discipline.course = Course;
            discipline.numberoflectures = NumberOfLectures;
            discipline.numberoflabs = NumberOfLabs;
        }
        public void BuildPartB(string Specialization, string TypeOfControl)
        {
            discipline.specialization = Specialization;
            discipline.typeofcontrol = TypeOfControl;
        }
        public void BuildPartC(Lector Lector)
        {
            discipline.Lector = Lector;
        }
        public Discipline GetDiscipline()
        {
            Discipline result = discipline;
            Reset();
            return result;
        }
    }

    internal class Director
    {
        public Builder build = new Builder();
        private IBuilder builder;
        public IBuilder Builder
        {
            set 
            { 
                builder = value;
            }
        }
        public Discipline BuildMinimalDiscipline(string Name, int Semestr, int Course, string NumberOfLectures, string NumberOfLabs)
        {
            build.BuildPartA(Name, Semestr, Course, NumberOfLectures, NumberOfLabs);
            return build.GetDiscipline();
        }

        public void BuildFullDiscipline(string Name, int Semestr, int Course, string NumberOfLectures, string NumberOfLabs, string Specialization, string TypeOfControl, Lector Lector)
        {
            builder.BuildPartA(Name, Semestr, Course, NumberOfLectures, NumberOfLabs);
            builder.BuildPartB(Specialization, TypeOfControl);
            builder.BuildPartC(Lector);
        }
    }
}
