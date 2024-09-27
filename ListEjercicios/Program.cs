//1
List<int> enteros = new List<int> { 1, 2, 3, 3, 4, 1, 2, 6, 6 };
enteros.Distinct().ToList().ForEach(x => Console.Write(x + ", "));
Console.WriteLine("");

//2
List<int> sumar = new List<int> { 1, 2, 3, 3, 4, 1, 2, 6, 6 };
int sum = sumar.Where(n => n % 2 == 0).Sum();
Console.WriteLine(sum);

//3
List<int> rev = new List<int> { 1, 2, 3, 3, 4, 1, 2, 6, 6 };
rev.Reverse();
rev.ForEach(n => Console.Write(n + ", "));
Console.WriteLine("");

//4
List<int> counting = new List<int> { 1, 2, 2, 3, 3, 4, 1, 1, 1, 2, 6, 6 };
Console.WriteLine(counting.Count(n => n == 1));

//5
List<string> chains = new List<string> { "hi", "how", "hello", "Speak", "eye", "Zero", "shallow", "harrow", "goat", "alias" };
chains.Sort();
chains.ForEach(n => Console.Write(n + ", "));
Console.WriteLine("");

//6
List<int> remove = new List<int> { 1, 2, 2, 3, 3, 4, 1, 1, 1, 2, 6, 6 };
remove.RemoveAll(n => n == 1);
remove.ForEach(n => Console.Write(n + ", "));
Console.WriteLine("");

//7
List<int> indice = new List<int> { 1, 2, 2, 3, 3, 4, 1, 1, 1, 2, 6, 6 };
Console.WriteLine(indice.IndexOf(3));

//8
List<int> list1 = new List<int> { 1, 2, 2, 3, 3, 4, 1, 1, 1, 2, 6, 6 };
List<int> list2 = new List<int> { 2, 5, 8, 3, 7, 7, 4 };
list1.AddRange(list2);
list1.ForEach(n => Console.Write(n + ", "));
Console.WriteLine("");

//9
List<int> listFirst = new List<int> { 1, 2, 2, 3, 3, 4, 1, 1, 1, 2, 6, 6 };
listFirst.GetRange(3, 6).ForEach(n => Console.Write(n + ", "));
Console.WriteLine("");

//10
List<int> removeLast = new List<int> { 1, 2, 2, 3, 3, 4, 1, 1, 1, 2, 6, 6 };
removeLast.RemoveAt(removeLast.Count -1);
removeLast.ForEach(n => Console.Write(n + ", "));
Console.WriteLine("");

//1
Dictionary<int, string> gems = new Dictionary<int, string>();
gems.Add(1, "Amethyst");
gems.Add(2, "Jade");
gems.Add(3, "Quartz");

gems.Remove(3);
foreach (var item in gems)
{
    Console.WriteLine($"{item.Key}, {item.Value}");
}

//2
Dictionary<int, string> gemsCount = new Dictionary<int, string>();
gemsCount.Add(1, "Amethyst");
gemsCount.Add(2, "Jade");
gemsCount.Add(3, "Quartz");
Console.WriteLine(gemsCount.Count);

//3
Dictionary<int, string> gemsValue = new Dictionary<int, string>();
gemsValue.Add(1, "Amethyst");
gemsValue.Add(2, "Jade");
gemsValue.Add(3, "Quartz");
Console.WriteLine(gemsValue[2]);

//4
Dictionary<int, string> gemsKey = new Dictionary<int, string>();
gemsKey.Add(1, "Amethyst");
gemsKey.Add(2, "Jade");
gemsKey.Add(3, "Quartz");
foreach (int key in gemsKey.Keys)
{
    Console.WriteLine(key);
}

//5
Dictionary<int, string> gemsV = new Dictionary<int, string>();
gemsV.Add(1, "Amethyst");
gemsV.Add(2, "Jade");
gemsV.Add(3, "Quartz");
foreach (string value in gemsV.Values)
{
    Console.WriteLine(value);
}

//6
Dictionary<int, string> gemsCK = new Dictionary<int, string>();
gemsCK.Add(1, "Amethyst");
gemsCK.Add(2, "Jade");
gemsCK.Add(3, "Quartz");
Console.WriteLine(gemsCK.ContainsKey(4));

//7
Dictionary<int, string> gemsCV = new Dictionary<int, string>();
gemsCV.Add(1, "Amethyst");
gemsCV.Add(2, "Jade");
gemsCV.Add(3, "Quartz");
Console.WriteLine(gemsCK.ContainsValue("Quartz"));

//8
Dictionary<int, string> gemsCopy = new Dictionary<int, string>();
gemsCopy.Add(1, "Amethyst");
gemsCopy.Add(2, "Jade");
gemsCopy.Add(3, "Quartz");
int[] keys = gemsCopy.Keys.ToArray();
Array.ForEach(keys, key => Console.WriteLine(key));

//9
gemsCopy.Clear();
Console.WriteLine(gemsCopy.Count);

//10
Dictionary<int, string> gemsToList = new Dictionary<int, string>();
gemsToList.Add(1, "Amethyst");
gemsToList.Add(2, "Jade");
gemsToList.Add(3, "Quartz");
List<object> list = new List<object>();
foreach (var item in gemsToList)
{
    list.Add(item);
}
list.ForEach(item => Console.WriteLine(item));