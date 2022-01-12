Single Cycle problem: Cycle through all values to see if you can do it in one loop


using System;
using System.Linq;
public class Program {
	public static bool HasSingleCycle(int[] array) {
		
		int currentIdx =0;
		int visited =0;
		
		while(visited < array.Length){
			if(visited >0 && currentIdx ==0){return false;}
			visited ++;
			currentIdx = GetNext(currentIdx,array);
		}
		return currentIdx ==0;
	}
	public static int GetNext(int currentIdx,int[] array){
			int jump = array[currentIdx];
			int nextIdx = (jump + currentIdx) % array.Length;
			
			return nextIdx >=0 ? nextIdx : nextIdx + array.Length;
			
		}
}
