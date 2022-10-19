class Solution {
    public int solve(int A) {
        int sqrt = Convert.ToInt32(Math.Floor(Math.Sqrt(A)));
        if(sqrt * sqrt == A){
            return sqrt;
        }
        else{
            return -1;
        }
    }
}
