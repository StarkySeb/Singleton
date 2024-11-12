namespace singleton{

    // 1. Vytvořte novou třídu.
    class Singleton{

    //2. Přidejte do třídy soukromý statický atribut, který bude uchovávat jedinou instanci třídy.
    private static Singleton instance = null;

    //3. Implementujte soukromý konstruktor, aby nebylo možné vytvářet nové instance třídy zvenčí.
    private Singleton() { }

    //4. Přidejte veřejnou statickou metodu, která vrátí jedinou instanci třídy. Tato metoda by měla vytvořit instanci třídy, pokud ještě neexistuje, a vrátit ji.//
    public static Singleton GetInstance(){
        if (instance == null){
            instance = new Singleton();
        }
        return instance;
    }

      //5. Přidejte do třídy metodu, která bude demonstrovat použití Singletonu (např. metoda, která vypíše nějakou zprávu).
    public void Zprava(){
        Console.WriteLine("Singleton");
    }
    }
}