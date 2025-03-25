using System;
namespace Solution.BracketValidation {
    public class BracketValidator {
        private class Node {
            public char Data;
            public Node? Next;
            public Node(char data) {
                Data = data;
                Next = null;
            }
        }
        private Node? top;
        public void Push(char c) {
            Node newNode = new Node(c);
            newNode.Next = top;
            top = newNode;
        }
        public char Pop() {
            if(top == null) return '\0';
            char value = top.Data;
            top = top.Next;
            return value;
        }
        public bool IsEmpty() {
            return top == null;
        }
        public bool ValidasiEkspresi(string ekspresi) {
            top = null;
            foreach(char c in ekspresi) {
                if(c=='(' || c=='{' || c=='[') {
                    Push(c);
                } else if(c==')' || c=='}' || c==']') {
                    if(IsEmpty()) return false;
                    char last = Pop();
                    if((c==')' && last!='(') || (c=='}' && last!='{') || (c==']' && last!='[')) return false;
                }
            }
            return IsEmpty();
        }
    }
}
