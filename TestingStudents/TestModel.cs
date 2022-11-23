using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStudents
{
    public class TestModel
    {
        string testName = "Тестирование без имени";
        int timer = 0;

        object[] tests; // Загруженные вопросы
        object[] answers; // Ответы на вопросы

        int generalQuest = 0; // Всего вопросов
        int currentQuest = 0; // Текущий вопрос

        int doneAnswers = 0;  // Дано ответов
        int completeAnswers = 0;  // Правильных ответов
        int failAnswers = 0;  // Неправильных ответов

        int maxScore = 0; // Всего очков
        int score = 0; // Набрано очков

        bool showResult = false; // Показывать результаты
        bool canBacking = true;  // Возможно ли возращаться

        /// <summary>
        /// Всего вопросов в тестировании
        /// </summary>
        /// <returns>Возращает общее колличество вопросов</returns>
        public int GeneralQuest => generalQuest;
        /// <summary>
        /// Номер текущего вопроса в тестировании
        /// </summary>
        /// <returns>Возращает номер текущего вопроса</returns>
        public int CurrentQuest => currentQuest;
        /// <summary>
        /// Дано ответов в тестировании
        /// </summary>
        /// <returns>Возращает колличество отвеченных вопросов</returns>
        public int DoneAnswers => doneAnswers;
        /// <summary>
        /// Не дано ответов в тестировании
        /// </summary>
        /// <returns>Возращает колличество не отвеченных вопросов</returns>
        public int DontAnswers => generalQuest - doneAnswers;
        /// <summary>
        /// Дано правильных ответов в тестировании
        /// </summary>
        /// <returns>Возращает колличество правильных ответов</returns>
        public int CompleteAnswers => showResult ? completeAnswers : 0;
        /// <summary>
        /// Дано неправильных ответов в тестировании
        /// </summary>
        /// <returns>Возращает колличество не правильных ответов</returns>
        public int FailAnswers => showResult ? failAnswers : 0;
        /// <summary>
        /// Максимально очков в тестировании
        /// </summary>
        /// <returns>Возращает колличество максимальное колличество очков</returns>
        public int MaxScore => maxScore;
        /// <summary>
        /// Заработано очков в тестировании
        /// </summary>
        /// <returns>Возращает колличество колличество заработанных очков</returns>
        public int Score => showResult ? score : 0;


        public TestModel(string name, int time = -1)
        {
            testName = name;
            timer = time;
        }

        public void QuestNext()
        {
            if (currentQuest < generalQuest) currentQuest++;
        }
        public void QuestBack()
        {
            if (currentQuest > 1 && canBacking) currentQuest--;
        }

        /// <summary>
        /// Проверка на последний вопрос
        /// </summary>
        /// <returns>Возращает true в случае, если это последний вопрос</returns>
        public bool IsLastQuest()
        {
            return currentQuest >= generalQuest;
        }


        /// <summary>
        /// Получение оставшегося времени
        /// </summary>
        /// <returns>Возращает оставшееся время в секундах</returns>
        public int GetTimer()
        {
            return timer;
        }

        /// <summary>
        /// Выполняет шаг в таймере
        /// </summary>
        public void TimerStep()
        {
            if (timer > 0) timer--;
        }

        public void SendResult()
        {

        }
        public void SendEnd()
        {

        }
    }
}
