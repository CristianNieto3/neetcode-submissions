public class Solution {
    public int MaxArea(int[] heights) {

        // Store the biggest area found so far
        int res = 0;

        // Left pointer starts at the beginning
        int l = 0;

        // Right pointer starts at the end
        int r = heights.Length - 1;

        // Keep checking while the pointers have not crossed
        while (l < r) {

            // Width is the distance between the two pointers
            // Height is the smaller of the two lines
            int area = (r - l) * Math.Min(heights[l], heights[r]);

            // Update result if this area is bigger
            res = Math.Max(res, area);

            // Move the pointer with the smaller height
            // because the smaller side limits the water
            if (heights[l] <= heights[r]) {
                l++;
            } else {
                r--;
            }
        }

        // Return the biggest area found
        return res;
    }
}
