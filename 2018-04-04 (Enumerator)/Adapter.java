import java.util.*;
import java.*;

public  class Adapter implements Iterator{
	Enumeration enume;
	public Adapter(Enumeration n){
		this.enume = n;
	}
	@Override
	public boolean hasNext(){
		return enume.hasMoreElements();
	}

	@Override
	public Object next(){
		return enume.nextElement();
	}

	@Override
	public void remove(){
		try{}catch(Exception name){}
	}

}