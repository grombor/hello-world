import java.util.*;

class Main {  
  public static String LongestWord(String sen) { 
    String[] array = sen.split(" |!|&");
        for (int i=0; i<array.length-1; i++){
            if (array[i].length()<array[i+1].length()){
                sen = array[i+1];
            }
            else if (sen.length()<array[i+1].length()){
                sen = array[i+1];
            }
            else {
                sen=array[i];
            }
        }
       
    return sen;
    
  } 
  
  public static void main (String[] args) {  
    // keep this function call here     
    Scanner s = new Scanner(System.in);
    System.out.print(LongestWord(s.nextLine())); 
    s.close();
  }   
  
}
