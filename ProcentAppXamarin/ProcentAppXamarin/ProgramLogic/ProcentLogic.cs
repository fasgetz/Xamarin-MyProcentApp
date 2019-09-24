using ProcentAppXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcentAppXamarin.ProgramLogic
{

    /// <summary>
    /// Для вычислений в контексте программы
    /// </summary>
    public static class ProcentLogic
    {

        public static double EarnedSum { get; set; }
        public static double AllCapital { get; set; }

        /// <summary>
        /// Метод, который вычисляет процент
        /// </summary>
        /// <returns>Возвращает процент от суммы</returns>
        private static double GetProcent(double sum, double procent)
        {
            return ((sum / 100) * procent);
        }

        public static List<Result> StartInvest(MainPageModel model)
        {
            double residue = 0; // Остаточная сумма
            double startcap = model.StartSum; // Стартовый капитал
            AllCapital = model.StartSum;

            List<Result> list = new List<Result>();

            // Считаем заработок за каждый месяц
            for (int i = 0; i < (model.EndDate - DateTime.Now).Days / 30; i++)
            {
                double MonthSum = GetProcent(startcap, model.Procent); // Месячный доход

                // Добавляем к остаточной сумме нашу зп (если ее выбрали)
                if (model.PutOffSum != 0)
                    MonthSum += model.PutOffSum;

                residue += MonthSum; // Добавляем к остаточной сумме 

                EarnedSum += MonthSum; // Прибавляем к заработанному капиталу сумму


                // Формируем результат для вывода
                Result res = new Result()
                {
                    NumbMonth = i + 1,
                    InterestIncome = MonthSum - model.PutOffSum,
                    TotalIncome = MonthSum - model.PutOffSum
                };

                if (model.PutOffSum != 0)
                    res.TotalIncome = MonthSum;

                list.Add(res);



                // Если заработанная сумма достигла больше суммы, которую можно добавить,
                // то добавь к капиталу для увеличения ежемесечных процентов
                if (residue > model.Capitalize && model.Capitalize != 0)
                {

                    var temp = residue - model.Capitalize; // Остаточная сумма
                    startcap += model.Capitalize; // Добавляем к капиталу накопленную сумму. Теперь будет больше %

                    residue = temp; // Остаточная сумма = Накопленная сумма - добавляемая сумма

                }
            }

            AllCapital += EarnedSum;

            return list;
        }
    }
}
