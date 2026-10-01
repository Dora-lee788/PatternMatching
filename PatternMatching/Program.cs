using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Классификация фигур");
                Console.WriteLine();
                Console.WriteLine("1. Создать круг и классифицировать");
                Console.WriteLine("2. Создать прямоугольник и классифицировать");
                Console.WriteLine("0. Выход");
                Console.WriteLine();

                try
                {
                    Console.Write("Выберите действие: ");
                    string choice = Console.ReadLine()!;

                    if (choice == "0")
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }

                    if (choice == "1")
                    {
                        double radius;

                        while (true)
                        {
                            try
                            {
                                Console.Write("Введите радиус круга: ");
                                radius = double.Parse(Console.ReadLine()!);

                                if (radius < 0)
                                {
                                    throw new ArgumentException(
                                        "Радиус не может быть отрицательным."
                                    );
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(
                                    "Ошибка: радиус должен быть числом."
                                );
                                Console.WriteLine("Попробуйте ещё раз.");
                                Console.WriteLine();
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Ошибка: {ex.Message}");
                                Console.WriteLine("Попробуйте ещё раз.");
                                Console.WriteLine();
                            }
                        }

                        Circle circle = new Circle(radius);

                        Console.WriteLine();
                        Console.WriteLine($"Фигура: {circle}");
                        Console.WriteLine(
                            $"Результат классификации: {ShapeClassifier.Classify(circle)}"
                        );
                        Console.WriteLine();
                    }
                    else if (choice == "2")
                    {
                        double width;
                        double height;

                        while (true)
                        {
                            try
                            {
                                Console.Write("Введите ширину прямоугольника: ");
                                width = double.Parse(Console.ReadLine()!);

                                if (width <= 0)
                                {
                                    throw new ArgumentException(
                                        "Ширина должна быть больше нуля."
                                    );
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(
                                    "Ошибка: ширина должна быть числом."
                                );
                                Console.WriteLine("Попробуйте ещё раз.");
                                Console.WriteLine();
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Ошибка: {ex.Message}");
                                Console.WriteLine("Попробуйте ещё раз.");
                                Console.WriteLine();
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.Write("Введите высоту прямоугольника: ");
                                height = double.Parse(Console.ReadLine()!);

                                if (height <= 0)
                                {
                                    throw new ArgumentException(
                                        "Высота должна быть больше нуля."
                                    );
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(
                                    "Ошибка: высота должна быть числом."
                                );
                                Console.WriteLine("Попробуйте ещё раз.");
                                Console.WriteLine();
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Ошибка: {ex.Message}");
                                Console.WriteLine("Попробуйте ещё раз.");
                                Console.WriteLine();
                            }
                        }

                        Rectangle rectangle = new Rectangle(width, height);

                        Console.WriteLine();
                        Console.WriteLine($"Фигура: {rectangle}");
                        Console.WriteLine(
                            $"Результат классификации: {ShapeClassifier.Classify(rectangle)}"
                        );
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(
                            "Ошибка: такого действия нет."
                        );
                        Console.WriteLine("Попробуйте ещё раз.");
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine("Попробуйте ещё раз.");
                    Console.WriteLine();
                }
            }
        }
    }
}
