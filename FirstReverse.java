import java.util.*; 
import java.io.*;

class Main {  
  public static String FirstReverse(String str) { 
    StringBuilder str2 = new StringBuilder();
    str2.append(str);
    str2.reverse();
    str=str2.toString();
    return str;
    
  } 
  
  public static void main (String[] args) {  
    // keep this function call here     
    Scanner s = new Scanner(System.in);
    System.out.print(FirstReverse(s.nextLine())); 
  }   
  
}