import java.io.*;
import java.util.*;
import java.*;

public class Main {
	public static void main(String[] args) throws IOException{
		String nombre = "Brian";
		String apellido = "Felix";
		String edad = "20";

		Vector<String> lista = new Vector<String>();
		lista.add(nombre);
		lista.add(apellido);
		lista.add(edad);
		Enumeration<String> enume = lista.elements();

		Adapter enumIte = new Adapter(enume);
		enumIte.hasNext();
		enumIte.next();
		enumIte.remove();
	}
}
