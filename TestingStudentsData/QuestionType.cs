using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStudentsData
{
    public enum QuestionType
    {
        OneСorrect      = 0, // Один правильный ответ
        MultiСorrect    = 1, // Несколько за правильный ответ
        Input           = 2, // Ручной ввод за правильный ответ
        Order           = 3, // Задание порядка за правильный ответ
        Сomparison      = 4, // Сопоставление за правильный ответ
    }
}
