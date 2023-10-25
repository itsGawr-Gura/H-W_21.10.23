using H_W_21._10._23;
using System;

namespace Practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            
            Employee semyon = new Employee("Семён", null);
            Employee rashid = new Employee("Рашид", semyon);
            Employee ilham = new Employee("О Ильхам", semyon);
            Employee lukas = new Employee("Лукас", rashid);
            Employee orkadiy = new Employee("Оркадий", ilham);
            Employee volodya = new Employee("Володя", ilham);
            Employee ilshat = new Employee("Ильшат", orkadiy);
            Employee ivanych = new Employee("Иваныч", orkadiy);
            Employee ilya = new Employee("Илья", ilshat);
            Employee vitya = new Employee("Витя", ilshat);
            Employee zhenya = new Employee("Женя", ilshat);
            Employee sergey = new Employee("Сергей", volodya);
            Employee lyaysan = new Employee("Ляйсан", volodya);
            Employee marat = new Employee("Марат", lyaysan);
            Employee dina = new Employee("Дина", lyaysan);
            Employee ildar = new Employee("Ильдар", lyaysan);
            Employee anton = new Employee("Антон", lyaysan);

            
            Task task1 = new Task(".......", sergey);
            Task task2 = new Task(".......", dina);
            Task task3 = new Task(".......", ilham);

           
            CheckTaskAssignment(semyon, task1);
            CheckTaskAssignment(lyaysan, task2);
            CheckTaskAssignment(orkadiy, task3);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void CheckTaskAssignment(Employee employee, Task task)
        {
            Console.WriteLine("От сотрудника " + employee.Name + " задача \"" + task.Name + "\" даётся " + task.Recipient.Name + ".");
            if (IsTaskAssigned(employee, task))
            {
                Console.WriteLine(employee.Name + " берет задачу.");
            }
            else
            {
                Console.WriteLine(employee.Name + " не берет задачу.");
            }
        }

        static bool IsTaskAssigned(Employee employee, Task task)
        {
            Employee recipient = task.Recipient;
            while (recipient != null)
            {
                if (recipient == employee)
                {
                    return true;
                }
                recipient = recipient.Manager;
            }
            return false;
        }
        
    }
}
    

