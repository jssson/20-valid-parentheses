namespace zolution;
public class Solution {

    IDictionary<char, int> brackets = new Dictionary<char, int>(){
        {'(', 1},
        {')', -1},
        {'[', 10},
        {']', -10},
        {'{', 100},
        {'}', -100}
    };

    public object IsValid(string s) {

        var str = s.ToList();
        int result = 0;

        foreach (var item in str)
        {
            result += brackets[item];
        }
        if (result != 0){
            return false;
        }

        
        for (int ni = 0; ni < str.Count()-1; ni++)
        {
            // If next sign is closing 
            // It must be the counter part
            if((brackets[str[ni+1]] < 0 ) 
                && 
                (brackets[str[ni]] + brackets[str[ni+1]] != 0))
            {
                return false;
            }
            // If next sign is closing 
            // and it is the counter part
            // Remove both
            if((brackets[str[ni+1]] < 0 ) 
                && 
                (brackets[str[ni]] + brackets[str[ni+1]] == 0)){
                str.RemoveAt(ni+1);
                str.RemoveAt(ni);
                ni = ni-2;
            }
        }

        return true;

    }
}

