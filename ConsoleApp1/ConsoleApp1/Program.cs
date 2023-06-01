using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            List<Employee> employees = new List<Employee>()
            {
                new("Петрова Лариса Генадевна", 3, 12300),
                new("Лысеков Иван Дмитреевич", 1, 9000),
                new("Охоткина Марина Евгенева", 5, 17990),
                new("Фузубов Никита Романович", 2, 21000),
                new("Лесопал Родион Алксандрович", 3, 14200),
                new("Ухова Анна Олеговна", 3, 25000),
                new("Минин Евгений Прокофьев", 1, 19000),
                new("Крысов Антон Владимирович", 3, 16000),
                new("Бешумов Степан Иванов", 4, 23000),
                new("Остров Михаил Сергеевич", 2, 20000),
            };
            //Day 3
            EmployDataList();
            SummSalaryMonyh();
            MinWage();
            MaksWage();
            AverageSalary();
            FioPerson();
            IndexWage();
            Console.WriteLine("---------------------------------");
            //Day 4
            IndexWage();
            FindDepartment();
            GetNumber();

            void EmployDataList()
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine($"#{employee.Id()} | ФИО: {emp.Fio} | Отделение: {emp.Department} | Зарплата: {emp.Salary}");
                }
            }
            void SummSalaryMonyh()
            {
                double summ = 0;
                foreach (var emp in employees)
                {
                    summ += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на зарплаты в месяц: {summ}");
            }
            void MinWage()
            {
                string fioMinWage = string.Empty;
                double valueMinWage = 200000;
                foreach (var emp in employees)
                {
                    if (valueMinWage > emp.Salary)
                    {
                        fioMinWage = emp.Fio;
                        valueMinWage = emp.Salary;
                    }
                }
                Console.WriteLine($"Минимальная зарплата у {fioMinWage}, она состовляет {valueMinWage}");
            }
            void MaksWage()
            {
                string fioMaxWage = string.Empty;
                double valueMaxWage = 0;
                foreach (var emp in employees)
                {
                    if (valueMaxWage < emp.Salary)
                    {
                        fioMaxWage = emp.Fio;
                        valueMaxWage = emp.Salary;
                    }
                }
                Console.WriteLine($"Максимальня зарплата у {fioMaxWage}, она состовляет {valueMaxWage}");
            }
            void AverageSalary()
            {
                int counter = 0;
                double summ = 0;
                foreach (var emp in employees)
                {
                    summ += emp.Salary;
                    counter++;
                }
                Console.WriteLine($"Среднее значение зарплаты состовляет {summ / counter}");
            }
            void FioPerson()
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine(emp.Fio);
                }
            }




            void IndexWage()
            {
                double index = 1.5;
                foreach (var emp in employees)
                {
                    Console.WriteLine($"Зарплата уввеиченная на 50%: {emp.Salary * index}");
                }
            }
            void FindDepartment()
            {
                Console.Write("Введите номер отдела: ");
                int nuberDepartment = int.Parse(Console.ReadLine());
                void MinWage()
                {
                    double minWage = 200000;
                    foreach (var emp in employees)
                    {
                        if (emp.Department == nuberDepartment)
                        {
                            if (minWage > emp.Salary)
                            {
                                minWage = emp.Salary;
                            }
                        }
                    }
                    Console.WriteLine($"Отдел: {nuberDepartment} миниммальная зарплата: {minWage}");

                }
                void MaxWage()
                {
                    double maxWage = 0;
                    foreach (var emp in employees)
                    {
                        if (emp.Department == nuberDepartment)
                        {
                            if (maxWage < emp.Salary)
                            {
                                maxWage = emp.Salary;
                            }
                        }
                    }
                    Console.WriteLine($"Отдел: {nuberDepartment} Максимальная зарплата: {maxWage}");

                }
                void MiddleWage()
                {
                    int count = 0;
                    double wage = 0;
                    foreach (var emp in employees)
                    {
                        if (emp.Department == nuberDepartment)
                        {
                            wage += emp.Salary;
                            count++;
                        }
                    }
                    Console.WriteLine($" Средняя зарплата{wage = wage / count}");
                }
                void IndexWage()
                {
                    foreach (var emp in employees)
                    {
                        if (emp.Department == nuberDepartment)
                        {
                            Console.WriteLine($"На 30% {emp.Salary * 1.3}");
                        }
                    }
                }
                void AllPerson()
                { 
                    foreach(var emp in employees)
                    {
                        if (emp.Department == nuberDepartment)
                        {
                            Console.WriteLine($"{emp.Fio} {emp.Salary}");
                        }
                    }
                }
                MinWage();
                MaxWage();
                MiddleWage();
                IndexWage();
                AllPerson();
            }
            void GetNumber()
            {
                Console.Write("Введите число: ");
                double userNumber = double.Parse(Console.ReadLine());
                void MinWageNumber()
                {
                    employee.IdUpdate();
                    foreach (var emp in employees)
                    {
                        if (userNumber > emp.Salary)
                        {
                            Console.WriteLine($"{employee.Id()} {emp.Fio} {emp.Salary}");
                        }
                    }
                }
                void MaxWageumber()
                {
                    employee.IdUpdate();
                    foreach (var emp in employees)
                    {
                        if (userNumber <= emp.Salary)
                        {
                            Console.WriteLine($"{employee.Id()} {emp.Fio} {emp.Salary}");
                        }    
                    }
                }
                MinWageNumber();
                Console.WriteLine();
                MaxWageumber();
            }
        }
    }
}