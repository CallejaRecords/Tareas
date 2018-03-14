import java.io.FilterInputStream;
import java.io.*;

public class LowerCaseInputStream extends FilterInputStream{
	protected LowerCaseInputStream(InputStream in){
		super(in);
	}
	@Override
	public int read() throws IOException{
		int c=in.read();
		if(c==-1){
			return -1;
		}else{
			return Character.toLowerCase((char)c);
		}
	}
}