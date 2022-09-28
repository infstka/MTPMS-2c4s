using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2
{
    public class ComputerValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Discipline discipline = value as Discipline;
            if (discipline.Semestr % 2 == 1)
            {
                ErrorMessage = "Введите корректный номер семестра";
                return false;
            }
            else if (discipline.Semestr % 2 == 1)
            {
                ErrorMessage = "Введите корректный номер семестра";
                return false;
            }
            return true;
        }

        public static bool Validate(Discipline discipline)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(discipline);
            if (!Validator.TryValidateObject(discipline, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                MessageBox.Show("Все хорошо");
                return true;
            }
        }
    }
}
