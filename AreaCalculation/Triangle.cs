namespace AreaCalculation
{
    public class Triangle
    {
        // Сортировка массива сторон треугольника по возрастанию (пузырьковая)
        public static double[] Sort(double[] sideArray)
        {
            double tempSide;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (sideArray[i] > sideArray[j])
                    {
                        tempSide = sideArray[i];
                        sideArray[i] = sideArray[j];
                        sideArray[j] = tempSide;
                    }
                }
            }
            return sideArray;
        }
        // Проверка на "прямоугольность" массива сторон(необходима предварительная сортировка)
        public static bool RightCheck(double[] sideArray)
        {
            if (Math.Pow(sideArray[2], 2) == (Math.Pow(sideArray[0], 2) + Math.Pow(sideArray[1], 2)))
                return true;
            return false;
        }
        // Проверка на "прямоугольность" введённых чисел
        public static bool RightCheck(double sideA, double sideB, double sideC)
        {
            double[] sideArray = { sideA, sideB, sideC };
            return RightCheck(Sort(sideArray));
        }
        // Проверка, могут ли являться введённый массив сторонами треугольника(необходима предварительная сортировка)
        public static bool Check(double[] sideArray)
        {
            if ((sideArray[2] < (sideArray[0] + sideArray[1])) && (sideArray[2] > sideArray[1] - sideArray[0]))
                return true;
            return false;
        }
        // Проверка, могут ли являться введённые числа сторонами треугольника
        public static bool Check(double sideA, double sideB, double sideC)
        {
            double[] sideArray = { sideA, sideB, sideC };
            return Check(Sort(sideArray));
        }

        public static double AreaCalculation(double sideA, double sideB, double sideC)
        {
            double[] sideArray = { sideA, sideB, sideC };
            // Сортируем стороны треугольника по возрастанию
            sideArray = Sort(sideArray);
            // Проверяем, являются ли введённые числа сторонами треугольника
            if (Check(sideArray))
            {
                // Проверяем, является ли треугольник прямоугольник
                if (RightCheck(sideArray))
                {
                    // Рассчитываем площадь прямоугольного треугольника
                    return (sideArray[0] * sideArray[1]) / 2;
                }
                else
                {
                    // Рассчитываем площадь треугольника по формуле Герона
                    return AreaCalculationWithoutChecks(sideArray);
                }
            }
            // Введённые числа нее могут являться сторонами треугольника, поэтому выводим площадь равную нулю
            return 0;
        }
        // Расчёт площади треугольника по формуле Герона без проверок для массива сторон
        public static double AreaCalculationWithoutChecks(double[] sideArray)
        {
            double semiP = (sideArray[0] + sideArray[1] + sideArray[2]) / 2;
            return Math.Sqrt(semiP * (semiP - sideArray[0]) * (semiP - sideArray[1]) * (semiP - sideArray[2]));
        }
        // Расчёт площади треугольника без проверок по трём сторонам
        public static double AreaCalculationWithoutChecks(double sideA, double sideB, double sideC)
        {
            double[] sideArray = { sideA, sideB, sideC };
            return AreaCalculationWithoutChecks(sideArray);
        }

    }
}
