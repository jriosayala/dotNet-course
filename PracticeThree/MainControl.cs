namespace PracticeThree;
public static class MainControl
{
    public static void Main()
    {
        Document doc = new("Practice 3", "#Practice 3 demostration\n##Topics to review\n- Interfaces\n- Inheritance\n- Polymorphism");

        // Use the functionalities from both interfaces
        doc.Print();
        doc.Save();
    }
}