using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();
        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("example.com");
        history.KunjungiHalaman("stackoverflow.com");
        Console.WriteLine("Halaman saat ini: " + history.LihatHalamanSaatIni());
        Console.WriteLine("Kembali ke halaman sebelumnya...");
        string halaman = history.Kembali();
        Console.WriteLine("Halaman saat ini: " + halaman);
        Console.WriteLine("Menampilkan history:");
        history.TampilkanHistory();
        
        // Bracket validator
        BracketValidator validator = new BracketValidator();
        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";
        Console.WriteLine("Ekspresi '" + ekspresiValid + "' valid? " + validator.ValidasiEkspresi(ekspresiValid));
        Console.WriteLine("Ekspresi '" + ekspresiInvalid + "' valid? " + validator.ValidasiEkspresi(ekspresiInvalid));
        
        //Palindrome Checker
        string s1 = "Kasur ini rusak";
        string s2 = "Ibu Ratna antar ubi";
        string s3 = "Hello World";
        Console.WriteLine(s1 + " -> " + PalindromeChecker.CekPalindrom(s1));
        Console.WriteLine(s2 + " -> " + PalindromeChecker.CekPalindrom(s2));
        Console.WriteLine(s3 + " -> " + PalindromeChecker.CekPalindrom(s3));
    }
}
