/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

import java.util.Scanner;

/**
 *
 * @author fdbague
 */
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.println("Hello World");
        System.out.println("Foo-Bar");
        
        Scanner read = new Scanner(System.in);
        System.out.println("Enter any word/s");
        String val = read.nextLine();
        System.out.println("You entered: "+val);
        
    }
    
}
