class Solution {
    public int solve(List<int> A, int B) {
        for(int i = 0; i < A.Count; i++){
            for(int j = 0; j < A.Count; j++){
                if(i == j) continue;
                if(A[i] + A[j] == B) return 1;
            }
        }
        return 0;
    }
}