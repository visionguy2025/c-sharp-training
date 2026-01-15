#region RECORD_V_CLASS_TYPE
// record da initialize olunan zaman deyerler yazilir, sonradan deyismek olmur, class in eksine, istisna
// MyRecord test = new MyRecord()
// {
// Firstname = "awdawdawd",
// Lastname = "aaaaaaa"
// };
// MyRecord test1 = test with {Lastname = "awdawdawdawdawdawd"};
// unvanlar ferqli olacaq (? PROPERTY ISTISANSI OLMASA ??)
#endregion

#region NAMESPACE
// eyni adli class lar ferqli namespace ler altinda yaradila biler
// namespace ler de nested ola biler amma duzgun deyil
// NameSpace1.ClassName de istifade oluna biler
// namespace i de deyisene menimsetmek olur, seliqe ucun, cox uzun olarsa istifade etmek olar | using nspc1 = customnamespacehere; npc1.Car car1 = new npc1.Car();
#endregion

#region OOP_ABSTRACT
// public abstract class Animal {}
// abstract class da abstract method lar yazmaq olur, non-abstract class da yox
// abstract class dan object yaratmaq olmur Animal test = new Animal(); X
// abstract class inin methoduna hemin class da body yazmaq olmur, obyektini yaratmaq olmur deye menasi olmur, eger miras alsa (OOP_INHERITANCE):
// public abstract class Animal
// {
//     public int Age {get; set;}
//     public abstract void Eat();
//     public virtual void Run()
//     {
//         Console.WriteLine(); // virtual abstract ucun default, override etmese buradaki isi gorur
//     }
// }
// public class Bird:Animal
// {
//     public override void Eat()
//     {
//         Console.WriteLine();
//     }
// }
#endregion

#region NEXT->
// OOP_POLYMORPHISM left (Inheritance, Encapsulation, Abstraction, Polymorphism), ...
#endregion
