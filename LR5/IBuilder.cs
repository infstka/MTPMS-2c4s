using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    public interface IBuilder
    {
        void BuildName(string Name);
        void BuildSemestr(int Semestr);
        void BuildCourse(int Course);
        void BuildSpecialization(string Specialization);
        void BuildNumberOfLectures(string NumberOfLectures);
        void BuildNumberOfLabs(string NumberOfLabs);
        void BuildTypeOfControl(string TypeOfControl);
        void BuildResult(string Result);
        void BuildLector(Lector Lector);
    }
    
    public class Builder : IBuilder
    {
        public Discipline discipline = new Discipline();
        public void BuildName(string Name)
        {
            discipline.Name = Name;
        }
        public void BuildSemestr(int Semestr)
        {
            discipline.Semestr = Semestr;
        }
        public void BuildCourse(int Course)
        {
            discipline.Course = Course;
        }
        public void BuildSpecialization(string Specialization)
        {
            discipline.Specialization = Specialization;
        }
        public void BuildNumberOfLectures(string NumberOfLectures)
        {
            discipline.NumberOfLectures = NumberOfLectures;
        }
        public void BuildNumberOfLabs(string NumberOfLabs)
        {
            discipline.NumberOfLabs = NumberOfLabs;
        }
        public void BuildTypeOfControl(string TypeOfControl)
        {
            discipline.TypeOfControl = TypeOfControl;
        }
        public void BuildResult(string Result)
        {
            discipline.Result = Result;
        }
        public void BuildLector(Lector Lector)
        {
            discipline.Lector = Lector;
        }
    }
}
