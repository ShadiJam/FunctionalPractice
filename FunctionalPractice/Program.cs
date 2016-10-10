using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

public class Program {

    /**
     * PART 0
     *
     * Write a function that calculates the sum of all the numbers in an array
     */

    public static int sumOfArray(int[] arr){

        int[] sumOfArray = new int [0];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) {
            sum += sumOfArray[0];
        }
        return 0;
    }

    /**
     * PART 1
     *
     * Write a function that takes two numbers as
     * arguments and computes the sum of those two numbers.
     */

    public static int sum(int a, int b){
        // YOUR CODE HERE
        return 0;
    }

    /**
     * PART 1B
     *
     * Write a function that handles any ampunt of numbers as input and
     * computes the sum of those numbers
     */

    public static int sumAll(){
        // YOUR CODE HERE
        return 0;
    }

    /**
     * PART 2
     *
     * write a function that finds the Greatest Common Denominator of two numbers
     * - if no GCD exists, return 1
     */

    public static int GCD(int a, int b){
        // YOUR CODE HERE
        return 0;
    }

    /**
     * PART 3
     *
     * write a function that prints out the Least Common Multiple of two numbers
     */

    public static int LCM(int a, int b){
        // YOUR CODE HERE
        return 0;
    }

    /**
     * Part 4
     *
     * write a function the returns a FizzBuzz string for some number N (counting up from 1).
     * - for every number that isn't a multiple of 3 or 5, return a period "."
     * - for every number that is a multiple of 3 (but not 5), return "fizz"
     * - for every number that is a multiple of 5 (but not 3), return "buzz"
     * - for every number that is a multiple of 3 and 5, return "fizzbuzz"
     */

    public static string fizzbuzz(int n){
        return "";
    }

    /**
     * PART 5
     *
     * Define a function max() that takes two numbers as arguments
     * and returns the largest of them.
     */

    public static int max(int a, int b){
        // YOUR CODE HERE
        return 0;
    }

    /**
     * PART 6
     *
     * Define a function maxOfThree() that takes three
     * numbers as arguments and returns the largest of them.
     */

    public static int maxOfThree(int a, int b, int c){
        // YOUR CODE HERE
        return 0;
    }

    /**
     * PART 6B
     *
     * Define a function maxOfAll() that takes any amount of
     * numbers as arguments and returns the largest of them.
     */

    public static int maxOfAll(){
        // YOUR CODE HERE
        return 0;
    }

    /**
     * PART 7
     *
     * Write a function isVowel() that takes a character (i.e. a string of length 1)
     * and returns true if it is a vowel, false otherwise.
     */

    public static bool isVowel(char c){
        // YOUR CODE HERE
        return false;
    }

    /**
     * PART 8
     *
     * Write a function rovarspraket() that will translate
     * a text into a "rövarspråket". That is, double every
     * consonant and place an occurrence of "o" in between.
     *
     * For example, rovarspraket("this is fun") should
     * return the string "tothohisos isos fofunon".

     */

    public static string rovarspraket(string s){
        // YOUR CODE HERE
        return "";
    }

    /**
     * Part 9
     *
     * Define a function reverse() that computes
     * the reversal of a string. For example,
     * reverse("skoob") should return the
     * string "books".
     */

    public static string reverse(string str){
        // YOUR CODE HERE
        return "";
    }

    /**
     * Part 10
     *
     * Write a function findLongestWord() that takes an
     * string returns the first, longest word in the string.
     *
     * i.e. findLongestWord("book dogs") should return "book"
     */

    public static string findLongestWord(string sentence){
        // YOUR CODE HERE
        return "";
    }

    public static void Main(){
        Debug.Assert(sumOfArray(new int[] { 1, 2 }) == 3);
        Debug.Assert(sumOfArray(new int[] { }) == 0);
        Debug.Assert(sumOfArray(new int[]{1, 2, 3}) == 6);
        Debug.Assert(sumOfArray(new int[]{10, 9, 8}) == 27);

        Debug.Assert(sum(8, 11) == 19);
        Debug.Assert(sum(4, 100) == 104);

        Debug.Assert(sumAll(8, 11) == 19);
        Debug.Assert(sumAll(4, 100) == 104);
        Debug.Assert(sumAll(8, 11, 20, 30, 11) == 80);
        Debug.Assert(sumAll(4, 100, 1, 4, -10, 15, 21) == 135);

        Debug.Assert(GCD(5,1) == 1);
        Debug.Assert(GCD(15,3) == 3);
        Debug.Assert(GCD(15,5) == 5);
        Debug.Assert(GCD(50,20) == 10);

        Debug.Assert(LCM(10,10) == 10);
        Debug.Assert(LCM(2,5) == 10);
        Debug.Assert(LCM(3,6) == 6);
        Debug.Assert(LCM(0,1) == 1);

        Debug.Assert(fizzbuzz(1) == ".");
        Debug.Assert(fizzbuzz(2) == "..");
        Debug.Assert(fizzbuzz(3) == "..fizz");
        Debug.Assert(fizzbuzz(5) == "..fizz.buzz");
        Debug.Assert(fizzbuzz(10) == "..fizz.buzzfizz..fizzbuzz");

        Debug.Assert(max(1,3)== 3);
        Debug.Assert(max(0,3)== 3);
        Debug.Assert(max(10,3)== 10);
        Debug.Assert(max(-1,-3)== -1);

        Debug.Assert(maxOfThree(1,3,2) == 3);
        Debug.Assert(maxOfThree(0,3,-1) == 3);
        Debug.Assert(maxOfThree(10,3,50) == 50);
        Debug.Assert(maxOfThree(-1,-3,-10) == -1);
        Debug.Assert(maxOfAll(-30, -50, -1,-3,-10, -11, -20) == -1);
        Debug.Assert(maxOfAll(10, 20, 11, 53, 100, 211, -20) == 211);

        Debug.Assert(isVowel("B") == false);
        Debug.Assert(isVowel("b") == false);
        Debug.Assert(isVowel("a") == true);
        Debug.Assert(isVowel("E") == true);

        Debug.Assert(rovarspraket("a") == "a");
        Debug.Assert(rovarspraket("b") == "bob");
        Debug.Assert(rovarspraket("cat") == "cocatot");
        Debug.Assert(rovarspraket("javascript") == "jojavovasoscocroripoptot");

        Debug.Assert(reverse("books") == "skoob");
        Debug.Assert(reverse("we don't want no trouble") == "elbuort on tnaw t'nod ew");

        Debug.Assert(findLongestWord("book dogs") == "book");
        Debug.Assert(findLongestWord("don't mess with Texas") == "Texas");
    }
}