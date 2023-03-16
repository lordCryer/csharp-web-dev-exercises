using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.

//FlavorComparer comparer = new FlavorComparer();
//foreach (Flavor flavor in availableFlavors)
//{
//    Console.WriteLine(flavor.Name);
//}
//availableFlavors.Sort(comparer);

availableFlavors.Sort(new FlavorComparer());


Console.WriteLine("*****THIS IS A DIVIDER and the .Sort sorts the new list of icecream flavor alphabetically*****");

foreach (Flavor flav in availableFlavors)
{
    Console.WriteLine($"{flav.Name} Allergens: {flav.Allergens.Count}");
}
//Console.WriteLine("************THIS IS ANOTHER DIVIDER************");
// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
////  field.
//foreach (Cone con in availableCones)
//{
//    Console.WriteLine($"{con.Name}: {con.Cost}");
//}

availableCones.Sort(new ConeComparer());
Console.WriteLine("\n************THIS IS ANOTHER DIVIDER************\n");
foreach (Cone con in availableCones)
{
    Console.WriteLine($"{con.Name}: {con.Cost}");
}


// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.