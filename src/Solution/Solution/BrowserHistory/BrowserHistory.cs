using System;
using System.Collections.Generic;
namespace Solution.BrowserHistory {
    public class Halaman {
        public string URL { get; set; }
        public Halaman(string url) {
            URL = url;
        }
    }
    public class HistoryManager {
        private class Node {
            public Halaman Data;
            public Node? Next;
            public Node(Halaman data) {
                Data = data;
                Next = null;
            }
        }
        private Node? top;
        public void KunjungiHalaman(string url) {
            Halaman halaman = new Halaman(url);
            Node newNode = new Node(halaman);
            newNode.Next = top;
            top = newNode;
            Console.WriteLine("Mengunjungi halaman: " + url);
        }
        public string LihatHalamanSaatIni() {
            if(top == null) return null!;
            return top.Data.URL;
        }
        public string Kembali() {
            if(top == null || top.Next == null) {
                return "Tidak ada halaman sebelumnya.";
            }
            top = top.Next;
            return top.Data.URL;
        }
        public void TampilkanHistory() {
            List<string> list = new List<string>();
            Node? current = top;
            while(current != null) {
                list.Add(current.Data.URL);
                current = current.Next;
            }
            list.Reverse();
            foreach(string url in list) {
                Console.WriteLine(url);
            }
        }
    }
}
