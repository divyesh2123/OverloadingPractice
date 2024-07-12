using ConsoleApp9;


CityManagement cityManagement = new CityManagement();

cityManagement.AddCity("vadodara");

List<string> a = new ();

a.Add("Pune");
a.Add("Mumbai");
a.Add("Gurugram");


cityManagement.AddCity(a) ;

cityManagement.find("vadodara");

cityManagement.find("Pune", "Mumbai");


//foreach(string p in cityManagement.cities)
//{
//    Console.WriteLine(p);   
//}