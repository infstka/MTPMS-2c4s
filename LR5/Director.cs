using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    public class Director
    {
        public static Discipline BuildDiscipline(string Name, int Semestr, int Course, string Specialization, string NumberOfLectures, string NumberOfLabs, string TypeOfControl, string Result, Lector Lector)
        {
            Builder build = new Builder();
            build.BuildName(Name);
            build.BuildSemestr(Semestr);
            build.BuildCourse(Course);
            build.BuildSpecialization(Specialization);
            build.BuildNumberOfLectures(NumberOfLectures);
            build.BuildNumberOfLabs(NumberOfLabs);
            build.BuildTypeOfControl(TypeOfControl);
            build.BuildResult(Result);
            build.BuildLector(Lector);

            return build.discipline;
        }

        public static Discipline BuildSystem(Lector lector, string name, int course, int semestr)
        {
            Builder build = new Builder();
            build.BuildLector(lector);
            build.BuildName(name);
            build.BuildCourse(course);
            build.BuildSemestr(semestr);

            return build.discipline;
        }

        public static Discipline BuildOther(string specialization, string numberoflectures, string numberoflabs, string typeofcontrol)
        {
            Builder build = new Builder();
            build.BuildSpecialization(specialization);
            build.BuildNumberOfLectures(numberoflectures);
            build.BuildNumberOfLabs(numberoflabs);
            build.BuildTypeOfControl(typeofcontrol);

            return build.discipline;
        }
    }
}
