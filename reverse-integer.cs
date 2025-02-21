public class Solution {
    public int Reverse(int x) {
        string value = x.ToString(); // converting int into string
        var result = new StringBuilder(); // StringBuilder to hold the reverse value
        byte i = 0;
        if(x<0) i = 1;
        while(i< value.Length){
            result.Insert(0, $"{value[i]}");
            i++;
        }
        // handle negative integer
        if(x < 0){
            result.Insert(0,"-");
        }
        try{
            // converting string to integer
        return Int32.Parse(result.ToString());
        }
        catch( System.OverflowException){
            return 0;
        }
    }
}