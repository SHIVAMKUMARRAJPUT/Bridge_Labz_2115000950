using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote
    public bool CanStudentVote(int age)
    {
        // Validate the age
        if (age < 0)  // Negative age is invalid
        {
            return false; // Cannot vote if age is negative
        }
        return age >= 18; // Can vote if age is 18 or above
    }
}

class program_07{
    public static void voteChecker(){
        int[] studentAges = new int[10];
        
        // Create an instance of the StudentVoteChecker class
        StudentVoteChecker voteChecker = new StudentVoteChecker();
        
        // Loop to take user input for the age of each student
        for (int i = 0; i < studentAges.Length; i++){
            Console.Write($"Enter the age of student {i + 1}: ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
            
            // Check if the student can vote and display the result
            bool canVote = voteChecker.CanStudentVote(studentAges[i]);
            if (canVote){
                Console.WriteLine($"Student {i + 1} can vote.");
            }
            else{
                Console.WriteLine($"Student {i + 1} cannot vote.");
            }
        }
    }
}
