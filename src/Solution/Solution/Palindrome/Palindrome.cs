using System;
using System.Collections.Generic;
using System.Text;
namespace Solution.Palindrome {
    public static class PalindromeChecker {
        public static bool CekPalindrom(string input) {
            StringBuilder sb = new StringBuilder();
            foreach(char c in input) {
                if(Char.IsLetter(c)) {
                    sb.Append(Char.ToLower(c));
                }
            }
            string normalized = sb.ToString();
            Stack<char> stack = new Stack<char>();
            foreach(char c in normalized) {
                stack.Push(c);
            }
            foreach(char c in normalized) {
                if(stack.Pop() != c) return false;
            }
            return true;
        }
    }
}
