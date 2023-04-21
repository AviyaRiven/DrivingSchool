using Dal.dalImplements;
using Dal.dataObjects;
StudentService s = new StudentService();
////Student st = new Student("gsjgsj");
////s.UpdateAsync("325324332", st);
var x = s.ReadByIdAsync("325324332");

//foreach (var db in x)
//{
//    Console.WriteLine(db);
//}
