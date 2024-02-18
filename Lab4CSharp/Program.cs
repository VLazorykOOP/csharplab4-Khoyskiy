using Lab4CSharp;

Console.WriteLine("Lab 4 CSharp");
while (true)
{
    Console.WriteLine("Введiть номер завдання:");
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            Romb romb = new Romb(4, 4 * Math.Sqrt(2), "Red");

            Console.WriteLine(romb[0]);
            Console.WriteLine(romb[1]);
            Console.WriteLine(romb[2]);

            // Перевантаження true і false
            Console.WriteLine(romb ? "Is Square" : "Is not Square");

            ++romb;
            Console.WriteLine($"After ++: {romb}");

            //--romb;
            Console.WriteLine($"After --: {romb}");

            // Перевантаження оператору *
            romb = romb * 2;
            Console.WriteLine($"After * 2: {romb}");

            // Перетворення типу Romb в string і навпаки
            string rombString = romb;
            Console.WriteLine($"Romb as string: {rombString}");

            Romb newRomb = rombString;
            Console.WriteLine($"String as Romb: {newRomb}");
            Console.ReadLine();

            break;
        case 2:
            VectorUshort vector1 = new VectorUshort(5);
            VectorUshort vector2 = new VectorUshort(5);

            Console.WriteLine("Демонстрація Вводу вручну");
            vector2.Fill();
            vector2.Print();

            Console.WriteLine("Демонстрація Заповнення скаляром(2)");
            vector2.Enter(2);
            vector2.Print();

            Console.WriteLine(vector2.Num);

            vector2.CodeError = 0;
            Console.WriteLine(vector2.CodeError);

            Console.WriteLine("Вірний " + vector2[1] + " Не Вірний " + vector2[10]);

            Console.WriteLine(vector2.CodeError);

            Console.WriteLine("Демонстрація ++");
            vector2++;
            vector2.Print();

            Console.WriteLine("Демонстрація --");
            vector2--;
            vector2--;
            vector2.Print();

            vector2.Fill();
            vector1.Enter(1);
            Console.WriteLine("Демонстрація True/False");
            if (vector2) Console.WriteLine("Не дорівнює нулю");
            else Console.WriteLine("Розмірність вектора або один з елементів дорівнює 0 ");

            VectorUshort vectorNot = new VectorUshort(2);
            VectorUshort vector = new VectorUshort(vector1.Num);
            ushort scalar = 2;
            Console.WriteLine("Перевантаження +");
            vector = vector1 + vector2;
            vector.Print();
            //vector = vector1 + vectorNot;
            //vector.Print();
            vector = vector2 + scalar;
            vector.Print();

            Console.WriteLine("Перевантаження -");
            vector = vector2 - vector1;
            vector.Print();
            //vector = vector1 - vectorNot;
            //vector.Print();
            vector = vector2 - scalar;
            vector.Print();

            Console.WriteLine("Перевантаження *");
            vector = vector1 * vector2;
            vector.Print();
            vector = vector2 * scalar;
            vector.Print();

            Console.WriteLine("Перевантаження /");
            vector = vector2 / vector1;
            vector.Print();
            vector = vector2 / scalar;
            vector.Print();

            Console.WriteLine("Перевантаження %");
            vector = vector2 % vector1;
            vector.Print();
            vector = vector2 % scalar;
            vector.Print();

            Console.WriteLine("Перевантаження |");
            vector = vector2 | vector1;
            vector.Print();
            vector = vector2 | scalar;
            vector.Print();

            Console.WriteLine("Перевантаження >>");
            vector = vector2 >> scalar;
            vector.Print();

            Console.WriteLine("Перевантаження <<");
            vector = vector2 << scalar;
            vector.Print();

            Console.WriteLine("Перевантаження ==");
            Console.WriteLine(vector1 == vector);
            vector1 = vector2;
            Console.WriteLine(vector1 == vector2);

            Console.WriteLine("Перевантаження !=");
            Console.WriteLine(vector1 != vector);

            Console.WriteLine("Перевантаження >");
            Console.WriteLine(vector1 > vector);

            Console.WriteLine("Перевантаження <");
            Console.WriteLine(vector1 < vector);

            Console.WriteLine("Перевантаження >=");
            Console.WriteLine(vector1 >= vector);

            Console.WriteLine("Перевантаження <=");
            Console.WriteLine(vector1 <= vector);
            break;
        case 3:
            MatrixUshort matrix1 = new MatrixUshort(2, 2);
            MatrixUshort matrix2 = new MatrixUshort(2, 2);

            matrix1.Print();

            Console.WriteLine("Демонстрація Вводу вручну");
            matrix1.Fill();
            matrix1.Print();

            Console.WriteLine("Демонстрація Заповнення скаляром(3)");
            matrix2.Enter(3);
            matrix2.Print();

            matrix2.CodeError = 0;
            Console.WriteLine(matrix2.CodeError);

            Console.WriteLine("Вірний " + matrix1[0, 1] + " Не Вірний " + matrix2[4, 5]);
            Console.WriteLine("Через індекс k - " + matrix1[3]);
            Console.WriteLine(matrix2.CodeError);

            Console.WriteLine("Демонстрація ++");
            matrix1++;
            matrix1.Print();

            Console.WriteLine("Демонстрація --");
            matrix2--;
            matrix2--;
            matrix2.Print();

            matrix2.Fill();
            Console.WriteLine("Демонстрація True/False");
            if (matrix2) Console.WriteLine("Не дорівнює нулю");
            else Console.WriteLine("Розмірність матриці або один з елементів дорівнює 0 ");

            MatrixUshort matrix = new MatrixUshort(2,2);
            ushort scalar1 = 2;
            Console.WriteLine("Перевантаження +");
            matrix = matrix1 + matrix2;
            matrix.Print();
            Console.WriteLine("--------");
            matrix = matrix1 + scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження -");
            matrix = matrix2 - matrix1;
            matrix.Print();
            Console.WriteLine("--------");
            matrix = matrix2 - scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження *");
            matrix = matrix1 * matrix2;
            matrix.Print();
            Console.WriteLine("--------");
            matrix = matrix2 * scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження /");
            matrix = matrix2 / matrix1;
            matrix.Print();
            Console.WriteLine("--------");
            matrix = matrix2 / scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження %");
            matrix = matrix2 % matrix1;
            matrix.Print();
            Console.WriteLine("--------");
            matrix = matrix2 % scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження |");
            matrix = matrix2 | matrix1;
            matrix.Print();
            Console.WriteLine("--------");
            matrix = matrix2 | scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження >>");
            matrix = matrix2 >> scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження <<");
            matrix = matrix2 << scalar1;
            matrix.Print();

            Console.WriteLine("Перевантаження ==");
            Console.WriteLine(matrix1 == matrix);
            matrix1 = matrix2;
            Console.WriteLine(matrix1 == matrix2);

            Console.WriteLine("Перевантаження !=");
            Console.WriteLine(matrix1 != matrix);

            Console.WriteLine("Перевантаження >");
            Console.WriteLine(matrix1 > matrix);

            Console.WriteLine("Перевантаження <");
            Console.WriteLine(matrix1 < matrix);

            Console.WriteLine("Перевантаження >=");
            Console.WriteLine(matrix1 >= matrix);

            Console.WriteLine("Перевантаження <=");
            Console.WriteLine(matrix1 <= matrix);

            break;
        default:
            Console.WriteLine("Не вiрно");
            break;
    }
}

