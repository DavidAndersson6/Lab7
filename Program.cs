namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Bosse", "Male", 20000);
            Employee employee2 = new Employee(2, "Bettan", "Female", 32000);
            Employee employee3 = new Employee(3, "Maria", "Female", 25000);
            Employee employee4 = new Employee(4, "David", "Male", 34000);
            Employee employee5 = new Employee(5, "Herve", "Male", 30000);


            Stack<Employee> stack = new Stack<Employee>();

            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            foreach (Employee item in stack)
            {
                Console.WriteLine(item);
                Console.WriteLine("Remaining items in stack: " + stack.Count);

            }

            Console.WriteLine();

            while (stack.Count > 0) 
            {
                Employee poppedItem = stack.Pop();

                Console.WriteLine($"Popped item {poppedItem}");
                Console.WriteLine("Remaining items in stack: " + stack.Count);
            }
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            Console.WriteLine();
            int count = 0;

            foreach (Employee item in stack)
            {
                Console.WriteLine("Peeked object: " + stack.Peek());
                Console.WriteLine("Remaining items in stack: " + stack.Count);
                count++;

                if (count == 2)
                {
                    break; 
                }
            }
            {
               

            }

            Employee[] stackArray = stack.ToArray();
            if (stackArray.Length >= 3)
            {
                Employee thirdItem = stackArray[2]; // Index 2 is the third item
                Console.WriteLine("Third item in the stack: " + thirdItem);
            }
            else
            {
                Console.WriteLine("The stack has fewer than 3 items.");
            }

            Console.WriteLine();
            List<Employee> list = new List<Employee>();

            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);
            list.Add(employee4);
            list.Add(employee5);

            if (list.Contains(employee5))
            {
                Console.WriteLine($"ID {employee5.ID} exists in the list");
            }
            else
            {
                Console.WriteLine($"ID {employee5.ID} does not exist in the list");

            }
            Console.WriteLine();
            Employee firstMaleEmployee = list.Find(emp => emp.Gender == "Male");

            if (firstMaleEmployee != null)
            {
                Console.WriteLine($"Found male employee: ID = {firstMaleEmployee.ID}, Name = {firstMaleEmployee.Name}");
            }
            else
            {
                Console.WriteLine("No male employee found in the list.");
            }

            List<Employee> maleEmployees = list.FindAll(emp => emp.Gender == "Male");

            if (maleEmployees.Count > 0)
            {
                foreach (Employee emp in maleEmployees)
                {
                    Console.WriteLine($" Male employees: ID: {emp.ID}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
                }
            }
            else
            {
                Console.WriteLine("No male employees found in the list.");
            }
        }
    }
}
