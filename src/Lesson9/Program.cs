using Lesson9;

int[] array = { 5, 3, 8, 4, 2, 1, 9, 7, 6 };



User[] users = new User[]
{
    new User { Name = "Alice", Age = 25 },
    new User { Name = "Bob", Age = 30 },
    new User { Name = "David", Age = 40 },
    new User { Name = "Charlie", Age = 35 },
    new User { Name = "Eve", Age = 45 },
    new User { Name = "Frank", Age = 34 },
    new User { Name = "Grace", Age = 45 },
    new User { Name = "Helen", Age = 33 },
    new User { Name = "Ivan", Age = 40 },
    new User { Name = "John", Age = 43 },
    new User { Name = "Kevin", Age = 38 }
};

// var orderedArray = array.Order().ToArray();
// var orderedByDescendingArray = array.OrderDescending().ToArray();

// User[] usersOrderedByAge = users.OrderByDescending(x => x.Age).ToArray();

var customAgregation = users
    .Where(x => x.Age > 30 && x.Age < 50)
    .GroupBy(x => x.Name.Length)
    .Select(x => new { NameLenght = x.Key, TotalAge = x.Sum(z => z.Age) })
    .Where(x => x.NameLenght > 5)
    .ToArray();

if (users.Any(x => x.Age < 30))
{
    Console.WriteLine("There are users younger than 30");
}

foreach (var group in customAgregation)
{
    Console.WriteLine(group.NameLenght);
    Console.WriteLine(group.TotalAge);
    Console.WriteLine();
}
// foreach (var user in usersOrderedByAge)
// {
//     Console.WriteLine(user.Name);
//     Console.WriteLine(user.Age);
// }

// Console.WriteLine(Factorial(5));

// // O(1)
// Console.WriteLine(array[4]);
//
// // O(n)
// foreach (var item in array)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine(array.Min());
// Console.WriteLine(array.Max());
// Console.WriteLine(array.Average());
//Console.WriteLine(array.FirstOrDefault(x => x == 123));


//Console.WriteLine(users.FirstOrDefault(x => x.Age > 30)?.Name);

// foreach (User user in users)
// {
//     if (user.Age > 30)
//     {
//         Console.WriteLine(user.Name);
//         break;
//     }
// }

// var oldUsers = users.Where(x => x.Age > 30).ToArray();
//
// foreach (var user in oldUsers)
// {
//     Console.WriteLine(user.Name);
// }



Console.WriteLine("Program finished");

User user = new User();


static void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}


// static (int min, int max) FindMinMax(int[] array)
// {
//     int min = array[0];
//     int max = array[0];
//
//     foreach (int num in array)
//     {
//         if (num < min) min = num;
//         if (num > max) max = num;
//     }
//
//     return (min, max);
// }

// static int LinearSearch(int[] array, int value)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == value)
//             return i;
//     }
//     return -1;
// }

// static int SimpleBinarySearch(int[] array, int value)
// {
//     int left = 0;
//
//     int right = array.Length - 1;
//
//     while (left <= right)
//     {
//         int mid = left + (right - left) / 2;
//
//         if (array[mid] == value)
//         {
//             return mid;
//         }
//
//         if (array[mid] < value)
//         {
//             left = mid + 1;
//         }
//         else
//         {
//             right = mid - 1;
//         }
//     }
//
//     return -1;
// }

// static int Factorial(int n)
// {
//     if (n <= 1)
//     {
//         return 1;
//     }
//
//     return n * Factorial(n - 1);
// }

public class TreeNode
{
    public int Value { get; init; }

    public List<TreeNode> Children { get; init; }

    public TreeNode(int value)
    {
        Value = value;
        Children = new List<TreeNode>();
    }
}

public class GeneralTree
{
    public TreeNode Root;

    public GeneralTree(int rootValue)
    {
        Root = new TreeNode(rootValue);
    }
    
    public TreeNode? Search(TreeNode node, int value)
    {
        if (node == null)
        {
            return null;
        }
        
        if (node.Value == value)
            return node;
        
        foreach (TreeNode child in node.Children)
        {
            TreeNode? result = Search(child, value);
            if (result != null)
                return result;
        }

        return null;
    }
    
    public void AddChild(TreeNode parent, int value)
    {
        TreeNode child = new TreeNode(value);
        parent.Children.Add(child);
    }
}