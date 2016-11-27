using System; 
 
class A 
{ 
    private int myField; 
    public int GetMyField() 
    { 
        return myField; 
    } 
    public void SetMyFiled(int newValue) 
    { 
        myField = newValue; 
    } 
} 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        A a = new A(); 
        a.SetMyFiled(123); 
        Console.WriteLine(a.GetMyField()); 
    } 
}