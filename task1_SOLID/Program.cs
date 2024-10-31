using task1_SOLID;

Employee employee = new Employee("Андрей", "Консультант", 30000, 50000);

SalaryCalculation salaryCalculation = new SalaryCalculation();

Console.WriteLine($"{employee._name} заработал с учётом штрафа: {salaryCalculation.CalculateSalary(employee)} рублей");